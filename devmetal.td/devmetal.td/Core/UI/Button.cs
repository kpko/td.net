using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Core.UI
{
    public class Button : UIElement
    {
        public string Text;

        public event EventHandler<EventArgs> Click;

        public Button(Vector2 position, string Text)
        {
            this.Size = new Vector2(600, 60);

            this.Position = position;
            this.Text = Text;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(Resources.Button, this.Position);

            float fontWidth = Resources.FontLarge.MeasureString(this.Text).X;

            float x = this.Position.X + (this.Size.X / 2) - (fontWidth / 2);
            float y = this.Position.Y;

            Color fontColor = Color.White;

            //if (!this.IsMouseOver)
            //{
            //    fontColor = Color.White;
            //}
            if (this.IsMouseOver && !this.IsMouseDown)
            {
                fontColor = Color.Gold;
            }

            else if (this.IsMouseOver && this.IsMouseDown)
            {
                fontColor = Color.Yellow;
            }

            batch.DrawString(Resources.FontLarge, Text, new Vector2(x, y), fontColor);
        }

        public override void OnClick()
        {
            if (this.Click != null)
            {
                this.Click(this, new EventArgs());
            }
        }
    }
}
