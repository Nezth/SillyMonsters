using System;
using System.Collections.Generic;

namespace Monsters
{
	class MainClass
	{

		public static void Main (string[] args)
		{
		
			List<Monster> monsters = new List<Monster> ();

			monsters.Add (new Dragon ());
			monsters.Add (new Ogre ());

			foreach (Monster m in monsters) {
				Console.WriteLine ("Monster: {0} health: {1}", m.GetName(), m.GetHealth());
			}

			Console.ReadKey ();
		}
	}
}
