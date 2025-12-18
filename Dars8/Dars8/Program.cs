namespace Dars8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {
                var ad = string.Empty;
                var adU = string.Empty;

                #region  Boshlanish
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" 1. Create");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" 2. Delete");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" 3. Update");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" 4. Read");
                Console.ResetColor();

                Console.WriteLine();
                #endregion


                Console.Write(" Ammalni tanlang: ");
                int.TryParse(Console.ReadLine(), out int amal);


                switch (amal)
                {
                    // 1. Create
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" AD");
                        Console.ResetColor();
                        Console.Write(" kiriting: ");

                        ad = Consol();

                        if (Standartlika(ad))
                        {
                            if (!SearchAD(ad))
                            {
                                Console.WriteLine();
                                CreateAD(ad);
                                Console.Write($" {ad} muvafaqiyatli saqlandi ");

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("☻");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write($" {ad} mavjud saqlanmadi ");

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("x");
                                Console.ResetColor();
                            }
                        }
                        else
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($" AD");
                            Console.ResetColor();
                            Console.Write(" to'gri farmatda emas");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"! {ad}");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($" AD");
                            Console.ResetColor();
                            Console.Write(" to'gri farmat: ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("AD1234567");
                            Console.ResetColor();

                        }
                        break;
                }
            }
        }
    }
}
