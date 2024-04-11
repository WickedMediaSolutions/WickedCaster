namespace WickedBroadcaster
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            listBox3 = new ListBox();
            panel1 = new Panel();
            button1 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            listBox6 = new ListBox();
            listBox5 = new ListBox();
            listBox4 = new ListBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            listBox7 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(95, 12);
            label1.Name = "label1";
            label1.Size = new Size(265, 28);
            label1.TabIndex = 0;
            label1.Text = "Main Audio Output Device";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(17, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(393, 34);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(95, 92);
            label2.Name = "label2";
            label2.Size = new Size(252, 28);
            label2.TabIndex = 2;
            label2.Text = "Cue Audio Output Device";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(17, 123);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(393, 34);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(95, 175);
            label3.Name = "label3";
            label3.Size = new Size(252, 28);
            label3.TabIndex = 4;
            label3.Text = "Microphone Input Device";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(17, 206);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(393, 34);
            listBox3.TabIndex = 5;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(listBox7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 459);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(941, 510);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1069, 510);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 9;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(listBox6);
            panel2.Controls.Add(listBox5);
            panel2.Controls.Add(listBox4);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(476, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 462);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.rotation;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(74, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(526, 299);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(245, 129);
            label8.Name = "label8";
            label8.Size = new Size(154, 28);
            label8.TabIndex = 7;
            label8.Text = "Rotation Setup";
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new Point(257, 100);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(120, 19);
            listBox6.TabIndex = 6;
            listBox6.SelectedIndexChanged += listBox6_SelectedIndexChanged;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new Point(257, 72);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(120, 19);
            listBox5.TabIndex = 5;
            listBox5.SelectedIndexChanged += listBox5_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(257, 44);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(120, 19);
            listBox4.TabIndex = 4;
            listBox4.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(257, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 28);
            label7.TabIndex = 3;
            label7.Text = "PlayList Rules";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(0, 91);
            label6.Name = "label6";
            label6.Size = new Size(245, 28);
            label6.TabIndex = 2;
            label6.Text = "Songs To Keep In Queue:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(0, 63);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 1;
            label5.Text = "Track Repeat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(0, 35);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 0;
            label4.Text = "Album Repeat:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(44, 261);
            label9.Name = "label9";
            label9.Size = new Size(316, 28);
            label9.TabIndex = 6;
            label9.Text = "Output Now Playing Info To File";
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.ItemHeight = 15;
            listBox7.Location = new Point(17, 292);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(393, 34);
            listBox7.TabIndex = 7;
            listBox7.SelectedIndexChanged += listBox7_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1170, 545);
            Controls.Add(panel2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Audio Config";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private ListBox listBox3;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ListBox listBox6;
        private ListBox listBox5;
        private ListBox listBox4;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private ListBox listBox7;
    }
}