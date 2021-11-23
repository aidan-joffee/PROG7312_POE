
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.answerBox1 = new System.Windows.Forms.CheckBox();
            this.answerBox2 = new System.Windows.Forms.CheckBox();
            this.answerBox3 = new System.Windows.Forms.CheckBox();
            this.answerBox4 = new System.Windows.Forms.CheckBox();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameInfoBox
            // 
            this.gameInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.descriptionToFindLbl.Location = new System.Drawing.Point(304, 197);
            this.descriptionToFindLbl.Name = "descriptionToFindLbl";
            this.descriptionToFindLbl.Size = new System.Drawing.Size(84, 32);
            this.descriptionToFindLbl.TabIndex = 1;
            this.descriptionToFindLbl.Text = "Label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.answerBox4);
            this.groupBox1.Controls.Add(this.answerBox3);
            this.groupBox1.Controls.Add(this.answerBox2);
            this.groupBox1.Controls.Add(this.answerBox1);
            this.groupBox1.Location = new System.Drawing.Point(113, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // answerBox1
            // 
            this.answerBox1.AutoSize = true;
            this.answerBox1.Location = new System.Drawing.Point(17, 39);
            this.answerBox1.Name = "answerBox1";
            this.answerBox1.Size = new System.Drawing.Size(106, 21);
            this.answerBox1.TabIndex = 0;
            this.answerBox1.Text = "answerBox1";
            this.answerBox1.UseVisualStyleBackColor = true;
            // 
            // answerBox2
            // 
            this.answerBox2.AutoSize = true;
            this.answerBox2.Location = new System.Drawing.Point(131, 39);
            this.answerBox2.Name = "answerBox2";
            this.answerBox2.Size = new System.Drawing.Size(106, 21);
            this.answerBox2.TabIndex = 1;
            this.answerBox2.Text = "answerBox2";
            this.answerBox2.UseVisualStyleBackColor = true;
            // 
            // answerBox3
            // 
            this.answerBox3.AutoSize = true;
            this.answerBox3.Location = new System.Drawing.Point(254, 39);
            this.answerBox3.Name = "answerBox3";
            this.answerBox3.Size = new System.Drawing.Size(106, 21);
            this.answerBox3.TabIndex = 2;
            this.answerBox3.Text = "answerBox3";
            this.answerBox3.UseVisualStyleBackColor = true;
            // 
            // answerBox4
            // 
            this.answerBox4.AutoSize = true;
            this.answerBox4.Location = new System.Drawing.Point(373, 39);
            this.answerBox4.Name = "answerBox4";
            this.answerBox4.Size = new System.Drawing.Size(106, 21);
            this.answerBox4.TabIndex = 3;
            this.answerBox4.Text = "answerBox4";
            this.answerBox4.UseVisualStyleBackColor = true;
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(223, 121);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 247);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // FindingCallNumbersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.descriptionToFindLbl);
            this.Controls.Add(this.gameInfoBox);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "FindingCallNumbersScreen";
            this.Text = "FindingCallNumbersScreen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox gameInfoBox;
        private System.Windows.Forms.Label descriptionToFindLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox answerBox4;
        private System.Windows.Forms.CheckBox answerBox3;
        private System.Windows.Forms.CheckBox answerBox2;
        private System.Windows.Forms.CheckBox answerBox1;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}