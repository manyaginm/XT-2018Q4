using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DynamicArray
{
    class DynamiArray<T>
    {
        private T [] r;
        private int fillness;
        public DynamiArray() : this(8) { }

        public DynamiArray(int i)
        {
           this.r = new T[i];
           this.Fillness = 0;
        }

        public T[] R { get => r; set => r = value; }
        public int Fillness { get => fillness; set => fillness = value; }

        public DynamiArray(IEnumerable<T> e)

        {
            this.r = new T[e.Count()];
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = e.ElementAt(i);
                Fillness++;
            }
        }

        public void addElement(T e)

        {
            if (Fillness == R.Length)
            {
                T[] tempArr = R;
                R = new T[R.Length * 2];

                for (int i = 0; i < tempArr.Length; i++)
                {
                    R[i] = tempArr[i];
                }
                R[tempArr.Length] = e;
                Fillness++;
            }
            else
            {
                R[Fillness] = e;
                Fillness++;
            }
        }

        public void addRange(IEnumerable<T> e)
        {
            T[] inputArr = e.ToArray();
           if(R.Length - fillness >= inputArr.Length)
            {
                for(int i = 0; i< inputArr.Length; i++)
                {
                    R[fillness] = inputArr[i];
                    fillness++;
                }
            }
            else
            {
                T[] tmpArr = new T[fillness];
                for (int i = 0; i < fillness; i++)
                {
                    tmpArr[i] = R[i];
                }

                R = new T[tmpArr.Length +(inputArr.Length -(tmpArr.Length - fillness))];
                fillness = 0;
                for(int i = 0; i<tmpArr.Length; i++)
                {
                    R[i] = tmpArr[i];
                    fillness++;
                }

                for (int i = 0; i < inputArr.Length; i++)
                {
                    R[fillness] = inputArr[i];
                    fillness++;
                }
            }
        }

        public bool deleteByIndex(int index)
        {
            bool res = false;
            if (fillness >= index)
            {
                R[index] = default(T);
                res = true;
            }

            return res;
        }

        public int getLength()
        {
            return this.R.Length;
        }

        public int getCapacity()
        {
            return th
is.Fillness;
        }

        public T getElemByIndex(int index, out T p)
        {

           return p=  this.R[index];
        }
    }
}   