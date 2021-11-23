using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Classes
{
    //----------------------------------------------------------------------------------
    /// <summary>
    /// Class to store items of the Dewey Decimal system
    /// </summary>
    public class DeweyDecimal
    {
        private double callNumberPart;
        private string descriptionPart;

        //----------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        public DeweyDecimal()
        {
        }

        //----------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        public DeweyDecimal(double callNum, string desc)
        {
            this.callNumberPart = callNum;
            this.descriptionPart = desc;
        }

        //----------------------------------------------------------------------------------
        //gets and sets
        public double CallNumberPart { get => callNumberPart; set => callNumberPart = value; }
        public string DescriptionPart { get => descriptionPart; set => descriptionPart = value; }

        //----------------------------------------------------------------------------------
        //ToString method
        override public string ToString()
        {
            string callpart = this.CallNumberPart.ToString("000");
            string callNum = String.Format("{0} {1}",callpart, this.descriptionPart);
            return callNum;
        }
    }
}
//--------------------------------------end of file------------------------------------------