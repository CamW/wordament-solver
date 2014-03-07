namespace WordamentSolver
{
    partial class MainForm
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
            this.RunButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.GridTextBox = new System.Windows.Forms.TextBox();
            this.WordsFoundTextBox = new System.Windows.Forms.TextBox();
            this.SolvedInTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Location = new System.Drawing.Point(470, 459);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsTextBox.Location = new System.Drawing.Point(184, 12);
            this.ResultsTextBox.Multiline = true;
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultsTextBox.Size = new System.Drawing.Size(361, 415);
            this.ResultsTextBox.TabIndex = 1;
            // 
            // GridTextBox
            // 
            this.GridTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridTextBox.Location = new System.Drawing.Point(12, 12);
            this.GridTextBox.Multiline = true;
            this.GridTextBox.Name = "GridTextBox";
            this.GridTextBox.Size = new System.Drawing.Size(166, 415);
            this.GridTextBox.TabIndex = 2;
            this.GridTextBox.Text = "I,S,I,A\r\nW,E,S,I\r\nD,O,R,G\r\nS,P,E,V\r\n";
            // 
            // WordsFoundTextBox
            // 
            this.WordsFoundTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WordsFoundTextBox.Location = new System.Drawing.Point(89, 458);
            this.WordsFoundTextBox.Name = "WordsFoundTextBox";
            this.WordsFoundTextBox.ReadOnly = true;
            this.WordsFoundTextBox.Size = new System.Drawing.Size(89, 20);
            this.WordsFoundTextBox.TabIndex = 3;
            // 
            // SolvedInTextbox
            // 
            this.SolvedInTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SolvedInTextbox.Location = new System.Drawing.Point(89, 432);
            this.SolvedInTextbox.Name = "SolvedInTextbox";
            this.SolvedInTextbox.ReadOnly = true;
            this.SolvedInTextbox.Size = new System.Drawing.Size(89, 20);
            this.SolvedInTextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Solved In";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Words Found";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SolvedInTextbox);
            this.Controls.Add(this.WordsFoundTextBox);
            this.Controls.Add(this.GridTextBox);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.RunButton);
            this.Name = "Form1";
            this.Text = "Wordament Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.TextBox GridTextBox;
        private System.Windows.Forms.TextBox WordsFoundTextBox;
        private System.Windows.Forms.TextBox SolvedInTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

