using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AplusKCreates.Items
{
    public class SeaPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Beneficial to any seafarer");
        }

        public override void SetDefaults()
        {
            item.width = /*replace*/0;
            item.height = /*replace*/0;
            item.useStyle = 2;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 1;
            item.value = Item.buyPrice(silver: 25);
            item.buffType = BuffType<Buffs.OneWithTheOcean>(); 
            item.buffTime = 18000; 
        }

        public override void AddRecipes(){
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.SharkFin, 2);
            recipe.AddIngredient(ItemID.Waterleaf, 3);
            recipe.AddIngredient(Item.Trout, 5);
            recipe.AddIngredient(ItemType<Items.BlackMush>());
            recipe.AddTile(13); //placed bottle
            recpie.AddTile(3000); //alchemy table
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}