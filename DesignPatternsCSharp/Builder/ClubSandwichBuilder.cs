using System.Collections.Generic;

namespace DesignPatternsCSharp.Builder
{

	public class ClubSandwichBuilder : SandwichBuilder
	{

		public override void prepareBread()
		{
			sandwich.BreadType = BreadType.White;
			sandwich.Toasted = true;
		}

		public override void applyMeatAndCheese()
		{
			sandwich.CheeseType = CheeseType.Swiss;
			sandwich.MeatType = MeatType.Turkey;
		}

		public override void applyVegetables()
		{
			sandwich.Vegetables = new List<string>{"Tomato", "Onion", "Lettuce"};
		}

		public override void addCondiments()
		{
			sandwich.HasMayo = true;
			sandwich.HasMustard = true;
		}
	}
}