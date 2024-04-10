using CheckCharacterSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.CheckCharacterSystems
{
    public class MOD11 : ICheckCharacterSystem
    {
        private int[] _weights;
        private ProcessingDirection _processingDirection;
        public MOD11(int[] weights, ProcessingDirection direction ) 
        {
            _processingDirection = direction;
            _weights = weights;
        }
        public string Calculate(string referenceWithoutCheckCharacters)
        {
            int sum = 0;
            int weightIndex = 0;

            if(_processingDirection == ProcessingDirection.RightToLeft)
            {
                for (int i = referenceWithoutCheckCharacters.Length-1; i >= 0; i--)
                {
                    sum += (int)char.GetNumericValue(referenceWithoutCheckCharacters[i]) * _weights[weightIndex];
                    if (weightIndex == _weights.Length - 1)
                    {
                        weightIndex = 0;
                    }
                    else
                    {
                        weightIndex++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < referenceWithoutCheckCharacters.Length; i++)
                {
                    sum += (int)char.GetNumericValue(referenceWithoutCheckCharacters[i]) * _weights[weightIndex];
                    if (weightIndex == _weights.Length - 1)
                    {
                        weightIndex = 0;
                    }
                    else
                    {
                        weightIndex++;
                    }
                }
            }

            int checkDigit = 11 - (sum % 11);
            if (checkDigit == 10)
            {
                return "X";
            }
            else if (checkDigit == 11)
            {
                return "0";
            }
            else
            {
                return checkDigit.ToString();
            }
            
        }

        public bool Validate(string referenceIncludingCheckCharacters)
        {
            throw new NotImplementedException();
        }
    }
}
