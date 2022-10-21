using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AplusKCreates.Projectiles
{
    public class UrchinSpine : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Urchin Spine";
            projectile.width = 36;
            projectile.height = 50;
            projectile.aiStyle = 2;
            projectile.friendly = true;
            projectile.thrown = true;
            projectile.penetrate = 1;
            aiType = ProjectileID.Shuriken;
        }
    }
}