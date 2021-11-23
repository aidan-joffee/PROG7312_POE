using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Classes
{
    public class ReplacingBooks
    {
        private List<DeweyDecimal> deweyList = new List<DeweyDecimal>();
        private List<DeweyDecimal> sortedList = new List<DeweyDecimal>();
        private int score;
        private Random random = new Random();
        //alphabet to generate a random author
        private Char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        
        //----------------------------------------------------------------------------------
        /// <summary>
        /// Constructor, will execute the GenerateList() method
        /// </summary>
        public ReplacingBooks()
        {
            this.GenerateList();
        }

        //----------------------------------------------------------------------------------
        //gets and sets
        public List<DeweyDecimal> DeweyList { get => deweyList; set => deweyList = value; }
        public int Score { get => score; set => score = value; }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to generate 10 random call numbers from the Dewey Decimal System and add 
        /// them to the list
        /// </summary>
        public void GenerateList()
        {
            //variables of the Dewey Decimal to be added to the list
            for(int i = 0; i < 10; i ++)
            {
                String authorName = "";
                double topicWholeNum = random.Next(0, 999); //whole number
                double topicDecimalNum = random.NextDouble(); //decimal of call number
                double topicNum = Math.Round(topicWholeNum + topicDecimalNum, 2); 
                DeweyDecimal callingNumber = new DeweyDecimal();

                //generating 3 random letters for the author name
                for(int n = 0; n < 3; n++)
                {
                    int character = random.Next(1, 26);
                    authorName += alphabet[character];
                }

                //generating the calling 

                //adding to lsit
                callingNumber.DescriptionPart = authorName;
                callingNumber.CallNumberPart = topicNum;
                DeweyList.Add(callingNumber); 
            }            
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// Method to correctly order the calling numbers in the DeweyList
        /// </summary>
        public List<DeweyDecimal> SortList()
        {
            sortedList = DeweyList;

            //sorting
            sortedList.Sort(delegate (DeweyDecimal p1, DeweyDecimal p2)
            {
                var topicNum = p1.CallNumberPart.CompareTo(p2.CallNumberPart); //comparing topic numbers
                return topicNum == 0 ? p1.DescriptionPart.CompareTo(p2.DescriptionPart) : topicNum; //comparing authors
            });

            return sortedList;
        }
        //--
    }
}
//--------------------------------------end of file------------------------------------------