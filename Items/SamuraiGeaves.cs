using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Legs)]
	public class SamuraiGeaves : ModItem
	{


		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 18;

			item.value = 100000;
			item.rare = 5;
			item.defense = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Samurai Legguards");
			Tooltip.SetDefault("Increases movement speed by 50%");
		}


		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.5f;
		}
	}
}
