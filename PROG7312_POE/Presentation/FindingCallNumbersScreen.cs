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
        public FindingCallNumbersScreen()
        {
            InitializeComponent();
            GetTree();
        }

        /// <summary>
        /// Method to create the tree to use for the quiz
        /// </summary>
        public void GetTree()
        {
            findingCallNumbers = new FindingCallNumbers();
            TreeNode root = findingCallNumbers.CreateTree();
        }

        /// <summary>
        /// Mmethod to get a random node and its parents for the quiz question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            findingCallNumbers.RandomNode();
            List<DeweyDecimal> list = findingCallNumbers.SelectSubCatAnswers();
            foreach(var item in list)
            {
                richTextBox1.AppendText(item.ToString() + "\n");
            }
            //richTextBox1.AppendText("Main: "+findingCallNumbers.MainValue.ToString());
            //richTextBox1.AppendText("\nCategory: " + findingCallNumbers.CategoryValue.ToString());
            //richTextBox1.AppendText("\nSubCategory: " + findingCallNumbers.SubCatValue.ToString());
        }
    }
}
