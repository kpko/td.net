using devmetal.td.Core;
using devmetal.td.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.States
{
    class MenuState : State
    {
        MenuScreen screen;

        public MenuState()
        {
            screen = new MenuScreen();
        }

        public override void Initialize()
        {
            screen.Initialize();

            screen.StartButton.Click += StartButton_Click;
            screen.ExitButton.Click += (s, args) =>
            {
                this.StateManager.Exit();
            };
        }

        void StartButton_Click(object sender, EventArgs e)
        {
            StateManager.ChangeState("game");
        }

        public override void Update(GameTime gameTime)
        {
            screen.Update(gameTime);
        }

        public override void Load()
        {
            screen.Load();
        }

        public override void Unload()
        {
            screen.Unload();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            screen.Draw(spriteBatch);

            spriteBatch.End();
        }
    }
}
