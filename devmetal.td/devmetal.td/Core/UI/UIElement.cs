using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Core.UI
{
    public class UIElement
    {
        public bool IsMouseOver { get; set; }
        public bool IsMouseDown { get; set; }

        private bool wasMouseDown = false;

        public Vector2 Position { get; set; }
        public Vector2 Size { get; set; }

        public UIElement()
        {
            this.Position = new Vector2();
            this.Size = new Vector2();
        }

        public virtual void Update(GameTime gameTime)
        {
            var mouse = Mouse.GetState();

            Vector2 mousePosition = mouse.Position.ToVector2();
            Vector2 pos = Position;

            IsMouseOver = (mousePosition.X > pos.X && mousePosition.X < (pos.X + Size.X)
                            && mousePosition.Y > pos.Y && mousePosition.Y < (pos.Y + Size.Y));

            bool isMouseCurrentlyDown = (mouse.LeftButton == ButtonState.Pressed);

            // MouseDown
            if (isMouseCurrentlyDown && !wasMouseDown && IsMouseOver)
            {
                this.IsMouseDown = true;
                this.OnMouseEnter();
            }
            wasMouseDown = isMouseCurrentlyDown;

            // MouseUp
            if (!isMouseCurrentlyDown && this.IsMouseDown && IsMouseOver)
            {
                this.IsMouseDown = false;

                OnClick();
            }
            else if (!isMouseCurrentlyDown && this.IsMouseDown)
            {
                this.IsMouseDown = false;
                this.OnMouseLeave();
            }
        }

        public virtual void OnClick() { }
        public virtual void OnMouseEnter() { }
        public virtual void OnMouseLeave() { }
        
        public virtual void Draw(SpriteBatch batch) { }
    }
}
