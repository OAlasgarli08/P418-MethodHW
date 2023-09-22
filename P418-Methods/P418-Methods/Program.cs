// Number 1

//static void Division(int n)
//{
//    if (n%3 == 0 && n%7 == 0)
//    {
//        Console.WriteLine("The number is divisble by 3 and 7");
//    }
//    else
//    {
//        Console.WriteLine("The number is not divisble by 3 and 7");
//    }
//}

//Division(21);

// -------------------------------------------------------------------------

// Number 2

//static void EvenNumbers(int n, int m)
//{
//    int sum = 0;
//    if (n%2 == 0 && m%2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("The numbers aren't even");
//    }

//}

//EvenNumbers(4, 8);

// -------------------------------------------------------------------------

// Number 3
//
//static void OddNumber(int n, int m)
//{
//    int count = 0;
//    for (int n = n; i < m; n++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }

//    }
//    Console.WriteLine(count);
//}

//OddNumber(1, 10);

// -------------------------------------------------------------------------

// Number 4

//static void SumOfOddNumbers(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i%2 != 0)
//        {
//            sum = n + m;
//        }
//    }
//    Console.WriteLine(sum);
//}

//SumOfOddNumbers(0, 10);

// -------------------------------------------------------------------------

// Number 5

//static void OddNumbersinArray(params int[] numbers)
//{
//   int sum = 0;
//    foreach (int number in numbers)
//    {
//        if (number%2 == 1)
//        {
//            sum += number;
//        }
//    }
//    Console.WriteLine(sum);
//}

//OddNumbersinArray( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

// -------------------------------------------------------------------------

// Number 6

//static void OddNumbersinArray(params int[] numbers)
//{
//    int sum = 0;
//    foreach (int number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            sum += number;
//        }
//    }
//    Console.WriteLine(sum);
//}

//OddNumbersinArray(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

// -------------------------------------------------------------------------

// Number 7

//static void SimpleOrComplex(int n)
//{
//    int count = 0;
//    if (n <= 1)
//    {
//        Console.WriteLine("Type in a new number");
//    }

//    for (int i = 1; i <= n; i++)
//    {
//       if(n%i == 0)
//       {
//            count++;
//       }
//    }

//    if (count == 2)
//    {
//        Console.WriteLine("The number is simple");
//    }
//    else
//    {
//        Console.WriteLine("The number is complex");
//    }
//}

//SimpleOrComplex(3);

// -------------------------------------------------------------------------

// Number 8

//static void PowerOfNumber(int n, int m)
//{
//    Console.WriteLine(n);
//    for (int i = n;  i <= m; i++)
//    {

//        Console.WriteLine(Math.Pow(n, i));

//    }
//}

//PowerOfNumber(2,5);

// -------------------------------------------------------------------------

// Number 9

//static void ProductOfArray(params int[] numbers)
//{
//    int multiple = 1;   
//    for (int i = 1; i <= numbers.Length; i++)
//        {
//        numbers[i] *= multiple ;
//            Console.WriteLine(multiple);
//        }
//}

//ProductOfArray(1, 2, 3, 4, 5);

// -------------------------------------------------------------------------

// Number 10

//static void ProductOfArray(params int[] numbers)
//{
//    int sum = 0;  

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            sum += numbers[i];
//        }

//    Console.WriteLine(sum * sum);
//}

//ProductOfArray(1, 2);