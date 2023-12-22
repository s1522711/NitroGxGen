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
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // GenBtn
            // 
            GenBtn.Font = new Font("Papyrus", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenBtn.Location = new Point(644, 12);
            GenBtn.Name = "GenBtn";
            GenBtn.Size = new Size(131, 58);
            GenBtn.TabIndex = 0;
            GenBtn.Text = "Generate!";
            GenBtn.UseVisualStyleBackColor = true;
            GenBtn.Click += GenBtn_Click;
            // 
            // OutputBox
            // 
            OutputBox.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutputBox.Location = new Point(12, 12);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.Size = new Size(626, 122);
            OutputBox.TabIndex = 1;
            OutputBox.Text = "PRESS THE GENERATE BUTTON TO GENERATE A KEY!";
            OutputBox.TextAlign = HorizontalAlignment.Center;
            // 
            // copyBtn
            // 
            copyBtn.Font = new Font("Papyrus", 15.75F, FontStyle.Bold);
            copyBtn.Location = new Point(644, 76);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(131, 58);
            copyBtn.TabIndex = 2;
            copyBtn.Text = "Copy!";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // copyLabel
            // 
            copyLabel.AutoSize = true;
            copyLabel.ForeColor = Color.DarkGreen;
            copyLabel.Location = new Point(564, 137);
            copyLabel.Name = "copyLabel";
            copyLabel.Size = new Size(74, 15);
            copyLabel.TabIndex = 3;
            copyLabel.Text = "COPY LABEL";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(12, 136);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "debug";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 137);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 6;
            label1.Text = "debug label";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(39, 398);
            label2.Name = "label2";
            label2.Size = new Size(382, 30);
            label2.TabIndex = 7;
            label2.Text = "100% WORKING 2024!!111!1!%$";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.discord_nitro_banner_jpegged;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 520);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(copyLabel);
            Controls.Add(copyBtn);
            Controls.Add(OutputBox);
            Controls.Add(GenBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 559);
            MinimumSize = new Size(800, 559);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DISCORD NITRO GENERATROR 2024 WORKING 100% !!!!!!!!11!!!!1!!1$#@$#$#!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenBtn;
        private TextBox OutputBox;
        private Button copyBtn;
        private Label copyLabel;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
    }
}
