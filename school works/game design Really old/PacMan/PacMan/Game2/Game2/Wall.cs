using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMaster
{
    class Wall : Sprite
    {
        private GameManager gameManager;

        public Wall(Texture2D tex, Vector2 pos, GameManager gameManager) : base(tex, pos)
        {
            this.gameManager = gameManager;
        }

        public Wall(Texture2D tex, Vector2 pos, string hp) : base(tex, pos)
        {
            AddAnimations(tex);
            if (hp == "P") hp = ".";
            SetAnimation(hp);
        }
        public override void AddAnimations(Texture2D tex)
        {
            AddAnimation(".", tex, new Point(30, 30), Point.Zero, Point.Zero, 0);
            AddAnimation("1", tex, new Point(30, 30), Point.Zero, new Point(30, 0), 0);

        }
    }
}
