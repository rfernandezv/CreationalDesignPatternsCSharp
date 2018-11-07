using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatternsCSharp.Prototype
{
    class PrototypeTest
    {
        static void Main(string[] args)
        {
            Registry registry = new Registry();
            Movie movie = (Movie)registry.createItem("Movie");
            movie.title = "Creational Patterns in Java";
            Console.WriteLine(movie);
            Console.WriteLine(movie.runtime);
            Console.WriteLine(movie.title);
            Console.WriteLine(movie.price);

            Console.WriteLine("*******************************************");

            Movie anotherMovie = (Movie)registry.createItem("Movie");
            anotherMovie.title = "Gang of Four";
            Console.WriteLine(anotherMovie);
            Console.WriteLine(anotherMovie.runtime);
            Console.WriteLine(anotherMovie.title);
            Console.WriteLine(anotherMovie.price);
            Console.ReadKey();
        }
    }
}
