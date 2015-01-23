using devmetal.td.Core;
using devmetal.td.Entities;
using devmetal.td.Modules;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.States
{
    class GameState : State
    {
        Scene scene;

        public override void Initialize()
        {
            scene = new Scene();
            scene.Entities.Add(new Zombie());
            scene.Entities.Add(new Tower());
        }

        public override void Load()
        {
            scene.Load();
        }

        public override void Update(GameTime gameTime)
        {
            scene.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin(samplerState: SamplerState.PointClamp);

            spriteBatch.Draw(Resources.map5, position: Vector2.Zero);
            scene.Draw(spriteBatch);

            spriteBatch.End();
        }

        public override void Unload()
        {
            scene.Unload();
        }
    }
}
