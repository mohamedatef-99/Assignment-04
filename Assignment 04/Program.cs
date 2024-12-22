namespace Assignment_04
{
    internal class Program
    {
        #region Q1
        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //static void SwapRef(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //} 
        #endregion

        #region Q2
        //static int sumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];

        //    } 

        //    return sum;
        //}

        //static int sumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];

        //    }

        //    return sum;
        //} 
        #endregion



        static void Main(string[] args)
        {
            #region Q1
            ////1.Passing by value

            //int A = 4;
            //int B = 5;
            //Console.WriteLine("Before Swap");
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Swap(A, B);
            //Console.WriteLine("After Swap");
            //Console.WriteLine(A);
            //Console.WriteLine(B);


            ////2.Passing by reference
            //int x = 4;
            //int Y = 5;
            //Console.WriteLine("Before Swap Ref");
            //Console.WriteLine(x);
            //Console.WriteLine(Y);

            //SwapRef(ref x, ref Y);
            //Console.WriteLine("After Swap Ref");

            //Console.WriteLine(x);
            //Console.WriteLine(Y); 
            #endregion

            #region Q2
            // passing by value
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int result = sumArray(arr); 
            //Console.WriteLine(result);  // 114

            //Console.WriteLine(arr[0]); // 100


            // passing by reference
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int result = sumArray(ref arr);
            //Console.WriteLine(result);  // 114

            //Console.WriteLine(arr[0]); // 100 
            #endregion

        }
    }
}
