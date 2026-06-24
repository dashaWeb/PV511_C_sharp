using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_IEnumerable
{
    class Demo
    {
        public void Test()
        {
            // Enumerable - те, що перелічується, по ньому можна проходити
            // Enumerator - той, хто перемішяється (в С++ це називалося ітерато)

            // низькорівневий обхід масиву
            int[] arr = { 10, 33, 44, -100, 77 };
            var enArr = arr.GetEnumerator(); 
            while(enArr.MoveNext())
            {
                Console.Write($"{enArr.Current, 7}");
            }
            Console.WriteLine();
            enArr.Reset();
            enArr.MoveNext();
            Console.WriteLine(enArr.Current);


            string str = "Hello from IEnumerable";
            CharEnumerator en = str.GetEnumerator();

            while (en.MoveNext())
            {
                Console.Write($"{en.Current,2}");
            }

            Console.WriteLine();
            en.Reset();
            StringBuilder sb = new StringBuilder();
            while (en.MoveNext())
            {
                sb.Append(en.Current);
                sb.Append("_");
            }
            Console.WriteLine(sb);
        }
    }
}
