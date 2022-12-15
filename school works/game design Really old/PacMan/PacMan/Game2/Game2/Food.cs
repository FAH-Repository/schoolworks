using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    class Food : Sprite
    {
        protected GameManager myGame;
        public bool deleteMe = false;
        float myscale = 1;
        public Food (Texture2D tex, Vector2 pos, GameManager mygame): base(tex, pos)
        {
            myGame = mygame;
            AddAnimations(tex);
            rotationCenter = new Vector2(2.5f, 2.5f);
        }
        public override void Update(GameTime gameTime)
        {
            if (Collision.GetMagnitude((myGame.player.GetPosition() + myGame.player.rotationCenter) - (position + rotationCenter)) <= 17.5)
            {
                deleteMe = true;
                //myGame.score +=10;
            }
            rotation += .1f;
            scale += (myscale * .1f);
            if (scale > 3 || scale < .5f) myscale *= -1;

            base.Update(gameTime);
        }
        public override void AddAnimations(Texture2D tex)
        {
            AddAnimation("IDLE", tex, new Point(5, 5), new Point(1, 1), Point.Zero, 0);
            SetAnimation("IDLE");
        }
    }
}
