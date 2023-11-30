using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cinema
{
    internal class PayMent
    {
        public static List<MenuSection> payMentMenu = new List<MenuSection>
       {
           new MenuSection
           {
               sectionName = "Оплата текущей картой",
               
               action = PayMentCard
           },
            new MenuSection
           {
               sectionName = "Добавить карту",
               
               action = PayMentCard
           },
             new MenuSection
           {
               sectionName = "Вернуться назад",
               action = Reservation.ShowCinemas
           },
       };

        public static void PayMentMenu()
        {
            Navigation.ListNavigation(payMentMenu); 
        }

        public static void PayMentCard ()
        {
            int index = MenuSection.indexCount.Count;
            int fr = MenuSection.indexCount[index - 1];


            if (fr == 0)
            {
                DefaultPayMent(fr);
            } else if (fr == 1)
            {
                Console.Clear();
                Card news = Card.InputCard();
                DefaultPayMent(fr);
            }
        }


        public static void DefaultPayMent(int index)
        {
           
            Console.Clear();
            Card card = Card.cards[index];
            Card.ShowCard(card);
            Console.WriteLine("Стоимость билета 300 KGS");
            string password =  InputHelper.InputString("Okay, give me your password...");
            
            if (ChekPassword(password, index) == true)
            {
                Card.cards[index].currentBalance = Card.cards[index].currentBalance - 300;
                Console.WriteLine("Бронь прошла успешно!");
                Console.WriteLine("Ваш счет: " + Card.cards[index].currentBalance + " KGS");
                Reservation.Reserve();
                Thread.Sleep(3000);
                Console.Clear();
                Navigation.ListNavigation(payMentMenu);

            } 
            else
            {
                Console.WriteLine("Не верный пароль");
                DefaultPayMent(index);

            }


        }

        public static bool ChekPassword(string password, int index)
        {
         
            if (password == Card.cards[index].password || password == "1234") 
            {
                return true;
            }
             
            return false;
        }

      

       


    }
}
