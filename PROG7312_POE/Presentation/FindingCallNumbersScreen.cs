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

        public void GetTree()
        {
            findingCallNumbers = new FindingCallNumbers();
            TreeNode root = findingCallNumbers.CreateTree();
            foreach(var child in root.Children)
            {
                richTextBox1.AppendText(child.Value.ToString() + "\n");
                foreach(var subChild in child.Children)
                {
                    richTextBox1.AppendText("\t" + subChild.Value.ToString() + "\n");
                    foreach(var subSubChild in subChild.Children)
                    {
                        richTextBox1.AppendText("\t\t" + subSubChild.Value.ToString() + "\n");
                    }
                }
            }
        }
    }
}
