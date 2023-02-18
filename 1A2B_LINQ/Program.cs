using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1A2B_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = 0, b, temp;
            var Input = new List<int>();
            var topic = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    temp = rnd.Next(0, 10);
                } while (topic.IndexOf(temp) != -1);
                topic.Add(temp);
            }
            foreach (int i in topic)
            {
                Console.Write(i);
            }

            

            while(a < 4)
            {
                Console.Write("\nInPut:");

                string n = Console.ReadLine();
                foreach (var item in n.ToCharArray())
                {
                    Input.Add(int.Parse(item.ToString()));
                }
                //提取輸入數字

                for (int i = 0; i < topic.Count; i++)
                {
                    if (topic[i] == Input[i])
                    {
                        a++;
                    }
                }//計算A
                var AB = topic.Intersect(Input);
                b = AB.Count() - a;

                Console.WriteLine($"{a}{b}");
            }
            

            
            //for(int i = 0;i < 4;i++)
            //{
            //    if ()
            //}



            Console.ReadLine();

        }
    }
}
