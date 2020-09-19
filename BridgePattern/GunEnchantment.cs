using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
	class GunEnchantment : IEnchantment
	{
		public void Apply()
		{
			Console.WriteLine("The gun automatically loads the bulled");
		}

		public void OnActivate()
		{
			Console.WriteLine("The gun shoots him");
		}

		public void OnDeactivate()
		{
			Console.WriteLine("The gun is kept down");
		}
	}
}
