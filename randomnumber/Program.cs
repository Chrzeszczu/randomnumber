using System;

namespace RandomNumber // Note: actual namespace depends on the project name.
{
    public class RanNumGenerator
    {
        public static int Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            Console.WriteLine(num);
            String str = Convert.ToString(num);
            File.WriteAllText(@"C:\Users\michal.chrzeszczyk\Desktop\Jenkins_Workspace\rnum.txt", str);
            return num;
        }
    }
}