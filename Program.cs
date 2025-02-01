namespace adv3
{
    public delegate int StringFuncDelegate(string S);


    public delegate bool ConditionFuncDelegate<t>(t A);
    internal class Program

    {
        public static void PrintArray<t>(t[] values)
        {

            Console.WriteLine();
            foreach (t item in values)
            {
                Console.Write($"{item} ,");
            }
            Console.WriteLine();

        }

        //public static List<int> FindOddNumbers (List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if(list?.Count > 0)
        //    {
        //        for(int i = 0; 1 < list.Count; i++)
        //        {
        //            if (list[i]%2 != 0)
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }
        //    return result;
        //}

        //public static List<int> FindevenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; 1 < list.Count; i++)
        //        {
        //            if (list[i] % 2 == 0)
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }
        //    return result;
        //}

        //public static List<int> Findby4Numbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; 1 < list.Count; i++)
        //        {
        //            if (list[i] % 4 == 0)
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }
        //    return result;
        //}

        
        public static List<t> FindOddNumbers<t>(List<t> list , ConditionFuncDelegate<t> reference)
        {
            List<t> result = new List<t>();
            if (list?.Count > 0)
            {
                for (int i = 0; 1 < list.Count; i++)
                {
                    if (reference.Invoke(list[i]))
                    {
                        result.Add(list[i]);
                    }

                }
            }
            return result;
        }

        //public static List<int> FindevenNumbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; 1 < list.Count; i++)
        //        {
        //            if (ConditionsFucntion.CheckEven(list[i]))
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }
        //    return result;
        //}

        //public static List<int> Findby4Numbers(List<int> list)
        //{
        //    List<int> result = new List<int>();
        //    if (list?.Count > 0)
        //    {
        //        for (int i = 0; 1 < list.Count; i++)
        //        {
        //            if (ConditionsFucntion.Checkby4(list[i]))
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }
        //    return result;
        //}
        public   static  void PrintList<t>(List<t> values)
        {
            Console.WriteLine();
            foreach(t item in values)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region video 2
            //StringFuncDelegate x = StringFunctions.GetCountOfUpperCaseChars;

            //x = StringFunctions.GetCountOfLowerCaseChars;
            //int count = x.Invoke("Hello Word");

            //Console.WriteLine(count); 
            #endregion

            #region Video 3

            int[] numbers = { 9, 3, 1, 4, 5, 7, 4, 5, 8 };


            PrintArray(numbers);

            SortingAlgorthims.BlubleSort(numbers, Sortingconditions.CompareGtr);

            PrintArray(numbers);


            #endregion


            #region Video 4

            string[] Names = { "omar", "ahmed", "mona", "hany", "mohamed", "randa" };

            PrintArray(Names);

            SortingAlgorthims.BlubleSort(Names, Sortingconditions.CompareLess);
            PrintArray(Names);
            #endregion

            #region video 5

            List<int> Numbers = Enumerable.Range(1, 100).ToList();
            List<int> OddNumbers = FindOddNumbers(Numbers, ConditionsFucntion.Checkby4);

            PrintList(OddNumbers);
            #endregion

            #region Video 6

            List<string> Namess = new List<String>() { "omar", "ahmed", "mona", "hany", "mohamed", "randa" };



            #endregion

            #region Video 7

            //Predicate<int> predicate = ConditionsFucntion.CheckEven;

            //bool r = predicate.Invoke(1);
            //Console.WriteLine(r);

            Func<int> func = Func01;
            Func<int, string> Func1 = Func02;

            Action action = print;


            #endregion

            #region video8


            //List<int> Numberss = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Func<int, bool> func1 = delegate (int X) { return X % 2 == 0; };

            //FindOddNumbers(Numberss, func1);
            //FindOddNumbers(Numberss, n => n % 2 != 0);
            #endregion
            #region video9
            //var x = 12;
            //var X = "hello";
            //var predicate = ConditionsFucntion.CheckEven;
            #endregion
        }
        public static void print()
        {
            Console.WriteLine("hello ");
        }
        public static int Func01()
        {
            return 1;
        }
        public  static string Func02(int x)
        {
            return $"{x}"; 
        }
    }

}
