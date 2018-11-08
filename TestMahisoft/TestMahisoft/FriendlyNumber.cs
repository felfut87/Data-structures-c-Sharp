using System.Collections.Generic;

namespace TestMahisoft
{
    public class FriendlyNumber
    {
        public List<int> getDivider(int number)
        {
            List<int> dividers = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    dividers.Add(i);
                }
            }
            return dividers;

        }

        public bool CalculateFriendlyNumber(int FirstNumber, int secondNumber, int sumDividersFirstNumber, int sumDividersSecondNumber)
        {
            return (FirstNumber == sumDividersSecondNumber) && (secondNumber == sumDividersFirstNumber);
        }

        public int CalculateAdditionDividers(List<int> dividersNumber)
        {
            int sumDividers = 0;

            foreach (var divider in dividersNumber)
            {
                sumDividers = sumDividers + divider;
            }

            return sumDividers;

        }




    }
}
