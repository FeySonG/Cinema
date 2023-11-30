using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Reservation
    {




        public static List<MenuSection> seatReservation = new List<MenuSection>
                    {
                      new MenuSection
                      {
                         sectionName = "Забронировать места",
                        action = ShowCinemas
                      },
                      new MenuSection
                      {
                        sectionName = "Ваша бронь",
                        action = ShowReservedSeats


                      },
                      new MenuSection
                      {
                         sectionName = "Вернуться назад",
                         action = BackMenu
                      }
        };




        public static List<MenuSection> cinemas = new List<MenuSection>
        {
            new MenuSection
            {
                sectionName = "Ala-Too",
                address = "Erkindik 53",
                action = PayMent.PayMentMenu
            },
            new MenuSection
            {
                sectionName = "BishkekPark",
                address = "Kievskaya/Isanova",
                action = PayMent.PayMentMenu

            },
            new MenuSection
            {
                sectionName = "DordoyPlaza",
                address = "ibraimova 115",
                action = PayMent.PayMentMenu

            },
            new MenuSection
            {
                sectionName = "Russia",
                address = "chuy 213",
                action = PayMent.PayMentMenu

            },
            new MenuSection
            {
                sectionName = "Вернуться назад",
                action = ShowSeatReservationMenu
            }
        };
        public static void ShowCinemas()
        {
            Navigation.ListNavigation(cinemas);
        }
        public static void ShowSeatReservationMenu()
        {
            Navigation.ListNavigation(seatReservation);
        }
        public static void BackMenu()
        {
            if (index == 1)
            {

                foreach (MenuSection section in Afisha.afishaMovies)
                {
                    if (section.index == 1) { section.index = 0; }
                }
                Afisha.ShowAfisha();
            }
            else if (index == 2)
            {
                foreach (MenuSection section in SelectMovies.selectMovies)
                {
                    if (section.index == 1) { section.index = 0; }
                }
                SelectMovies.ShowMovies();
            }


        }
        public static int index { get; set; }

        public static List<MenuSection> reservedList = new List<MenuSection>
        {
            new MenuSection
            {
                sectionName = "Вернуться назад",
                action = MainMenu.ShowMainMenu
            }
        };
        public static void CheckIndex(List<MenuSection> list1, List<MenuSection> list2)
        {
            MenuSection reserved = new MenuSection();
            foreach (MenuSection section in list1)
            {
                if (section.index == 1)
                {
                    reserved.sectionName += section.sectionName;
                    reserved.sectionDate = section.sectionDate;
                }
            }
            foreach (MenuSection section in list2)
            {
                if (section.index == 1)
                {
                    reserved.sectionTitle += section.sectionName;
                    reserved.address += section.address;
                }
            }
            reservedList.Add(reserved);

        }

        public static void Reserve()
        {
            if (index == 1)

            {
                CheckIndex(Afisha.afishaMovies, Reservation.cinemas);
            }
            else if (index == 2)
            {
                CheckIndex(SelectMovies.selectMovies, Reservation.cinemas);
            }
            
        }


            public static void ShowReservedSeats()
            {
                Navigation.ListNavigation(reservedList);
            }



        
    }
}
