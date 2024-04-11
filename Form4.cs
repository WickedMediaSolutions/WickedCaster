using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WickedBroadcaster
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dropdown selector of available audio output devices for main output
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dropdown selector of available audio output devices for cue output
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Dropdown selector of available audio input devices to set for microphone use
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Panel for holding settings configs
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Minutes to not repeat a track from the same album minute selection 
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Minutes to not repeat same track minute selection
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Number of songs to keep in the queue selector starting at 0 for default value
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // this is what the rotation setup should look like and each button functional to load categories from the playlist folders section
            //should be able to add a list of options to the rotation and save it and use whatever is active in the editor
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select file location to save now playing info output to text file. Should output Artist - Song Title plain text
        }
    }
}
