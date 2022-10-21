using Terraria.ModLoader;

namespace AplusKCreates.Items 
{
    public class UrchinFibers : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sticky but strong");
        }

        public override void SetDefaults()
        {
            item.width = 0/*replace*/;
            item.height = 0/*replace*/;
            item.rare = 0;
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 1);
        }
    }
}