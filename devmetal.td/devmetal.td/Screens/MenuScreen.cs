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
        public Button StartButton { get; private set; }
        public Button HelpButton { get; private set; }
        public Button ExitButton { get; private set; }

        public override void Initialize()
        {
            StartButton = new Button(new Vector2(100, 150), "Start");
            HelpButton = new Button(new Vector2(100, 250), "Hilfe");
            ExitButton = new Button(new Vector2(100, 350), "Ende");

            UIElements.Add(StartButton);
            UIElements.Add(HelpButton);
            UIElements.Add(ExitButton);
        }

        public override void Load()
        {
            this.Background = Resources.MenuBackground;
        }
    }
}
