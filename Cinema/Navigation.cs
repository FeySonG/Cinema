﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Navigation
    {

      
        
        public static void SelectMenu(int index, List<MenuSection> select)
        {

            // Console.Clear();

            // Console.WriteLine(select[index].sectionName);
           
            foreach (var rasd in select)
            {
                MenuSection.Index(index);

                if (rasd == select[index])
                {   
                    
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    if (rasd.sectionDate == null)
                    {
                        Console.WriteLine(" >> " + rasd.sectionName + "\n" + rasd.address);
                    }
                    else
                    {
                         Console.WriteLine(" >> " + rasd.sectionName + "     {0:M} в {0:t}", rasd.sectionDate);
                    }

                }
                else
                {
                    if (rasd.sectionDate == null)
                    {
                        Console.WriteLine(" " + rasd.sectionName + "\n" + rasd.address);
                    }
                    else
                    {
                        Console.WriteLine(" " + rasd.sectionName + "     {0:M} в {0:t}", rasd.sectionDate);
                    }
                   
                }

                Console.ResetColor();

            }
        }

        public static void ListNavigation(List<MenuSection> list)
        {
          
            int index = 0;
            SelectMenu(index, list);
            ConsoleKeyInfo key;

            do
            {
                
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.DownArrow && index + 1 < list.Count)
                {
                    if (index > list.Count) { index = index - 1; }
                    index++;
                    Console.Clear();
                    SelectMenu(index, list);
                    
                }
                if (key.Key == ConsoleKey.UpArrow && index - 1 >= 0)
                {
                    index--;
                    Console.Clear();
                    SelectMenu(index, list);
                    
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();                    
                    list[index].action();
                    list[index].index = 1;
                    //MenuSection.Index(index);
                    
                 
                    SelectMenu(index, list);

                    index = 0;
                }
            } while (key.Key != ConsoleKey.Enter
            );

            Console.ReadKey();

            


        }
       
        //public static int Indexer( int index)
        //{
        //    return index;
        //}

        public static int inputIndex { get; set; }  
        public static void Greetings()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            string Greting = "████████████████████████████████████████\n████████████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█████████\n█████▀▀░░░░░░░░░░░░░░░░░░░░░░░░░▀███████\r\n████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████\r\n███▀░░░░░▄▄▄░░░░░░░░▄▄▀███▄▄░░░░░░░█████\r\n██░░░░░░▀▀▀███▄▄░░░█▄▄█▀█▀▀▀▀░▀░▄▄░▀▀███\r\n█░░▄▄░▄▄░▄░░░█▀░░░░░░░░░░▀▄▄▄█▀▀▄░▀█░░▀█\r\n█░░░░▄░▀▀░░▄█▀░░░░░░▄▄░░░░░░░▄▄▀██▄░█░░█\r\n██░░░██░░░▀▀█▄░░░▀▀▀▄▀░▄▄▄███▀░▄█░░░▀░▄█\r\n██▄░██▀█▀▄▄▄▄▄█▄▄▄▄▄▀▀█▀░░▄███▀█▀░░░▄▄██\r\n███░████▄█▄░░█░░▄█░░▄▄███▀▀▀█▄▀░░░░▄████\r\n███░▀██████████████▀▀▀▀█░░░▄▀▀░░░░▄█████\r\n███░░██▀█▀██▀█▀░░▀█░░░░█▄█▀░░░░░▄███████\r\n███░░░░▀▀▀██▄██▄▄██▀▀▀▀▀░░░░░▄▄█████████\r\n██▀░░░░░░░░░░░░░░░░░░░░░░▄▄▄████████████\r\n██▄░░░░░░░░░░░░░░░░░░▄▄█████████████████\r\n████▄░░░░░░░░░▄▄▄▄▄█████████████████████\r\n████████████████████████████████████████";
             Console.WriteLine(Greting);
            
            Console.WriteLine(" Добро пожаловать в онлайн Кинотеатр ");
            Thread.Sleep(3000);  
            Console.Clear();
            Console.ResetColor();
        }
        
       


    }
}
