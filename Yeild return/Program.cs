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
            // function listCollection(listDataInput,number)
            foreach (var item in listCollection(listDataInput, number))
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        
        }
        /// <summary>
        ///  IEnumberable will collect data no need declare more List<string> for add item.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        private static IEnumerable<int> listCollection(List<int> list,int number)
        {
            for (int i=0;i<list.Count();i++)
            {
                if (list[i].Equals(number))
                {
                    // item yield so very performance when switch main function and listcollection function
                    yield return i;
                }
            }
        }
    }
}
