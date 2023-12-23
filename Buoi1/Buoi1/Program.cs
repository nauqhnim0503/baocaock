using System;

namespace Buoi1
{
    
    class Program
    {
     
        static void Main(string[] args)
        {
            //Console.WriteLine("hi hi hi ");
            //Console.ReadLine();
            //string s;
            //Console.Write(" nhap so a ");
            //s = Console.ReadLine();
            //double a = double.Parse(s);


            //Phanso x;
            //Console.Write("nhap tu so");
            //string s = Console.ReadLine();
            //x.tuso = int.Parse(s);

            //Console.Write("Nhap mau so");
            //s = Console.ReadLine();
            //x.mauso = int.Parse(s);

            //Console.WriteLine("Phan so:{0}/{1}", x.tuso, x.mauso);
            string s1 = "Cao lo";
            string s2 = "180";
            string s = s2 + " " + s1;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine("chuoi'{0}'co do dai la {1}", s,s.Length);
            
            for(int i=0;i<s.Length;i++)
            {
                Console.WriteLine(s[i]);
            }
            string sub = s.Substring(4, 6);
            Console.WriteLine(sub);
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
