using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_capacity.models
{
    internal class IndexerList
    {
        int[] _arr;
        int Capacity=5;
        public int Count { get; private set; } 
        public IndexerList()
        {
            _arr = new int[Capacity];
        }
        public IndexerList(int capacity)
        {
            Capacity = capacity;

            _arr = new int[Capacity];
        }
        public int this[int num]
        {
            get 
            {
                return _arr[Count];
            }
            set
            {
                if (value<=Count)
                _arr[Count] = value; 
                else
                    Console.WriteLine("arraydan kenara cixdiz");
            }

        }


        public void GetInfo()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
        public void Add(int item)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Capacity + Count);
            }
            _arr[Count] = item;
            Count++;

        }
        
        public void IndexOf(int value)
        {
            bool result=false ;
            int index=0;
            for (int i = 0; i < Count; i++)
            {
                if (_arr[i] == value)
                {
                    index= i;
                    result = true;
                    break;
                }
            }
            if (result)
                Console.WriteLine(index);
            else
                Console.WriteLine("bele eded yoxdur");



        }
        public void LastIndexOf(int value)
        {
            bool result=false;
            int index=0;
            for (int i = Count - 1; i >= 0; i--)
            {
                if (_arr[i] == value)
                {
                    index = i;
                    result = true;
                    break;
                }
            }
            if (result)
                Console.WriteLine(index);
            
            else
                Console.WriteLine("bele eded yoxdur");

        }
        public void RemoveAt(int index)
        {
            _arr[index] = 0;
            Console.WriteLine(index+" indexli eded = 0");
        }


        public  override string ToString()
        {
            string result=null;
            for (int i = 0; i < Count; i++)
            {
                if (i > 0)
                {
                    result += ", ";
                }
                result += _arr[i].ToString();

            }

            return $"{"{"}{result}{"}"}";
        }
    }
}

