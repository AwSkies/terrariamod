using Terraria;
using Terraria.ModLoader;

namespace AplusKCreates.Items.Accessories
{
    public class UrchinCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Infused with the vitality of the sea");
        }

        public override void SetDefaults()
        {
            item.width = 27;
            item.height = 28;
            item.accessory = true;
            item.value = Item.sellPrice(gold: 1, silver: 50);
            item.rare = 3;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<AplusKPlayer>().urchinCharm = true;
        }
    }
}