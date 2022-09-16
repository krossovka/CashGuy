using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashGuy
{
    public class Guy
    {
        public string Name;
        public int Cash;


        /// <summary>
        /// Выводит значение моих полей Name и Cash на консоль.
        /// </summary>
        public void WriteMyInfo()
        {
            Console.WriteLine(Name + " имеет " + Cash + " долларов.");
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
                Console.WriteLine(Name + " говорит: " + "У меня недостаточно денег, чтобы дать тебе " + amount);
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

}
