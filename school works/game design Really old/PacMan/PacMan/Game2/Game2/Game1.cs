using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace PacManMaster
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        GameManager gameManager;
        public int scorefood = 0;
        public int deathCount = 0;
        public int foodlist = 0;
        //  public int scoresuperfood = 0;

        public Game1()
        {
            this.IsMouseVisible = true;
            graphics = new GraphicsDeviceManager(this);
 //           Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            gameManager = new GameManager(this);
            Components.Add(gameManager);
            gameManager.Enabled = true;
            gameManager.Visible = true;
            
            // TODO: Add your initialization logic here

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

            // TODO: use this.Content to load your game content here
 //       score = Content.Load<SpriteFont>(@"font\score");
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
  
            //            spriteBatch.Draw(Background, Vector2.Zero, Color.White);
            //            foreach (Sprite s in paddles)
            //            {
            //                s.Draw(spriteBatch, gameTime);
            //            }
            // TODO: Add your drawing code here
/*            if (deathCount == 4)
            {
                spriteBatch.DrawString(score, "You Lose", new Vector2(600, 160), Color.Black);
            }

            if (foodlist == 1)
            {
                spriteBatch.DrawString(score, "You Win", new Vector2(600, 260), Color.Black);
            }

            spriteBatch.DrawString(score, "Score: " + scorefood, new Vector2(600, 400), Color.Black);
 */           spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
