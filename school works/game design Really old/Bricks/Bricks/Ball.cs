using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Bricks.Collision;

namespace Bricks {
    public class Ball : Sprite {
        Game1 myGame;
        Vector2 direction;
        float speed, defaultSpeed;

        public Ball(Texture2D tex, Vector2 pos, Game1 mygame) : base(tex, pos) {
            myGame = mygame;
            AddAnimations(tex);
            defaultSpeed = 5;
            speed = 0;
            direction.X = (float)mygame.rng.NextDouble() * 2 - 1;
            direction.Y = (float)mygame.rng.NextDouble() - 1;
        }
        public override void Update(GameTime gameTime) {
            direction = GetUnitVector(direction);
            position += direction * speed;

            circle ball;
            ball.P = position + new Vector2(currentAnimation.frameSize.X / 2, currentAnimation.frameSize.Y / 2);
            ball.R = currentAnimation.frameSize.X / 2;

            foreach (Segment s in myGame.mapSegments) {
                if (CheckCircleSegmentCollision(ball, s)) {
                    speed *= 1.01f;
                    direction = GetReflectedVector(direction, s.GetVector());
                    position += direction * speed;
                }
            }
            if (CheckCircleSegmentCollision(ball, myGame.paddle.paddleLeft)) {
                speed *= 1.01f;
                direction = GetReflectedVector(direction, myGame.paddle.paddleLeft.GetVector());
                position += direction * speed;
            }
            if (CheckCircleSegmentCollision(ball, myGame.paddle.paddleRight)) {
                speed *= 1.01f;
                direction = GetReflectedVector(direction, myGame.paddle.paddleRight.GetVector());
                position += direction * speed;
            }
            foreach (Brick b in myGame.bricks) {
                if (GetMagnitude(b.brick.P - ball.P) <= b.brick.R + ball.R) {
                    b.HitBrick();
                    direction = GetReflectedVector(direction, GetVectorNormal(b.brick.P - ball.P));
                    position += direction * speed;
                }
            }
            if (CheckCircleSegmentCollision(ball, myGame.paddle.paddleTop)) {
                /*speed = 0;
                direction.Y = -1;
                direction.X = 0;*/
                speed *= 1.01f;
                direction = GetReflectedVector(direction, myGame.paddle.paddleTop.GetVector());
                position += direction * speed;
                position.Y = (float)(myGame.paddle.GetPosition().Y - ball.R * 2 - 1);
            }

            if (speed == 0 && position.X < 650) {
                position.X = myGame.paddle.paddleLeft.p2.X + 65;
            }
            if (speed == 0 && position.X < 650 && keyboardState.IsKeyDown(Keys.Space)) {
                speed = defaultSpeed;
            }
            if (speed > 7.5) speed = 7.5f;
            if (position.X > 650) {
                position = new Vector2(400, 400);
            }
            base.Update(gameTime);
        }
        public override void AddAnimations(Texture2D tex) {
            AddAnimation("IDLE", tex, new Point(20, 20), new Point(1, 1), new Point(0, 0), 1000);
            SetAnimation("IDLE");
        }
    }
}
