using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Figher_Game
{
    public class Player
    {
        public Character character;
        public Rectangle rectangle;
        public int yVel = 0;
        public bool isJumping = false;
        //public Player opponent;

        public Player(Character character, Rectangle rectangle)
        {
            this.character = character;
            this.rectangle = rectangle;
        }
        /*public void setOpponent(Player opponent)
        {
            this.opponent = opponent;
        }*/
        /*public int punch()
        {
            //runs when punch button is pressed.
            //returns damage dealt

            if(

            return 0;
        } */

    }
}
