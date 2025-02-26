using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Security.Cryptography.X509Certificates;

namespace EntityComponent_NathanielWhite_20250224
{
    public class Game1 : Game
    {
        
        private GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;

        // A variable to the GameObject class called player
        private GameObject player;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            // Makes the player variable equal an instance to the GameObject class
            player = new GameObject();

            // Makes the GameObject's Game1 reference equal this class
            player.gameRef = this;
        }

        protected override void Initialize()
        {
            // Makes a reference to the GameObject's Start method
            player.Start();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Makes a reference to the GameObject's Update method
            player.Update();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // Makes the background of the build a different color
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            // Makes a reference to the GameObject's Draw method
            player.Draw();

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
