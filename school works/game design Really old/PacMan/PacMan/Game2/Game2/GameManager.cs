using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Audio;

namespace PacManMaster
{
    class GameManager : DrawableGameComponent
    {
        /// <summary>
        SpriteFont score;
 //       GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public int scorefood = 0;
        public int deathCount = 0;
 //       public int foodlist = 0;
        /// </summary>
   
        public List<string> map = new List<string>();
        List<Tiles> mapTiles = new List<Tiles>();
        List<Food> foodList = new List<Food>();
     // add class to add walls
        List<Wall> wallList = new List<Wall>();
        List<Enemy> enemyList = new List<Enemy>();
        List<Player> playerList = new List<Player>();
            
            Texture2D backgroundTex, playerTex, foodTex, superFoodTex, enemyTex, wallTex, particleTex;
        public Player player;
        public int buffActive = 0;
        //Sounds
        SoundEffect eatsoundEffect, startsound, powersound, losesound;


        public GameManager (Game1 game) : base(game)
        {
            Game.Content.RootDirectory = "Content";
        }

        public override void Initialize()
        {
            map = MapGen();
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);
            backgroundTex = Game.Content.Load<Texture2D>(@"Images\MapBackground30x30");
            playerTex = Game.Content.Load<Texture2D>(@"Images\charUp");
            foodTex = Game.Content.Load<Texture2D>(@"Images\SuperFood.");
            superFoodTex = Game.Content.Load<Texture2D>(@"Images\Food");
            enemyTex = Game.Content.Load<Texture2D>(@"Images\EnemySprite30x30");

            wallTex = Game.Content.Load<Texture2D>(@"Images\WallTile30x30");


            for (int i = 0; i< map.Count; i++)
            {
                for (int j = 0; j< map[0].Length; j++)
                {
                    if (map[i][j] == 'P')
                    {
                        player = new Player(playerTex, new Vector2(j * 30, i * 30), this);
                        map[i] = map[i].Substring(0, j) + '.' + map[i].Substring(j + 1);
                    }

                    if (map[i][j] == 'E')
                    {
                        enemyList.Add(new Enemy(enemyTex, new Vector2(j * 30, i * 30), this));
                        // map [i][j] = '.'; // THIS CAN'T WORK!!!
                        map[i] = map[i].Substring(0, j) + '.' + map[i].Substring(j + 1);
                    }
               //walls
                    if (map[i][j] == 'W')
                    {
                        wallList.Add(new Wall(wallTex, new Vector2(j * 30 + 12, i * 30 + 12), this));
                    }

                    if (map[i][j] == '.')
                    {
                        foodList.Add(new Food(foodTex, new Vector2(j * 30 + 12, i * 30 + 12), this));
                    }

                    if (map[i][j] == 'S')
                    {
                        foodList.Add(new SuperFood(superFoodTex, new Vector2(j * 30 + 11, i * 30 + 11), this));
                        map[i] = map[i].Substring(0, j) + '.' + map[i].Substring(j + 1);
                    }
                    mapTiles.Add(new Tiles(backgroundTex, new Vector2(j * 30, i * 30), map[i][j].ToString()));

                }
            }


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
            score = Game.Content.Load<SpriteFont>(@"font\score");
            eatsoundEffect = Game.Content.Load<SoundEffect>(@"GameSounds\PelletEat1");
            startsound = Game.Content.Load<SoundEffect>(@"GameSounds\Intro");
            powersound = Game.Content.Load<SoundEffect>(@"GameSounds\Siren");
            losesound = Game.Content.Load<SoundEffect>(@"GameSounds\PacmanEaten");
        }
        public override void Update(GameTime gameTime)
        {
            player.Update(gameTime);
            if (buffActive > 0)
            {
                buffActive -= gameTime.ElapsedGameTime.Milliseconds;
            }
            else
            {
                foreach (Enemy e in enemyList)
                {
                    e.Update(gameTime);
                }
            }
            for (int i = 0; i < foodList.Count; i++)
            {
                if (foodList[i].deleteMe)
                {
                    eatsoundEffect.Play();
                    foodList.RemoveAt(i);
                    i--;
                    scorefood++;

                }
                else
                {
                    foodList[i].Update(gameTime);
                }
            }

           if (player.dead == true)
                    {

                        deathCount++;
                    }

 
                base.Update(gameTime);
            }

        public override void Draw(GameTime gameTime)
        {
            ///
            ///    
            spriteBatch.Begin();
            
            foreach(Tiles t in mapTiles)
            {
                t.Draw(spriteBatch, gameTime);
            }
            foreach(Food f in foodList)
            {
                f.Draw(spriteBatch, gameTime);
            }
            foreach(Enemy e in enemyList)
            {
                e.Draw(spriteBatch, gameTime);
            }
            player.Draw(spriteBatch, gameTime);

            if (deathCount >= 5)
            {
                spriteBatch.DrawString(score, "You Lose", new Vector2(600, 160), Color.Red);
                losesound.Play();
            }

            if (scorefood >=192)
            {
                spriteBatch.DrawString(score, "You Win!", new Vector2(600, 260), Color.Gold);
            }

            spriteBatch.DrawString(score, "Score: " + scorefood, new Vector2(600, 400), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);
        }
        List<string> MapGen()
        {
            List<string> tmplist = new List<string>();
            tmplist.Add("S........P........S"); // 19 dots
            tmplist.Add(".WWWWW.W.W.W.WWWWW.");
            tmplist.Add(".WP....W.W.W.....W.");
            tmplist.Add(".W.WWW.W.W.W.WWW.W.");
            tmplist.Add(".W.W...........W.W.");
            tmplist.Add(".W.W.WWWW.WWWW.W.W.");
            tmplist.Add(".....WE.....EW.....");
            tmplist.Add(".W.W.W.W.W.W.W.W.W.");

            tmplist.Add(".W.W.W.W.W.W.W.W.W.");
            tmplist.Add(".....W...E...W.....");
            tmplist.Add(".W.W.WWWW.WWWW.W.W.");
            tmplist.Add(".W.W...........W.W.");
            tmplist.Add(".W.WWW.W.W.W.WWW.W.");
            tmplist.Add(".W.....W.W.W.....W.");
            tmplist.Add(".WWWWW.W.W.W.WWWWW.");
            tmplist.Add("S.................S");
            return tmplist;
        }
    }
}
