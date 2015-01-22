using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td
{
    public class Button : UIElement
    {
        public string Text;

        public Button(Vector2 position, string Text)
        {
            this.Width = 600;
            this.Height = 60;

            this.Position = position;
            this.Text = Text;
        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(Resources.Button, this.Position);

            float fontWidth = Resources.FontLarge.MeasureString(this.Text).X;

            float x = this.Position.X + (this.Size.X / 2) - (fontWidth / 2);
            float y = this.Position.Y;

            batch.DrawString(Resources.FontLarge, Text, new Vector2(x, y), Color.White);
        }
    }
}
