using System.Collections.Generic;

namespace TestMahisoft
{
    public class IdentifierMultiple
    {
        public List<int> CalculateMultiples(int identifier, int multipleNumber)
        {
            List<int> multiples = new List<int>();
            for (int i = 1; i <= identifier; i++)
            {
                if ((i % multipleNumber) == 0)
                {
                    multiples.Add(i);
                }
            }

            return multiples;

        }

        public int GetIdentifiersCount(int identifier, int countMultiples)
        {
            return identifier - countMultiples;
        }

    }
}
