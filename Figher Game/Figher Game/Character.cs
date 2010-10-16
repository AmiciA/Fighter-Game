using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Figher_Game
{
    public class Character
    {
        public static Character DEADPOOL = new Character("deadpool");

        public static int height = 132,
                          width = 92;

        public Texture2D texture;
        public String name;

        public Character(String name)
        {
            this.name = name;
            this.texture = Program.game.Content.Load<Texture2D>(@"Sprites/" + name);
        }
    }
}
