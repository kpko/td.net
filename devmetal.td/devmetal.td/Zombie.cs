using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace devmetal.td
{
    class Zombie : Entity
    {
        public override void Initialize()
        {

        }

        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(Resources.Zombie, position: new Vector2(200, 200), scale: new Vector2(2, 2));
        }
    }
}
