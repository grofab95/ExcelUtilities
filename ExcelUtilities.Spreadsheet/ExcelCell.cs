﻿using System;
using System.Collections.Generic;

namespace ExcelUtilities.Spreadsheet
{
    public class ExcelCell
    {
        private readonly static List<string> _alphabet = new List<string> 
        { 
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
                "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", 
                "u", "v", "w", "x", "y", "z" 
        };

        public static CellFactors TranslateFromString(string cell) 
        {
            return new CellFactors
            {
                X = GetNumbersFromString(cell),
                Y = (_alphabet.IndexOf(cell[0].ToString().ToLower())) + 1
            };
        }

        private static int GetNumbersFromString(string text)
        {
            var numberStr = String.Empty;
            for (int i = 1; i < text.Length; i++)
            {
                numberStr += text[i];
            }
            return int.Parse(numberStr);
        }

        public static string TranslateFromXY(int x, int y)
            => (_alphabet[x - 1].ToString() + y.ToString()).ToUpper();
    }
}
