using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using Microsoft.Xna.Framework.Content;
namespace SilverSurferGame

{
    public class Player
    { 
        #region //variables        
        
        public Texture2D player,pWeap;
        Vector2 playerPosition;
        
        #region Lives
            public int totalLives, 
                       remainingLives;
        #endregion
        
        #region HP/MP
            public int health,
                       currHp,
                       mana,
                       currMana;
        #endregion
        
        #region XP
            int xp,
                currxp;
        #endregion               
        
        #region Rectangles       
        
            public Rectangle p_Weap_Rect;     
            public Rectangle p_Src_Rect;

        //hit boxes
           public Rectangle p_Hitbox,p_HitboxSRC;
           public  Rectangle p_WeaponHitbox;
        #endregion        

        
          public  bool fire;
        #endregion
            
        //SETUP PLAYER         
        public void Initializeplayer()
        {
            totalLives = 3;
            health = 100;
            mana = 100;
            xp = 0;
            currHp = health;
            currMana = mana;
            currxp = xp;
            remainingLives = totalLives;
            playerPosition = new Vector2(20, 200);
            
        }    
                
        public void LoadContent(ContentManager content)
        {
            player= content.Load<Texture2D>(@"Player\silversurfer");   //PLAYER
            pWeap = content.Load<Texture2D>(@"Weapons\playerWeap");    //WEAPON 
        }
        
        public void Draw(SpriteBatch sb)
        {           
            sb.Draw(player, playerPosition, p_Src_Rect, Color.White,0.0f,Vector2.Zero,0.2f,SpriteEffects.None,0);   //PLAYER                  
            sb.Draw(player, p_Hitbox,p_HitboxSRC, Color.Red);
            if (fire == true)
            {
                sb.Draw(pWeap, p_Weap_Rect, Color.White);   //WEAPON
                               
                if (p_Weap_Rect.X>=1300)//STOP FIRING
                {
                    fire = false;
                }

                if (p_Weap_Rect.X <= 1300)//CONTINUE TO FIRE
                {
                    p_Weap_Rect.X += 10;
                    p_WeaponHitbox.X += 10;
                }
            }
        }     
       
       #region IN GAME FUNCTIONS
      
        //XP and Level up
        public void gainXP(int value)
        {
            currxp += value;
        }
            
        public void level_Up(int incTotalLives, int incTotHealth, int incTotMana, int incTo_Xp_Required)
        {
            //increases
            totalLives += incTotalLives;
            health += incTotHealth;
            mana += incTotMana;
            xp = incTo_Xp_Required;

            //reset to map_Src_Ximum
            remainingLives = totalLives;
            currMana = mana;

            //reset to default
            currHp = health;
            currxp = 0;
        }
        
        public void resetWeaponPosition()
             {
                 p_Weap_Rect = new Rectangle((int)playerPosition.X + 100, (int)playerPosition.Y - 15, 64, 64);      //WEAPON    
                 p_WeaponHitbox = new Rectangle((int)playerPosition.X + 100, (int)playerPosition.Y - 15, 64, 64);   //HITBOX
             }

        public void check_movement()
        {
            
            #region Movement
            KeyboardState keyst = Keyboard.GetState();
            p_Hitbox.X = (int)playerPosition.X;
            p_Hitbox.Y = (int)playerPosition.Y;
            if (keyst.IsKeyDown(Keys.S)|keyst.IsKeyDown(Keys.Down))//down
            {   
                //source  
                p_HitboxSRC = new Rectangle(110, 600, 480, 500);
                p_Src_Rect = new Rectangle(110,600,480,500);

                playerPosition.Y += 10;
                //hitbox
                
                p_Hitbox.Y += 10;
                //NO out of screen
                if (playerPosition.Y >= 500)
                {
                    playerPosition.Y -= 10;
                    p_Hitbox.Y -= 10;
                }

            }
            else if (keyst.IsKeyDown(Keys.W) | keyst.IsKeyDown(Keys.Up))//up
            {   
                //source
                p_HitboxSRC = new Rectangle(780,700,510,360);
                p_Src_Rect = new Rectangle(780, 700, 510, 360);
                playerPosition.Y -= 10;
                
                //hitbox
               
                p_Hitbox.Y -= 10;
                //NO out of screen
                if (playerPosition.Y <= 90)
                {
                    playerPosition.Y += 10;
                    p_Hitbox.Y += 10;
                }
            }
            else if (keyst.IsKeyDown(Keys.A) | keyst.IsKeyDown(Keys.Left))//left
            {
                //source
                p_HitboxSRC = new Rectangle(100,120,510,360);
                p_Src_Rect = new Rectangle(100,120,510,360);
                playerPosition.X -= 10;
                
                //hitbox
               
                p_Hitbox.X -= 10;
                //NO out of screen
                if (playerPosition.X <= 0)
                {
                    playerPosition.X += 10;
                    p_Hitbox.X += 10;
                }
            }
            else if (keyst.IsKeyDown(Keys.D) | keyst.IsKeyDown(Keys.Right))//right
            { p_HitboxSRC = new Rectangle(100,120,510,360);
                //source
                p_Src_Rect = new Rectangle(100, 120, 510, 360);
                playerPosition.X += 10;
                 p_Hitbox.X += 10;
                //hitbox
               
               
                //NO out of screen
                if (playerPosition.X >= 600)
                {
                    playerPosition.X -= 10;
                    p_Hitbox.X -= 10;
                }
            }
            else if (keyst.IsKeyDown(Keys.LeftControl))
            {
                //Source
                p_Src_Rect = new Rectangle(1410, 630, 530, 380);
                
                //hitbox
                p_HitboxSRC = new Rectangle(1410,630,530,380);
                
                //weapon
                resetWeaponPosition();
                fire = true;
            }
            else if (keyst.IsKeyDown(Keys.Space))
            {   
                //Source
                p_Src_Rect = new Rectangle(780, 100, 510, 360);
                
                //hitbox
                p_HitboxSRC = new Rectangle(780,100,510,360);
                
                //weapon
                resetWeaponPosition();
                fire = true;               
            }
            else //default pose on kep_Src_Y up
            {
                //source
                p_Src_Rect = new Rectangle(100, 120, 510, 380);
                
                //hitbox
                p_HitboxSRC = new Rectangle(100,120,510,380);                               
            }
            #endregion
        }//call this to move player
        #endregion
           
        
    }
}
