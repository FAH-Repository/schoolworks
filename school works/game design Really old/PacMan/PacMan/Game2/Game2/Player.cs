using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    class Player : Sprite
    {
        GameManager myGame;
        float speed;
        Vector2 direction;
        public bool dead = false;
        public int deathCount = 0;

        public Player(Texture2D tex, Vector2 pos, GameManager mygame) : base(tex, pos)
        {
            myGame = mygame;
            AddAnimations(tex);
            rotationCenter = new Vector2(15, 15);
            speed = 4;
        }

        public override void Update(GameTime gameTime)
        {
            if (dead)
            {
                dead = false;
                 deathCount++;
                switch (new Random().Next(5))
                {
                    case 0:
                        position = new Vector2(60, 60);
                        break;
                    case 1:
                        position = new Vector2(480, 60);
                        break;
                    case 2:
                        position = new Vector2(60, 390);
                        break;
                    case 3:
                        position = new Vector2(480, 390);
                        break;
                    // working on 
                }
            }

            if (direction.X == 1)
            {
                if ((int)((position.X + speed) / 30) > (int)(position.X / 30))
                {
                    position.X += 30 - (position.X % 30);
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
                }
                if (position.Y % 30 == 0 && position.Y > 0)
                {
                    if (myGame.map[(int)position.Y / 30 - 1][(int)position.X / 30] != '.')
                    {
                        direction.Y = 0;
                    }
                }
            }

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                if (position.Y % 30 == 0 && position.X % 30 == 0 && position.X < 540)
                {
                    if (myGame.map[(int)position.Y / 30][(int)position.X / 30 + 1] == '.')
                    {
                        rotation = 90 * (float)Math.PI / 180;
                        direction.X = 1;
                        direction.Y = 0;
                    }
                }
            }

            // left
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                if (position.Y % 30 == 0 && position.X % 30 == 0 && position.X >0)
                {
                    if (myGame.map[(int)position.Y / 30][(int)position.X / 30 - 1] == '.')
                    {
                        rotation = 270 * (float)Math.PI / 180;
                        direction.X = -1;
                        direction.Y = 0;
                    }
                }
            }

            //down
            if (keyboardState.IsKeyDown(Keys.Down))
            {
                if (position.Y % 30 == 0 && position.X % 30 == 0 && position.Y < 450)
                {
                    if (myGame.map[(int)position.Y / 30+1][(int)position.X / 30] == '.')
                    {
                        rotation = 180 * (float)Math.PI / 180;
                        direction.X = 0;
                        direction.Y = 1;
                    }
                }
            }

            //up
            if (keyboardState.IsKeyDown(Keys.Up))
            {
                if (position.Y % 30 == 0 && position.X % 30 == 0 && position.Y > 0)
                {
                    if (myGame.map[(int)position.Y / 30-1][(int)position.X / 30] == '.')
                    {
                        rotation = 360 * (float)Math.PI / 180;
                        direction.X = 0;
                        direction.Y = -1;
                    }
                }
            }

            position += direction * speed;

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
            AddAnimation("IDLE", tex, new Point(30, 30), new Point(1, 1), Point.Zero, 0);
            SetAnimation("IDLE");
        }
    }
}
