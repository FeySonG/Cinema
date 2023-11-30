using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Program
    {

      

        
       
       
        static void Main(string[] args)
        {
          Console.CursorVisible = false;

             Navigation.Greetings();
             MainMenu.ShowMainMenu() ;

            Console.ReadKey();
           
            
        }
    }
}
