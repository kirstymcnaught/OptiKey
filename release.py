#! python

from subprocess import call

import subprocess
import fileinput
import re
import os
import sys
import getopt

origPath = os.getcwd();

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
#    safeProcess("git reset --hard head")

def get_version(filename):
    pattern = re.compile('"ProductVersion" = "8:(\d+(\.\d+)+)"');
    for line in fileinput.input(filename):
        if re.search(pattern, line): 
            version = pattern.search(line).groups()[0]
            return version
    return None;        
  
# Don't continue if working copy is dirty
if not safeProcess('git diff-index --quiet HEAD --'):
    print( "Cannot build, git working copy dirty")
    safeExit()
    

# Build installer and dependent project

# FYI if you're running this directly in git bash, you need to escape the forward slashes in the options (e.g. //Project)
vdproj = 'install\SetupOptiKeyMinecraft\SetupOptiKeyMinecraft\SetupOptiKeyMinecraft.vdproj'
build = 'devenv.com OptiKey.sln /Project {} /Build "Release"'.format(vdproj)
if not safeProcess(build):
    print("Error building project or installer")
    safeExit()

# Tag code by version
version = get_version(vdproj)
safeProcess("git tag release/{}".format(version))



