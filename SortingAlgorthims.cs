using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv3
{

    public delegate bool SortingFuncDelegate<t>(t A, t B);
    //public delegate bool SortingFuncDelegatev02(string A, string B);

    internal class SortingAlgorthims
    {

        //public static void BlubleSortAscending(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length -i -1; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    SWAP(ref arr[j], ref arr[j+1]);
        //                }
        //            }
        //        }
        //    }
            
        //}

        public static void BlubleSort<t>(t[] arr , SortingFuncDelegate<t> reference)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(arr[j], arr[j+1]))
                        {
                            SWAP(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }

        }
        //public static void BlubleSort(string[] arr , SortingFuncDelegatev02 reference)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (reference.Invoke(arr[j], arr[j+1]))
        //                {
        //                    SWAP(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }

        //}


        //private static void SWAP (ref int  x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        private static void SWAP<t>(ref t x, ref t y)
        {
            t temp = x;
            x = y;
            y = temp;
        }
    }
}
