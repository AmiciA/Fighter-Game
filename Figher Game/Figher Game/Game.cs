using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Figher_Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D background;
        Player player1, player2;

        Rectangle standingRectangle = new Rectangle(
            0,
            0,
            92,
            134);

        public Game()
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

            background = Content.Load<Texture2D>(@"Backgrounds/Cubes");

            player1 = new Player(Character.DEADPOOL);
            player2 = new Player(Character.DEADPOOL);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        public ContentManager getContent()
        {
            return Content;
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            Keys[] pressed_Key = Keyboard.GetState().GetPressedKeys();

            for (int i = 0; i < pressed_Key.Length; i++)
            {
                switch (pressed_Key[i])
                {
                    case Keys.A:
                        player1.rectangle.X -= 10;
                        break;
                    case Keys.D:
                        player1.rectangle.X += 10;
                        break;
                    case Keys.Space:
                        player1.jump();
                        break;
                    case Keys.Left:
                        player2.rectangle.X -= 10;
                        break;
                    case Keys.Right:
                        player2.rectangle.X += 10;
                        break;
                    case Keys.RightShift:
                        player2.jump();
                        break;
                    default:
                        break;
                }
            }

            // Jumping
            if (player1.isJumping)
            {
                player1.rectangle.Y -= player1.yVel;
                player1.yVel -= 1;
            }

            if (player2.isJumping)
            {
                player2.rectangle.Y -= player2.yVel;
                player2.yVel -= 1;
            }

            if (player1.rectangle.Y >= GraphicsDevice.Viewport.Height - 134)
            {
                player1.isJumping = false;
                player1.rectangle.Y = GraphicsDevice.Viewport.Height - 134;
            }

            if (player2.rectangle.Y >= GraphicsDevice.Viewport.Height - 134)
            {
                player2.isJumping = false;
                player2.rectangle.Y = GraphicsDevice.Viewport.Height - 134;
            }

            // End jumping

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
            spriteBatch.Draw(
                background,
                new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height),
                Color.White);
            spriteBatch.Draw(player1.character.texture, player1.rectangle, standingRectangle, Color.White);
            spriteBatch.Draw(player2.character.texture, player2.rectangle, standingRectangle, Color.White);
            //spriteBatch.Draw(player2, player2Loc, standingRectangle, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
