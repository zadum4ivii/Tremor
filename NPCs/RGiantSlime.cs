using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs
{

	public class RGiantSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Slime");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1000;
			npc.damage = 100;
			npc.defense = 30;
			npc.knockBackResist = 0.3f;
			npc.width = 70;
			npc.alpha = 175;
			npc.color = new Color(255, 30, 0, 100);
			npc.height = 46;
			animationType = 244;
			npc.aiStyle = 1;
			aiType = 138;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
		}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hitDirection, -2.5f, 0, Color.Red, 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hitDirection, -2.5f, 0, Color.Red, 0.7f);
				}
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hitDirection, -2.5f, 0, Color.Red, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hitDirection, -2.5f, 0, Color.Red, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 4, 2.5f * hitDirection, -2.5f, 0, Color.Red, 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 1, 2.5f * hitDirection, -2.5f, 0, Color.Red, 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = Main.tile[x, y].type;
			return Main.hardMode && NPC.downedMoonlord && !spawnInfo.player.ZoneDungeon && y > Main.rockLayer ? 0.1f : 0f;
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;
				if (Main.rand.Next(1) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 23);
				};
			}
		}

	}
}