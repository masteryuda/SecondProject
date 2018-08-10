using System;

namespace SecondProject
{
    public class MyString
    {

        public string innerStr;
        
        public int CountTillLetter(char letter)
        {

            for (int i = 0; i < innerStr.Length; i++)
            {
                if(letter == innerStr[i])
                {
                    return i;
                }

            }
            return -1;
        }

        public int CountLetter(char letterToCheck)
        {
            
            int numOf = 0;
            for (int i = 0; i < innerStr.Length; i++)
            {
                char currLetter = innerStr[i];

                if (letterToCheck == currLetter)
                {
                    numOf++;
                }
            }

            return numOf;
        }

        public string Reverse()
        {
            string retString = "";
            for (int i = innerStr.Length - 1; i >= 0; i--)
            {
                retString += (innerStr[i]);
            }
            return retString;
        }

        public bool Contain(char letter, bool isCaseSense)
        {
            if (isCaseSense == false)
            {
                letter = Char.ToUpper(letter);

            }
            for (int i = 0; i < innerStr.Length; i++)
            {
                char currentLetter = innerStr[i];
                if (isCaseSense == false)
                {
                    currentLetter = Char.ToUpper(innerStr[i]);
                }
                if (currentLetter == letter)
                {
                    return true;
                }
            }
            return false;
        }

        public void ReversePrint()
        {
            for (int i = innerStr.Length - 1; i >= 0; i--)
            {
                Console.Write(innerStr[i]);
            }
            Console.WriteLine();

        }

        public void Print()
        {
            for (int i = 0; i < innerStr.Length; i++)
            {
                Console.Write(innerStr[i]);
            }
            Console.WriteLine();
        }
    }
}
