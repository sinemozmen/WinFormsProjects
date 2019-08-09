using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sil
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList array1 = new ArrayList();
            //int var1 = 10;
            //int var2;
            //array1.Add(var1);
            //var2 = (int)array1[0];//Hata vermemesi için bu satır eklenmeli.


            //Aşağıdakilerden hangisi sonsuz döngüye girer.
            //for (int i = 100; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i != 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i == 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <=10 ; i=i+5)
            //{
            //    Console.WriteLine("a");
            //}

             // BASE KEYWORD - MAIN CLASS için 
             // Normalde override edildiğinde override edilen kod çalışır. Ancak base ile parent'taki kod çalıştırılır ,
             //Daha sonra child'daki kod çalıştırılır.

            DerivedClass md = new DerivedClass();
            Console.ReadLine();
            DerivedClass md1 = new DerivedClass(1);
            Console.ReadLine();
        }
    }

    //BASE KEYWORD-- With constructor// 

    public class BaseClass
    {
        int num;

        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }

        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }
    }

    public class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass()
        public DerivedClass() : base()
        { 
            Console.WriteLine("***in DerivedClass()");
        }

        // This constructor will call BaseClass.BaseClass(int i)
        public DerivedClass(int i) : base(i)
        {
            int num = i;
            Console.WriteLine("***in DerivedClass(int i)");
        }

     
    }
    /*
    Output:
    in BaseClass()
    in BaseClass(int i)
    */


    //BASE KEYWORD 2: 
    //public class Person
    //{
    //    protected string ssn = "444-55-6666";
    //    protected string name = "John L. Malgraine";

    //    public virtual void GetInfo()
    //    {
    //        Console.WriteLine("Name: {0}", name);
    //        Console.WriteLine("SSN: {0}", ssn);
    //    }
    //}
    //class Employee : Person
    //{
    //    public string id = "ABC567EFG";
    //    public override void GetInfo()
    //    {
    //        // Calling the base class GetInfo method:
    //        base.GetInfo();
    //        Console.WriteLine("Employee ID: {0}", id);
    //    }
    //}

    //class TestClass
    //{
    //    static void Main()
    //    {
    //        Employee E = new Employee();
    //        E.GetInfo();
    //    }
    //}
    ///*
    //Output
    //Name: John L. Malgraine
    //SSN: 444-55-6666
    //Employee ID: ABC567EFG
    //*/

}
