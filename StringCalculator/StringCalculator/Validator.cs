﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class Validator
    {
        private const string NEGATIVESNOTALLOWED = "Negatives not allowed: ";

        public void ValidateNumbers(IEnumerable<int> numbers)
        {
            var negativeNumbers = GetNegativeNumbers(numbers);
            if (negativeNumbers.Any())
            {
                throw new ArgumentException(NEGATIVESNOTALLOWED + string.Join(", ", negativeNumbers));
            }
        }

        private IEnumerable<int> GetNegativeNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(number => number < 0);
        }
    }
}