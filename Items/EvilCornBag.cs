using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EvilCornBag : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;

			item.rare = 9;
			item.expert = true;
			bossBagNPC = mod.NPCType("EvilCorn");
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("Right click to open");
		}


		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			if (Main.rand.Next(7) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("EvilCornMask"));
			}
			if (Main.rand.Next(10) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("EvilCornTrophy"));
			}
			if (Main.rand.Next(1) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("CornHeater"));
			}
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("GrayKnightHelmet"));
			}
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("GrayKnightBreastplate"));
			}
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("KnightGreaves"));
			}
			if (Main.rand.Next(3) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("CornSword"));
			}
			if (!Main.player[Main.myPlayer].HasItem(mod.ItemType("FarmerShovel")))
			{
				player.QuickSpawnItem(mod.ItemType("FarmerShovel"));
			}
			player.QuickSpawnItem(mod.ItemType("Corn"), Main.rand.Next(25, 48));
			player.QuickSpawnItem(mod.ItemType("CornJavelin"), Main.rand.Next(15, 45));
		}

	}
}
