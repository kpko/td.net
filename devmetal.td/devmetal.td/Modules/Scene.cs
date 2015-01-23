using devmetal.td.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Modules
{
    class Scene : Module
    {
        public List<Entity> Entities { get; set; }

        public Scene()
        {
            this.Entities = new List<Entity>();
        }

        public override void Initialize()
        {
            foreach (var entity in this.Entities)
            {
                entity.Initialize();
            }
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var entity in this.Entities)
            {
                entity.Update(gameTime);
            }
        }

        public override void Draw(SpriteBatch batch)
        {
            foreach (var entity in this.Entities)
            {
                entity.Draw(batch);
            }
        }
    }
}
