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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // list view for available encoders and their status as you can see from the image for reference from sam broadcaster. 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // toolbar for adding deleting and editing encoders also ability to stop and start highlighted encoder from the list view below
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // encoders panel and configuration should support mp3 audio output we do not need support for other codecs on stream output
            // icecast/shoutcast audo support only

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show(); // or form.ShowDialog(this);
        }
    }
}
