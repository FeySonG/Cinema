using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class SelectMovies
    {
      
      // public string 
        public static List<MenuSection> selectMovies = new List<MenuSection>
        {
            new MenuSection
            {
                sectionName =  "Джон Уик 4",
                sectionDate = DateTime.Now,
               
                price = 300,
                action = Reservation.ShowSeatReservationMenu

            },
            new MenuSection 
            {
                sectionName = "Стражи Галактики 2",
                sectionDate = DateTime.Now,
               
                price = 300,
                 action = Reservation.ShowSeatReservationMenu
            },
            new MenuSection 
            {
                sectionName = "Кунг фу жеребец",
                sectionDate = DateTime.Now,
               
                price = 300,
                 action = Reservation.ShowSeatReservationMenu

            },
            new MenuSection 
            {
                sectionName = "Горбатая гора",
                sectionDate = DateTime.Now,
                
                price = 300,
                 action = Reservation.ShowSeatReservationMenu


            },
            new MenuSection
            {
                sectionName = "Неудержимые 4",
                sectionDate = DateTime.Now,
                
                price = 300,
                 action = Reservation.ShowSeatReservationMenu


            },
            new MenuSection
            {
                sectionName = "Поехавшая",
                sectionDate = DateTime.Now,
                
                price = 300,
                 action = Reservation.ShowSeatReservationMenu


            },
            new MenuSection
            {
                sectionName = "Человек паук",
                sectionDate = DateTime.Now,
                
                price = 300,
                 action = Reservation.ShowSeatReservationMenu

            },
            new MenuSection
            {
                sectionName = "Переводчик",
                sectionDate = DateTime.Now,
                
                price = 300,
                 action = Reservation.ShowSeatReservationMenu


            },
            new MenuSection
            {
                sectionName = "Кунг фу жеребец",
                sectionDate = DateTime.Now,
                
                price = 300,
                 action = Reservation.ShowSeatReservationMenu

            },
             new MenuSection
            {
                sectionName = "Вернуться назад",
               action = MainMenu.ShowMainMenu


            }

        };

        public static void ShowMovies()
        {
            Reservation.index = 2;
            Navigation.ListNavigation(selectMovies);
        }

       
       

    }
}
