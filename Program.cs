using _1_InlämningsuppgiftCesharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_InlämningsuppgiftCesharp
{
    internal class Program
    {
        static void Main(string[] args)

           
        {


            Console.WriteLine("  Välkommen till dagensfest! \n  Välj en av följande och gör en dubbel enter!");

            Console.WriteLine("  1. lägg till en deltagare");
            Console.WriteLine("  2. ta bort en deltagare");
            Console.WriteLine("  3. Lista upp alla deltagare");
            Console.WriteLine("  4. skapa en rabattkod");
            Console.WriteLine("  0. Avsluta Programmet");
            string inmmatad = Console.ReadLine();
            int x = int.Parse(inmmatad);

             Console.ReadKey();


            List<DeLtagarLista> list = new List<DeLtagarLista>(20);


            if (x == 1)
                {
                    
                    
                        

                        for (int i = 0; i < 1; i++)
                        {
                            Console.WriteLine("Skriv ditt för och efternamn ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Skriv ditt Mail ");
                            string mail = Console.ReadLine();

                            DeLtagarLista info = new DeLtagarLista(name, mail);
                            list.Add(info);

                        }
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i].ToString());

                        }

                Console.ReadKey();
          
                }
              else if(x == 2)
            {

                Console.WriteLine("Skriv ditt för och efternamn ");
                string name = Console.ReadLine();
                Console.WriteLine("Skriv ditt Mail ");
                string mail = Console.ReadLine();
                Console.WriteLine(" Ditt namn tagis bort från listan");
                Console.ReadKey();

            }
            else if (x == 3)
            {

                List<string> data = new List<string>();
                data.Add("Johan Andersson, Hohan.an@gmail.com \n" +
                    " Lars  Erik, Lars.ek@gmail.com \n " +
                    "anna samuellson,hann.sa@gmail.com \n" +
                    " Ali   rsson, Ali.resson@gmail.com \n" +
                    " Johan Andersson, Hohan.an@gmail.com \n" +
                    " Bagher.hasani, bagher.has@gmmail.com");


                foreach (string s in data)
                {
                    Console.WriteLine(s);
                    Console.ReadKey();
                }
            }
            else if (x == 4)
            {
                Console.WriteLine(" Här kommer ditt rabattkod som du kan avnända till nästa kommande fest  \n Jul-2021-15%");
                Console.ReadKey();
            }
            else if( x == 0)
            {
                Console.WriteLine("Programmet är avslutad");
            }


           
        } 
}   }