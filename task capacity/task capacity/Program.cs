using System.Collections;
using task_capacity.models;

namespace task_capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexerList indexerList = new IndexerList();
            indexerList.Add(4);
            indexerList.Add(2);
            indexerList.Add(4);
            indexerList.Add(45);
            indexerList.Add(6);
            indexerList.Add(9);

            indexerList.GetInfo();
            indexerList.RemoveAt(2);
            indexerList.GetInfo();


            indexerList.IndexOf(5);
            indexerList.LastIndexOf(5);
            indexerList.RemoveAt(0);



          
           
            Console.WriteLine(indexerList.ToString());
        }
    }
}
