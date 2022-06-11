using System;
using System.Collections.Generic;

namespace MvcApi.Model
{

     class Movie
    {
        public int Title { get; set; }
        public string Overview { get; set; }
        public string Orginal_language { get; set; }
        //public virtual ICollection<Actor> Actors { get; set; }

        public static int SearchForMoviByid()
        {
            while (true)
            {
                Console.Write("Enter Id for a movie:");
                if(int.TryParse(Console.ReadLine(), out int movieId))
                {
                    return movieId;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void DisplayMovie()
        {
            Console.Clear();
            Console.WriteLine("⁄Title: {0}", Title);
            Console.WriteLine("⁄Language: {0}", Orginal_language);
            Console.WriteLine("⁄overview: {0}", Overview);
        }

        }
    }

