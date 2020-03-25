﻿namespace Miki.Services.Rps
{
    using Miki.Bot.Models.Attributes;

    [Entity("weapon")]
    public class RpsWeapon
	{
		public string Name;
		public string Emoji;

        public RpsWeapon(string name, string emoji = null)
		{
			Name = name;
			Emoji = emoji;
		}
    }
}