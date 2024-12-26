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

        //static int[] sum(int x, int y)
        //{
        //    int[] result = {1, 2, 3, 4, 5 };
        //    return result;
        //}

        //static int sumarr(params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

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

        #region Q3
        //static int[] sumint(int x, int y, int a, int b)
        //{
        //    int[] result = {x+y, a - b };
        //    return result;
        //}
        #endregion

        #region Q4
        //static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number != 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //} 
        #endregion

        #region Q5
        //static bool IsPrime(int number)
        //{
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //} 
        #endregion

        #region Q6
        //static void MinMaxArray(int[] arr, ref int min, ref int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min) min = arr[i];
        //        if (arr[i] > max) max = arr[i];
        //    }
        //} 
        #endregion

        #region Q7
        //static int factiorial(int num)
        //{
        //    int fact = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        fact *= i;
        //    }
        //    return fact;
        //} 
        #endregion

        #region Q8
        //static string ChangeChar(string str, int position, char newChar)
        //{
        //    char[] arr = str.ToCharArray();
        //    arr[position] = newChar;
        //    return new string(arr);
        //} 
        #endregion

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

            // Parameters
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(sumarr(nums));


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

            #region Q3
            //int num1, num2, num3, num4;
            //bool flag1, flag2, flag3, flag4;
            //do
            //{
            //    Console.Write("Enter first number: ");
            //    flag1 = int.TryParse(Console.ReadLine(), out num1);
            //    Console.Write("Enter second number: ");
            //    flag2 = int.TryParse(Console.ReadLine(), out num2);
            //    Console.Write("Enter third number: ");
            //    flag3 = int.TryParse(Console.ReadLine(), out num3);
            //    Console.Write("Enter fourth number: ");
            //    flag4 = int.TryParse(Console.ReadLine(), out num4);

            //}
            //while (!flag1 && !flag2 && !flag3 && !flag4);

            //int[] result = sumint(num1, num2, num3, num4);
            //Console.WriteLine(result[0]);
            //Console.WriteLine(result[1]);
            #endregion

            #region Q4
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(SumOfDigits(num)); 
            #endregion

            #region Q5
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(num)); 
            #endregion

            #region Q6
            //int[] arr = { 10, 2, 3, 4, 5 };
            //int min = 0, max = 0;
            //MinMaxArray(arr, ref min, ref max);
            //Console.WriteLine($"min: {min}, max: {max}"); 
            #endregion

            #region Q7
            //int num = 5;
            //Console.WriteLine($"factorial of {num} : {factiorial(num)}"); 
            #endregion

            #region Q8
            //string str = "mohamed";
            //Console.WriteLine(ChangeChar(str, 1, 'a')); 
            #endregion

            #region Q9
            //int size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter the size of the array: ");
            //    flag = int.TryParse(Console.ReadLine(), out size);
            //} while (!flag);

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write($" {1} ");
            //        }
            //        else
            //        {
            //            Console.Write($" {0} ");
            //        }
            //    }
            //    Console.WriteLine("\n");
            //} 
            #endregion

            #region Q10
            //int sum =0;
            //int[] arr = { 10, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum); 
            #endregion
        }
    }
}
