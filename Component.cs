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
        public virtual void Draw(Texture2D _texture, Vector2 _position, Color _color)
        {
        }

        public virtual void Update(Vector2 _position)
        {
        }
    }

    public class DrawComponent : Component
    {
        public override void Draw(Texture2D _texture, Vector2 _position, Color _color)
        {

        }
    }

    public class InputComponent : Component
    {
        public override void Update(Vector2 _position)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                _position.Y -= 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D) || Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                _position.X += 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S) || Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                _position.Y += 1f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A) || Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                _position.X += 1f;
            }

        }
    }
}
