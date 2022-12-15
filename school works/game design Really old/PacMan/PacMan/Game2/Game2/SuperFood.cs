using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    class SuperFood : Food
    {
        public SuperFood (Texture2D tex, Vector2 pos, GameManager mygame): base(tex, pos,mygame)
        {
            rotationCenter = new Vector2(3.5f, 3.5f);
        }
        public override void Update(GameTime gameTime)
        {
            if (Collision.GetMagnitude((myGame.player.GetPosition() + myGame.player.rotationCenter) - (position + rotationCenter)) <= 18.5)
            {
                deleteMe = true;
                // myGame.score +=10;
                myGame.buffActive = 3000;
            }
            base.Update(gameTime);
        }
        public override void AddAnimations(Texture2D tex)
        {
            AddAnimation("IDLE", tex, new Point(7, 7), new Point(1, 1), Point.Zero, 0);
            SetAnimation("IDLE");
        }
    }
}
