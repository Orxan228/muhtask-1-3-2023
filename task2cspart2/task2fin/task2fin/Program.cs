namespace task2fin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of an array: ");
            int arrLenght = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[arrLenght];
            double value = 0;
            int count = 0;
            double[] primeArr = new double[0];
            double[] compoundArr = new double[0];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a value " + (i + 1) + " : ");
                value = Convert.ToDouble(Console.ReadLine());
                while (value == 0 || value < 0 || value == 1)
                {
                    Console.WriteLine("The min value you can enter is 2 and The value you entered must be more than 0");
                    Console.WriteLine("Enter a value " + (i + 1) + " : ");
                    value = Convert.ToDouble(Console.ReadLine());
                }
                if (value > 0)
                {
                    arr[i] = value;
                }
            }
            foreach (double item in arr)
            {
                int i = 2;
                count = 0;
                while(i < item) 
                {
                    if (item % i == 0)
                    count++;
                    i++;
                    
                }
                if (count>0)
                {
                    Array.Resize(ref compoundArr, compoundArr.Length+1);
                    compoundArr[compoundArr.Length-1] = item;
                    
                }
                else
                {
                    Array.Resize(ref primeArr, primeArr.Length+1);
                    primeArr[primeArr.Length-1] = item;
                }
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Compound numbers:");
            foreach (double item in compoundArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("Prime numbers");
            foreach (double item in primeArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}