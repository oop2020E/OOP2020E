using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KG01_intro.Goodies
{
    class Functions
    {
        //TODOEXTRA 45 static helper function
        /// <summary>
        /// Funktion der demonsterer
        ///  - static modifier l. 20
        ///  - optional argument l. 20
        ///  - komplekst udtryk (måske unødigt?) l. 24
        ///  - output parameter l.24
        /// </summary>
        /// <param name="prompt">Message printed in console when prompting for an integer</param>
        /// <returns>The integer value as from the parsed console-input</returns>
        public static int ReadInt(string prompt="Please type an integer: ")
        {
            string s;
            int result;
            Console.Write(prompt);
            while (!int.TryParse(s=Console.ReadLine(), out result)){
                Console.Write($"[{s}] is not an integer : ");
            }
            return result;
        }
    }
}
