namespace Asg4
{
    partial class Asg4
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
            this.MainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.JackPotLabel = new System.Windows.Forms.Label();
            this.DollarLabel = new System.Windows.Forms.Label();
            this.AmountWonLabel = new System.Windows.Forms.Label();
            this.WinningThreeTextBox = new System.Windows.Forms.TextBox();
            this.WinningTwoTextBox = new System.Windows.Forms.TextBox();
            this.WinningOneTextBox = new System.Windows.Forms.TextBox();
            this.winningNumbersLabel = new System.Windows.Forms.Label();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.InstructionsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.GuessThreeTextBox = new System.Windows.Forms.TextBox();
            this.GuessTwoTextBox = new System.Windows.Forms.TextBox();
            this.GuessOneTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.matchLabel = new System.Windows.Forms.Label();
            this.NoOfMatchesLabel = new System.Windows.Forms.Label();
            this.MainFlowLayoutPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFlowLayoutPanel
            // 
            this.MainFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainFlowLayoutPanel.Controls.Add(this.MainPanel);
            this.MainFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainFlowLayoutPanel.Location = new System.Drawing.Point(12, 42);
            this.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
            this.MainFlowLayoutPanel.Size = new System.Drawing.Size(512, 330);
            this.MainFlowLayoutPanel.TabIndex = 0;
            this.MainFlowLayoutPanel.WrapContents = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OutputPanel);
            this.MainPanel.Controls.Add(this.InputPanel);
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(508, 330);
            this.MainPanel.TabIndex = 0;
            // 
            // OutputPanel
            // 
            this.OutputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.OutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPanel.Controls.Add(this.NoOfMatchesLabel);
            this.OutputPanel.Controls.Add(this.matchLabel);
            this.OutputPanel.Controls.Add(this.JackPotLabel);
            this.OutputPanel.Controls.Add(this.DollarLabel);
            this.OutputPanel.Controls.Add(this.AmountWonLabel);
            this.OutputPanel.Controls.Add(this.WinningThreeTextBox);
            this.OutputPanel.Controls.Add(this.WinningTwoTextBox);
            this.OutputPanel.Controls.Add(this.WinningOneTextBox);
            this.OutputPanel.Controls.Add(this.winningNumbersLabel);
            this.OutputPanel.Location = new System.Drawing.Point(4, 171);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(500, 158);
            this.OutputPanel.TabIndex = 7;
            // 
            // JackPotLabel
            // 
            this.JackPotLabel.AutoSize = true;
            this.JackPotLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JackPotLabel.Location = new System.Drawing.Point(13, 126);
            this.JackPotLabel.Name = "JackPotLabel";
            this.JackPotLabel.Size = new System.Drawing.Size(0, 24);
            this.JackPotLabel.TabIndex = 9;
            // 
            // DollarLabel
            // 
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DollarLabel.ForeColor = System.Drawing.Color.Yellow;
            this.DollarLabel.Location = new System.Drawing.Point(345, 126);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(0, 24);
            this.DollarLabel.TabIndex = 8;
            // 
            // AmountWonLabel
            // 
            this.AmountWonLabel.AutoSize = true;
            this.AmountWonLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountWonLabel.Location = new System.Drawing.Point(209, 126);
            this.AmountWonLabel.Name = "AmountWonLabel";
            this.AmountWonLabel.Size = new System.Drawing.Size(130, 24);
            this.AmountWonLabel.TabIndex = 7;
            this.AmountWonLabel.Text = "Amount Won $";
            // 
            // WinningThreeTextBox
            // 
            this.WinningThreeTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningThreeTextBox.Location = new System.Drawing.Point(294, 67);
            this.WinningThreeTextBox.Name = "WinningThreeTextBox";
            this.WinningThreeTextBox.Size = new System.Drawing.Size(23, 27);
            this.WinningThreeTextBox.TabIndex = 6;
            // 
            // WinningTwoTextBox
            // 
            this.WinningTwoTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningTwoTextBox.Location = new System.Drawing.Point(228, 67);
            this.WinningTwoTextBox.Name = "WinningTwoTextBox";
            this.WinningTwoTextBox.Size = new System.Drawing.Size(23, 27);
            this.WinningTwoTextBox.TabIndex = 5;
            // 
            // WinningOneTextBox
            // 
            this.WinningOneTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinningOneTextBox.Location = new System.Drawing.Point(164, 67);
            this.WinningOneTextBox.Name = "WinningOneTextBox";
            this.WinningOneTextBox.Size = new System.Drawing.Size(23, 27);
            this.WinningOneTextBox.TabIndex = 4;
            // 
            // winningNumbersLabel
            // 
            this.winningNumbersLabel.AutoSize = true;
            this.winningNumbersLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningNumbersLabel.Location = new System.Drawing.Point(146, 13);
            this.winningNumbersLabel.Name = "winningNumbersLabel";
            this.winningNumbersLabel.Size = new System.Drawing.Size(184, 28);
            this.winningNumbersLabel.TabIndex = 0;
            this.winningNumbersLabel.Text = "Winning Numbers";
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputPanel.Controls.Add(this.InstructionsListBox);
            this.InputPanel.Controls.Add(this.panel2);
            this.InputPanel.Controls.Add(this.EnterLabel);
            this.InputPanel.Controls.Add(this.PlayButton);
            this.InputPanel.Controls.Add(this.GuessThreeTextBox);
            this.InputPanel.Controls.Add(this.GuessTwoTextBox);
            this.InputPanel.Controls.Add(this.GuessOneTextBox);
            this.InputPanel.Location = new System.Drawing.Point(3, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(502, 165);
            this.InputPanel.TabIndex = 6;
            // 
            // InstructionsListBox
            // 
            this.InstructionsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InstructionsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionsListBox.Font = new System.Drawing.Font("Monotype Corsiva", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsListBox.FormattingEnabled = true;
            this.InstructionsListBox.ItemHeight = 15;
            this.InstructionsListBox.Items.AddRange(new object[] {
            "Numbers must be ",
            "betweeen 1 and 4",
            "Match 1: $10",
            "Match 2: $100",
            "Match 3: $1000",
            "3 in a row: $10,000"});
            this.InstructionsListBox.Location = new System.Drawing.Point(0, 61);
            this.InstructionsListBox.Name = "InstructionsListBox";
            this.InstructionsListBox.Size = new System.Drawing.Size(156, 120);
            this.InstructionsListBox.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(349, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 6;
            // 
            // EnterLabel
            // 
            this.EnterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterLabel.Location = new System.Drawing.Point(131, 12);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(215, 28);
            this.EnterLabel.TabIndex = 0;
            this.EnterLabel.Text = "Enter your 3 numbers";
            this.EnterLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Yellow;
            this.PlayButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(200, 110);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 33);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "PLAY";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // GuessThreeTextBox
            // 
            this.GuessThreeTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessThreeTextBox.Location = new System.Drawing.Point(295, 57);
            this.GuessThreeTextBox.Name = "GuessThreeTextBox";
            this.GuessThreeTextBox.Size = new System.Drawing.Size(23, 27);
            this.GuessThreeTextBox.TabIndex = 3;
            // 
            // GuessTwoTextBox
            // 
            this.GuessTwoTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessTwoTextBox.Location = new System.Drawing.Point(229, 57);
            this.GuessTwoTextBox.Name = "GuessTwoTextBox";
            this.GuessTwoTextBox.Size = new System.Drawing.Size(23, 27);
            this.GuessTwoTextBox.TabIndex = 2;
            // 
            // GuessOneTextBox
            // 
            this.GuessOneTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessOneTextBox.Location = new System.Drawing.Point(165, 57);
            this.GuessOneTextBox.Name = "GuessOneTextBox";
            this.GuessOneTextBox.Size = new System.Drawing.Size(23, 27);
            this.GuessOneTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(192, 2);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(146, 37);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "WIN BIG!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Location = new System.Drawing.Point(437, 21);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(0, 17);
            this.matchLabel.TabIndex = 8;
            this.matchLabel.Visible = false;
            // 
            // NoOfMatchesLabel
            // 
            this.NoOfMatchesLabel.AutoSize = true;
            this.NoOfMatchesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfMatchesLabel.Location = new System.Drawing.Point(373, 23);
            this.NoOfMatchesLabel.Name = "NoOfMatchesLabel";
            this.NoOfMatchesLabel.Size = new System.Drawing.Size(58, 13);
            this.NoOfMatchesLabel.TabIndex = 10;
            this.NoOfMatchesLabel.Text = "Matches:";
            this.NoOfMatchesLabel.Visible = false;
            // 
            // Asg4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(536, 401);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MainFlowLayoutPanel);
            this.MaximizeBox = false;
            this.Name = "Asg4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lottery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainFlowLayoutPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel MainFlowLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox GuessThreeTextBox;
        private System.Windows.Forms.TextBox GuessTwoTextBox;
        private System.Windows.Forms.TextBox GuessOneTextBox;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label DollarLabel;
        private System.Windows.Forms.Label AmountWonLabel;
        private System.Windows.Forms.TextBox WinningThreeTextBox;
        private System.Windows.Forms.TextBox WinningTwoTextBox;
        private System.Windows.Forms.TextBox WinningOneTextBox;
        private System.Windows.Forms.Label winningNumbersLabel;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label JackPotLabel;
        private System.Windows.Forms.ListBox InstructionsListBox;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Label NoOfMatchesLabel;
    }
}

