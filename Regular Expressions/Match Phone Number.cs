using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PhoneNumber
{
    class phoneNumber
    {
        static void Main(string[] args)
        {
            //+359(2)123-4567
            //string pattern = @"\+[359]{3}([\s,\-])2\1\d{3}\d{4}";

            string phoneNumber = Console.ReadLine();

            while (phoneNumber != "end")
            {
                string pattern = @"\+[359]{3}([\s\-])2\1\d{3}\1\d{4}$";
                Regex regex = new Regex(pattern);
                bool containsText = regex.IsMatch(phoneNumber);
                if (containsText)
                    Console.WriteLine(phoneNumber);

                phoneNumber = Console.ReadLine();
            }

        }
    }
}
