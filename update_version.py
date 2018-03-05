#! python

from subprocess import call

import subprocess
import fileinput
import re
import os
import sys
import getopt

if len(sys.argv) < 2:
    print("usage: ./update_version.py --major")
    print("or:    ./update_version.py --minor")
    print("or:    ./update_version.py --revision")
    sys.exit(1)

origPath = os.getcwd();
version_level = sys.argv[1];
valid_version_levels = ['--major', '--minor', '--revision']
if version_level not in valid_version_levels:
    print("Version level not recognised, must be one of")
    print(valid_version_levels)
    sys.exit(1)
    
if version_level in  ['--major', '--minor']:
    print('major and minor version levels not yet implemented')
    print('WARNING: for version levels > revision, you might need to change extra GUIDs in the installer')    

def safeProcess( cmd ):
    "Run command, return boolean for success"
    print(cmd);
    try:
        out = subprocess.check_output(cmd, shell=True)
        print(out.decode("utf-8").replace("\\\n", "\n"))
        return True;
    except subprocess.CalledProcessError as e:                                                                                                   
        print("Status : FAIL", e.returncode, e.output)
        return False;
        
def safeExit():
    print ("Exiting...")
    os.chdir(origPath)
    sys.exit(1)
    print("To reset state, you probably want to run: ")
    print("git reset --hard head")
#    safeProcess("git reset --hard head")

def update_assembly_version(filename):
    pattern = re.compile("\[assembly:\s*AssemblyVersion\(\"(\d).(\d).(\d)\"\)\]")
    
    for line in fileinput.input(filename, inplace=True):
        if re.search(pattern, line): 
            major = int(pattern.search(line).groups()[0])
            minor = int(pattern.search(line).groups()[1])
            revision = int(pattern.search(line).groups()[2])
            
            if version_level == "--major":
                major += 1
                minor = 0
                revision = 0
            elif version_level == "--minor":
                minor += 1
                revision = 0
            elif version_level == "--revision":
                revision += 1
            new_version =  "{}.{}.{}".format(major, minor, revision)
            line = re.sub(pattern, "[assembly: AssemblyVersion(\"{}\")]".format(new_version), line);        
        print(line.rstrip('\n'))
    return new_version

def update_vdproj_version(filename, new_version):
    #e.g. "ProductVersion" = "8:1.0.5"
    pattern = re.compile('"ProductVersion"\s*=\s*"8:(\d*.\d*.\d*)"');

    for line in fileinput.input(filename, inplace=True):
        if re.search(pattern, line): 
            curr_version = pattern.search(line).groups()[0]
            line = line.replace(curr_version, new_version)    
        print(line.rstrip('\n'))
    return new_version

        
# Don't continue if working copy is dirty
if not safeProcess('git diff-index --quiet HEAD --'):
    print( "Cannot continue, git working copy dirty")
    safeExit()
    
# Update the source files that OptiKey uses
version_file = 'src/JuliusSweetland.OptiKey/Properties/AssemblyInfo.cs'
new_version = update_assembly_version(version_file)

# Update the version reported in the vdproj
vdproj = 'install\SetupOptiKeyMinecraft\SetupOptiKeyMinecraft\SetupOptiKeyMinecraft.vdproj'
update_vdproj_version(vdproj, new_version)

# Update the installer GUIDs, via VBS script
# This is necessary to make sure we get correct 'upgrade' behaviour
increment_script = 'install/SetupOptiKeyMinecraft/SetupOptiKeyMinecraft/UpdateGuids.vbs'
if not safeProcess('cscript {} {}'.format(increment_script, vdproj)):
    print( "Cannot update installer, exiting")
    safeExit()

# Commit changes
safeProcess("git add {}".format(version_file))
safeProcess("git add {}".format(vdproj))
safeProcess('git commit -m "Update version number to ' + new_version + '"')
    

