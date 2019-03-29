using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStringReverse
{
    public class StringLab
    {
        public StringLab()
        { }
        public StringLab(string forwardString)
        {
            originalString = forwardString;
        } 

        //string[] blackList = {"shit","save","coupon" };

        private string originalString;
        public string OriginalString
        {
            get { return originalString; } 
            set
            {
                if (value.ToLower().Contains("shit"))
                {
                    originalString = "Please try again.";
                }
                else
                { 
                    originalString = value;
                } 
            }
        }


        public string StringReverse()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append("You have to work on this method to make it work.\n");
            sb.Append(originalString);
            return sb.ToString();
        }



    }
}
