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
        public Player opponent;

        public static bool first = true;

        public Player(Character character)
        {
            this.character = character;
            if (first)
                this.rectangle = new Rectangle(0, Program.game.GraphicsDevice.Viewport.Height - 134, 92, 134);
            else
                this.rectangle = new Rectangle(Program.game.GraphicsDevice.Viewport.Width - 92, Program.game.GraphicsDevice.Viewport.Height - 134, 92, 134);
            first = false;
        }
        public void setOpponent(Player opponent)
        {
            this.opponent = opponent;
        }
        /*public int punch()
        {
            //runs when punch button is pressed.
            //returns damage dealt

            if()

            return 0;
        } */

        public void jump()
        {
            if (!isJumping)
            {
                yVel = 18;
                isJumping = true;
                rectangle.Y -= yVel;
                yVel -= 1;
            }
        }

    }
}
