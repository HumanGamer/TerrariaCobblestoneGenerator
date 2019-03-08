using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CobblestoneGenerator.Tiles;
using Terraria.ModLoader;

namespace CobblestoneGenerator.Items
{
	public class ItemCobbleGen : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobblestone Generator");
			Tooltip.SetDefault("Generates Cobblestone!");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 28;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType<TileCobbleGen>();
		}
	}
}
