namespace WinFormsApp1
{
    partial class Form3
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
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1265, 684);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Teal;
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1265, 684);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(1121, 640);
            button2.Name = "button2";
            button2.Size = new Size(140, 38);
            button2.TabIndex = 4;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(975, 640);
            button1.Name = "button1";
            button1.Size = new Size(140, 38);
            button1.TabIndex = 3;
            button1.Text = "Add Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.encoderdetailsicecast;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(417, 299);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 376);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.encoderserverdetails;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(6, 299);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 380);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.encoderconfigadd;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 287);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1273, 712);
            tabControl1.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1282, 718);
            Controls.Add(tabControl1);
            Name = "Form3";
            Text = "New Encoder";
            Load += Form3_Load;
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button button1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TabControl tabControl1;
        private Button button2;
    }
}