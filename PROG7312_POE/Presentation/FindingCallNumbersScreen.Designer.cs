
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
            this.descriptionToFindLbl = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.answerBtn1 = new System.Windows.Forms.Button();
            this.answerBtn2 = new System.Windows.Forms.Button();
            this.answerBtn3 = new System.Windows.Forms.Button();
            this.answerBtn4 = new System.Windows.Forms.Button();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.answerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameInfoBox
            // 
            this.gameInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameInfoBox.Location = new System.Drawing.Point(321, 12);
            this.gameInfoBox.Name = "gameInfoBox";
            this.gameInfoBox.ReadOnly = true;
            this.gameInfoBox.Size = new System.Drawing.Size(399, 103);
            this.gameInfoBox.TabIndex = 0;
            this.gameInfoBox.Text = resources.GetString("gameInfoBox.Text");
            // 
            // descriptionToFindLbl
            // 
            this.descriptionToFindLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.descriptionToFindLbl.AutoSize = true;
            this.descriptionToFindLbl.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionToFindLbl.Location = new System.Drawing.Point(315, 175);
            this.descriptionToFindLbl.Name = "descriptionToFindLbl";
            this.descriptionToFindLbl.Size = new System.Drawing.Size(84, 32);
            this.descriptionToFindLbl.TabIndex = 1;
            this.descriptionToFindLbl.Text = "Label1";
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
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
            this.answerBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn1.Location = new System.Drawing.Point(42, 22);
            this.answerBtn1.Name = "answerBtn1";
            this.answerBtn1.Size = new System.Drawing.Size(203, 61);
            this.answerBtn1.TabIndex = 24;
            this.answerBtn1.Text = "answerBtn1";
            this.answerBtn1.UseVisualStyleBackColor = true;
            this.answerBtn1.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerBtn2
            // 
            this.answerBtn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn2.Location = new System.Drawing.Point(349, 22);
            this.answerBtn2.Name = "answerBtn2";
            this.answerBtn2.Size = new System.Drawing.Size(203, 61);
            this.answerBtn2.TabIndex = 25;
            this.answerBtn2.Text = "answerBtn2";
            this.answerBtn2.UseVisualStyleBackColor = true;
            this.answerBtn2.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerBtn3
            // 
            this.answerBtn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn3.Location = new System.Drawing.Point(42, 131);
            this.answerBtn3.Name = "answerBtn3";
            this.answerBtn3.Size = new System.Drawing.Size(203, 61);
            this.answerBtn3.TabIndex = 26;
            this.answerBtn3.Text = "answerBtn3";
            this.answerBtn3.UseVisualStyleBackColor = true;
            this.answerBtn3.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerBtn4
            // 
            this.answerBtn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerBtn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerBtn4.Location = new System.Drawing.Point(349, 131);
            this.answerBtn4.Name = "answerBtn4";
            this.answerBtn4.Size = new System.Drawing.Size(203, 61);
            this.answerBtn4.TabIndex = 27;
            this.answerBtn4.Text = "answerBtn4";
            this.answerBtn4.UseVisualStyleBackColor = true;
            this.answerBtn4.Click += new System.EventHandler(this.answerBtn_Click);
            // 
            // answerPanel
            // 
            this.answerPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerPanel.Controls.Add(this.answerBtn1);
            this.answerPanel.Controls.Add(this.answerBtn3);
            this.answerPanel.Controls.Add(this.answerBtn4);
            this.answerPanel.Controls.Add(this.answerBtn2);
            this.answerPanel.Location = new System.Drawing.Point(62, 246);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(593, 219);
            this.answerPanel.TabIndex = 28;
            // 
            // FindingCallNumbersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.answerPanel);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.descriptionToFindLbl);
            this.Controls.Add(this.gameInfoBox);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "FindingCallNumbersScreen";
            this.Text = "FindingCallNumbersScreen";
            this.answerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameInfoBox;
        private System.Windows.Forms.Label descriptionToFindLbl;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button answerBtn1;
        private System.Windows.Forms.Button answerBtn2;
        private System.Windows.Forms.Button answerBtn3;
        private System.Windows.Forms.Button answerBtn4;
        private System.Windows.Forms.Panel answerPanel;
    }
}