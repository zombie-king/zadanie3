using System;
using System.Collections.Generic;
using System.Linq;

namespace zadanie3
{
    public class Rest
    {
        private static readonly uint[] Banknotes;

        static Rest()
        {
            Banknotes = new uint[] {
                200,
                100,
                50,
                20,
                10
            };
            Array.Sort(Banknotes);
        }
        public static uint[] GiveTheRest(uint rest)
        {
            if (rest == 0)
            {
                throw new ArgumentException($"Brak reszty do wydania. Wartość powinna być większa od zera.");
            }
            var lastNumber = rest % 10;
            if (lastNumber != 0)
            {
                throw new ArgumentException(
                    $"Nie można wydać {rest} reszty mając banknoty o nominałach: {FormatResult(Banknotes)}.");
            }
            HashSet<uint> result = new HashSet<uint>();
            var n = Banknotes.Length;
            // Traverse through all denomination 
            for (int i = n - 1; i >= 0; i--) {
                // Find denominations 
                while (rest >= Banknotes[i]) { 
                    rest -= Banknotes[i]; 
                    result.Add(Banknotes[i]); 
                } 
            }

            return result.ToArray();
        }

        public static string FormatResult(uint[] result)
        {
            return
                $"Nominały banknotów potrzebne do wydania reszty: {string.Join(", ", result.Select(n => n.ToString()).ToArray())}";
        }
    }
}