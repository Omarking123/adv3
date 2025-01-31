namespace adv3
{
    public delegate int StringFuncDelegate(string S);


  
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

        }
    }
}
