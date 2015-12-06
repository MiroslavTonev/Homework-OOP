using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> arr = new GenericList<int>();
            arr.Add(5);
            arr.Add(6);
            arr.InsertElement(3, 1);
            arr.InsertElement(2, 4);
            arr.Contain(5);
            Console.WriteLine(arr.Contain(15));
            Console.WriteLine(arr);     
        }
    }
}
