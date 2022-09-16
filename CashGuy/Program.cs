namespace CashGuy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.WriteLine("Введите сумму: ");
                string howMuch = Console.ReadLine();
                if (howMuch == " ") return;

                if (int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Кто дает деньги? ");
                    string whishGuy = Console.ReadLine();
                    if (whishGuy == "Joe")
                    {
                        int cashGiven = joe.GiveCash(amount);
                        bob.ReceiveCash(cashGiven);
                    }
                    else if (whishGuy == "Bob")
                    {
                        int cashGiven = bob.GiveCash(amount);
                        joe.ReceiveCash(cashGiven);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob'");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit)");
                }
            }
            Console.WriteLine("The house always win");
        }
    }
}
