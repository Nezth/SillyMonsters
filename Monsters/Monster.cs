using System;

namespace Monsters
{
	public class Monster
	{
		private int health;

		protected Monster (int h)
		{
			health = h;
		}

	
		public int GetHealth() {
			return health;
		}

		public virtual string GetName() {
			return "just a monster...";
		}
	}
}

