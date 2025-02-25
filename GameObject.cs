using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EntityComponent_NathanielWhite_20250224
{
    public class GameObject
    {
        public InputComponent inputRef;
        public DrawComponent drawRef;

        //Texture2D objTexture = Content.Load<Texture2D>("CoolSprite");
        Vector2 objPosition = Vector2.Zero;

        public void Update()
        {
            inputRef = new InputComponent();
            inputRef.Update(objPosition);
        }

        public void Draw()
        {
            drawRef = new DrawComponent();
            //drawRef.Draw(objTexture, objPosition, Color.White);
        }
    }
}
