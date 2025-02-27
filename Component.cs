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
        // Makes a reference to the GameObject
        public GameObject gameObjectOwn;

        // Virtual method for drawing a sprite, allowing it to be overridden
        public virtual void Draw(Texture2D _texture, Vector2 _position, Color _color)
        {
            
        }

        // Virtual method for updating a sprite, allowing it to be overridden
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
            // gets the draw method from the GameObject reference, that then gets it from the Game1 reference
            gameObjectOwn.gameRef._spriteBatch.Draw(_texture, _position, _color);  
        }
    }

    // A child that inherits from the Component class, with the child only using the update method
    public class InputComponent : Component
    {
        public override void Update()
        {
            // Uses the GetComponent method from GameObject to create a reference of another component
            //gameObjectOwn.GetComponent(DrawComponent);

            // If W or the Up arrow key is pressed, the gameObject goes up
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                gameObjectOwn.objPosition.Y -= 1f;
            }

            // If D or the Right arrow key is pressed, the gameObject goes right
            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                gameObjectOwn.objPosition.X += 1f;
                //gameObjectOwn.gameRef._spriteBatch.Draw(_texture, _position, Color.Red);
            }

            // If S or the Down arrow key is pressed, the gameObject goes down
            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                gameObjectOwn.objPosition.Y += 1f;
            }

            // If A or the Left arrow key is pressed, the gameObject goes left
            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                gameObjectOwn.objPosition.X -= 1f;
                //gameObjectOwn.gameRef._spriteBatch.Draw(_texture, _position, Color.Blue);

            }
        }
    }
}
