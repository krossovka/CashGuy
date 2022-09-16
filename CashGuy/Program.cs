﻿Guy joe = new Guy() { Cash = 50, Name = "Joe" };
Guy bob = new Guy() { Cash = 100, Name = "Bob" };

while (true)
{
    joe.WriteMyInfo();
    bob.WriteMyInfo();
    Console.WriteLine("Enter an amount: ");
    string howMuch = Console.ReadLine();
    if (howMuch == " ") return;

    if (int.TryParse(howMuch, out int amount))
    {
        Console.Write("Who should give the cash: ");
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






class Guy
{
    public string Name;
    public int Cash;


    /// <summary>
    /// Выводит значение моих полей Name и Cash на консоль.
    /// </summary>
    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " bucks.");
    }
    /// <summary>
    /// Выдает часть моих денег, удаляя их из кармана (или выводит сообщение на консоль о том, что денег недостаточно).
    /// </summary>
    /// <param name="amount">Выдаваемая сумма</param>
    /// <returns>Сумма денег, взятая из кармана или 0, если денег не хватает (или сумма недействительна)
    /// </returns>
    public int GiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            return 0;
        }
        if (amount > Cash)
        {
            Console.WriteLine(Name + " says: " + "I don't have enough cash to give you " + amount);
            return 0;
        }
        Cash -= amount;
        return amount;
    }
    /// <summary>
    /// Получает деньги, добавляя их в мой карман (или выводит сообщение на консоль, если сумма недействительна)
    /// </summary>
    /// <param name="amount">Получаемая сумма.</param>
    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
        }
        else
        {
            Cash += amount;
        }
    }
}
