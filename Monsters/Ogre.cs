using System;

namespace Monsters
{
	public class Ogre : Monster
	{
		public Ogre () : base(10)
		{
		}

		public override string GetName() {
			return "Ogre"; 
		}
	}
}

