
namespace PROG7312_POE.Presentation
{
    partial class FindingCallNumbersScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingCallNumbersScreen));
            this.gameInfoBox = new System.Windows.Forms.RichTextBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.answerBtn4 = new System.Windows.Forms.Button();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.gameEndedPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gameResultLbl = new System.Windows.Forms.Label();
            this.descriptionToFindLbl = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.currentScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreTxtLbl = new System.Windows.Forms.Label();
            this.currentScoreTxtLbl = new System.Windows.Forms.Label();
            this.GameNumLbl = new System.Windows.Forms.Label();
            this.answerPanel.SuspendLayout();
            this.gameEndedPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameInfoBox
            // 
            this.gameInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameInfoBox.Location = new System.Drawing.Point(301, 12);
            this.gameInfoBox.Name = "gameInfoBox";
            this.gameInfoBox.ReadOnly = true;
            this.gameInfoBox.Size = new System.Drawing.Size(419, 60);
            this.gameInfoBox.TabIndex = 0;
            this.gameInfoBox.Text = resources.GetString("gameInfoBox.Text");
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newGameBtn.Enabled = false;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(12, 12);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(116, 42);
            this.newGameBtn.TabIndex = 23;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // answerBtn1
            // 
            this.answerBtn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn1.BackColor = System.Drawing.SystemColors.Control;
            this.answerBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn1.Location = new System.Drawing.Point(41, 20);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(203, 61);
            this.answerBtn1.TabIndex = 24;
            this.answerBtn1.Text = "answerBtn1";
            this.answerBtn1.UseVisualStyleBackColor = false;
            this.answerBtn1.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerBtn2
            // 
            this.answerBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn2.BackColor = System.Drawing.SystemColors.Control;
            this.answerBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn2.Location = new System.Drawing.Point(348, 20);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(203, 61);
            this.answerBtn2.TabIndex = 25;
            this.answerBtn2.Text = "answerBtn2";
            this.answerBtn2.UseVisualStyleBackColor = false;
            this.answerBtn2.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerBtn3
            // 
            this.answerBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn3.BackColor = System.Drawing.SystemColors.Control;
            this.answerBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn3.Location = new System.Drawing.Point(41, 129);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(203, 61);
            this.answerBtn3.TabIndex = 26;
            this.answerBtn3.Text = "answerBtn3";
            this.answerBtn3.UseVisualStyleBackColor = false;
            this.answerBtn3.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerBtn4
            // 
            this.answerBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn4.BackColor = System.Drawing.SystemColors.Control;
            this.answerBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn4.Location = new System.Drawing.Point(348, 129);
            this.answerBtn4.Name = "answerBtn4";
            this.answerBtn4.Size = new System.Drawing.Size(203, 61);
            this.answerBtn4.TabIndex = 27;
            this.answerBtn4.Text = "answerBtn4";
            this.answerBtn4.UseVisualStyleBackColor = false;
            this.answerBtn4.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerPanel
            // 
            this.answerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.answerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerPanel.Controls.Add(this.answerBtn1);
            this.answerPanel.Controls.Add(this.answerBtn3);
            this.answerPanel.Controls.Add(this.answerBtn4);
            this.answerPanel.Controls.Add(this.answerBtn2);
            this.answerPanel.Location = new System.Drawing.Point(62, 255);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(593, 219);
            this.answerPanel.TabIndex = 28;
            // 
            // gameEndedPanel
            // 
            this.gameEndedPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.gameEndedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gameEndedPanel.Controls.Add(this.richTextBox1);
            this.gameEndedPanel.Controls.Add(this.gameResultLbl);
            this.gameEndedPanel.Location = new System.Drawing.Point(455, 125);
            this.gameEndedPanel.Name = "gameEndedPanel";
            this.gameEndedPanel.Size = new System.Drawing.Size(200, 115);
            this.gameEndedPanel.TabIndex = 29;
            this.gameEndedPanel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(175, 56);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "The game is over, to start another question, click new game.";
            // 
            // gameResultLbl
            // 
            this.gameResultLbl.AutoSize = true;
            this.gameResultLbl.Location = new System.Drawing.Point(17, 16);
            this.gameResultLbl.Name = "gameResultLbl";
            this.gameResultLbl.Size = new System.Drawing.Size(102, 17);
            this.gameResultLbl.TabIndex = 0;
            this.gameResultLbl.Text = "gameResultLbl";
            // 
            // descriptionToFindLbl
            // 
            this.descriptionToFindLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.descriptionToFindLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionToFindLbl.Location = new System.Drawing.Point(84, 216);
            this.descriptionToFindLbl.Name = "descriptionToFindLbl";
            this.descriptionToFindLbl.ReadOnly = true;
            this.descriptionToFindLbl.Size = new System.Drawing.Size(335, 24);
            this.descriptionToFindLbl.TabIndex = 30;
            this.descriptionToFindLbl.Text = "Label";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(94, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Description:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "Score:";
            // 
            // scorePanel
            // 
            this.scorePanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scorePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.scorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scorePanel.Controls.Add(this.currentScoreLbl);
            this.scorePanel.Controls.Add(this.totalScoreLbl);
            this.scorePanel.Controls.Add(this.totalScoreTxtLbl);
            this.scorePanel.Controls.Add(this.currentScoreTxtLbl);
            this.scorePanel.Location = new System.Drawing.Point(68, 101);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(162, 66);
            this.scorePanel.TabIndex = 32;
            // 
            // currentScoreLbl
            // 
            this.currentScoreLbl.AutoSize = true;
            this.currentScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentScoreLbl.Location = new System.Drawing.Point(105, 34);
            this.currentScoreLbl.Name = "currentScoreLbl";
            this.currentScoreLbl.Size = new System.Drawing.Size(17, 17);
            this.currentScoreLbl.TabIndex = 18;
            this.currentScoreLbl.Text = "0";
            // 
            // totalScoreLbl
            // 
            this.totalScoreLbl.AutoSize = true;
            this.totalScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLbl.Location = new System.Drawing.Point(105, 9);
            this.totalScoreLbl.Name = "totalScoreLbl";
            this.totalScoreLbl.Size = new System.Drawing.Size(17, 17);
            this.totalScoreLbl.TabIndex = 17;
            this.totalScoreLbl.Text = "0";
            // 
            // totalScoreTxtLbl
            // 
            this.totalScoreTxtLbl.AutoSize = true;
            this.totalScoreTxtLbl.Location = new System.Drawing.Point(21, 9);
            this.totalScoreTxtLbl.Name = "totalScoreTxtLbl";
            this.totalScoreTxtLbl.Size = new System.Drawing.Size(85, 17);
            this.totalScoreTxtLbl.TabIndex = 16;
            this.totalScoreTxtLbl.Text = "Total Score:";
            // 
            // currentScoreTxtLbl
            // 
            this.currentScoreTxtLbl.AutoSize = true;
            this.currentScoreTxtLbl.Location = new System.Drawing.Point(8, 34);
            this.currentScoreTxtLbl.Name = "currentScoreTxtLbl";
            this.currentScoreTxtLbl.Size = new System.Drawing.Size(100, 17);
            this.currentScoreTxtLbl.TabIndex = 15;
            this.currentScoreTxtLbl.Text = "Current Score:";
            // 
            // GameNumLbl
            // 
            this.GameNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GameNumLbl.AutoSize = true;
            this.GameNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNumLbl.Location = new System.Drawing.Point(339, 245);
            this.GameNumLbl.Name = "GameNumLbl";
            this.GameNumLbl.Size = new System.Drawing.Size(69, 17);
            this.GameNumLbl.TabIndex = 28;
            this.GameNumLbl.Text = "Game 1:";
            // 
            // FindingCallNumbersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.GameNumLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionToFindLbl);
            this.Controls.Add(this.gameEndedPanel);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.gameInfoBox);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "FindingCallNumbersScreen";
            this.Text = "FindingCallNumbersScreen";
            this.answerPanel.ResumeLayout(false);
            this.gameEndedPanel.ResumeLayout(false);
            this.gameEndedPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameInfoBox;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.Button answerBtn4;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Panel gameEndedPanel;
        private System.Windows.Forms.Label gameResultLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox descriptionToFindLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label currentScoreLbl;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.Label totalScoreTxtLbl;
        private System.Windows.Forms.Label currentScoreTxtLbl;
        private System.Windows.Forms.Label GameNumLbl;
    }
}