using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> testList = new CustomList<string>();

            testList.Add("Sam");
            testList.Add("C");
            Console.WriteLine(testList[3]);
            testList.Add("Mike");
            testList.Add("H");

            testList.Remove("Sam");

            Console.WriteLine(testList[0]);

            throw new ArgumentOutOfRangeException();
        }
    }
}
