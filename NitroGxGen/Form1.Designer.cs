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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GenBtn = new Button();
            OutputBox = new TextBox();
            copyBtn = new Button();
            copyLabel = new Label();
            debugCheckbox = new CheckBox();
            debugLabel = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            timerInput = new NumericUpDown();
            timerBox = new CheckBox();
            fileSelect = new Button();
            saveFileDialog1 = new SaveFileDialog();
            saveTimerToFile = new CheckBox();
            selectedFileLabel = new Label();
            groupBox1 = new GroupBox();
            infoTimerLabel = new Label();
            groupBox2 = new GroupBox();
            saveIndicatorLabel = new Label();
            timerProgressBar = new ProgressBar();
            timerProgressBarSmall = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)timerInput).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            OutputBox.AcceptsReturn = true;
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
            // debugCheckbox
            // 
            debugCheckbox.AutoSize = true;
            debugCheckbox.BackColor = Color.Transparent;
            debugCheckbox.Location = new Point(12, 136);
            debugCheckbox.Name = "debugCheckbox";
            debugCheckbox.Size = new Size(60, 19);
            debugCheckbox.TabIndex = 5;
            debugCheckbox.Text = "debug";
            debugCheckbox.UseVisualStyleBackColor = false;
            debugCheckbox.CheckedChanged += debugCheckbox_CheckedChanged;
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.Location = new Point(78, 137);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(69, 15);
            debugLabel.TabIndex = 6;
            debugLabel.Text = "debug label";
            debugLabel.Visible = false;
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
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.ForeColor = Color.White;
            timerLabel.Location = new Point(394, 28);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(38, 15);
            timerLabel.TabIndex = 8;
            timerLabel.Text = "label3";
            timerLabel.Visible = false;
            // 
            // timerInput
            // 
            timerInput.DecimalPlaces = 2;
            timerInput.InterceptArrowKeys = false;
            timerInput.Location = new Point(6, 26);
            timerInput.Minimum = new decimal(new int[] { 5, 0, 0, 65536 });
            timerInput.Name = "timerInput";
            timerInput.Size = new Size(120, 23);
            timerInput.TabIndex = 9;
            timerInput.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // timerBox
            // 
            timerBox.AutoSize = true;
            timerBox.Location = new Point(132, 27);
            timerBox.Name = "timerBox";
            timerBox.Size = new Size(94, 19);
            timerBox.TabIndex = 10;
            timerBox.Text = "Enable Timer";
            timerBox.UseVisualStyleBackColor = true;
            timerBox.CheckedChanged += timerBox_CheckedChanged;
            // 
            // fileSelect
            // 
            fileSelect.ForeColor = SystemColors.ControlText;
            fileSelect.Location = new Point(163, 19);
            fileSelect.Name = "fileSelect";
            fileSelect.Size = new Size(75, 23);
            fileSelect.TabIndex = 11;
            fileSelect.Text = "Select File";
            fileSelect.UseVisualStyleBackColor = true;
            fileSelect.Click += button1_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // saveTimerToFile
            // 
            saveTimerToFile.AutoSize = true;
            saveTimerToFile.Location = new Point(6, 22);
            saveTimerToFile.Name = "saveTimerToFile";
            saveTimerToFile.Size = new Size(151, 19);
            saveTimerToFile.TabIndex = 12;
            saveTimerToFile.Text = "Save timer results to file";
            saveTimerToFile.UseVisualStyleBackColor = true;
            saveTimerToFile.CheckedChanged += saveTimerToFile_CheckedChanged;
            // 
            // selectedFileLabel
            // 
            selectedFileLabel.AutoSize = true;
            selectedFileLabel.Location = new Point(244, 23);
            selectedFileLabel.Name = "selectedFileLabel";
            selectedFileLabel.Size = new Size(104, 15);
            selectedFileLabel.TabIndex = 13;
            selectedFileLabel.Text = "NO FILE SELECTED";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(timerProgressBarSmall);
            groupBox1.Controls.Add(timerLabel);
            groupBox1.Controls.Add(infoTimerLabel);
            groupBox1.Controls.Add(timerInput);
            groupBox1.Controls.Add(timerBox);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(349, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 63);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loop Timer";
            // 
            // infoTimerLabel
            // 
            infoTimerLabel.AutoSize = true;
            infoTimerLabel.BackColor = Color.Transparent;
            infoTimerLabel.ForeColor = Color.White;
            infoTimerLabel.Location = new Point(232, 28);
            infoTimerLabel.Name = "infoTimerLabel";
            infoTimerLabel.Size = new Size(167, 15);
            infoTimerLabel.TabIndex = 14;
            infoTimerLabel.Text = "time left until next generation:";
            infoTimerLabel.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(saveIndicatorLabel);
            groupBox2.Controls.Add(saveTimerToFile);
            groupBox2.Controls.Add(fileSelect);
            groupBox2.Controls.Add(selectedFileLabel);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(349, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(381, 63);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saving results";
            // 
            // saveIndicatorLabel
            // 
            saveIndicatorLabel.AutoSize = true;
            saveIndicatorLabel.ForeColor = Color.DarkRed;
            saveIndicatorLabel.Location = new Point(146, 44);
            saveIndicatorLabel.Name = "saveIndicatorLabel";
            saveIndicatorLabel.Size = new Size(105, 15);
            saveIndicatorLabel.TabIndex = 14;
            saveIndicatorLabel.Text = "Saved Successfully";
            saveIndicatorLabel.TextAlign = ContentAlignment.MiddleCenter;
            saveIndicatorLabel.Visible = false;
            // 
            // timerProgressBar
            // 
            timerProgressBar.Location = new Point(12, 485);
            timerProgressBar.MarqueeAnimationSpeed = 10000;
            timerProgressBar.Maximum = 1000;
            timerProgressBar.Name = "timerProgressBar";
            timerProgressBar.Size = new Size(760, 23);
            timerProgressBar.Style = ProgressBarStyle.Continuous;
            timerProgressBar.TabIndex = 16;
            timerProgressBar.Visible = false;
            // 
            // timerProgressBarSmall
            // 
            timerProgressBarSmall.Location = new Point(232, 43);
            timerProgressBarSmall.MarqueeAnimationSpeed = 10000;
            timerProgressBarSmall.Maximum = 1000;
            timerProgressBarSmall.Name = "timerProgressBarSmall";
            timerProgressBarSmall.Size = new Size(191, 17);
            timerProgressBarSmall.Style = ProgressBarStyle.Continuous;
            timerProgressBarSmall.TabIndex = 17;
            timerProgressBarSmall.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.discord_nitro_banner_jpegged;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 520);
            Controls.Add(timerProgressBar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(debugLabel);
            Controls.Add(debugCheckbox);
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
            ((System.ComponentModel.ISupportInitialize)timerInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GenBtn;
        private TextBox OutputBox;
        private Button copyBtn;
        private Label copyLabel;
        private CheckBox debugCheckbox;
        private Label debugLabel;
        private Label label2;
        public System.Windows.Forms.Timer timer1;
        private Label timerLabel;
        private NumericUpDown timerInput;
        private CheckBox timerBox;
        private Button fileSelect;
        private SaveFileDialog saveFileDialog1;
        private CheckBox saveTimerToFile;
        private Label selectedFileLabel;
        private GroupBox groupBox1;
        private Label infoTimerLabel;
        private GroupBox groupBox2;
        private Label saveIndicatorLabel;
        private ProgressBar timerProgressBar;
        private ProgressBar timerProgressBarSmall;
    }
}
