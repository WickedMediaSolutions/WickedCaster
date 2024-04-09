namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel10 = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel38 = new Panel();
            panel2 = new Panel();
            label10 = new Label();
            label3 = new Label();
            label11 = new Label();
            label12 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel12 = new Panel();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            panel20 = new Panel();
            panel21 = new Panel();
            panel39 = new Panel();
            panel22 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel23 = new Panel();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            panel42 = new Panel();
            panel43 = new Panel();
            panel44 = new Panel();
            panel45 = new Panel();
            label13 = new Label();
            panel29 = new Panel();
            label18 = new Label();
            label17 = new Label();
            panel47 = new Panel();
            panel46 = new Panel();
            panel27 = new Panel();
            panel40 = new Panel();
            panel41 = new Panel();
            panel28 = new Panel();
            panel25 = new Panel();
            panel26 = new Panel();
            panel24 = new Panel();
            panel30 = new Panel();
            panel31 = new Panel();
            panel32 = new Panel();
            panel33 = new Panel();
            panel34 = new Panel();
            panel35 = new Panel();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel36 = new Panel();
            panel37 = new Panel();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel21.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel42.SuspendLayout();
            panel43.SuspendLayout();
            panel29.SuspendLayout();
            panel27.SuspendLayout();
            panel40.SuspendLayout();
            panel25.SuspendLayout();
            panel30.SuspendLayout();
            panel32.SuspendLayout();
            panel34.SuspendLayout();
            panel35.SuspendLayout();
            panel36.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 233);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox2.Location = new Point(468, 204);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(96, 26);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Cue Out";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox1.Location = new Point(380, 204);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(89, 26);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Air Out";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = Properties.Resources.playervucontrol;
            panel10.BackgroundImageLayout = ImageLayout.Stretch;
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(490, 7);
            panel10.Name = "panel10";
            panel10.Size = new Size(28, 192);
            panel10.TabIndex = 7;
            panel10.Paint += panel10_Paint;
            // 
            // panel11
            // 
            panel11.BackColor = Color.White;
            panel11.Location = new Point(-35, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(28, 192);
            panel11.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.vumeter;
            panel8.BackgroundImageLayout = ImageLayout.Stretch;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(524, 7);
            panel8.Name = "panel8";
            panel8.Size = new Size(28, 192);
            panel8.TabIndex = 5;
            panel8.Paint += panel8_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(-35, 1);
            panel9.Name = "panel9";
            panel9.Size = new Size(28, 192);
            panel9.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.nextbutton;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(297, 93);
            panel6.Name = "panel6";
            panel6.Size = new Size(66, 61);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.stopbutton;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(225, 93);
            panel7.Name = "panel7";
            panel7.Size = new Size(66, 61);
            panel7.TabIndex = 4;
            panel7.Paint += panel7_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.playbutton;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(153, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(66, 61);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.sliderhoriz;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(8, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(474, 31);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(panel38);
            panel3.Location = new Point(10, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 150);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel38
            // 
            panel38.BackColor = Color.Transparent;
            panel38.BackgroundImage = Properties.Resources.na;
            panel38.BackgroundImageLayout = ImageLayout.Stretch;
            panel38.BorderStyle = BorderStyle.FixedSingle;
            panel38.Location = new Point(3, 3);
            panel38.Name = "panel38";
            panel38.Size = new Size(133, 144);
            panel38.TabIndex = 10;
            panel38.Paint += panel38_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LawnGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(150, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 78);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label10.Location = new Point(255, 36);
            label10.Name = "label10";
            label10.Size = new Size(72, 37);
            label10.TabIndex = 8;
            label10.Text = "3:13";
            label10.Click += label10_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.Location = new Point(255, 4);
            label3.Name = "label3";
            label3.Size = new Size(72, 37);
            label3.TabIndex = 2;
            label3.Text = "3:13";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(65, 34);
            label11.Name = "label11";
            label11.Size = new Size(166, 28);
            label11.TabIndex = 7;
            label11.Text = "Jane's Addiction";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(65, 0);
            label12.Name = "label12";
            label12.Size = new Size(162, 28);
            label12.TabIndex = 6;
            label12.Text = "Caught Stealing";
            label12.Click += label12_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Artist:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Teal;
            panel12.Controls.Add(checkBox3);
            panel12.Controls.Add(checkBox4);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(panel15);
            panel12.Controls.Add(panel17);
            panel12.Controls.Add(panel18);
            panel12.Controls.Add(panel19);
            panel12.Controls.Add(panel20);
            panel12.Controls.Add(panel21);
            panel12.Controls.Add(panel22);
            panel12.Location = new Point(873, 12);
            panel12.Name = "panel12";
            panel12.Size = new Size(558, 233);
            panel12.TabIndex = 10;
            panel12.Paint += panel12_Paint;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.FlatStyle = FlatStyle.System;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox3.Location = new Point(468, 204);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(96, 26);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Cue Out";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.FlatStyle = FlatStyle.System;
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox4.Location = new Point(380, 204);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(89, 26);
            checkBox4.TabIndex = 8;
            checkBox4.Text = "Air Out";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // panel13
            // 
            panel13.BackColor = Color.White;
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(490, 7);
            panel13.Name = "panel13";
            panel13.Size = new Size(28, 192);
            panel13.TabIndex = 7;
            panel13.Paint += panel13_Paint;
            // 
            // panel14
            // 
            panel14.BackColor = Color.White;
            panel14.Location = new Point(-35, 1);
            panel14.Name = "panel14";
            panel14.Size = new Size(28, 192);
            panel14.TabIndex = 6;
            // 
            // panel15
            // 
            panel15.BackColor = Color.White;
            panel15.Controls.Add(panel16);
            panel15.Location = new Point(524, 7);
            panel15.Name = "panel15";
            panel15.Size = new Size(28, 192);
            panel15.TabIndex = 5;
            panel15.Paint += panel15_Paint;
            // 
            // panel16
            // 
            panel16.BackColor = Color.White;
            panel16.Location = new Point(-35, 1);
            panel16.Name = "panel16";
            panel16.Size = new Size(28, 192);
            panel16.TabIndex = 6;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Transparent;
            panel17.BackgroundImage = Properties.Resources.nextbutton;
            panel17.BackgroundImageLayout = ImageLayout.Stretch;
            panel17.Location = new Point(297, 93);
            panel17.Name = "panel17";
            panel17.Size = new Size(66, 61);
            panel17.TabIndex = 4;
            panel17.Paint += panel17_Paint;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Transparent;
            panel18.BackgroundImage = Properties.Resources.stopbutton;
            panel18.BackgroundImageLayout = ImageLayout.Stretch;
            panel18.Location = new Point(225, 93);
            panel18.Name = "panel18";
            panel18.Size = new Size(66, 61);
            panel18.TabIndex = 4;
            panel18.Paint += panel18_Paint;
            // 
            // panel19
            // 
            panel19.BackColor = Color.Transparent;
            panel19.BackgroundImage = Properties.Resources.playbutton;
            panel19.BackgroundImageLayout = ImageLayout.Stretch;
            panel19.Location = new Point(153, 93);
            panel19.Name = "panel19";
            panel19.Size = new Size(66, 61);
            panel19.TabIndex = 3;
            panel19.Paint += panel19_Paint;
            // 
            // panel20
            // 
            panel20.BackColor = Color.Transparent;
            panel20.BackgroundImage = Properties.Resources.sliderhoriz1;
            panel20.BackgroundImageLayout = ImageLayout.Stretch;
            panel20.BorderStyle = BorderStyle.Fixed3D;
            panel20.Location = new Point(8, 168);
            panel20.Name = "panel20";
            panel20.Size = new Size(474, 31);
            panel20.TabIndex = 2;
            panel20.Paint += panel20_Paint;
            // 
            // panel21
            // 
            panel21.BackColor = Color.DimGray;
            panel21.Controls.Add(panel39);
            panel21.Location = new Point(6, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(139, 150);
            panel21.TabIndex = 1;
            panel21.Paint += panel21_Paint;
            // 
            // panel39
            // 
            panel39.BackColor = Color.Transparent;
            panel39.BackgroundImage = Properties.Resources.na;
            panel39.BackgroundImageLayout = ImageLayout.Stretch;
            panel39.BorderStyle = BorderStyle.FixedSingle;
            panel39.Location = new Point(3, 3);
            panel39.Name = "panel39";
            panel39.Size = new Size(133, 144);
            panel39.TabIndex = 11;
            panel39.Paint += panel39_Paint;
            // 
            // panel22
            // 
            panel22.BackColor = Color.LawnGreen;
            panel22.BorderStyle = BorderStyle.FixedSingle;
            panel22.Controls.Add(label9);
            panel22.Controls.Add(label8);
            panel22.Controls.Add(label7);
            panel22.Controls.Add(label4);
            panel22.Controls.Add(label5);
            panel22.Controls.Add(label6);
            panel22.Location = new Point(150, 7);
            panel22.Name = "panel22";
            panel22.Size = new Size(332, 78);
            panel22.TabIndex = 0;
            panel22.Paint += panel22_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label9.Location = new Point(255, 36);
            label9.Name = "label9";
            label9.Size = new Size(72, 37);
            label9.TabIndex = 5;
            label9.Text = "3:13";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(65, 33);
            label8.Name = "label8";
            label8.Size = new Size(166, 28);
            label8.TabIndex = 4;
            label8.Text = "Jane's Addiction";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(65, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 28);
            label7.TabIndex = 3;
            label7.Text = "Caught Stealing";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.Location = new Point(255, 4);
            label4.Name = "label4";
            label4.Size = new Size(72, 37);
            label4.TabIndex = 2;
            label4.Text = "3:13";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(3, 36);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 1;
            label5.Text = "Artist:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 0;
            label6.Text = "Title:";
            // 
            // panel23
            // 
            panel23.BackColor = Color.Teal;
            panel23.Controls.Add(label16);
            panel23.Controls.Add(label15);
            panel23.Controls.Add(label14);
            panel23.Controls.Add(panel42);
            panel23.Controls.Add(label13);
            panel23.Controls.Add(panel29);
            panel23.Controls.Add(panel27);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel24);
            panel23.Location = new Point(576, 12);
            panel23.Name = "panel23";
            panel23.Size = new Size(291, 233);
            panel23.TabIndex = 11;
            panel23.Paint += panel23_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Location = new Point(138, 11);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 12;
            label16.Text = "Fade Level";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(205, 0);
            label15.Name = "label15";
            label15.Size = new Size(27, 15);
            label15.TabIndex = 11;
            label15.Text = "Mic";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(150, -1);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 10;
            label14.Text = "Music";
            // 
            // panel42
            // 
            panel42.BackColor = Color.Transparent;
            panel42.BackgroundImage = Properties.Resources.playervucontrol;
            panel42.BackgroundImageLayout = ImageLayout.Stretch;
            panel42.BorderStyle = BorderStyle.FixedSingle;
            panel42.Controls.Add(panel43);
            panel42.Controls.Add(panel45);
            panel42.Location = new Point(157, 26);
            panel42.Name = "panel42";
            panel42.Size = new Size(28, 206);
            panel42.TabIndex = 9;
            panel42.Paint += panel42_Paint;
            // 
            // panel43
            // 
            panel43.BackColor = Color.Transparent;
            panel43.BackgroundImage = Properties.Resources.playervucontrol;
            panel43.BackgroundImageLayout = ImageLayout.Stretch;
            panel43.BorderStyle = BorderStyle.FixedSingle;
            panel43.Controls.Add(panel44);
            panel43.Location = new Point(-30, -1);
            panel43.Name = "panel43";
            panel43.Size = new Size(28, 206);
            panel43.TabIndex = 8;
            // 
            // panel44
            // 
            panel44.BackColor = Color.White;
            panel44.Location = new Point(-35, 1);
            panel44.Name = "panel44";
            panel44.Size = new Size(28, 192);
            panel44.TabIndex = 6;
            // 
            // panel45
            // 
            panel45.BackColor = Color.White;
            panel45.Location = new Point(-35, 1);
            panel45.Name = "panel45";
            panel45.Size = new Size(28, 192);
            panel45.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(29, 214);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 9;
            label13.Text = "Push To Talk";
            label13.Click += label13_Click;
            // 
            // panel29
            // 
            panel29.BackColor = Color.Transparent;
            panel29.Controls.Add(label18);
            panel29.Controls.Add(label17);
            panel29.Controls.Add(panel47);
            panel29.Controls.Add(panel46);
            panel29.Location = new Point(13, 5);
            panel29.Name = "panel29";
            panel29.Size = new Size(122, 100);
            panel29.TabIndex = 8;
            panel29.Paint += panel29_Paint;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(65, 19);
            label18.Name = "label18";
            label18.Size = new Size(49, 15);
            label18.TabIndex = 14;
            label18.Text = "Mic Off";
            label18.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(7, 19);
            label17.Name = "label17";
            label17.Size = new Size(46, 15);
            label17.TabIndex = 13;
            label17.Text = "Mic On";
            label17.Click += label17_Click;
            // 
            // panel47
            // 
            panel47.BackColor = Color.Transparent;
            panel47.BackgroundImage = Properties.Resources.micon;
            panel47.BackgroundImageLayout = ImageLayout.Stretch;
            panel47.Location = new Point(0, 37);
            panel47.Name = "panel47";
            panel47.Size = new Size(60, 60);
            panel47.TabIndex = 1;
            panel47.Paint += panel47_Paint;
            // 
            // panel46
            // 
            panel46.BackColor = Color.Transparent;
            panel46.BackgroundImage = Properties.Resources.micoff;
            panel46.BackgroundImageLayout = ImageLayout.Stretch;
            panel46.Location = new Point(60, 37);
            panel46.Name = "panel46";
            panel46.Size = new Size(60, 60);
            panel46.TabIndex = 0;
            panel46.Paint += panel46_Paint;
            // 
            // panel27
            // 
            panel27.BackColor = Color.Transparent;
            panel27.BackgroundImage = Properties.Resources.playervucontrol;
            panel27.BackgroundImageLayout = ImageLayout.Stretch;
            panel27.BorderStyle = BorderStyle.FixedSingle;
            panel27.Controls.Add(panel40);
            panel27.Controls.Add(panel28);
            panel27.Location = new Point(204, 26);
            panel27.Name = "panel27";
            panel27.Size = new Size(28, 206);
            panel27.TabIndex = 7;
            panel27.Paint += panel27_Paint;
            // 
            // panel40
            // 
            panel40.BackColor = Color.Transparent;
            panel40.BackgroundImage = Properties.Resources.playervucontrol;
            panel40.BackgroundImageLayout = ImageLayout.Stretch;
            panel40.BorderStyle = BorderStyle.FixedSingle;
            panel40.Controls.Add(panel41);
            panel40.Location = new Point(-30, -1);
            panel40.Name = "panel40";
            panel40.Size = new Size(28, 206);
            panel40.TabIndex = 8;
            // 
            // panel41
            // 
            panel41.BackColor = Color.White;
            panel41.Location = new Point(-35, 1);
            panel41.Name = "panel41";
            panel41.Size = new Size(28, 192);
            panel41.TabIndex = 6;
            // 
            // panel28
            // 
            panel28.BackColor = Color.White;
            panel28.Location = new Point(-35, 1);
            panel28.Name = "panel28";
            panel28.Size = new Size(28, 192);
            panel28.TabIndex = 6;
            // 
            // panel25
            // 
            panel25.BackColor = Color.Transparent;
            panel25.BackgroundImage = Properties.Resources.vumeter;
            panel25.BackgroundImageLayout = ImageLayout.Stretch;
            panel25.BorderStyle = BorderStyle.FixedSingle;
            panel25.Controls.Add(panel26);
            panel25.Location = new Point(241, 26);
            panel25.Name = "panel25";
            panel25.Size = new Size(28, 206);
            panel25.TabIndex = 7;
            panel25.Paint += panel25_Paint;
            // 
            // panel26
            // 
            panel26.BackColor = Color.White;
            panel26.Location = new Point(-35, 1);
            panel26.Name = "panel26";
            panel26.Size = new Size(28, 192);
            panel26.TabIndex = 6;
            // 
            // panel24
            // 
            panel24.BackColor = Color.Transparent;
            panel24.BackgroundImage = Properties.Resources.mictalkbutton;
            panel24.BackgroundImageLayout = ImageLayout.Stretch;
            panel24.Location = new Point(5, 109);
            panel24.Name = "panel24";
            panel24.Size = new Size(122, 100);
            panel24.TabIndex = 0;
            panel24.Paint += panel24_Paint;
            // 
            // panel30
            // 
            panel30.BackColor = Color.Teal;
            panel30.Controls.Add(panel31);
            panel30.Location = new Point(12, 251);
            panel30.Name = "panel30";
            panel30.Size = new Size(558, 460);
            panel30.TabIndex = 12;
            panel30.Paint += panel30_Paint;
            // 
            // panel31
            // 
            panel31.BackColor = Color.White;
            panel31.Location = new Point(8, 3);
            panel31.Name = "panel31";
            panel31.Size = new Size(544, 447);
            panel31.TabIndex = 0;
            panel31.Paint += panel31_Paint;
            // 
            // panel32
            // 
            panel32.BackColor = Color.Teal;
            panel32.Controls.Add(panel33);
            panel32.Location = new Point(874, 251);
            panel32.Name = "panel32";
            panel32.Size = new Size(558, 460);
            panel32.TabIndex = 13;
            panel32.Paint += panel32_Paint;
            // 
            // panel33
            // 
            panel33.BackColor = Color.White;
            panel33.Location = new Point(8, 3);
            panel33.Name = "panel33";
            panel33.Size = new Size(544, 447);
            panel33.TabIndex = 0;
            panel33.Paint += panel33_Paint;
            // 
            // panel34
            // 
            panel34.BackColor = Color.Teal;
            panel34.Controls.Add(panel35);
            panel34.Controls.Add(button4);
            panel34.Controls.Add(button3);
            panel34.Controls.Add(button2);
            panel34.Controls.Add(button1);
            panel34.Location = new Point(575, 254);
            panel34.Name = "panel34";
            panel34.Size = new Size(293, 288);
            panel34.TabIndex = 14;
            panel34.Paint += panel34_Paint;
            // 
            // panel35
            // 
            panel35.BackColor = Color.DarkGray;
            panel35.BorderStyle = BorderStyle.FixedSingle;
            panel35.Controls.Add(checkBox5);
            panel35.Controls.Add(checkBox6);
            panel35.Location = new Point(6, 76);
            panel35.Name = "panel35";
            panel35.Size = new Size(280, 208);
            panel35.TabIndex = 19;
            panel35.Paint += panel35_Paint_1;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.FlatStyle = FlatStyle.System;
            checkBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox5.Location = new Point(135, 180);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(96, 26);
            checkBox5.TabIndex = 11;
            checkBox5.Text = "Cue Out";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.FlatStyle = FlatStyle.System;
            checkBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox6.Location = new Point(47, 180);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(89, 26);
            checkBox6.TabIndex = 10;
            checkBox6.Text = "Air Out";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(153, 41);
            button4.Name = "button4";
            button4.Size = new Size(130, 30);
            button4.TabIndex = 18;
            button4.Text = "Tools";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(6, 41);
            button3.Name = "button3";
            button3.Size = new Size(130, 30);
            button3.TabIndex = 17;
            button3.Text = "Encoders";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(6, 6);
            button2.Name = "button2";
            button2.Size = new Size(130, 30);
            button2.TabIndex = 16;
            button2.Text = "Audio Setup";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(152, 6);
            button1.Name = "button1";
            button1.Size = new Size(130, 30);
            button1.TabIndex = 15;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel36
            // 
            panel36.BackColor = Color.Teal;
            panel36.Controls.Add(panel37);
            panel36.Location = new Point(575, 548);
            panel36.Name = "panel36";
            panel36.Size = new Size(290, 163);
            panel36.TabIndex = 15;
            panel36.Paint += panel36_Paint;
            // 
            // panel37
            // 
            panel37.BackColor = Color.White;
            panel37.BorderStyle = BorderStyle.FixedSingle;
            panel37.Location = new Point(5, 4);
            panel37.Name = "panel37";
            panel37.Size = new Size(281, 150);
            panel37.TabIndex = 0;
            panel37.Paint += panel37_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.Rpbjm;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1444, 726);
            Controls.Add(panel36);
            Controls.Add(panel34);
            Controls.Add(panel32);
            Controls.Add(panel30);
            Controls.Add(panel23);
            Controls.Add(panel12);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Wicked Broadcaster";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
            panel42.ResumeLayout(false);
            panel43.ResumeLayout(false);
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            panel27.ResumeLayout(false);
            panel40.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel30.ResumeLayout(false);
            panel32.ResumeLayout(false);
            panel34.ResumeLayout(false);
            panel35.ResumeLayout(false);
            panel35.PerformLayout();
            panel36.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel10;
        private Panel panel11;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Panel panel12;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private Panel panel20;
        private Panel panel21;
        private Panel panel22;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel23;
        private Panel panel24;
        private Panel panel27;
        private Panel panel28;
        private Panel panel25;
        private Panel panel26;
        private Panel panel29;
        private Panel panel30;
        private Panel panel31;
        private Panel panel32;
        private Panel panel33;
        private Panel panel34;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel36;
        private Panel panel37;
        private Panel panel35;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel38;
        private Panel panel39;
        private Label label13;
        private Panel panel42;
        private Panel panel43;
        private Panel panel44;
        private Panel panel45;
        private Panel panel40;
        private Panel panel41;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label18;
        private Label label17;
        private Panel panel47;
        private Panel panel46;
    }
}
