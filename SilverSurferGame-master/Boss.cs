using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace SilverSurferGame
{
    public class Boss
    {
      
        Texture2D bossTex;              //IMAGE

        Vector2 bossPosition,           //POSITION
                iconPos,
                healthbarPos;

        public Rectangle srcRect,      //SOURCE RECTANGLES
                         iconSrc,
                         healthBarSRC;
                      
        
        public void LoadContent(ContentManager content)
        {
            //Boss Texture
            bossTex = content.Load<Texture2D>(@"Enemies\Thanos");
            
            //Source Rectangles
            srcRect = new Rectangle(3, 50, 69, 110);////x= 145, 75,3
            iconSrc = new Rectangle(10, 383,171, 130);
            healthBarSRC = new Rectangle(0, 0, 100, 50);

            //Positions
            bossPosition = new Vector2(1100, 420);
            iconPos = new Vector2(0, 576);
            healthbarPos = new Vector2(165, 575);            
        }
        public void Draw(SpriteBatch sb)
        {
           //BOSS
            sb.Draw(bossTex,bossPosition,srcRect,Color.White,0.0f,Vector2.Zero,2.5f,SpriteEffects.None,0.0f);
            
            //HEALTHBAR + SIZE
            float scale = 3.0f;
            sb.Draw(bossTex, healthbarPos,healthBarSRC,Color.White,0.0f,Vector2.Zero,scale,SpriteEffects.None,0.0f );
            
            //ICON
             sb.Draw(bossTex,iconPos,iconSrc, Color.White);

        }

    }
}
