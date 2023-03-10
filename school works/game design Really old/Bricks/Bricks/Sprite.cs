using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bricks {
    public class Sprite {
        protected Vector2 position = Vector2.Zero;
        Color washColor = Color.White;
        public struct AnimationSet {
            public string name;
            public Point frameSize;
            public Point sheetSize;
            public Point startPos;
            public int millisecondsPerFrame;
            public Texture2D texture;
        }
        public AnimationSet currentAnimation;
        public List<AnimationSet> animationSets = new List<AnimationSet>();
        Point currentFrame = Point.Zero;
        int timeSinceLastFrame = 0;
        protected KeyboardState keyboardState, prevKeyboardState;
        protected MouseState mouseState, prevMouseState;
        protected GamePadState gamePadState, prevGamePadState;

        public Sprite(Texture2D tex, Vector2 pos) {
            currentAnimation.texture = tex;
            position = pos;
        }
        public virtual void Update(GameTime gameTime) {
            prevKeyboardState = keyboardState;
            prevMouseState = mouseState;
            prevGamePadState = gamePadState;
            keyboardState = Keyboard.GetState();
            mouseState = Mouse.GetState();
            gamePadState = GamePad.GetState(PlayerIndex.One);

            timeSinceLastFrame += gameTime.ElapsedGameTime.Milliseconds;
            if (timeSinceLastFrame >= currentAnimation.millisecondsPerFrame) {
                timeSinceLastFrame -= currentAnimation.millisecondsPerFrame;
                currentFrame.X++;
                if (currentFrame.X == currentAnimation.sheetSize.X) {
                    currentFrame.Y++;
                    currentFrame.X = 0;
                    if (currentFrame.Y == currentAnimation.sheetSize.Y) {
                        currentFrame.Y = 0;
                    }
                }
            }
        }
        public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime) {
            spriteBatch.Draw(currentAnimation.texture, position, new Rectangle(currentAnimation.startPos.X + currentFrame.X * currentAnimation.frameSize.X, currentAnimation.startPos.Y + currentFrame.Y * currentAnimation.frameSize.Y, currentAnimation.frameSize.X, currentAnimation.startPos.Y + currentAnimation.frameSize.Y), washColor);                                                           
        }

        public Vector2 GetPosition() {
            return position;
        }

        public void AddAnimation (string name, Texture2D tex, Point frameSize, Point sheetSize, Point startPos, int millesecondsPerFrame) {
            AnimationSet tempAni;
            tempAni.name = name;
            tempAni.texture = tex;
            tempAni.frameSize = frameSize;
            tempAni.sheetSize = sheetSize;
            tempAni.startPos = startPos;
            tempAni.millisecondsPerFrame = millesecondsPerFrame;
            animationSets.Add(tempAni);
        }
        public void SetAnimation(string setName) {
            if (currentAnimation.name != setName) {
                foreach(AnimationSet a in animationSets) {
                    if (a.name == setName) {
                        currentAnimation = a;
                        currentFrame = Point.Zero;
                    }
                }
            }
        }
        public virtual void AddAnimations(Texture2D tex) { }
        public Rectangle CollisionRect() {
            return new Rectangle((int)position.X, (int)position.Y, currentAnimation.frameSize.X, currentAnimation.frameSize.Y);
        }
    }
}
