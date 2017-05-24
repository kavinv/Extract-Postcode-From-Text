using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractPostcodeFromText
{

    class ExtractPostcodeFromText
    {

        /// <summary>
        /// Below Regex will work only for UK Post Codes.
        /// </summary>
        /// <param name="data"></param>
        public void startExtraction(string data)
        {

            const string matchPostCodePattern = @"(GIR 0AA)|((([A-Z-[QVX]][0-9][0-9]?)|(([A-Z-[QVX]][A-Z-[IJZ]][0-9][0-9]?)|(([A-Z-[QVX]][0-9][A-HJKPSTUW])|([A-Z-[QVX]][A-Z-[IJZ]][0-9][ABEHMNPRVWXY])))) [0-9][A-Z-[CIKMOV]]{2})";
            Regex regex = new Regex(matchPostCodePattern,RegexOptions.Compiled|RegexOptions.IgnoreCase);
            Match match = regex.Match(data);
            Console.WriteLine(match);


        }

}



    class Program
    {
        static void Main(string[] args)
        {
            ExtractPostcodeFromText epExtractPostcodeFromText = new ExtractPostcodeFromText();
            epExtractPostcodeFromText.startExtraction("10 abc,xyz 34f, B27 7SQ, UK");
            Console.ReadKey();
        }
    }
}
