using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Builder
{
    class BuilderTest
    {
        static void Main(string[] args)
        {
            SandwichDirector sandwichDirector = new SandwichDirector(new MySandwichBuilder());
            sandwichDirector.buildSandwich();
            Sandwich sandwich1 = sandwichDirector.Sandwhich;
            sandwich1.display();

            SandwichDirector sandwichDirector2 = new SandwichDirector(new ClubSandwichBuilder());
            sandwichDirector2.buildSandwich();
            Sandwich sandwich2 = sandwichDirector2.Sandwhich;
            sandwich2.display();
            Console.ReadKey();
        }
    }
}
