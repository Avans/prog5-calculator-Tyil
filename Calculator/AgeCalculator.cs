using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    class AgeCalculator : IAgeCalculator
    {
        string[] formats = {
                               "dd-MM-yyyy"
                           };
        string culture = "nl-NL";

        public bool ParseInput(string input, out DateTime result)
        {
            return DateTime.TryParseExact(
                input,
                this.formats,
                new CultureInfo(this.culture),
                DateTimeStyles.None,
                out result
            );
        }

        public int CalculateAge(DateTime dob)
        {
            DateTime now = DateTime.Now;
            int years = now.Year - dob.Year;

            Console.WriteLine("{0} < {1}", now.Month, dob.Month);
            if ((now.Month < dob.Month) || (now.Month == dob.Month && now.Day < dob.Day))
            {
                years--;
            }

            return years;
        }
    }
}
