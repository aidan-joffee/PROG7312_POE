
namespace PROG7312_POE.Presentation
{
    partial class ReplaceBooksScreen
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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceBooksScreen));
            this.nextListBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verifyListBtn = new System.Windows.Forms.Button();
            this.resultListView = new System.Windows.Forms.ListView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.currentScoreTxtLbl = new System.Windows.Forms.Label();
            this.totalScoreTxtLbl = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.currentScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.DownListBtn = new System.Windows.Forms.Button();
            this.UpListBtn = new System.Windows.Forms.Button();
            this.randomBookList = new System.Windows.Forms.ListBox();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.QuestionNumLbl = new System.Windows.Forms.Label();
            this.GameProgressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextListBtn
            // 
            this.nextListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nextListBtn.Enabled = false;
            this.nextListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextListBtn.Location = new System.Drawing.Point(111, 436);
            this.nextListBtn.Name = "nextListBtn";
            this.nextListBtn.Size = new System.Drawing.Size(136, 42);
            this.nextListBtn.TabIndex = 2;
            this.nextListBtn.Text = "Next Question";
            this.nextListBtn.UseVisualStyleBackColor = false;
            this.nextListBtn.Click += new System.EventHandler(this.nextListBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Call Numbers";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Results";
            // 
            // verifyListBtn
            // 
            this.verifyListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.verifyListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.verifyListBtn.Enabled = false;
            this.verifyListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyListBtn.ForeColor = System.Drawing.Color.Black;
            this.verifyListBtn.Location = new System.Drawing.Point(365, 436);
            this.verifyListBtn.Name = "verifyListBtn";
            this.verifyListBtn.Size = new System.Drawing.Size(102, 42);
            this.verifyListBtn.TabIndex = 8;
            this.verifyListBtn.Text = "Verify";
            this.verifyListBtn.UseVisualStyleBackColor = false;
            this.verifyListBtn.Click += new System.EventHandler(this.verifyListBtn_Click);
            // 
            // resultListView
            // 
            this.resultListView.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resultListView.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultListView.HideSelection = false;
            this.resultListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.resultListView.Location = new System.Drawing.Point(356, 187);
            this.resultListView.MinimumSize = new System.Drawing.Size(120, 235);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(120, 235);
            this.resultListView.TabIndex = 13;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.List;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(272, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(448, 73);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
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
            // totalScoreTxtLbl
            // 
            this.totalScoreTxtLbl.AutoSize = true;
            this.totalScoreTxtLbl.Location = new System.Drawing.Point(21, 9);
            this.totalScoreTxtLbl.Name = "totalScoreTxtLbl";
            this.totalScoreTxtLbl.Size = new System.Drawing.Size(85, 17);
            this.totalScoreTxtLbl.TabIndex = 16;
            this.totalScoreTxtLbl.Text = "Total Score:";
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
            this.scorePanel.Location = new System.Drawing.Point(534, 262);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(162, 66);
            this.scorePanel.TabIndex = 17;
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
            // DownListBtn
            // 
            this.DownListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DownListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DownListBtn.BackgroundImage = global::PROG7312_POE.Properties.Resources.icons8_down_arrow_30;
            this.DownListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownListBtn.Location = new System.Drawing.Point(248, 235);
            this.DownListBtn.Name = "DownListBtn";
            this.DownListBtn.Size = new System.Drawing.Size(48, 42);
            this.DownListBtn.TabIndex = 10;
            this.DownListBtn.UseVisualStyleBackColor = false;
            this.DownListBtn.Click += new System.EventHandler(this.downListBtn_Click);
            // 
            // UpListBtn
            // 
            this.UpListBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UpListBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UpListBtn.BackgroundImage = global::PROG7312_POE.Properties.Resources.icons8_up_arrow_30;
            this.UpListBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpListBtn.Location = new System.Drawing.Point(247, 187);
            this.UpListBtn.Name = "UpListBtn";
            this.UpListBtn.Size = new System.Drawing.Size(49, 42);
            this.UpListBtn.TabIndex = 9;
            this.UpListBtn.UseVisualStyleBackColor = false;
            this.UpListBtn.Click += new System.EventHandler(this.upListBtn_Click);
            // 
            // randomBookList
            // 
            this.randomBookList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.randomBookList.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBookList.FormattingEnabled = true;
            this.randomBookList.ItemHeight = 19;
            this.randomBookList.Location = new System.Drawing.Point(121, 187);
            this.randomBookList.MinimumSize = new System.Drawing.Size(120, 242);
            this.randomBookList.MultiColumn = true;
            this.randomBookList.Name = "randomBookList";
            this.randomBookList.Size = new System.Drawing.Size(120, 232);
            this.randomBookList.TabIndex = 11;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameBtn.Location = new System.Drawing.Point(12, 12);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(116, 42);
            this.NewGameBtn.TabIndex = 19;
            this.NewGameBtn.Text = "New Game";
            this.NewGameBtn.UseVisualStyleBackColor = false;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // QuestionNumLbl
            // 
            this.QuestionNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuestionNumLbl.AutoSize = true;
            this.QuestionNumLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.QuestionNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionNumLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumLbl.Location = new System.Drawing.Point(228, 94);
            this.QuestionNumLbl.Name = "QuestionNumLbl";
            this.QuestionNumLbl.Size = new System.Drawing.Size(125, 28);
            this.QuestionNumLbl.TabIndex = 20;
            this.QuestionNumLbl.Text = "Question 1:";
            // 
            // GameProgressBar
            // 
            this.GameProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GameProgressBar.Location = new System.Drawing.Point(125, 134);
            this.GameProgressBar.Name = "GameProgressBar";
            this.GameProgressBar.Size = new System.Drawing.Size(351, 23);
            this.GameProgressBar.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Score:";
            // 
            // ReplaceBooksScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GameProgressBar);
            this.Controls.Add(this.QuestionNumLbl);
            this.Controls.Add(this.NewGameBtn);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.randomBookList);
            this.Controls.Add(this.DownListBtn);
            this.Controls.Add(this.UpListBtn);
            this.Controls.Add(this.verifyListBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextListBtn);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "ReplaceBooksScreen";
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextListBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verifyListBtn;
        private System.Windows.Forms.Button UpListBtn;
        private System.Windows.Forms.Button DownListBtn;
        private System.Windows.Forms.ListView resultListView;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label currentScoreTxtLbl;
        private System.Windows.Forms.Label totalScoreTxtLbl;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label currentScoreLbl;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.ListBox randomBookList;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.Label QuestionNumLbl;
        private System.Windows.Forms.ProgressBar GameProgressBar;
        private System.Windows.Forms.Label label3;
    }
}