using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td
{
    class Tower : Entity
    {
        public override void Draw(SpriteBatch batch)
        {
            batch.Draw(Resources.Tower, position: new Vector2(200, 200), scale: new Vector2(2, 2));
        }
    }
}
