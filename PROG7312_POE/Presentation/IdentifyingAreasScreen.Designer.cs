
namespace PROG7312_POE.Presentation
{
    partial class IdentifyingAreasScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentifyingAreasScreen));
            this.nextQuestionBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.questionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.answer4ListBox = new System.Windows.Forms.ListBox();
            this.answer3ListBox = new System.Windows.Forms.ListBox();
            this.answer2ListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.question4Lbl = new System.Windows.Forms.Label();
            this.question3Lbl = new System.Windows.Forms.Label();
            this.question2Lbl = new System.Windows.Forms.Label();
            this.question1Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.answer1ListBox = new System.Windows.Forms.ListBox();
            this.answerListBox = new System.Windows.Forms.ListBox();
            this.QuestionNumLbl = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.scorePanel = new System.Windows.Forms.Panel();
            this.currentScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreLbl = new System.Windows.Forms.Label();
            this.totalScoreTxtLbl = new System.Windows.Forms.Label();
            this.currentScoreTxtLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.questionsPanel.SuspendLayout();
            this.scorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextQuestionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.nextQuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionBtn.Location = new System.Drawing.Point(551, 428);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(145, 49);
            this.nextQuestionBtn.TabIndex = 3;
            this.nextQuestionBtn.Text = "Next Question";
            this.nextQuestionBtn.UseVisualStyleBackColor = false;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.questionsPanel);
            this.panel1.Controls.Add(this.answerListBox);
            this.panel1.Location = new System.Drawing.Point(29, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 252);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Answers";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Questions";
            // 
            // questionsPanel
            // 
            this.questionsPanel.AllowDrop = true;
            this.questionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.questionsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.questionsPanel.ColumnCount = 3;
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.questionsPanel.Controls.Add(this.answer4ListBox, 2, 3);
            this.questionsPanel.Controls.Add(this.answer3ListBox, 2, 2);
            this.questionsPanel.Controls.Add(this.answer2ListBox, 2, 1);
            this.questionsPanel.Controls.Add(this.label4, 0, 3);
            this.questionsPanel.Controls.Add(this.label3, 0, 2);
            this.questionsPanel.Controls.Add(this.question4Lbl, 1, 3);
            this.questionsPanel.Controls.Add(this.question3Lbl, 1, 2);
            this.questionsPanel.Controls.Add(this.question2Lbl, 1, 1);
            this.questionsPanel.Controls.Add(this.question1Lbl, 1, 0);
            this.questionsPanel.Controls.Add(this.label2, 0, 1);
            this.questionsPanel.Controls.Add(this.label1, 0, 0);
            this.questionsPanel.Controls.Add(this.answer1ListBox, 2, 0);
            this.questionsPanel.Location = new System.Drawing.Point(3, 53);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.RowCount = 4;
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.questionsPanel.Size = new System.Drawing.Size(359, 179);
            this.questionsPanel.TabIndex = 7;
            // 
            // answer4ListBox
            // 
            this.answer4ListBox.AllowDrop = true;
            this.answer4ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer4ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.answer4ListBox.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4ListBox.FormattingEnabled = true;
            this.answer4ListBox.ItemHeight = 20;
            this.answer4ListBox.Location = new System.Drawing.Point(170, 143);
            this.answer4ListBox.Name = "answer4ListBox";
            this.answer4ListBox.Size = new System.Drawing.Size(184, 24);
            this.answer4ListBox.TabIndex = 9;
            this.answer4ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.answer4ListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.answer4ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Answer_MouseDown);
            // 
            // answer3ListBox
            // 
            this.answer3ListBox.AllowDrop = true;
            this.answer3ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer3ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.answer3ListBox.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3ListBox.FormattingEnabled = true;
            this.answer3ListBox.ItemHeight = 20;
            this.answer3ListBox.Location = new System.Drawing.Point(171, 98);
            this.answer3ListBox.Name = "answer3ListBox";
            this.answer3ListBox.Size = new System.Drawing.Size(183, 24);
            this.answer3ListBox.TabIndex = 8;
            this.answer3ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.answer3ListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.answer3ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Answer_MouseDown);
            // 
            // answer2ListBox
            // 
            this.answer2ListBox.AllowDrop = true;
            this.answer2ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer2ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.answer2ListBox.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2ListBox.FormattingEnabled = true;
            this.answer2ListBox.ItemHeight = 20;
            this.answer2ListBox.Location = new System.Drawing.Point(171, 54);
            this.answer2ListBox.Name = "answer2ListBox";
            this.answer2ListBox.Size = new System.Drawing.Size(183, 24);
            this.answer2ListBox.TabIndex = 7;
            this.answer2ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.answer2ListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.answer2ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Answer_MouseDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // question4Lbl
            // 
            this.question4Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question4Lbl.AutoSize = true;
            this.question4Lbl.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question4Lbl.Location = new System.Drawing.Point(30, 145);
            this.question4Lbl.Name = "question4Lbl";
            this.question4Lbl.Size = new System.Drawing.Size(83, 20);
            this.question4Lbl.TabIndex = 5;
            this.question4Lbl.Text = "Question 4";
            // 
            // question3Lbl
            // 
            this.question3Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question3Lbl.AutoSize = true;
            this.question3Lbl.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question3Lbl.Location = new System.Drawing.Point(30, 100);
            this.question3Lbl.Name = "question3Lbl";
            this.question3Lbl.Size = new System.Drawing.Size(82, 20);
            this.question3Lbl.TabIndex = 4;
            this.question3Lbl.Text = "Question 3";
            // 
            // question2Lbl
            // 
            this.question2Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question2Lbl.AutoSize = true;
            this.question2Lbl.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question2Lbl.Location = new System.Drawing.Point(30, 56);
            this.question2Lbl.Name = "question2Lbl";
            this.question2Lbl.Size = new System.Drawing.Size(82, 20);
            this.question2Lbl.TabIndex = 3;
            this.question2Lbl.Text = "Question 2";
            // 
            // question1Lbl
            // 
            this.question1Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.question1Lbl.AutoSize = true;
            this.question1Lbl.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question1Lbl.Location = new System.Drawing.Point(30, 12);
            this.question1Lbl.Name = "question1Lbl";
            this.question1Lbl.Size = new System.Drawing.Size(80, 20);
            this.question1Lbl.TabIndex = 2;
            this.question1Lbl.Text = "Question 1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // answer1ListBox
            // 
            this.answer1ListBox.AllowDrop = true;
            this.answer1ListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.answer1ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.answer1ListBox.Font = new System.Drawing.Font("Franklin Gothic Heavy", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1ListBox.FormattingEnabled = true;
            this.answer1ListBox.ItemHeight = 20;
            this.answer1ListBox.Location = new System.Drawing.Point(171, 10);
            this.answer1ListBox.Name = "answer1ListBox";
            this.answer1ListBox.Size = new System.Drawing.Size(183, 24);
            this.answer1ListBox.TabIndex = 6;
            this.answer1ListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.answer1ListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.answer1ListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Answer_MouseDown);
            // 
            // answerListBox
            // 
            this.answerListBox.AllowDrop = true;
            this.answerListBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.answerListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.answerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerListBox.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerListBox.FormattingEnabled = true;
            this.answerListBox.ItemHeight = 19;
            this.answerListBox.Location = new System.Drawing.Point(368, 53);
            this.answerListBox.Name = "answerListBox";
            this.answerListBox.Size = new System.Drawing.Size(298, 154);
            this.answerListBox.TabIndex = 6;
            this.answerListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.answerListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.answerListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Answer_MouseDown);
            // 
            // QuestionNumLbl
            // 
            this.QuestionNumLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.QuestionNumLbl.AutoSize = true;
            this.QuestionNumLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.QuestionNumLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionNumLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNumLbl.Location = new System.Drawing.Point(292, 130);
            this.QuestionNumLbl.Name = "QuestionNumLbl";
            this.QuestionNumLbl.Size = new System.Drawing.Size(125, 28);
            this.QuestionNumLbl.TabIndex = 21;
            this.QuestionNumLbl.Text = "Question 1:";
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.Location = new System.Drawing.Point(12, 12);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(116, 42);
            this.newGameBtn.TabIndex = 22;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
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
            this.richTextBox1.Size = new System.Drawing.Size(448, 55);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 24;
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
            this.scorePanel.Location = new System.Drawing.Point(72, 92);
            this.scorePanel.Name = "scorePanel";
            this.scorePanel.Size = new System.Drawing.Size(162, 66);
            this.scorePanel.TabIndex = 23;
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
            // IdentifyingAreasScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 503);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.scorePanel);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.QuestionNumLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextQuestionBtn);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "IdentifyingAreasScreen";
            this.Text = "IdentifyingAreasScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.questionsPanel.ResumeLayout(false);
            this.questionsPanel.PerformLayout();
            this.scorePanel.ResumeLayout(false);
            this.scorePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextQuestionBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label question4Lbl;
        private System.Windows.Forms.Label question3Lbl;
        private System.Windows.Forms.Label question2Lbl;
        private System.Windows.Forms.Label question1Lbl;
        private System.Windows.Forms.TableLayoutPanel questionsPanel;
        private System.Windows.Forms.ListBox answerListBox;
        private System.Windows.Forms.ListBox answer4ListBox;
        private System.Windows.Forms.ListBox answer3ListBox;
        private System.Windows.Forms.ListBox answer2ListBox;
        private System.Windows.Forms.ListBox answer1ListBox;
        private System.Windows.Forms.Label QuestionNumLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel scorePanel;
        private System.Windows.Forms.Label currentScoreLbl;
        private System.Windows.Forms.Label totalScoreLbl;
        private System.Windows.Forms.Label totalScoreTxtLbl;
        private System.Windows.Forms.Label currentScoreTxtLbl;
    }
}