namespace WinFormsApp1
{
    partial class Form2
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
            panel1 = new Panel();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            button6 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = WickedBroadcaster.Properties.Resources.encoderpanel;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(13, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 190);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 256);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(137, 3);
            button5.Name = "button5";
            button5.Size = new Size(128, 29);
            button5.TabIndex = 5;
            button5.Text = "Edit  Encoder";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(539, 3);
            button4.Name = "button4";
            button4.Size = new Size(128, 29);
            button4.TabIndex = 4;
            button4.Text = "Record Stream";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(405, 3);
            button3.Name = "button3";
            button3.Size = new Size(128, 29);
            button3.TabIndex = 3;
            button3.Text = "Stop Encoder";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(271, 3);
            button2.Name = "button2";
            button2.Size = new Size(128, 29);
            button2.TabIndex = 2;
            button2.Text = "Start Encoder";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 1;
            button1.Text = "Add Encoder";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Teal;
            listView1.Location = new Point(3, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(664, 214);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(609, 274);
            button6.Name = "button6";
            button6.Size = new Size(75, 34);
            button6.TabIndex = 2;
            button6.Text = "Close";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(696, 315);
            Controls.Add(button6);
            Controls.Add(panel2);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form2";
            Text = "Encoders";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListView listView1;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
    }
}