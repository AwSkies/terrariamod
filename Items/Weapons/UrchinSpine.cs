using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AplusKCreates.Items
{
    public class UrchinSpine : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Don't step on it");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.thrown = true;
            item.noMelee = true;
            item.width = 36;
            item.height = 50;
            item.useTime = 15; 
            item.useAnimation = 5;
            item.useStyle = 1;
            item.knockback = 6;
            item.autoReuse = true;
            item.value = Item.buyPrice(silver: 1);
            item.rare = 1;
            item.useSound = SoundID.Item1;
            item.shoot = ProjectileType<Projectiles.UrchinSpine>();
            item.shootSpeed = 8f;
            item.maxStack = 999;
            item.consumable = true;
            item.noUseGraphic = true;
        }
    }
}