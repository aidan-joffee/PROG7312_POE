using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROG7312_POE.Classes;
using TreeNode = PROG7312_POE.Classes.TreeNode;

namespace PROG7312_POE.Presentation
{
    public partial class FindingCallNumbersScreen : Form
    {
        private FindingCallNumbers findingCallNumbers;
        private List<Button> buttons;
        private List<DeweyDecimal> answersList;
        private DeweyDecimal correctAnswer;
        private int questionNum = 0;

        public FindingCallNumbersScreen()
        {
            InitializeComponent();
            GetTree();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to create the tree to use for the quiz
        /// </summary>
        public void GetTree()
        {
            findingCallNumbers = new FindingCallNumbers();
            TreeNode root = findingCallNumbers.CreateTree();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to get a random node and its parents for the quiz question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to start a new game
        /// </summary>
        private void StartNewGame()
        {
            findingCallNumbers.RandomNode();
            descriptionToFindLbl.Text = findingCallNumbers.SubCatValue.DescriptionPart; //display value to find
            questionNum++;
            GenerateAnswers();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to generate a list of answers based on the level of the question determined by questionNum
        /// </summary>
        private void GenerateAnswers()
        {
            switch(questionNum)
            {
                case 1:
                    //main
                    answersList = findingCallNumbers.SelectMainAnswers();
                    correctAnswer = findingCallNumbers.MainValue;
                    DisplayButtons();
                    break;
                case 2:
                    //category
                    answersList = findingCallNumbers.SelectCategoryAnswers();
                    correctAnswer = findingCallNumbers.CategoryValue;
                    DisplayButtons();
                    break;
                case 3:
                    //subcategory
                    answersList = findingCallNumbers.SelectSubCatAnswers();
                    correctAnswer = findingCallNumbers.SubCatValue;
                    DisplayButtons();
                    break;
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to add the answers to the button
        /// </summary>
        private void DisplayButtons()
        {
            buttons = answerPanel.Controls.OfType<Button>().ToList();
            int count = 0;
            foreach(var button in buttons)
            {
                //reset buttons from previous question
                button.Enabled = true;
                button.BackColor = default(Color);
                button.ForeColor = default(Color);
                //only display call numbers for question the sub category
                if(questionNum == 3)
                {
                    button.Text = answersList[count].CallNumberPart.ToString();
                    button.Tag = answersList[count];
                }
                else
                {
                    button.Text = answersList[count].ToString();
                    button.Tag = answersList[count];          
                }
                count++;
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// button click to select an answer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerBtn_Click(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            DeweyDecimal answer = (DeweyDecimal)button.Tag; //users answer

            if(answer == correctAnswer)
            {
                if(questionNum != 3)
                {
                    EndGame();
                }
                else
                {
                    //correct
                    questionNum++;
                    GenerateAnswers(); //display next set of answers
                }               
            }
            else
            {
                //incorrect
                questionNum = 0; //reset numbers
                //update button color
                button.BackColor = Color.Red;
                button.ForeColor = Color.Red;
                
                //find correct answer button
                foreach (var btn in buttons)
                {
                    btn.Enabled = false;
                    if (btn.Tag == correctAnswer)
                    {
                        btn.BackColor = Color.Green;
                        btn.ForeColor = Color.Green;
                    }
                }
            }
        }

        /// <summary>
        /// method if the final answer given by the user is correct
        /// </summary>
        protected void EndGame()
        {

        }

      //--
    }
}
//-------------------------------------end of file---------------------------------------------
