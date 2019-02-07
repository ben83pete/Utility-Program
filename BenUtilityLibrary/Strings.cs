using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenUtilityLibrary
{
    public class Strings
    {
        public static bool EqualIgnoreCase(string strA, string strB)  // pass 2 strings into method EqualIgnoreCase
        {
            var compareResult = string.Compare(strA.ToUpper(), strB.ToUpper()); // compare the 2 strings to see if they are equal, string.Compare will return an integer -1, 0, or 1
                                            //  .ToUpper will make all char in the string upper case.
            bool returnResult;

            if( compareResult == 0){
                returnResult = true;
            }else{
                returnResult = false;
            }
            return returnResult;   

        }
    }
}
