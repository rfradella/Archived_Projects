using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace SilverSurferGame
{
    public class Text
    { 
        SpriteFont Arial;

        Color color;

        string text;

        Vector2 position;

        public void spriteFontSetup(ContentManager content)
        {
            Arial = content.Load<SpriteFont>(@"Arial");
        }
        public void drawText(SpriteBatch sprteBatch, string s, Vector2 pos,Color c)
        {
            text = s;
            position = pos;
            color = c;
          
            sprteBatch.DrawString(Arial, text, position, color);
        }
        public void changeColor(Color c)
        {
            color = c;
        }
        public void drawText(string text, Vector2 position, Color color, SpriteFont sf, SpriteBatch sb)
        {
            sb.DrawString(sf, text, position, color);
        }
        public string WrapText(SpriteFont spriteFont, string text, float maxLineWidth)
        {
            StringBuilder sb = new StringBuilder();

            string[] words = text.Split(' ');

            float lineWidth = 0f;
            float spaceWidth = spriteFont.MeasureString(" ").X;

            foreach (string word in words)
            {
                Vector2 size = spriteFont.MeasureString(word);

                if (lineWidth + size.X < maxLineWidth)
                {
                    sb.Append(word + " ");
                    lineWidth += size.X + spaceWidth;
                }
                else
                {
                    sb.Append("\n" + word + " ");
                    lineWidth = size.X + spaceWidth;
                }
            }

            return sb.ToString();
        }
    }
}
