﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace texMrSpace
{
    class Stick : Sprite
    {

        float speed;
        public Rectangle hitbox;
        public Stick(Vector2 position, Texture2D image, Color tint, float speed)
            : base(position, image, tint)
        {

            this.speed = speed;

        }
        public void Update(GameTime gametime, KeyboardState currentkey, KeyboardState previouskey, int x)
        {
            hitbox = new Rectangle((int)(Position.X), (int)(Position.Y), Image.Width, Image.Height);
            if (currentkey.IsKeyDown(Keys.Left) && X >= 0 && previouskey.IsKeyUp(Keys.Left))
            {
                X -= 70;
            }
            if (currentkey.IsKeyDown(Keys.Right) && X + 50 <= x && previouskey.IsKeyUp(Keys.Right))
            {
                X += 70;
            }            
        }
    }
}
