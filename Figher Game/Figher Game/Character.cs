using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Figher_Game
{
    public class Character
    {
        //public static Character DEADPOOL = new Character("deadpool");


        public Texture2D texture;

        public Character(String name, Texture2D texture)
        {
            //this.texture = Content.Load<Texture2D>(@"Sprites/" + name);
            this.texture = texture;
        }
    }
}
