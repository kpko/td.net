using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td
{
    public class UIElement
    {
        public int Left
        {
            get { return (int)Position.X; }
            set { Position.X = value; }
        }
        public int Top
        {
            get { return (int)Position.Y; }
            set { Position.Y = value; }
        }

        public int Width
        {
            get { return (int)Size.X; }
            set { Size.X = value; }
        }

        public int Height
        {
            get { return (int)Size.Y; }
            set { Size.Y = value; }
        }

        public Vector2 Position;
        public Vector2 Size;

        public EventHandler OnClick;
        public EventHandler OnMouseOver;
        public EventHandler OnMouseDown;

        public UIElement()
        {
            this.Position = new Vector2();
            this.Size = new Vector2();
        }

        public virtual void Click()
        {

        }

        public virtual void MouseOver()
        {

        }

        public virtual void MouseOut()
        {

        }

        public virtual void Draw(SpriteBatch batch)
        {

        }
    }
}
