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
    public partial class ReplaceBooksScreen : Form
    {
        private ReplacingBooks bookList; //random list of call numbers
        private List<DeweyDecimal> sortedList; //the sorted list of call numbers
        private int totalScore; //keeps track of the total score of the user
        private int totalGames; //keeps track of the amount of games played

        public ReplaceBooksScreen()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to print the randomly generated book calling numbers to the user
        /// </summary>
        private void PrintRandomBooks()
        {
            bookList = new ReplacingBooks();
            randomBookList.Items.Clear();
            //printing to textbox
            foreach(var book in bookList.DeweyList)
            {
                randomBookList.Items.Add(book);
            }
            SortRandomBooks();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// method to sort and display the list of random books
        /// </summary>
        private void SortRandomBooks()
        {
            sortedList = new List<DeweyDecimal>();
            sortedList = bookList.SortList();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// method to verify whether or not the users formatted list is in the correct order
        /// </summary>
        private void VerifyUserList()
        {
            try
            {
                if (bookList == null) return; //ensure there is a booklist

                List<DeweyDecimal> userList = new List<DeweyDecimal>();
                resultListView.Items.Clear();
                int score = 0;

                foreach (var book in randomBookList.Items)
                {
                    userList.Add((DeweyDecimal)book);
                }

                //compare to existing sorted list 
                for (int i = 0; i < 10; i++)
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = userList[i].ToString();
                    if (userList[i] == sortedList[i])
                    {
                        //userlist element is correct         
                        item.ForeColor = Color.Green;
                        score++; //increase score
                    }
                    else
                    {
                        //userlist element is incorrect
                        item.ForeColor = Color.Red;
                        //dont increase score
                    }
                    bookList.Score = score;

                    //displaying              
                    resultListView.Items.Add(item);
                }
                //displaying scores
                totalScore += score;
                UpdateTotalGames();
                currentScoreLbl.Text = String.Format("{0}/10", score);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to update and display the total games played and total score
        /// </summary>
        private void UpdateTotalGames()
        {          
            totalScoreLbl.Text = String.Format("{0}/{1}0", totalScore, totalGames);
            this.GameProgressBar.Increment(20);
            //game over
            if(totalGames == 5)
            {
                QuestionNumLbl.Text = "Game Over!";
                nextListBtn.Enabled = false;
                return;
            }
            totalGames += 1;
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// button click to verify user list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void verifyListBtn_Click(object sender, EventArgs e)
        {
            verifyListBtn.Enabled = false; //enable verify button
            nextListBtn.Enabled = true; //disable generate list button
            randomBookList.SelectedIndex = -1; //deselect current item
            randomBookList.Enabled = false; //disable selection of book list          
            VerifyUserList();
        }

        
        //----------------------------------------------------------------------------------
        /// <summary>
        /// Button to start the next question and execute PrintRandomBooks() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextListBtn_Click(object sender, EventArgs e)
        {
            currentScoreLbl.Text = "0"; //set the current game score to 0
            verifyListBtn.Enabled = true; //enable verify list button
            nextListBtn.Enabled = false; //disable generate list button
            randomBookList.Enabled = true; //enable ListBox
            QuestionNumLbl.Text = String.Format("Question {0}:", totalGames); //updates question number
            resultListView.Items.Clear();
            PrintRandomBooks();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// move selected item up the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upListBtn_Click(object sender, EventArgs e)
        {
            //up is true
            MoveListItem(true);
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// move selected item down the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downListBtn_Click(object sender, EventArgs e)
        {
            //down is false
            MoveListItem(false);
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// method that will move the list item up or down the list
        /// </summary>
        /// <param name="up"></param>
        private void MoveListItem(bool up)
        {
            try
            {
                //ensures an item is selected
                if (randomBookList.SelectedIndex == -1) return;

                int newIndex;
                if (up)
                {
                    //move up the list 
                    newIndex = randomBookList.SelectedIndex - 1;
                }
                else
                {
                    //move down the list
                    newIndex = randomBookList.SelectedIndex + 1;
                }
                if (newIndex < 0 || newIndex >= 10) return;

                object selectedItem = randomBookList.SelectedItem;
                randomBookList.Items.Remove(selectedItem);
                randomBookList.Items.Insert(newIndex, selectedItem);
                randomBookList.SetSelected(newIndex, true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Button to start a new game 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            this.RefreshGameElements();
            this.PrintRandomBooks(); //printin the books
            
        }
        //--

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Refreshing all labels and text for the new game
        /// </summary>
        private void RefreshGameElements()
        {
            //set scores to 0
            this.totalGames = 1;
            this.totalScore = 0;
            //resets text
            QuestionNumLbl.Text = "Question 1:";
            totalScoreLbl.Text = "0";
            currentScoreLbl.Text = "0";
            //enables or disables buttons
            verifyListBtn.Enabled = true; //enable verify buttons
            randomBookList.Enabled = true; //enable the list
            resultListView.Items.Clear(); //clear all items from results
            GameProgressBar.Value = 0; //reset
        }
    }
}
//--------------------------------------end of file------------------------------------------