﻿using System;

namespace ExcelUtilities
{
    public class PeselToBirthDate
    {
        private long _pesel;
        private string _peselStr;

        public PeselToBirthDate(long pesel)
        {
            VaildatePesel(pesel);
            _pesel = pesel;
            _peselStr = pesel.ToString();
        }

        private void VaildatePesel(long pesel)
        {
            Validators.ValidateCell(pesel.ToString());
        }

        private string GetStringFromPesel(int pos) => 
            _peselStr[pos].ToString();

        private bool IsPeselAfter2000()
        {
            var monthFromPesel = int.Parse(GetStringFromPesel(2) + GetStringFromPesel(3));
            return monthFromPesel > 12 ? true : false;
        }

        private DateTime ChangePesel()
        {
            var day = int.Parse(GetStringFromPesel(4) + GetStringFromPesel(5));
            var month = int.Parse(GetStringFromPesel(2) + GetStringFromPesel(3));
            var year = int.Parse("19" + GetStringFromPesel(0) + GetStringFromPesel(1));
            var x = new DateTime(year, month, day);
            return new DateTime(year, month, day);
        }

        private DateTime ChangePeselAfter2000()
        {
            throw new NotImplementedException("Brak obsługi roczników > 2000");
        }

        public DateTime GetBirthDate() => 
             IsPeselAfter2000()
                ? ChangePeselAfter2000()
                : ChangePesel();
    }
}
