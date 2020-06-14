using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeild_return
{
    class Program
    {
        private static  List<int> listData = new List<int>() { 1, 2, 3, 1, 2, 3, 3, 4, 2, 3, 1, 3, 2, 3, 4, 5, 6, 3, 5, 6 };
        static void Main(string[] args)
        {
            printIndexOfNumber(listData, 3);
        }
       static void printIndexOfNumber(List<int> listDataInput, int number)
        {
            foreach (var item in listCollection(listDataInput, number))
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        
        }

        private static IEnumerable<int> listCollection(List<int> list,int number)
        {
            for (int i=0;i<list.Count();i++)
            {
                if (list[i].Equals(number))
                {
                    yield return i;
                }
            }
        }
    }
}
