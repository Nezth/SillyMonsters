using System;

namespace Monsters
{
	public class Dragon : Monster
	{
		public Dragon () : base(200)
		{
		}

		public override string GetName() {
			return "Dragon";
		}
	}
}

