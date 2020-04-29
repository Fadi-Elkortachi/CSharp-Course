using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_charStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;

            char MyVar = 'A';
            int myVarValue = 'A';

            char myVarVlue2 = Convert.ToChar(myVarValue);

            Console.WriteLine("Min char = {0} Max char = {1} My character = {2} my Variable Number = {3} my Conversion Value = {4}" , charMin, charMax, MyVar, myVarValue, myVarVlue2);

            string myString = "This is My Variable";
            Console.WriteLine("\nMy String is {0} ", myString);

            bool myBool = true;
            Console.WriteLine("my Boolean Value = {0}", myBool);
          
            Console.ReadKey();

        }
    }
}
