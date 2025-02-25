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
        public List<Component> componentsList = new List<Component>();

        public Game1 gameRef;

        Texture2D objTexture;
        public Vector2 objPosition = Vector2.Zero;

        public void Start()
        {
            var inputRef = new InputComponent();
            var drawRef = new DrawComponent();

            AddComponent(inputRef);
            AddComponent(drawRef);

            objTexture = gameRef.Content.Load<Texture2D>("CoolSprite");
        }

        public void Update()
        {
            foreach(var component in componentsList)
            {
                component.Update();
            }
        }

        public void Draw()
        {
            foreach (var component in componentsList)
            {
                component.Draw(objTexture, objPosition, Color.White);
            }
        }

        public void AddComponent(Component _component)
        {
            componentsList.Add(_component);
            _component.gameObjectOwn = this;
        }
    }
}
