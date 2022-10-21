using System;
using Terraria;
using Terraria.ModLoader;

namespace AplusKCreates.Buffs
{
    public class OneWithTheOcean : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("One With the Ocean");
			Description.SetDefault("Grant infinite breath underwater\nIncreased attack, defense, and regeneration while submerged\nIncreased swim speed in liquids\nYou glow while submerged\n");
			Main.debuff[Type] = false;
			Main.buffNoSave[Type] = false;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 4;
            player.GetModPlayer<AplusKPlayer>().oneWithTheOcean = true;
        }
    }
}