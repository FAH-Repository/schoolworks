using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Bricks.Collision;

namespace Bricks {
    public class Paddle : Sprite {
        public Segment paddleLeft, paddleRight, paddleTop;
        Game1 myGame;

        public Paddle(Texture2D tex, Vector2 pos, Game1 mygame) : base(tex, pos) {
            myGame = mygame;
            AddAnimations(tex);
        }
        public override void Update(GameTime gameTime) {
            if (keyboardState.IsKeyDown(Keys.A) && !CheckSegmentSegmentCollision(paddleLeft, myGame.mapSegments[1])) {
                if (keyboardState.IsKeyDown(Keys.LeftShift)) {
                    position.X -= 10;
                }
                else {
                    position.X -= 6;
                }
            }
            if (keyboardState.IsKeyDown(Keys.D) && !CheckSegmentSegmentCollision(paddleRight, myGame.mapSegments[0])) {
                if (keyboardState.IsKeyDown(Keys.LeftShift))
                {
                    position.X += 10;
                }
                else
                {
                    position.X += 6  ;
                }
            }
            Vector2 a = new Vector2(position.X, position.Y + 50);
            Vector2 b = position + new Vector2(50, 0);
            Vector2 c = new Vector2(position.X + 100, position.Y);
            Vector2 d = new Vector2(position.X + 150, position.Y + 50);
            paddleLeft = new Segment(a, b);
            paddleRight = new Segment(c, d);
            paddleTop = new Segment(b, c);

            base.Update(gameTime);
        }
        public override void AddAnimations(Texture2D tex) {
            AddAnimation("IDLE", tex, new Point(150, 50), new Point(1, 1), new Point(0, 0), 1000);
            SetAnimation("IDLE");
        }
    }
}

