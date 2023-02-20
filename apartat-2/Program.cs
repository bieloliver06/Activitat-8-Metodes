namespace Apartat_2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Introdueix la paraula que desitges veures si es un palíndrom : ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    char[] arr = input.ToCharArray();
                    bool isPalindrome = GetPalindrome(arr);
                    if (isPalindrome)
                    {
                        Console.WriteLine($"{input} és un palíndrom.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{input} no és un palíndrom.");
                        break;
                    }
                }
            }
            
        }
        
        public static bool GetPalindrome(char[] arr)
        {
            string inputString = new string(arr);
            string first = inputString.Substring(0, inputString.Length / 2);
            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}