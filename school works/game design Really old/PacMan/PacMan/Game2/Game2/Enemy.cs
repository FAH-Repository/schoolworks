using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    class Enemy : Sprite
    {
        GameManager myGame;
        int speed;
        public Vector2 direction = Vector2.Zero;
        float myscale = 1;

        public Enemy(Texture2D tex, Vector2 pos, GameManager mygame) : base(tex, pos)
        {
            myGame = mygame;
            AddAnimations(tex);
            rotationCenter = new Vector2(15, 15);
            speed = 2;
        }

        public override void Update(GameTime gameTime)
        {
            if (Collision.GetMagnitude(position - myGame.player.GetPosition()) < 30)
            {
                myGame.player.dead = true;
            }
            if (position.X % 30 == 0 && position.Y % 30 == 0)
            {
                Point enemy = new Point((int)position.X / 30, (int)position.Y / 30);
                Point target = new Point((int)myGame.player.GetPosition().X / 30, 
                    (int)myGame.player.GetPosition().Y / 30);
                direction = Pathing.aStar(enemy, target, myGame.map);
                position += direction * speed;
            }
            else
            {
                rotation = (float)Math.Atan2(direction.Y, direction.X);
                //rotation = (float)Math.Atan2(myGame.player.GetPosition().Y - posiion.Y,
                //    myGame.player.GetPosition().X - position.X);

                if (direction.X == 1)
                {
                    if ((int)((position.X + speed) / 30) > (int)(position.X / 30))
                    {
                        position.X += 30 - (position.X % 30);
                        direction.X = 0;
                    }
                    if (position.X % 30 == 0 && position.X < 540)
                    {
                        if (myGame.map[(int)position.Y / 30][(int)position.X / 30 + 1] != '.')
                        {
                            direction.X = 0;
                        }
                    }
                }
                if (direction.X == -1)
                {
                    if ((int)((position.X - speed) / 30) < (int)(position.X / 30))
                    {
                        position.X -= position.X % 30;
                        direction.X = 0;
                    }
                    if (position.X % 30 == 0 && position.X > 0)
                    {
                        if (myGame.map[(int)position.Y / 30][(int)position.X / 30 - 1] != '.')
                        {
                            direction.X = 0;
                        }
                    }
                }
                if (direction.Y == 1)
                {
                    if ((int)((position.Y + speed) / 30) > (int)(position.Y / 30))
                    {
                        position.Y += 30 - (position.Y % 30);
                        direction.Y = 0;
                    }
                    if (position.Y % 30 == 0 && position.Y < 450)
                    {
                        if (myGame.map[(int)position.Y / 30 + 1][(int)position.X / 30] != '.')
                        {
                            direction.Y = 0;
                        }
                    }
                }
                if (direction.Y == -1)
                {
                    if ((int)((position.Y - speed) / 30) < (int)(position.Y / 30))
                    {
                        position.Y -= position.Y % 30;
                        direction.Y = 0;
                    }
                    if (position.Y % 30 == 0 && position.Y > 0)
                    {
                        if (myGame.map[(int)position.Y / 30 - 1][(int)position.X / 30] != '.')
                        {
                            direction.Y = 0;
                        }
                    }
                }
                position += direction * speed;
            }

            if (position.X > 540)
            {
                position.X = 540;
                direction.X = 0;
            }
            if (position.X < 0)
            {
                position.X = 0;
                direction.X = 0;
            }
            if (position.Y > 450)
            {
                position.Y = 450;
                direction.Y = 0;
            }
            if (position.Y < 0)
            {
                position.Y = 0;
                direction.Y = 0;
            }

            base.Update(gameTime);
        }

        public override void AddAnimations(Texture2D tex)
        {
            AddAnimation("IDLE", tex, new Microsoft.Xna.Framework.Point(30, 30), new Microsoft.Xna.Framework.Point(1, 1), Point.Zero, 0);
            SetAnimation("IDLE");
        }
    }
}
               