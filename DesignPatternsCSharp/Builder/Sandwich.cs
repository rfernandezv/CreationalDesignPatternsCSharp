using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatternsCSharp.Builder
{

	public class Sandwich
	{
        private BreadType breadType;
        private Boolean isToasted;
        private CheeseType cheeseType;
        private MeatType meatType;
        private Boolean hasMustard;
        private Boolean hasMayo;
        private IList<string> vegetables;

        public BreadType BreadType
        {
            get
            {
                return breadType;
            }
            set
            {
                this.breadType = value;
            }
        }


        public bool Toasted
        {
            get
            {
                return isToasted;
            }
            set
            {
                this.isToasted = value;
            }
        }


        public CheeseType CheeseType
        {
            get
            {
                return cheeseType;
            }
            set
            {
                this.cheeseType = value;
            }
        }


        public MeatType MeatType
        {
            get
            {
                return meatType;
            }
            set
            {
                this.meatType = value;
            }
        }


        public bool HasMustard
        {
            get
            {
                return hasMustard;
            }
            set
            {
                this.hasMustard = value;
            }
        }


        public bool HasMayo
        {
            get
            {
                return hasMayo;
            }
            set
            {
                this.hasMayo = value;
            }
        }


        public IList<string> Vegetables
        {
            get
            {
                return vegetables;
            }
            set
            {
                this.vegetables = value;
            }
        }

        public void display()
		{

            Console.WriteLine($"Sandwich on {breadType} bread\n");
            if (isToasted)
			{
                Console.WriteLine("Toasted \n");
			}
			if (hasMayo)
			{
                Console.WriteLine("With Mayo \n");
			}
			if (hasMustard)
			{
                Console.WriteLine("With Mustard\n");
			}

            Console.WriteLine($"Meat: {meatType}\n");
            Console.WriteLine($"Cheese: {cheeseType}\n");
            Console.WriteLine("Veggies: \n");
			foreach (string vegetable in vegetables)
			{
                Console.WriteLine($"   {vegetable}\n", vegetable);
			}
            Console.WriteLine("******************************\n\n");
		}
	}
}