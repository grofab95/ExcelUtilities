using System;

namespace ExcelUtilities.Pesel
{
    public class Pesel
    {
        public string InString { get; set; }
        public long InNumber { get; set; }        
        
        public Pesel(string inString)
        {
            //Validators.ValidatePesel(inString);
            InString = inString;
            InNumber = long.Parse(inString);
        }
    }
}
