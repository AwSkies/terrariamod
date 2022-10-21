using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AplusKCreates.Projectiles
{
    public class SpikyGrenade
    {
        public override SetDefaults()
        {
            projectile.name = "Spiky Grenade";
            projectile.width = /*actual size minus 5*/0;
            projectile.height = /*actual size minus 5*/0;
            drawOffsetX = 5;
			drawOriginOffsetY = 5;

            projectile.timeLeft = 180; //3 second fuse
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.aiStyle = 16; //grenade and bombs bouncing AI style
            projectile.aiType = 30; //grenade AI type
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection) 
        {
			// Vanilla explosions do less damage to Eater of Worlds in expert mode
			if (Main.expertMode && (target.type >= NPCID.EaterofWorldsHead && target.type <= NPCID.EaterofWorldsTail)) {
                damage /= 5;
			}
		}

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(SoundID.Item13, projectile.position); //explosion noise
            //smoke dust
			for (int i = 0; i < 50; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 100, default(Color), 2f);
				Main.dust[dustIndex].velocity *= 1.4f;
			}
            //spawn urchin spines
            for (int i = 0; i < 5; i++) {
                Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
                Projectile.NewProjectile(projectile.Center, vel, ProjectileType<Projectiles.UrchinSpine>(), projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
			}
        }
    }
}