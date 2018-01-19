using System.Windows.Controls;
using System.Windows;
using Microsoft.Win32;
using System;
using System.Windows.Forms;
using JuliusSweetland.OptiKey.Properties;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace JuliusSweetland.OptiKey.UI.Views.Management
{
    /// <summary>
    /// Interaction logic for VisualsView.xaml
    /// </summary>
    public partial class VisualsView : System.Windows.Controls.UserControl
    {

        public VisualsView()
        {
            InitializeComponent();
        }

        private void FindKeyboardsFolder(object sender, System.Windows.RoutedEventArgs e)
        {
            var folderBrowser = new CommonOpenFileDialog();
            folderBrowser.IsFolderPicker = true;
            folderBrowser.Title = "Select folder containing dynamic keyboards";
            folderBrowser.InitialDirectory = txtKeyboardsLocation.Text;

            if (folderBrowser.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // This is hooked up to the DynamicKeyboardsLocation property
                txtKeyboardsLocation.Text = folderBrowser.FileName;
            }            
        }

        private void FindStartupKeyboardFile(object sender, System.Windows.RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "XML keyboard definition (*.xml)|*.xml"
            };

            // If there's already a valid path set, start there, otherwise try the
            // dynamic keyboards location
            if (File.Exists(txtStartupKeyboardLocation.Text))
            {
                openFileDialog.InitialDirectory = Path.GetDirectoryName(txtStartupKeyboardLocation.Text);
            }
            else if (Directory.Exists(txtKeyboardsLocation.Text))
            {
                openFileDialog.InitialDirectory = txtKeyboardsLocation.Text;
            }

            if (openFileDialog.ShowDialog() == true)
            {
                if (openFileDialog.FileName.EndsWith(@".xml"))
                {
                    // This is hooked up to the DynamicKeyboardsLocation property
                    txtStartupKeyboardLocation.Text = openFileDialog.FileName;
                }                
            }
        }
    }
}
