using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Part_02.Services
{
    class CalculationService
    {
        public int Max(List<int> list)
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");
            }

            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
