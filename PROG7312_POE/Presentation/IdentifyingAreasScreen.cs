using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG7312_POE.Classes;
using System.Windows.Forms;

namespace PROG7312_POE.Presentation
{
    public partial class IdentifyingAreasScreen : Form
    {
        private IdentfiyingAreas identfiyingAreas;
        private int gameNumber = 0;
        private object listItem;
        private ListBox fromBox;
        private int currentScore = 0;
        private int totalScore = 0;
        public IdentifyingAreasScreen()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Button to load the next question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            totalScore += currentScore; //udpating score
            totalScoreLbl.Text = String.Format("{0}/{1}", totalScore, (gameNumber * 4));
            currentScoreLbl.Text = "0/4";
            CreateQuestion();                     
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to create the match the columns question
        /// </summary>
        public void CreateQuestion()
        {
            this.gameNumber++; //increasing game number
            QuestionNumLbl.Text = String.Format("Question {0}:",gameNumber);
            this.identfiyingAreas = new IdentfiyingAreas();
            this.identfiyingAreas.GameNumber = gameNumber;
            this.identfiyingAreas.GenerateRandomQuestion(); //generating question
            ClearAnswerBox();
            SetupQuestion();         
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to setup the match the columns question that was generated
        /// </summary>
        public void SetupQuestion()
        {
            currentScore = 0; //reset currentScore for next question
            //even, call numbers
            if(gameNumber%2 == 0)
            {
                //questions
                String[] questionArray = identfiyingAreas.RandomQuestionsDictionary.Keys.ToArray();
                SetupLeftQuestions(questionArray);
                //answers, combining the dictionary and the wrong answers list 
                List<String> answerList = identfiyingAreas.RandomQuestionsDictionary.Values.ToList();
                answerList.AddRange(identfiyingAreas.WrongAnswersArray);
                answerList = identfiyingAreas.ShuffleAnswers(answerList); //shuffle
                SetupRightAnswers(answerList);
            }
            //odd, descriptions
            else
            {
                //questions
                String[] questionArray = identfiyingAreas.RandomQuestionsDictionary.Values.ToArray();
                SetupLeftQuestions(questionArray);
                //answers, combining the dictionary and the wrong answers list 
                List<String> answerList = identfiyingAreas.RandomQuestionsDictionary.Keys.ToList();
                answerList.AddRange(identfiyingAreas.WrongAnswersArray);
                answerList = identfiyingAreas.ShuffleAnswers(answerList); //shuffle
                SetupRightAnswers(answerList);
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to setup the left side, the questions
        /// </summary>
        public void SetupLeftQuestions(String[] questions)
        {
            int count = 0;
            //getting the labels
            var labels = questionsPanel.Controls.OfType<Label>().Where(c => c.Name.StartsWith("question")).ToList();
            labels.Reverse(); //labels were being retrieved in the opposite order to what was needed.
            foreach(Label lbl in labels)
            {
                lbl.Text = questions[count];
                count++;
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to setup the right side, the answers
        /// </summary>
        public void SetupRightAnswers(List<String> answers)
        {
            //getting the labels
            //TODO randomize answers list
            answerListBox.Items.Clear();
            foreach(var item in answers)
            {
                answerListBox.Items.Add(item);
            }
        }
        //--

        //----------------------------------------------------------------------------------
        ///Drag and drop event to drag items from one listbox to another
        private void Answer_MouseDown (object sender, MouseEventArgs e)
        {
            try
            {
                ListBox box = (ListBox)sender;
                fromBox = box;
                if (box.SelectedItem != null)
                {
                    String text = box.SelectedItem.ToString();
                    listItem = box.SelectedItem;
                    DoDragDrop(text, DragDropEffects.Copy);
                }               
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Drag Error Occured");
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        ///  Event to allow the dragged label to enter the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            //ensures the data is text format
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method for when the answer is dropped into a listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //getting text
                String text = e.Data.GetData("Text", true) as String;
                
                //adding to the listbox
                ListBox answerBox = (ListBox)sender;
                if (answerBox != fromBox)
                {
                    //not the answerbox and less than 1 item, ensures a questionbox
                    if((answerBox != answerListBox)&&(answerBox.Items.Count < 1))
                    {
                        fromBox.Items.Remove(listItem); //removing from sender
                        answerBox.Items.Add(text);
                        CheckAnswer();
                    }
                    if(answerBox == answerListBox)
                    {
                        fromBox.Items.Remove(listItem); //removing from sender
                        answerBox.Items.Add(text);
                        CheckAnswer();
                    }                  
                }               
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Drag Error Occured");
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to check if the answer was correct
        /// </summary>
        public void CheckAnswer()
        {
            int score = 0;
            var boxes = questionsPanel.Controls.OfType<ListBox>().ToList();
            foreach (var item in boxes)
            {
                if (item.Items.Count != 0)
                {
                    //question number is always 7th letter of listbox
                    String listBoxName = item.Name;
                    String answer = item.Items[0].ToString();
                    int index = Convert.ToInt32(listBoxName[6].ToString()) - 1;
                    string question;
                    bool isCorrect;
                    //even, call number
                    if (gameNumber % 2 == 0)
                    {
                        question = this.identfiyingAreas.RandomQuestionsDictionary.ElementAt(index).Key; //call num
                        isCorrect = this.identfiyingAreas.ValidateAnswer(question, answer);
                    }
                    //odd, descriptions
                    else
                    {
                        question = this.identfiyingAreas.RandomQuestionsDictionary.ElementAt(index).Value; //descr
                        isCorrect = this.identfiyingAreas.ValidateAnswer(answer, question);
                    }

                    if (isCorrect == true)
                    {
                        //right
                        item.ForeColor = Color.Green;
                        score++;
                        
                    }
                    else
                    {
                        //wrong
                        item.ForeColor = Color.Red;                   
                    }                   
                }               
            }
            UpdateScore(score);
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to clear the answer boxes when a new question is generated
        /// </summary>
        private void ClearAnswerBox()
        {
            var boxes = questionsPanel.Controls.OfType<ListBox>().ToList();
            foreach(var item in boxes)
            {
                item.Items.Clear();
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to update the score of the game
        /// </summary>
        private void UpdateScore(int scoreChange)
        {
            currentScore = scoreChange;
            currentScoreLbl.Text = String.Format("{0}/4", currentScore);         
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Button click to reset game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to reset game
        /// </summary>
        private void ResetGame()
        {
            gameNumber = 0;
            totalScore = 0;
            currentScore = 0;
            totalScoreLbl.Text = "0";
            currentScoreLbl.Text = "0";
            CreateQuestion();
        }
    }
}
//--------------------------------------end of file------------------------------------------