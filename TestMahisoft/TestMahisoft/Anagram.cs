using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestMahisoft
{
    public class Anagram
    {
        public bool IsAnagram(string firstWord, string secondWord)
        {
            bool result = false;


            result = Evaluate(firstWord, secondWord);


            return result;
        }

        public bool Evaluate(string firstWord, string secondWord)
        {
            bool isAnagram = true;
            string newWord = secondWord;

            foreach (var letter in firstWord)
            {
                if (!newWord.Contains(letter))
                {
                    isAnagram = false;
                    break;
                }
                else
                {
                    int index;

                    index = newWord.IndexOf(letter);

                    if (index == newWord.Length - 1)
                    {
                        newWord = newWord.Substring(0, index);
                    }
                    else
                    {
                        newWord = newWord.Substring(0, index) + newWord.Substring(index + 1);
                    }
                }
            }

            return isAnagram && ValidateSpaces(newWord);
        }

        private bool ValidateSpaces(string word)
        {

            Regex regex = new Regex(@"[^\s]");

            return regex.Matches(word).Count == 0;

        }
    }
}
