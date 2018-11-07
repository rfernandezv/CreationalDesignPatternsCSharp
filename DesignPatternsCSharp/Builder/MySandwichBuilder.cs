using System.Collections.Generic;

namespace DesignPatternsCSharp.Builder
{

	public class MySandwichBuilder : SandwichBuilder
	{

		public override void prepareBread()
		{

			sandwich.BreadType = BreadType.White;
			sandwich.Toasted = true;
		}

		public override void applyMeatAndCheese()
		{
			sandwich.CheeseType = CheeseType.Cheddar;
			sandwich.MeatType = MeatType.Chicken;
		}

		public override void applyVegetables()
		{
			sandwich.Vegetables = new List<string> {"Tomato", "Onion"};
		}

		public override void addCondiments()
		{
			sandwich.HasMayo = false;
			sandwich.HasMustard = true;
		}
	}
}