using System.Windows.Forms;

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
            //Player must support mp3, wav, m4a, and flac at minimum
            // Slider controls should be the color scheme as in the placeholder image
            // VU Meter should be those colors not sure how
            // When auto-dj is enabled players should crossfade to each other
            // Player panel for player A
            // panel color should be editable in the configuration options
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
            Form2 form = new Form2();
            form.Show(); // or form.ShowDialog(this);
            // Encoder setup window
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Tools and utilities window
        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {
            // one click sound cart panel with audio level control for output of sounds. multiple sounds should be able to play at the same time
            //image is just for visual reference from sam broadcaster we will not split the audio between cue/air output for sound carts we only need the volume slider controls and sound cart buttons

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

        private void label9_Click(object sender, EventArgs e)
        {
            // Total track time Player B
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // placeholder for title display player b
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // placeholder for artist display player b
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // placeholder for title display player a
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // placeholder for artist display player a
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // total track time player a
        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {
            // panel and format to display album art player b
        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {
            // panel and format to display album art for player a
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {
            //Music Volume Level for when auto fade is engaged music should be faded to this % when push to talk is pressed
        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {
            //Pressing enables mic press to talk to be used
        }

        private void panel46_Paint(object sender, PaintEventArgs e)
        {
            // pressing disables mic and press to talk cannot be engaged
        }

        private void label17_Click(object sender, EventArgs e)
        {
            //mic on label
        }

        private void label18_Click(object sender, EventArgs e)
        {
            // mic off label
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Enable autoi dj control and use rotation playlist ruleis on repeats
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Dsable autodj and return to manual control
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //non selectable indicator if Auto DJ is enabled
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ths project should utilize SQL for storing song information such as file location and id3 tag info like artist/title 
            // SQL needs to be remotely accessble for web plugins to pull now playing information and inject song requests into the database
            // Encoders are icecast2 and shoutcast 2 only
            // audio support should be mp3, wav, flac, m4a
            // vu meters should all be uniform in color I would like blue for normal level then gradient to red for red line levels
            // all slider controls should be uniform in coloring and function
            // will be able to edit id3 tag information for songs in library
            // multiple audio output support to output audio to many devices
            // separate air/cue audio devices AIR being for main station output feed and CUE for headphones and previewing all audio with cue support
            // sound cart panel for instant play sounds with adjustable output level control
            // more of these comments to come as i think of stuff I aim only able to work on this late in the evening hours for a few hours a day and I suck at coding I can easily visualise the end result
            // will add song request display for real time viewing of song requests coming in from a web plugin
            // because of remote SQL access we can use that to build a wordpress plugin to handle now playing information as well as song requests
            // will add main audio control levels for air output level and cue output level

        }

        private void panel50_Paint(object sender, PaintEventArgs e)
        {
            // air output volume control
        }

        private void panel54_Paint(object sender, PaintEventArgs e)
        {
            // cue output audio control
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // air output enable/disable if enable make button green
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // cue output enable/disable if enabled make button green
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // list view for song requests displays in order as is received shows song artist/title in list and double clicking track will insert into queue or song can be dragged directly into player deck
        }
    }
}
