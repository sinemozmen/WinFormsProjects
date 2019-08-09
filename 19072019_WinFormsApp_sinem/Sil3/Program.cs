using System;

namespace Sil3
{   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IDataContainer
    {
        string Data { get; set; }
    }
    class Worker
    {
        void DoWork (object obj)
        {
            //var dataContainer = (IDataContainer);//seçenek 1 
            //dynamic dataContainer = obj;
            //var  dataContainer = obj is IDataContainer;// objenin tipi data container mı ? 
            //
            //var dataContainer = obj as IDataContainer;//Doğru cevap "AS"
            //IDataContainer dataContainer = obj as IDataContainer;
            //is ve as için : https://www.codeproject.com/Tips/532831/Use-of-Is-and-As-operators-in-Csharp


            if (dataContainer!=null)
            {
                Console.WriteLine(datacContainer.Data);

            } 


        }


    }
}
