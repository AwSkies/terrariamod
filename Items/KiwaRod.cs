using Terraria;
using Terraria.ModLoader;

namespace AplusKCreates.Items
{
    public class KiwaRod
    {
        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Kiwa's Rod");
			Tooltip.SetDefault("Wait... How do sea urchins fish?");
        }
        
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.GoldenFishingRod);
            item.fishingPole = 43;      
            item.value = Item.buyPrice(silver: 50);
            item.rare = 2;
            item.shoot = mod.ProjectileType<Projectiles.KiwaRodBobber>();
            item.shootSpeed = 10f;
        }
    }
}