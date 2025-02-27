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
        // A variable that creates a list that will hold the components
        public List<Component> componentsList = new List<Component>();

        // A reference to the Game1 class
        public Game1 gameRef;

        // A reference to the sprite
        Texture2D objTexture;

        // A reference to the position of the player, having said position equal (0,0)
        public Vector2 objPosition = Vector2.Zero;

        // A method that enables itself when the build is made
        public void Start()
        {
            // Creates references to the amount of components you have
            var inputRef = new InputComponent();
            var drawRef = new DrawComponent();

            // Uses the AddComponent method to add both references to the components into the componentList
            AddComponent(inputRef);
            AddComponent(drawRef);

            // Loads the CoolSprite.png from the Content folder into the objTexture variable
            objTexture = gameRef.Content.Load<Texture2D>("CoolSprite");
        }

        // A method that loads whatever is in it each frame
        public void Update()
        {
            // Makes a foreach loop that has each component in the componentList update
            foreach(var component in componentsList)
            {
                component.Update();
            }
        }

        // A method that creates sprites to be used in the build
        public void Draw()
        {
            // Makes a foreach loop that has each component in the componentList draw
            foreach (var component in componentsList)
            {
                component.Draw(objTexture, objPosition, Color.White);
            }
        }
        
        // A method used for grabbing the various components and placing them into the componentList
        public void AddComponent(Component _component)
        {
            componentsList.Add(_component);

            // Makes the component's gameObject reference equal this class
            _component.gameObjectOwn = this;
        }

        // A method used for removing a component from the componentList
        public void RemoveComponent(Component _component)
        {
            componentsList.Remove(_component);
        }

        // A method used for getting a reference to a component
        public void GetComponent(Type componentType)
        {
            foreach (var component in componentsList)
            {
                if (componentType == component.GetType())
                {
                    
                }
            }
        }
    }
}
