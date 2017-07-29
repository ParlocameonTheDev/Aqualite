using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aqualite
{
    public partial class Payload : Form
    {
        public Payload()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                Payload form = new Payload();
                form.Show();
        }

        private void Payload_Load(object sender, EventArgs e)
        {
            while (true)
            {
                Payload form = new Payload();
                form.Show();
            }
        }
    }
}
