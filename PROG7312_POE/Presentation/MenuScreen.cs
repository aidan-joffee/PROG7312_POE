using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG7312_POE.Presentation;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class MenuScreen : Form
    {
        private string _currentLbl = "";
        public MenuScreen()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Opens the ReplaceBooksScreen in the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void replaceBooksBtn_Click(object sender, EventArgs e)
        {
            //check if game is currently active, return if is or set _currentLbl text
            if (_currentLbl.Equals("replace")) return;
            else _currentLbl = "replace";

            //Styling
            SetActiveButton();
            ReplaceBooksScreen replaceBooksScreen = new ReplaceBooksScreen();
            replaceBooksScreen.TopLevel = false;
            replaceBooksScreen.FormBorderStyle = FormBorderStyle.None;
            replaceBooksScreen.Dock = DockStyle.Fill;

            //adding to panel and updating label
            UpdatePanel(replaceBooksScreen, "Replacing Book Game");          
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Opens the IdentifyingAreasScreen in the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void identifyingAreasBtn_Click(object sender, EventArgs e)
        {
            //check if game is currently active, return if is or set _currentLbl text
            if (_currentLbl.Equals("identifying")) return;
            else _currentLbl = "identifying";

            //Styling          
            SetActiveButton();
            IdentifyingAreasScreen identifyingAreasScreen = new IdentifyingAreasScreen();
            identifyingAreasScreen.TopLevel = false;
            identifyingAreasScreen.FormBorderStyle = FormBorderStyle.None;
            identifyingAreasScreen.Dock = DockStyle.Fill;

            //adding to form
            UpdatePanel(identifyingAreasScreen, "Identifying Areas Game");
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Opens the FindingCallNumbersScreen in the panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findCallNumbersBtn_Click(object sender, EventArgs e)
        {
            //check if game is currently active, return if is or set _currentLbl text
            if (_currentLbl.Equals("finding")) return;
            else _currentLbl = "finding";

            //Styling          
            SetActiveButton();
            FindingCallNumbersScreen findingCallNumbersScreen = new FindingCallNumbersScreen();
            findingCallNumbersScreen.TopLevel = false;
            findingCallNumbersScreen.FormBorderStyle = FormBorderStyle.None;
            findingCallNumbersScreen.Dock = DockStyle.Fill;

            //adding to form
            UpdatePanel(findingCallNumbersScreen, "Finding Call Numbers Game");
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Updates the panel with the requested form.
        /// </summary>
        /// <param name="formToAdd"></param>
        public void UpdatePanel(Form FormToAdd, String gameName)
        {
            this.displayPanel.Controls.Clear(); //remove all controls, to make space for new form
            this.displayPanel.Controls.Add(FormToAdd);
            this.currentFormLbl.Text = gameName;
            FormToAdd.Show();
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// method to set the active button for the game types.
        /// </summary>
        public void SetActiveButton()
        {
            switch (_currentLbl)
            {
                case "replace":
                    replaceBooksBtn.BackColor = Color.MediumPurple;
                    findCallNumbersBtn.BackColor = Color.FromArgb(192, 192, 255);
                    identifyingAreasBtn.BackColor = Color.FromArgb(192, 192, 255);
                    break;
                case "identifying":
                    identifyingAreasBtn.BackColor = Color.MediumPurple;
                    findCallNumbersBtn.BackColor = Color.FromArgb(192, 192, 255);
                    replaceBooksBtn.BackColor = Color.FromArgb(192, 192, 255);
                    break;
                case "finding":
                    findCallNumbersBtn.BackColor = Color.MediumPurple;
                    identifyingAreasBtn.BackColor = Color.FromArgb(192, 192, 255);
                    replaceBooksBtn.BackColor = Color.FromArgb(192, 192, 255);
                    break;
                default:
                    break;
            }
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Button to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        //--    
    }
}
//--------------------------------------end of file------------------------------------------