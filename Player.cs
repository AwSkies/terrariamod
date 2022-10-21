using Terraria;
using Terraria.ModLoader;

namespace AplusKCreates
{
    public class AplusKPlayer : ModPlayer
    {
        public bool oneWithTheOcean;
        public bool urchinCharm;

        public override void ResetEffects()
        {
            oneWithTheOcean = false;
            urchinCharm = false;
        }

        public override void OnHitByNPC(Player player, NPC npc, int damage, bool crit)
        {
            if (urchinCharm) {
                
            }
        }
    }
}