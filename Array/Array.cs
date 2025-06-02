
//Insertion O(N)
//Delete O(N)
//Find O(N)

namespace AlgoritmsAndDaraStructures.NET.Array
{
    internal class Array<T>
    {
        private T[] a;
        private int nElems;

        public Array(int max)
        {
            a = new T[max];
            nElems = 0;
        }

        public int find(T key)
        {
            int j;
            for (j = 0; j < nElems; j++)
            {
                if (a[j].Equals(key))
                {
                    return j;
                }
            }
            return -1;
        }
        public void insert(T key , int ind )
        {
            if (nElems>=a.Length)
            {
                T[] arr =new T[a.Length * 2];
                for (int i = 0; i < nElems; i++)
                {
                    arr[i] = a[i];
                }
                a = arr;

            }
            if (nElems==0) {a[0] = key; nElems++; return; }
           
            for (int i = nElems-1;i>ind; i--)
            {
                a[i+1]=a[i];
            }
            a[ind+1] = key;
            nElems += 1;
        }
        public Boolean delete(T key)
        {
            if (nElems==0) return false;
            int j;
            for (j = 0; j < nElems; j++)
            {
                if (a[j].Equals(key))
                {
                    break;
                }
            }
            if (a[j].Equals(key))
            {
                for (int i = j; i<nElems-1; i++)
                {
                    a[i] = a[i+1];
                }
                nElems -= 1;
                return true;
            }
            return false;
        }
        public void display()
        {
            for (int i = 0; i < nElems; i++)
            {
                Console.Write(a[i]+" ");
                
            }
            Console.WriteLine();
        }
    }
}
