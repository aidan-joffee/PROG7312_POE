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
            StartNewGame();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to create the tree to use for the quiz
        /// </summary>
        public void GetTree()
        {
            findingCallNumbers = new FindingCallNumbers();
            TreeNode root = findingCallNumbers.CreateTree();
            //setting score values
            findingCallNumbers.gameNumber = 1; 
            findingCallNumbers.totalScore = 0;
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to get a random node and its parents for the quiz question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            findingCallNumbers.gameNumber++; //increase game number
            findingCallNumbers.currentSCore = 0; //reset current score
            currentScoreLbl.Text = "0";
            GameNumLbl.Text = String.Format("Game {0}:", findingCallNumbers.gameNumber);
            newGameBtn.Enabled = false;
            StartNewGame();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to start a new game
        /// </summary>
        private void StartNewGame()
        {
            //showing questions panel and hiding end panel
            gameEndedPanel.Visible = false;
            answerPanel.Visible = true;

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
            List<DeweyDecimal> unshuffledAnswers = new List<DeweyDecimal>();
            switch(questionNum)
            {
                case 1:
                    //main
                    unshuffledAnswers = findingCallNumbers.SelectMainAnswers();
                    correctAnswer = findingCallNumbers.MainValue;
                    break;
                case 2:
                    //category
                    unshuffledAnswers = findingCallNumbers.SelectCategoryAnswers();
                    correctAnswer = findingCallNumbers.CategoryValue;
                    
                    break;
                case 3:
                    //subcategory
                    unshuffledAnswers = findingCallNumbers.SelectSubCatAnswers();
                    correctAnswer = findingCallNumbers.SubCatValue;
                    break;
            }
            answersList = findingCallNumbers.ShuffleAnswers(unshuffledAnswers);
            DisplayButtons();
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
                //correct
                //increase current score
                findingCallNumbers.currentSCore++;
                currentScoreLbl.Text = String.Format("{0}/3", findingCallNumbers.currentSCore);
                if (questionNum == 3)
                {
                    EndGame(true); //theyve won the game
                    ColorButtons(false, button); //colour correct button
                }
                else
                {                   
                    questionNum++;
                    GenerateAnswers(); //display next set of answers
                }               
            }
            else
            {
                //incorrect
                ColorButtons(true, button);    
                //end the game
                EndGame(false);              
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to color the buttons if correct/incorrect
        /// </summary>
        /// <param name="isWrong"></param>
        /// <param name="btn"></param>
        protected void ColorButtons(bool isWrong, Button button)
        {
            if(isWrong)
            {
                button.BackColor = Color.Red;
                button.ForeColor = Color.Red;
            }

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

        //----------------------------------------------------------------------------------
        /// <summary>
        /// method for when the final answer is selected
        /// </summary>
        protected void EndGame(bool isCorrect)
        {
            newGameBtn.Enabled = true; //renable new game btn
            //showing game results screen
            gameEndedPanel.Visible = true;
            if (isCorrect)
            {
                //correct, game won               
                gameResultLbl.Text = "You won!";
                gameResultLbl.ForeColor = Color.Green;
            }
            else
            {
                //incorrect, game lost
                gameResultLbl.Text = "You lost";
                gameResultLbl.ForeColor = Color.Red;
            }
            //update score
            UpdateTotalScore();
            //display final answer
            questionNum = 0;
            descriptionToFindLbl.Text = correctAnswer.ToString();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to update the score of the game
        /// </summary>
        private void UpdateTotalScore()
        {           
            //increase total score if game is over       
            findingCallNumbers.totalScore += findingCallNumbers.currentSCore;
            //updating labels
            int total = findingCallNumbers.totalScore;
            int totalQuestions = (findingCallNumbers.gameNumber * 3);
            totalScoreLbl.Text = String.Format("{0}/{1}",total, totalQuestions);
        }

        //--
    }
}
//-------------------------------------end of file---------------------------------------------
