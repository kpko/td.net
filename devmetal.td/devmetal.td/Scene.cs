using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td
{
    class Scene 
    {
        public List<Entity> Entities { get; set; }

        public Scene()
        {
            this.Entities = new List<Entity>();
        }

        public void Initialize()
        {
            foreach (var entity in this.Entities)
            {
                entity.Initialize();
            }
        }

        public void Update(GameTime gameTime)
        {
            foreach (var entity in this.Entities)
            {
                entity.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch batch)
        {
            batch.Begin(samplerState: SamplerState.PointClamp);

            batch.Draw(Resources.map5, position: Vector2.Zero);

            foreach (var entity in this.Entities)
            {
                entity.Draw(batch);
            }

            batch.End();
        }
    }
}
