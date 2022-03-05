using System;

namespace AP204_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homeworks
            //string[] words = { "Bahadur", "Shemsi", "Tural", "Vahid", "Ali", "Fazil", "Safiyya" };

            //foreach (string word in words)
            //{
            //    if (word.Length > 5)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length > 5)
            //    {
            //        Console.WriteLine(words[i]);
            //    }
            //    else
            //    {
            //        Console.WriteLine("uzunlugu 5-den kicikdir");
            //    }
            //}


            //Task 2

            //int number = 214;

            //int total = 0;


            //while (number != 0)
            //{
            //    int remainder = number % 10;
            //    total += remainder;
            //    number /= 10;//number = number /10
            //}
            //Console.WriteLine(total);
            #endregion


            int num1 = 5;
            int num2 = 10;
            int total1 = num1 + num2;

            int num3 = 12;
            int num4 = 18;
            int total2 = num3 + num4;

            //Console.WriteLine(total1);
            //Console.WriteLine(total2);

            int[] arr = { 1, 6, 7, 9, 12, 16, 23 };

            int number = Convert.ToInt32(Console.ReadLine());

            DivideCount(arr,number);
            //Divide(arr, 2);
            //Divide(arr, 3);
            //Divide(arr, 4);
            //Divide(arr, 5);
            //Divide(arr, 6);
            //Divide(arr, 7);
            //int total = 10;
            //Console.WriteLine(Sum(total, num2));
            //Console.WriteLine(Sum(num3, num4));


            //Console.WriteLine(Fullname("Kamal","Ebishli"));
            //Console.WriteLine(Fullname("Islam","Xalitov"));

            //Console.WriteLine(Fullname(surname:"Hasanzade",name:"Fatima"));

            //Console.WriteLine(Sum(10,30));

            //Console.WriteLine(Add(5, 10));
            //Console.WriteLine(Add(100));
            //Console.WriteLine(Add(100,20,30));
            //Console.WriteLine(Add(15," test"));
            //Console.WriteLine(Add("Shemsi ",80));
            //Console.WriteLine(Add(1,6,7,10));
            //Console.WriteLine(Add1(10, 15));

            //Console.WriteLine(Concat(5,"okay"));
        }

        #region Methods
        public static int Sum(int num1, int num2 = 5)
        {
            return num1 + num2;
        }

        public static void Divide(int[] array, int number)
        {
            Console.WriteLine("divided by " + number);
            foreach (int num in array)
            {
                if (num % number == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static string Fullname(string name, string surname)
        {
            return name + " " + surname;
        }

        public static string Concat(int number, string word)
        {
            return number + " " + word;
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(int num1)
        {
            return num1 + 10;
        }

        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public static string Add(int num1, string word)
        {
            return num1 + word;
        }

        public static string Add(string word, int num1)
        {
            return word + num1;
        }

        public static string Add(int num1, int num2, int num3, string num4)
        {
            return num1 + num2 + num3 + num4;
        }

        public static string Add(int num1, int num2, string num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
        #endregion


        public static void DivideCount(int[] arr,int number)
        {
            int count = 0;
            foreach (int num in arr)
            {
                if(num % number == 0)
                {
                    count++;
                    return;
                }
            }
            Console.WriteLine(count);
        }
        
    }

}
