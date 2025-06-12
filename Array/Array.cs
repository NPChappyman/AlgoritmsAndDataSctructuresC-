
//Insertion O(N)
//Delete O(N)
//Find O(N)

using System.Runtime.ConstrainedExecution;

namespace AlgoritmsAndDaraStructures.NET.Array
{
    public static class Sort<T> where T : IComparable<T>
    {
        public static void bubblesort(ref Array<T> arr,int size)
        {
            for (int i = 0; i < size-1; i++)
            {
                for (int j = 0; j<size-1-i; j++)
                {
                    if (arr.get(j).CompareTo(arr.get(j+1)) >0)
                        swap(ref arr,j,j+1);
                }
            }
        }

        public static void quicksort(ref Array<T> arr,int i, int j)
        {
            if (i >= j) return;
            int c = i;
            for (int ii = i+1; ii < j; ii++)
            {
                if (arr.get(ii).CompareTo(arr.get(i))<0)
                {
                    swap(ref arr,++c,ii);
                }
            }
            swap(ref arr,i,c);
            if (c>i)
            {
                quicksort(ref arr,i,c);
            }
            if (j>c+1)
            {
                quicksort(ref arr, c + 1, j);
            }
        }
        public static void swap(ref Array<T> arr, int i ,int j)
        {
            T temp = arr.get(i);
            arr.set(arr.get(j), i);
            arr.set(temp, j);
        }
    }
    public  class Array<T> where T : IComparable<T>
    {
        private T[] a;
        private int nElems;

        public Array(int max)
        {
            a = new T[max];
            nElems = 0;
        }
        public T get(int i)
        {
            return a[i];
        }
        public void set(T key, int ind)
        {
            a[ind] = key;
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
        public int binarysearch(T key)
        {
            int l = 0;
            int r=nElems-1;
            int cur;
            while (true)
            {
                cur = (r + l) / 2;
                if (a[cur].Equals(key))
                    return cur;
                else if (l > r)
                    return -1;
                else
                {
                    if (a[cur].CompareTo( key)>0)
                        r = cur - 1;
                    else
                        l = cur + 1;
                }
            }

        }
        public int size()
        {
            return nElems;
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
