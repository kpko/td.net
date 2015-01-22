using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td
{
    class UI
    {
        List<UIElement> UIElements;

        public bool IsActive { get; set; }
        public Button StartButton { get; set; }
        public Button HelpButton { get; set; }
        public Button ExitButton { get; set; }

        public UI()
        {
            UIElements = new List<UIElement>();
        }


        public void Initialize()
        {
            StartButton = new Button(new Vector2(100, 150), "Start");
            HelpButton = new Button(new Vector2(100, 250), "Hilfe");
            ExitButton = new Button(new Vector2(100, 350), "Ende");

            UIElements.Add(StartButton);
            UIElements.Add(HelpButton);
            UIElements.Add(ExitButton);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch batch)
        {
            batch.Begin(samplerState: SamplerState.PointClamp);

            batch.Draw(Resources.MenuBackground, position: Vector2.Zero);

            foreach (var element in UIElements)
            {
                element.Draw(batch);
            }

            batch.End();
        }

    }
}
