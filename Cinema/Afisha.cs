using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Afisha 
    {
        

        // public Action Action { get; set; }

        public static List<MenuSection> afishaMovies = new List<MenuSection>
        {
            new MenuSection
            {
               
                sectionName = "Годзилла и Конг",
                sectionDate = new DateTime(2023,5,20,19,0,12),
                
                price = 300,
                action = Reservation.ShowSeatReservationMenu
            },
            new MenuSection
            {
                sectionName = "Дедпул 3",
                sectionDate = new DateTime(2023,8,10,18,25,12),
               
                price = 300,
                action = Reservation.ShowSeatReservationMenu
            },
            new MenuSection
            {
                sectionName = "Шрек 4",
                sectionDate = new DateTime(2023,5,9,15,30,12),
               
                price = 300,
                action = Reservation.ShowSeatReservationMenu
            },
            new MenuSection
            {
                sectionName = "Джокер 2",
                sectionDate = new DateTime(2023,11,4,21,30,12),
                
                price = 300,
                action = Reservation.ShowSeatReservationMenu
            },
            new MenuSection
            {
                sectionName = "Кунг-Фу панда 4",
                sectionDate = new DateTime(2024,3,12,22,00,12),
                
                price = 300,
                action = Reservation.ShowSeatReservationMenu
            },
            new MenuSection
            {
                sectionName = "Вернуться назад",
                action = MainMenu.ShowMainMenu
            }


        };


       
        
        public static void ShowAfisha()
        {
            
            Reservation.index = 1;
            Navigation.ListNavigation(afishaMovies);
          

           
        }

     


       

       



    }
}
