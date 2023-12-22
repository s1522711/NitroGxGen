namespace NitroGxGen
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
            GenBtn = new Button();
            OutputBox = new TextBox();
            copyBtn = new Button();
            copyLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GenBtn
            // 
            GenBtn.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenBtn.Location = new Point(644, 12);
            GenBtn.Name = "GenBtn";
            GenBtn.Size = new Size(131, 46);
            GenBtn.TabIndex = 0;
            GenBtn.Text = "Generate!";
            GenBtn.UseVisualStyleBackColor = true;
            GenBtn.Click += GenBtn_Click;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(12, 12);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.ScrollBars = ScrollBars.Vertical;
            OutputBox.Size = new Size(626, 102);
            OutputBox.TabIndex = 1;
            OutputBox.Text = "PRESS THE GENERATE BUTTON TO GENERATE A KEY!";
            // 
            // copyBtn
            // 
            copyBtn.Font = new Font("Papyrus", 15.75F, FontStyle.Bold);
            copyBtn.Location = new Point(644, 64);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(131, 50);
            copyBtn.TabIndex = 2;
            copyBtn.Text = "Copy!";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // copyLabel
            // 
            copyLabel.AutoSize = true;
            copyLabel.ForeColor = Color.DarkGreen;
            copyLabel.Location = new Point(644, 117);
            copyLabel.Name = "copyLabel";
            copyLabel.Size = new Size(74, 15);
            copyLabel.TabIndex = 3;
            copyLabel.Text = "COPY LABEL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.discord_nitro_banner_jpegged;
            pictureBox1.Location = new Point(12, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(760, 373);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 520);
            Controls.Add(pictureBox1);
            Controls.Add(copyLabel);
            Controls.Add(copyBtn);
            Controls.Add(OutputBox);
            Controls.Add(GenBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DISCORD NITRO GENERATROR 2024 WORKING 100% !!!!!!!!11!!!!1!!1$#@$#$#!";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenBtn;
        private TextBox OutputBox;
        private Button copyBtn;
        private Label copyLabel;
        private PictureBox pictureBox1;
    }
}
