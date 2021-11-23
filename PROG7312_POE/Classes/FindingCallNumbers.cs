using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG7312_POE.Classes;

namespace PROG7312_POE.Classes
{
    
    class FindingCallNumbers
    {
        //entire tree is stored in the root
        private TreeNode root { get; set; }
        private Random random = new Random();
        //each value here is the answer to the question generated for the different levels
        private DeweyDecimal MainValue { get; set; }
        private DeweyDecimal CategoryValue { get; set; }
        private DeweyDecimal SubCatValue { get; set; }


        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method that creates the tree from the text file
        /// </summary>
        /// <returns></returns>
        public TreeNode CreateTree()
        {
            //getting the lines stored in the file
            string[] lines = File.ReadAllLines("DeweyDecimalData.txt");

            //setting the root node of the tree
            this.root = new TreeNode(new DeweyDecimal(0, "root"));

            //parents and children line numbers
            int main = 0; //add 26 to get to next main parent
            int cat = main + 1; //adding 5 to get to next Cat
            int subCat= cat + 1; //adding 1 to get to next SubCat

            //reading each line
            //4 as there are 4 main categories
            for(int i = 0; i < 4; i++)
            {
                //store 2 lines, call number and description
                string[] mainLine = lines[main].Split('.');
                double mainCall = Convert.ToDouble(mainLine[0]);
                TreeNode mainNode = new TreeNode(new DeweyDecimal(mainCall, mainLine[1]));
                //5 sub categories for each main
                for(int n = 0; n < 5; n++)
                {
                    string[] catLine = lines[cat].Split('.');
                    double catCall = Convert.ToDouble(catLine[0]);
                    TreeNode catNode = new TreeNode(new DeweyDecimal(catCall, catLine[1]));
                    //4 sub categories in each category
                    for (int q = 0; q < 4; q++)
                    {
                        string[] subCatLine = lines[subCat].Split('.');
                        double subCatCall = Convert.ToDouble(subCatLine[0]);
                        TreeNode subCatNode = new TreeNode(new DeweyDecimal(subCatCall, subCatLine[1]));

                        //adding to cat node
                        catNode.Children.Add(subCatNode);
                        subCat = subCat + 1;
                    }
                    //adding to main node
                    mainNode.Children.Add(catNode);
                    cat = cat + 5;
                    subCat = cat + 1;
                }
                //adding main to root node
                root.Children.Add(mainNode);

                //setting values up for next category
                main = main + 26;
                cat = main + 1;
                subCat = cat + 1;
            }

            //return root;
            return root;
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to randomly select a sub cateogory node for the quiz
        /// </summary>
        /// <returns></returns>
        public void RandomNode()
        {  
            int main = random.Next(0, 3); //for the 4 mains
            int category = random.Next(0, 4); //for the 5 categories
            int subCategory = random.Next(0, 3); //for the 4 sub categories

            //getting dewey decimal value of each child/parent for the answer
            this.MainValue = root.Children[main].Value;
            this.CategoryValue = root.Children[main].Children[category].Value;
            this.SubCatValue = root.Children[main].Children[category].Children[subCategory].Value;
        }

        //--
    }    
}
//--------------------------------------end of file------------------------------------------
