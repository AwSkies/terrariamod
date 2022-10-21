using System;
using Terraria;
using Terraria.ModLoader;

namespace AplusKCreates.Items
{
    public class KiwaBag : ModItem
    {
        public override void SetStaticDefaults() 
        {
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

        public override void SetDefaults() 
        {
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 11;
			item.expert = true;
		}
        public override bool CanRightClick() => true;

		public override void OpenBossBag(Player player) {
			player.TryGettingDevArmor();
			player.TryGettingDevArmor();

            //non-guaranteed items
			int mask = Main.rand.Next(7);
			if (mask == 0) { player.QuickSpawnItem(ItemType<KiwaMask>()); } 

            int trophy = Main.rand.Next(10);
            if (trophy == 0) { player.QuickSpawnItem(ItemType<KiwaTrophy>()); }

            int urchinCharm = Main.rand.Next(4);
            if (urchinCharm != 0) { player.QuickSpawnItem(ItemType<Items.Accessories.UrchinCharm>()); }

            int rod = Main.rand.Next(20);
            if (rod == 0) { player.QuickSpawnItem(ItemType<Items.KiwaRod>()); }

            //grenade has an 80% chance of dropping 10-15
            int grenade = Main.rand.Next(5);
            if (grenade != 0) {
                grenadeNum = Main.rand.Next(10, 16);
                player.QuickSpawnItem(ItemType<Items.SpikyGrenade>(), grenadeNum);
            }

            //guarunteed items, just choosing how many to give
            int urchinFibers = Main.rand.Next(6, 11); //gives 6-10
			player.QuickSpawnItem(ItemType<Items.UrchinFibers>(), urchinFibers);

            int blackMush = Main.rand.Next(5, 7); //gives 5-6
			player.QuickSpawnItem(ItemType<Items.BlackMush>(), blackMush);

            int urchinSpines = Main.rand.Next(30, 36); //gives 30-35
            player.QuickSpawnItem(ItemType<Items.Weapons.UrchinSpine>(), urchinSpines);
		}

		public override int BossBagNPC => NPCType<NPCs.Kiwa>();
    }
}