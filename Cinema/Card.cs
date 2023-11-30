using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Card
    {
        private long _cardNumber;
        public long cardNumber { 
            get 
            {
                return _cardNumber;    
            
            } 
            set 
            {
                
              
                if (value < 9999999999999999 && value > 1000000000000000)
                {
                    _cardNumber = value;
                } 
                else if (value > 9999999999999999 || value < 1000000000000000)
                {
                     Console.WriteLine("недопустимый Формат номера карты");

                } 
            } 
        }   
       
        public string ownerName { get; set; }
        public string bankName { get; set; }      
        public int currentBalance { get; set; }
        

        public string password { get; set; }

         public static List<Card> cards = new List<Card>
         {
              new Card
              {
                 cardNumber = 1234567890123456,
                 ownerName = "Billy DungeonMaster",
                 bankName = "MBank",
                 currentBalance = 500,
                 password = "oralcumshot"
              }
         };


        public static Card InputCard()
        {
            Random random = new Random();
            
          
            var card = new Card
            {
                cardNumber = InputHelper.ReadLong("Введите номер карты  "),
                ownerName = InputHelper.InputString("Введите Имя"),
                bankName = InputHelper.InputString("Название банка"),
                password = InputHelper.InputString("Введите пароль"),
                currentBalance = random.Next(200,1000)
            };
            cards.Add(card);
            return card;
            
        }

        public static void ShowCard(Card card) 
        {
            Console.WriteLine("Номер карты: " + card._cardNumber);
            Console.WriteLine("Владелец карты: " + card.ownerName);
            Console.WriteLine("Банк: " + card.bankName);
            Console.WriteLine("Баланс: " + card.currentBalance + " KGS");

        }
       


       
    }
}
