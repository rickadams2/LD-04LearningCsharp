using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLoopsDesisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate("Firstname ", "Lastname");
            // string word = Concatenate  ("First", " Lastname");
            Console.WriteLine(Concatenate("First",  "Last" ));
            Console.ReadLine(); 

            #region Data types

            #endregion

            #region Loops 
            #endregion

            #region Decision structure 
            #endregion
        }
        // A non-returning funcion that concatenates to strings and just displays the result in screen 
        //static public void Concatenate(string first, string last)
        //{
        //    string whole = first + last;
        //    Console.WriteLine(whole);
        //    Console.ReadLine(); 
        //}


        // A non-returning funcion that concatenates two strings and the result
        static string Concatenate(string first, string last)
        {
            string whole = first + last;
            return whole; 
        }


        }
    }

