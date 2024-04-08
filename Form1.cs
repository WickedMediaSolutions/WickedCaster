namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Album Art player A
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Title, Artist, Time Remaining player A
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            // Play/Pause button player A
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Stop button player A
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            // Skip to next track first from player b if that deck is empty load next track in player B from queue
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            // Volume level for player A
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // VU Meter for player A
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            // Track position selector
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Send audio from player A to main output device
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Send audio from player A to cue output device
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {
            // Album art player B
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {
            // Title, Artist, Time remaining player B
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {
            // Pause/play player B
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {
            // Stop player B
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
            // Skip to next track in Player A if player A is empty load next track from queue into player A
        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {
            // Track position selector player B
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            // Volume level player B
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            // VU Meter player B
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            // Send audio from player B to main audio output device
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Send audio from player B to cue audio output device
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            // Player panel for player B
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Player panel for player A
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {
            // Microphone control panel
        }

        private void panel24_Paint(object sender, PaintEventArgs e)
        {
            // Push to talk button
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {
            // Music fade level when push to talk is engaged
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            // Microphone level
        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {
            //Mic on/off buttons
        }

        private void panel30_Paint(object sender, PaintEventArgs e)
        {
            // Audio library panel
        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            // Audio library browser 
        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {
            // Queue panel
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {
            // Queue playlist
        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {
            // Configuration panel
        }

        private void panel35_Paint(object sender, PaintEventArgs e)
        {
            // Place holder for configuration buttons to load settings panels for various controls
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close application
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Audio setup window
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Encoder setup window
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Tools and utilities window
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {
            // Encoders status and details of stream stats
        }

        private void panel36_Paint(object sender, PaintEventArgs e)
        {
            // Encoder panel
        }

        private void panel35_Paint_1(object sender, PaintEventArgs e)
        {
            // Sound cart panel should load sound effects library as playable buttons for each audio file in that folder set in config options
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            // Send sound cart audio to main audio device
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            // Send sound cart audio to cue audio device
        }
    }
}
