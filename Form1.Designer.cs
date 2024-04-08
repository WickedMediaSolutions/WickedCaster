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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            panel2 = new Panel();
            label3 = new Label();
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
            panel22 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel23 = new Panel();
            panel29 = new Panel();
            panel27 = new Panel();
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
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel27.SuspendLayout();
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
            panel1.BackColor = Color.Gray;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
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
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox2.Location = new Point(468, 204);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(90, 25);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Cue Out";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox1.Location = new Point(380, 204);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 25);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Air Out";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
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
            panel8.BackColor = Color.White;
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
            panel6.BackColor = Color.White;
            panel6.Location = new Point(297, 93);
            panel6.Name = "panel6";
            panel6.Size = new Size(66, 61);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Location = new Point(225, 93);
            panel7.Name = "panel7";
            panel7.Size = new Size(66, 61);
            panel7.TabIndex = 4;
            panel7.Paint += panel7_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(153, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(66, 61);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(8, 168);
            panel4.Name = "panel4";
            panel4.Size = new Size(474, 31);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(6, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(139, 150);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(150, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 78);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
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
            panel12.BackColor = Color.Gray;
            panel12.BackgroundImage = Properties.Resources._1;
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
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox3.Location = new Point(468, 204);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(90, 25);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Cue Out";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox4.Location = new Point(380, 204);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 25);
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
            panel17.BackColor = Color.White;
            panel17.Location = new Point(297, 93);
            panel17.Name = "panel17";
            panel17.Size = new Size(66, 61);
            panel17.TabIndex = 4;
            panel17.Paint += panel17_Paint;
            // 
            // panel18
            // 
            panel18.BackColor = Color.White;
            panel18.Location = new Point(225, 93);
            panel18.Name = "panel18";
            panel18.Size = new Size(66, 61);
            panel18.TabIndex = 4;
            panel18.Paint += panel18_Paint;
            // 
            // panel19
            // 
            panel19.BackColor = Color.White;
            panel19.Location = new Point(153, 93);
            panel19.Name = "panel19";
            panel19.Size = new Size(66, 61);
            panel19.TabIndex = 3;
            panel19.Paint += panel19_Paint;
            // 
            // panel20
            // 
            panel20.BackColor = Color.White;
            panel20.Location = new Point(8, 168);
            panel20.Name = "panel20";
            panel20.Size = new Size(474, 31);
            panel20.TabIndex = 2;
            panel20.Paint += panel20_Paint;
            // 
            // panel21
            // 
            panel21.BackColor = Color.White;
            panel21.Location = new Point(6, 4);
            panel21.Name = "panel21";
            panel21.Size = new Size(139, 150);
            panel21.TabIndex = 1;
            panel21.Paint += panel21_Paint;
            // 
            // panel22
            // 
            panel22.BackColor = Color.White;
            panel22.Controls.Add(label4);
            panel22.Controls.Add(label5);
            panel22.Controls.Add(label6);
            panel22.Location = new Point(150, 3);
            panel22.Name = "panel22";
            panel22.Size = new Size(332, 78);
            panel22.TabIndex = 0;
            panel22.Paint += panel22_Paint;
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
            panel23.BackColor = Color.Gray;
            panel23.BackgroundImage = Properties.Resources._1;
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
            // panel29
            // 
            panel29.BackColor = Color.White;
            panel29.Location = new Point(13, 8);
            panel29.Name = "panel29";
            panel29.Size = new Size(186, 100);
            panel29.TabIndex = 8;
            panel29.Paint += panel29_Paint;
            // 
            // panel27
            // 
            panel27.BackColor = Color.White;
            panel27.Controls.Add(panel28);
            panel27.Location = new Point(205, 8);
            panel27.Name = "panel27";
            panel27.Size = new Size(28, 206);
            panel27.TabIndex = 7;
            panel27.Paint += panel27_Paint;
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
            panel25.BackColor = Color.White;
            panel25.Controls.Add(panel26);
            panel25.Location = new Point(249, 8);
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
            panel24.BackColor = Color.White;
            panel24.Location = new Point(42, 114);
            panel24.Name = "panel24";
            panel24.Size = new Size(122, 100);
            panel24.TabIndex = 0;
            panel24.Paint += panel24_Paint;
            // 
            // panel30
            // 
            panel30.BackColor = Color.Gray;
            panel30.BackgroundImage = Properties.Resources._1;
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
            panel32.BackColor = Color.Gray;
            panel32.BackgroundImage = Properties.Resources._1;
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
            panel34.BackColor = Color.Gray;
            panel34.BackgroundImage = Properties.Resources._1;
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
            checkBox5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox5.Location = new Point(135, 180);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(90, 25);
            checkBox5.TabIndex = 11;
            checkBox5.Text = "Cue Out";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            checkBox6.Location = new Point(47, 180);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(83, 25);
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
            panel36.BackColor = Color.Gray;
            panel36.BackgroundImage = Properties.Resources._1;
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
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel23.ResumeLayout(false);
            panel27.ResumeLayout(false);
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
    }
}
