using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using static Bricks.Collision;
using static Bricks.Brick;

namespace Bricks
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D bricksTex, ballTex, background, paddleTex;
        SpriteFont pongFont;
        public static int score;
        public Paddle paddle;
        public List<Segment> mapSegments = new List<Segment>();
        public List<Brick> bricks = new List<Brick>();
        public List<Ball> ball = new List<Ball>();
        public Random rng = new Random();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            mapSegments.Add(new Segment(new Vector2(650, 480), new Vector2(649, 0)));
            mapSegments.Add(new Segment(new Vector2(1,0), new Vector2(0,480)));
            mapSegments.Add(new Segment(new Vector2(649,0), new Vector2(1,0)));

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            paddleTex = Content.Load<Texture2D>(@"Images/BlackPaddle");
            ballTex = Content.Load<Texture2D>(@"Images/ball");
            bricksTex = Content.Load<Texture2D>(@"Images/brick");
            background = Content.Load<Texture2D>(@"Images/BackR");
            paddle = new Paddle(paddleTex, new Vector2(250, 400), this);
            pongFont = Content.Load<SpriteFont>(@"Fonts/pongFont");
            for (int i = 5; i > 0; i--) {
                ball.Add(new Ball(ballTex, new Vector2(650 + 20 * i, 450), this));
            }
            SpawnBricks();
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            paddle.Update(gameTime);
            if (ball.Count > 0) {
                if (ball[0].GetPosition().Y > 500) {
                    ball.RemoveAt(0);
                }
            }
            if (ball.Count > 0) {
                ball[0].Update(gameTime);
            }

            for (int i = 0; i < bricks.Count; i++) {
                if (bricks[i].deleteMe) {
                    bricks.RemoveAt(i);
                    i--;
                } else {
                    bricks[i].Update(gameTime);
                }
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch.Draw(background, Vector2.Zero, Color.White);
            paddle.Draw(spriteBatch, gameTime);
            foreach (Ball b in ball) {
                b.Draw(spriteBatch, gameTime);
            }
            foreach (Brick b in bricks) {
                b.Draw(spriteBatch, gameTime);
            }
            if (ball.Count == 0) {
                spriteBatch.DrawString(pongFont, "You Lose!", new Vector2(285, 240), Color.Black);
            }
            if (bricks.Count == 0) {
                spriteBatch.DrawString(pongFont, "You Win!", new Vector2(285, 240), Color.Black);
            }
            spriteBatch.DrawString(pongFont, "Score: ", new Vector2(650, 10), Color.Black);
            spriteBatch.DrawString(pongFont, score.ToString(), new Vector2(650, 60), Color.Black);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }

        void SpawnBricks() {
            int width = 11;
            int height = 29;
            ushort[,] brickspawn;

            brickspawn = Maps.GetBrickArray(Maps.BasicLines());

            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    if (brickspawn[y, x] > 0) {
                        bricks.Add(new Brick(bricksTex, new Vector2(y * 20 + 30, x * 20 + 30), this, brickspawn[y, x]));
                    }
                }
            }
        }
    }
}
