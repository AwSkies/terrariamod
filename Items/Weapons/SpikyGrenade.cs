using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AplusKCreates.Items.Weapons
{
    public class SpikyGrenade 
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Made with real sea urchins!");
        } 

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.damage = 60;
            item.thrown = true;
			item.shootSpeed = 6f;
			item.shoot = ProjectileType<Projectiles.SpikyGrenade>();
			item.width = /*replace*/0;
			item.height = /*replace*/0;
			item.maxStack = 99;
			item.consumable = true;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 40;
			item.useTime = 45;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 0, 1, 0);
			item.rare = 0;
        }

        public override void AddRecipes() 
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Grenade);
            repice.AddIngredient(ItemType<Items.Weapons.UrchinSpine>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}