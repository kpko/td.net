using devmetal.td.Core.UI;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Screens
{
    class MenuScreen : Screen
    {
        Button startButton;
        Button helpButton;
        Button exitButton;

        public override void Initialize()
        {
            startButton = new Button(new Vector2(100, 150), "Start");
            helpButton = new Button(new Vector2(100, 250), "Hilfe");
            exitButton = new Button(new Vector2(100, 350), "Ende");

            UIElements.Add(startButton);
            UIElements.Add(helpButton);
            UIElements.Add(exitButton);
        }

        public override void Load()
        {
            this.Background = Resources.MenuBackground;
        }
    }
}
