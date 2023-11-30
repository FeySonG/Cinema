using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class MainMenu 
    {
        public static List<MenuSection> sections = new List<MenuSection>()
        {
            new MenuSection()
            {
                sectionName = "Афиша",
                action = Afisha.ShowAfisha

            },
             new MenuSection()
             {
                sectionName = "Выбор фильма",
                action = SelectMovies.ShowMovies


             },
              new MenuSection()
              {
                sectionName = "Бронь",
                action = Reservation.ShowReservedSeats

              },
               
                new MenuSection()
                {
                  sectionName = "Выход",
                  action = OnExit

                }
        };

        public static void ShowMainMenu()
        {
            Navigation.ListNavigation(sections);
        }

        public static void OnExit()
        {
            Environment.Exit(0);
        }


    }
}
