using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityComponent_NathanielWhite_20250224
{
    public class Component
    {
        public GameObject gameObjectOwn;
        // Virtual methods for drawing a sprite and updating the movement of it
        public virtual void Draw(Texture2D _texture, Vector2 _position, Color _color)
        {
            
        }

        public virtual void Update()
        {

        }
    }

    // A child that inherits from the Component class, with the child only using the draw method with the parameters to get the texture,
    // position and color of the sprite
    public class DrawComponent : Component
    {
        public override void Draw(Texture2D _texture, Vector2 _position, Color _color)
        {
            gameObjectOwn.gameRef._spriteBatch.Draw(_texture, _position, _color);  
        }
    }

    public class InputComponent : Component
    {
        public override void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                gameObjectOwn.objPosition.Y -= 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                gameObjectOwn.objPosition.X += 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                gameObjectOwn.objPosition.Y += 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                gameObjectOwn.objPosition.X -= 1f;
            }

        }
    }
}
