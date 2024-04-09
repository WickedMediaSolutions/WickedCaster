using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // server details tab when shoutcast is selected being added as a new server
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // server details tab options for when icecast is selected
            // add options to save stream to an mp3 file, should prompt user for save folder location and store in SQL
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add server to database
        }
    }
}
