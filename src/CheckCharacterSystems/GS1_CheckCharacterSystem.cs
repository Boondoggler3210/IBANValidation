﻿using CheckCharacterSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.CheckCharacterSystems
{
    internal class GS1_CheckCharacterSystem : ICheckCharacterSystem
    {

        public GS1_CheckCharacterSystem() { }
        public string Calculate(string reference)
        {
            int _counter = 1;
            int _sumOfOdd = 0;
            int _sumOfEven = 0;

            foreach (var c in reference)
            {
                int _value = 0;
                if (!char.IsDigit(c))
                {
                    return "";
                }
                _value = (int)char.GetNumericValue(c);

                if (_counter % 2 == 0)
                {
                    _sumOfEven += _value;
                }
                else
                {
                    _sumOfOdd += _value;
                }

                _counter++;
            }

            _sumOfEven *= 3;
            int _totalSum = _sumOfOdd + _sumOfEven;

            if (_totalSum % 10 == 0)
            {
                return "0";
            }
            else
            {
                int _checkDigit = 10 - (_totalSum % 10);
                return _checkDigit.ToString();

            }

        }

        public bool Validate(string reference)
        {
            string _checkDigit = reference.Substring(reference.Length - 1, 1);
            if(_checkDigit == Calculate(reference.Substring(0, reference.Length - 1)))
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
