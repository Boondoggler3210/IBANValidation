using CheckCharacterSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.CheckCharacterSystems
{
    internal class MOD9755_DescendingFrom8 : ICheckCharacterSystem
    {
        private readonly int[] _weights = { 8, 7, 6, 5, 4, 3, 2 };

        public string Calculate(string reference)
        {
            if (string.IsNullOrEmpty(reference) || reference.Length != 7)
            {
                return "";
            }

            string _reference = reference;
            int sum = 0;
            int index = 0;
            foreach (var c in _reference)
            {
                if (!char.IsDigit(c))
                {
                    return "";
                }
                sum += (c - 48) * _weights[index];
                index++;
            }
            if ((sum + 55) % 97 == 0)
            {
                return "00";
            }

            int checkDigits = 97 - ((sum +55) % 97);
            
            if (checkDigits < 10)
            {
                return "0" + checkDigits.ToString();
            }
            else
            {
                return checkDigits.ToString();
            }
        }

        public bool Validate(string reference)
        {
            if (string.IsNullOrEmpty(reference) || reference.Length != 9)
            {
                return false;
            }
            string _reference = reference.Substring(0, 7);
            string checkDigits = reference.Substring(7, 2);

            var calculatedCheckDigits = Calculate(_reference);

            if (calculatedCheckDigits == checkDigits)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
