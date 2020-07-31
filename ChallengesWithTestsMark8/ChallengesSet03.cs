using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsFalse = false;
            for (int j = 0; j < vals.Length; j++)
            {
                //if the current element the array is equals to false, then containsFalse is true,
                //then exit for loop
                if (vals[j] == false)
                {
                    containsFalse = true;
                    break;
                    
                }
            }

            if (containsFalse)
            {
                //your array contains a false then.
                return true;
            }
            return false;


        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToCharArray()[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char last = val[val.Length - 1];
            return last;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 && divisor == 0)
            {
                return 0;
                
            }
            else
            {
                return dividend / divisor;
            }
            
        }

        public int LastMinusFirst(int[] nums)
        {
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            words = Array.ConvertAll(words, s => s.ToUpper());
            
        }
    }
}
