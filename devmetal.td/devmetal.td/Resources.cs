using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td
{
    static class Resources
    {
        public static SpriteFont FontSmall;
        public static SpriteFont FontMedium;
        public static SpriteFont FontLarge;

        public static Texture2D map5;
        public static Texture2D Zombie;
        public static Texture2D Tower;

        public static Texture2D MenuBackground;
        public static Texture2D Button;


        public static void Load(ContentManager content)
        {
            FontSmall = content.Load<SpriteFont>("FontSmall"); // Use the name of your sprite font file here instead of 'Score'.
            FontMedium = content.Load<SpriteFont>("FontMedium"); // Use the name of your sprite font file here instead of 'Score'.
            FontLarge = content.Load<SpriteFont>("FontLarge"); // Use the name of your sprite font file here instead of 'Score'.

            map5 = content.Load<Texture2D>("sprites/map5");
            Zombie = content.Load<Texture2D>("sprites/zombie");
            Tower = content.Load<Texture2D>("sprites/tower");

            MenuBackground = content.Load<Texture2D>("sprites/menu");
            Button = content.Load<Texture2D>("sprites/button");

        }
    }
}
