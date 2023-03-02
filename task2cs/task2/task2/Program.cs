namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter lenght of an array: ");
            int arrLenght = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[arrLenght];
            double value = 0;
            double[] primeArr = new double[100];
            double[] compoundArr = new double[100];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a value " + (i + 1) + " : ");
                value = Convert.ToDouble(Console.ReadLine());
                if (value == 0 || value < 0)
                {
                    Console.WriteLine("The min value you can enter is 1 and The value you entered must be more than 0");
                    Console.WriteLine("Enter a value " + (i + 1) + " : ");
                    value = Convert.ToDouble(Console.ReadLine());
                }
                if (value > 0)
                {
                    arr[i] = value;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                double z = arr[i];
                int d = 1;
                int c = 0;
                while (d <= arr[i])
                {
                    if (arr[i] % d == 0)
                    {
                        c++;
                    }
                    d++;
                }
                if (c == 2)
                {
                    compoundArr[i] = arr[i];
                }
                else if (true)
                {
                    primeArr[i] = arr[i];   
                }
            }
            Console.WriteLine("Prime numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(primeArr[i]);
            }
            Console.WriteLine("Compound numbers: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(primeArr[i]);
            }
            //           for (int i = 0; i < arr.Length; i++)
            //           {
            //               if (arr[i] == 0 || arr[i] == 1)
            //               {
            //                   Console.WriteLine("0 amd 1 are not prome or compound numbers");
            //              }
            //               else if ()
            //               {
            //                   primeArr[i] = arr[i];
            //               }
            //               else if ()
            //              {
            //                   compoundArr[i] == arr[i];
            //               }
        }
           
        }
    }