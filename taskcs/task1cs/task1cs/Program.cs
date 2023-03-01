namespace task1cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value: ");
            int val =  Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Enter lenght of an array: ");
            int arrLenght = Convert.ToInt32(Console.ReadLine()); 
            int count = 0;
            int[] arr = new int[arrLenght];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter a value " + (i + 1) + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (val == arr[i])
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("There is no " + val + " value in this array");
            }
            else
            {
                Console.WriteLine("There is " + count + " values in this array");
            }

        }
    }
}