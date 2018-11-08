using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMahisoft
{
    public class RepeatedString
    {

        private int GetCountRepeatedChars(char charaterToSearch, string pieceString)
        {
            int countRepeated = 0;

            for (int i = 0; i < pieceString.Length; i++)
            {
                if (pieceString[i] == charaterToSearch)
                {

                    countRepeated++;
                }
                else
                {
                    break;
                }
            }

            return countRepeated;
        }
        internal string GetStringConverted(string initialString)
        {
            StringBuilder stringConverted = new StringBuilder();

            for (int i = 0; i < initialString.Length; i++)
            {

                int repeatedChars = GetCountRepeatedChars(initialString[i], initialString.Substring(i));
                if (repeatedChars == 1)
                {
                    stringConverted.Append(initialString[i]);
                }
                else
                {
                    stringConverted.Append($"{repeatedChars}{initialString[i]}");
                    i = i + (repeatedChars - 1);
                }
            }
            return stringConverted.ToString();
        }
    }
}
