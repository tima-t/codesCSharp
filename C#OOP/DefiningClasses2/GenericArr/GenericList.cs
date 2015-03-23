using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArr
{
    class GenericList<T>
        where  T : IComparable<T>
    {
         private T[] elements;
         private int capacity=16;
         private int  count=0;
      
        public GenericList(int capacity1)
        {
            this.elements = new T[capacity1];
            this.capacity = capacity1;
        }
        public GenericList() 
        {
            this.elements = new T[this.capacity];
        }
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }
       
        
      

        public void AddEl(T el)
        {
            if (count >= capacity-1)
            {
               this.AutoGrow();
            }
            this.elements[count] = el;
            this.count++;
           
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
            set
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
                }
                this.elements[index]=value;
            }
        }

        public void RemoveEl(int index)
        {
            if (index >= this.count)
            {
                throw new ArgumentException("invalid index");
            }
            this.elements[index] = default(T);
            this.count--;
        }
        public void InsertEl(int index, T el)
        {
            if (index > this.Count - 1)
            {
                this.AutoGrow();
            }
            this.elements[index] = el;
            this.count++;
        }

        public void ClearList()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.elements[i] = default(T);
            }
            this.count = 0;
            this.capacity = 16;
        }
        public int ReturnIndex(T el)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(el))
                {
                    return i;
                }

            }

            return -1;
           
              
            
        }

        public override string ToString()
        {
            T[] elementsFilled = new T[count];
            for (int i = 0; i < count; i++)
            {
                elementsFilled[i] = elements[i];
            }
            string result = String.Join(" ", elementsFilled);
            return result;
        }

        private  void AutoGrow()
        {
            
                int newSize =  this.capacity * 2;
                T[] newList = new T[newSize];
                for (int ind = 0; ind <= this.count; ind++)
                {
                    newList[ind] = this.elements[ind];
                }
                this.elements = newList;
                this.capacity = newSize;
            

        }
        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < count; i++)
            {
                if (min.CompareTo(this.elements[i])>0)
                {
                    min = this.elements[i];
                }
                
            }
            return min;
        }
      

        public T Max()
             
        {
            T max = this.elements[0];
            foreach (var element in this.elements)
            {
                if (max.CompareTo(element) < 0)
                {
                    max = element;
                }
            }
            return max;
        }
    }
}
