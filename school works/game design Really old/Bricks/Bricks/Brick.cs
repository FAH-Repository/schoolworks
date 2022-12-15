using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Bricks.Collision;
using static Bricks.Game1;

namespace Bricks {
    public class Brick : Sprite {
        Game1 myGame;
        ushort HP = 3;
        public circle brick;
        public bool deleteMe = false;

        public Brick(Texture2D tex, Vector2 pos, Game1 mygame, ushort hp) : base(tex, pos) {
            HP = hp;
            myGame = mygame;
            AddAnimations(tex);
            SetAnimation(HP.ToString());
            brick.R = 10;
            brick.P = position + new Vector2((float)brick.R, (float)brick.R);
        }
        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }
        public override void AddAnimations(Texture2D tex) {
            AddAnimation("1", tex, new Point(20, 20), new Point(1, 1), new Point(40, 0), 1000);
            AddAnimation("2", tex, new Point(20, 20), new Point(1, 1), new Point(20, 0), 1000);
            AddAnimation("3", tex, new Point(20, 20), new Point(1, 1), new Point(0, 0), 1000);
        }
        public void HitBrick() {
            HP--;
            Game1.score += 100;
            if (HP <= 0) {
                deleteMe = true;
            }
            else {
                SetAnimation(HP.ToString());
            }
        }
    }
}
