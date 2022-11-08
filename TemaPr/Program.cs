namespace TemaPr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            do
            {
                Console.WriteLine("ВВедите слогаемое 1");
                string a = Console.ReadLine();

                Console.WriteLine("ВВедите слогаемое 2");
                string b = Console.ReadLine();

                int.TryParse(a, out int cal);
                int.TryParse(b, out int vruh);

                if (cal == 0 && vruh == 0)
                    Console.WriteLine("Введите цифры");
                else
                {
                    Console.WriteLine($"{cal} + {vruh} = {cal + vruh}");
                }

                Console.WriteLine("Повторить?");
                Console.WriteLine("Y/N");
               if(Console.ReadLine() != "Y")
                    end = true;
               else
                Console.Clear();
            } while (end == false);
            
        }
    }
}