namespace Assignment_04
{
    internal class Program
    {
        //static void PrintShape()
        //{
        //    // Body
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("*****");
        //    }
        //}

        //static void PrintShape(int count = 1)
        //{
        //    // Body
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("*****");
        //    }
        //}

        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}

        //static int sum(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //static int sum(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        static void Main(string[] args)
        {

            #region One D Array
            // One D Array
            //   int[] Number;
            //   // Declare For Reference from type array of integers
            //   // Numbers can refere to object of type array of integers
            //   // numbers refer to null

            //   // 8 bytes will be allocated at stack for reference numbers
            //   // 0 bytes will be allocated at heap for array of integers

            //   Number = new int[5];

            //   // new
            //   // 1. allocate the number of required bytes for the object at heap (4 byets * 5) = 20
            //   // 2. Initialize the allocated block of memory to default values (0 for integers)
            //   // 3. call user defined constructor if exsits
            //   // 4. assign the object to the reference numbers

            //   Console.WriteLine(Number[0]);

            //   int[] num = { 1, 2, 3, 4, 5 };


            //   int[] num01;
            //   for (int i = 0; i < num.Length; i++)
            //   {
            //       Console.WriteLine(num[i]);
            //   }

            //   Console.WriteLine(num.Length);
            //   Console.WriteLine(num.Rank); 
            #endregion

            #region Two D Array
            // Two D Array
            //int[,] Number = new int[3, 3];
            //Number[0, 0] = 1;
            //Number[0, 1] = 2;
            //Number[0, 2] = 3;
            //Number[1, 0] = 4;
            //Number[1, 1] = 5;
            //Number[1, 2] = 6;
            //Number[2, 0] = 7;
            //Number[2, 1] = 8;
            //Number[2, 2] = 9;

            //Console.WriteLine(Number[0,0]);
            //Console.WriteLine(Number[0,1]);
            //Console.WriteLine(Number[0,2]);


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(Number[i, j]);
            //    }
            //} 
            #endregion

            #region Functions
            // Functions : Block of code that have name if u need to executer this code
            // you can call this function by its name

            // Function Prototype
            // signature 
            // name
            // return type
            // parameters
            // Body (code)

            // Call the function

            //PrintShape(3);

            // Method
            // 1. Static Method
            // 2. non static method

            //Program p = new Program();
            //p.PrintShape(); 
            #endregion

            #region Bassing By Value and Ref
            // 1. Passing by value

            //int A = 4;
            //int B = 5;

            //Swap(A, B);


            // 2. Passing by reference
            //int A = 4;
            //int B = 5;

            //Swap(ref A, ref B); 
            #endregion

            #region Passing by ref
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int result = sum(arr);
            //Console.WriteLine(result);

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int result = sum(ref arr);
            //Console.WriteLine(result); 
            #endregion
        }
    }
}
