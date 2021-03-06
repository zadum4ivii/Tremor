using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class NecroShield : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 30;
			item.value = 110;
			item.rare = 0;
			item.accessory = true;
			item.defense = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Necro Shield");
			Tooltip.SetDefault("Increases minion damage by 10%\nIncreases magic critical strike chance by 10");
		}

		public override void UpdateEquip(Player player)
		{
			player.magicCrit += 10;
			player.minionDamage += 0.1f;
		}

	}
}
