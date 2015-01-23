using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Core.UI
{
    public class Screen : Module
    {
        protected List<UIElement> UIElements { get; set; }
        protected Texture2D Background { get; set; }

        public Screen()
        {
            UIElements = new List<UIElement>();
        }


        public override void Initialize()
        {
        }

        public override void Update(GameTime gameTime)
        {

        }

        public override void Draw(SpriteBatch batch)
        {
            if (this.Background != null)
                batch.Draw(Background, position: Vector2.Zero);

            foreach (var element in UIElements)
            {
                element.Draw(batch);
            }
        }

    }
}
