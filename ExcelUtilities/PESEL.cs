using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelUtilities
{
    public class PESEL
    {
        public string InString { get; set; }
        public long InNumber { get; set; }

        public PESEL(string InString)
        {
            this.InString = InString;
            ValidatePesel();
        }

        private void ValidatePesel()
        {
            
        }
    }
}
