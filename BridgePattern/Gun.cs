using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
	public class Gun : IWeapon
	{
		private readonly IEnchantment _enchantment;


		public Gun(IEnchantment enchantment)
		{
			_enchantment = enchantment;
		}

		public IEnchantment GetEnchantment()
		{
			return _enchantment;
		}

		public void Swing()
		{
			Console.WriteLine("THe gun is swinged like rajini movie");
			_enchantment.Apply();
		}

		public void Unwield()
		{
			Console.WriteLine("THe gun is unwielded");
			_enchantment.OnDeactivate();
		}

		public void Wield()
		{
			Console.WriteLine("The gun is weilded");
			_enchantment.OnActivate();
		}
	}
}
