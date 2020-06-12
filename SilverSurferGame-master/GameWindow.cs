using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System.IO;


namespace SilverSurferGame
{
    public class GameWindow:Game
    {
        #region Variables

        #region  //Classes
        Player pl = new Player();
        Boss b = new Boss();
        Text text = new Text();
        Enemies enm=new Enemies();
        #endregion
      
        #region // Textures
        Texture2D CurrentWindow,
                    splash,
                    hint,
                    Playing,
                    Story,
                    pause,
                    stars,
                    stars2,
                    currPlanet,
                    GameOver,
                    Win;

        Texture2D player;
       
        #endregion         
       
        #region//Rectangle
        Rectangle windowRect =
            new Rectangle(0, 0, 1300, 700);
            
            public Rectangle hudWeaponSrc=new Rectangle(211,0,32,32);

       
        #endregion

        #region  //gameStates
        public bool playing = false,
                    story = false,
                    Pause = false,
                    Hint = false,
                    gameOver = false,
                    Winner = false;
        #endregion

        #region  //Health / Mana   
         
        Rectangle manaRect = 
            new Rectangle(109, 54, 215, 24);

        Rectangle healthRect =
            new Rectangle(109, 12, 215, 22);

        Texture2D  healthBar,
                   manaBar,
                   hudWeapon;

        #endregion

        #region //font/text
        SpriteFont font;

        string tscore,
               tMultiplier,               
               tEnemiesRemain;

        public int score=0,
            multiplier=1 ,
           enemiesRemain=5 ;

        
        #endregion
          
        #region //Scrolling backgrounds
        Rectangle starRect = 
            new Rectangle(0, 0, 1300, 700);//Star1

        Rectangle starRect2 = 
            new Rectangle(1300, 0, 1300, 700);//Star2

        Rectangle planetRect = 
            new Rectangle(0, 500, 1300, 700);//Planet1

        Rectangle planetRect2 =
            new Rectangle(1300, 500, 1300, 700);//Planet2

        int scrollSpeed = 1;
        #endregion

        
         int currentLevel = 1;
        
        #endregion

        public void LoadContent(ContentManager content)
        {
            b.LoadContent(content);

          //Playing textures
            font = content.Load<SpriteFont>("Arial");
            text.spriteFontSetup(content);

          //Backgrounds
            splash = content.Load<Texture2D>(@"GameStates\Menu-Bak");           //Splash
              hint = content.Load<Texture2D>(@"GameStates\hint") ;              //Hint
                stars = content.Load<Texture2D>(@"GameStates\stars");          //Stars
                Playing = content.Load<Texture2D>(@"GameStates\HUD");                   //HUD
                Story = content.Load<Texture2D>(@"GameStates\story1-Bak"); //Story

          //Playing          
            player = content.Load<Texture2D>(@"Player\silversurfer");         //Player
              healthBar = content.Load<Texture2D>(@"Player\healthbar");            //HEALTHBar
                manaBar = content.Load<Texture2D>(@"Player\manabar");              //MANABar
                 hudWeapon = content.Load<Texture2D>(@"Weapons\effects");       //Effects    
            
          //Pause  
            pause = content.Load<Texture2D>(@"GameStates\Pause");                                           
          //planet
            currPlanet = content.Load<Texture2D>(@"Backgrounds\alienmoon");
           stars2 = content.Load<Texture2D>(@"GameStates\stars2");     
          //EndGAME
            GameOver = content.Load<Texture2D>(@"GameStates\Game Over ");       //GameOvers
            Win = content.Load<Texture2D>(@"GameStates\Win");                  //Win
                                     
        }     
        
        public void checkInput(SpriteBatch s)
        {
            KeyboardState keyst = Keyboard.GetState();
            //game states
            #region Splash Screen
            if (playing == false)
            {
                //set window for drawing
                CurrentWindow = splash;
                
                // Draw window
                Draw(s);
                
                s.DrawString(font, "Press Enter to Play", new Vector2(0, 500), Color.Silver);
               
                //hint
                if (keyst.IsKeyDown(Keys.Enter))
                {
                    Hint = true;
                    
                }
            }
            #endregion

            #region Hint
            if (Hint == true)
            {
                CurrentWindow = hint;

                Draw(s);
               
                   
                    s.DrawString(font, "PRESS N to PLAY", new Vector2(400, 650), Color.White);
                
                if (keyst.IsKeyDown(Keys.N))
                    story = true;
            }
            #endregion

            #region Story
            if (story == true)
            {
                CurrentWindow = Story;
                string t;
                Draw(s);
                //level 1
                if (currentLevel == 1)
                {
                    t = text.WrapText(font, "Norin Radd of Zen-La became the Silver Surfer to save his home planet from the world "+
                                "eating Galactus! The Silver Surfer now in search of his beloved home heads to the planet PLANET1 to try to learn"+
                                "its location. On his way to PLANET1 he is met with resistance from worlds he helped destroy whilst in the service in "+
                                "Galactus.                                                                     Press Enter to Play", 401.0f);                   
                }
                else
                {
                     t = text.WrapText(font, "Comming soon", 401.0f);
                }
                s.DrawString(font, t,new Vector2 (20,20),Color.White);
                
                         if (keyst.IsKeyDown(Keys.Enter))               
                                playing = true;
                
                       
                
            }
            #endregion

            #region Playing
            if ((playing == true) & (Pause != true))
            {
                tscore = score.ToString();
                tMultiplier = multiplier.ToString();
                tEnemiesRemain = enemiesRemain.ToString();
                
                //set window for drawing
                CurrentWindow = Playing;
                
                //draw window
                Draw(s);
                
                //loose
                if (healthRect.Width < 0)
                {
                    gameOver = true;                  
                }
                //Pause
                if (keyst.IsKeyDown(Keys.P))
                    Pause = true;

                //decrease mana
                if (keyst.IsKeyDown(Keys.LeftControl))
                {
                    decreaseMana(1);
                   
                }

                //release ammo pack
                if (manaRect.Width <= 1)
                {
                    s.DrawString(font, "Out of Mana", new Vector2(130, 45), Color.White);
                    manaRect.Width = 1;
                }

                //Win
                if (enemiesRemain == 0)
                {
                    //Winner = true;
                    playing = false;
                    
                }
                
            }
#endregion
           
            #region Pause
            if (Pause == true)
            {               
                //set window for drawing
                CurrentWindow = pause;

                //Draw
               Draw(s);
                
                //how to resume
                s.DrawString(font, "Press Space to Resume Play", new Vector2(0, 500), Color.Silver);
                
                //play
                if (keyst.IsKeyDown(Keys.Space))
                {
                    Pause = false;
                    stopScroll();
                    
                }
            }
            #endregion

            #region Game Over
            if (gameOver == true)
            {
                CurrentWindow = GameOver;
               Pause = false;
                playing = false;
               
                Draw(s);
                s.DrawString(font, tscore, new Vector2(1050, 430), Color.White);
            }
            #endregion

            #region Winner
            if (Winner == true)
            {
                CurrentWindow = Win;
                playing = false;
                
                Draw(s);
            }
            #endregion

        }   
             
        public void changeStoryBack(string fileName, ContentManager content)
        {
           Story= content.Load<Texture2D>(@"Backgrounds\" + fileName);
        }
          
        public void changePlanet(ContentManager content, string path)
        {
          currPlanet=  content.Load<Texture2D>(@"Backgrounds\" + path);
        }

        #region Scrolling
        private void scrollBackground()
        {
            if ((playing == true)&(!Pause))
            {
                //move texture
                starRect.X -= scrollSpeed;
                starRect2.X -= scrollSpeed;
                planetRect.X -= scrollSpeed;
                planetRect2.X -= scrollSpeed;

                //place next texture
                if (starRect.X + starRect.Width <= 0)   //stars<0
                    starRect.X = 1300;
                if (planetRect.X + planetRect.Width <= 0) //planet<0
                    planetRect.X = 1300;
                if (starRect2.X + starRect2.Width <= 0)  //stars2<0
                    starRect2.X = 1300;
                if (planetRect2.X + planetRect2.Width <= 0)
                    planetRect2.X = 1300;
               
                if (enemiesRemain < 1)
                {
                    stopScroll();                   
                }
            }
            
        }
        
        public void stopScroll()
        {
            scrollSpeed = 0;

        }
        #endregion

        void Draw(SpriteBatch s)
        {
           
            #region playing
            if ((playing == true)&(Pause==false))//draw playing screen
            {
                #region Backgrounds
                s.Draw(stars, starRect, Color.White);
                s.Draw(stars2, starRect2, Color.White);
                s.Draw(currPlanet, planetRect, new Rectangle(0, 50, 1020, 700), Color.White);
                s.Draw(currPlanet, planetRect2, new Rectangle(0, 50, 1020, 700), Color.White);
                #endregion
               
                #region Number variable drawing
                s.DrawString(font, tscore, new Vector2(725, 30), Color.White);// score  
                s.DrawString(font, tMultiplier, new Vector2(950, 30), Color.White);//multiplyer
                s.DrawString(font, tEnemiesRemain, new Vector2(1200, 30), Color.White);//enemies remaining
                #endregion
                //how to pause
                //s.DrawString(font, "Press P to PAUSE", new Vector2(0, 400), Color.Silver);

                scrollBackground();
                CurrentWindow = Playing;
                s.Draw(CurrentWindow, windowRect, Color.White);
                               
                        
            }
            #endregion

            if (enemiesRemain == 0)
            {
                Winner = true;

                s.Draw(CurrentWindow, windowRect, Color.White);
                tscore = score.ToString();
                s.DrawString(font, tscore, new Vector2(200, 105), Color.LightGreen);


            }
            if (enemiesRemain <= 1)
            {
                enm.stopUpdate(0);
                enm.stopUpdate(1);
                enm.stopUpdate(2);
            }
            else                    //draw other windows
            {
                s.Draw(CurrentWindow, windowRect, Color.White);
             
            }
        }             
       
        #region Health/Mana
        
        public void increaseHealth(int value)
        {
            healthRect.Width += value;
        }        
        public void increaseMana(int value)
        {
            manaRect.Width += value;
        }

        public void decreaseMana(int value)
        {
            manaRect.Width -= value;
            if (manaRect.Width <= 0)
            {
                //release ammo pack
            }
        }
        public void decreaseHealth(int value)
        {
            healthRect.Width -= value;
            if (healthRect.Width <= 0)
                gameOver = true;
        }

        public void drawHealthandManaBars(SpriteBatch s)
        {
          
                s.Draw(healthBar, healthRect, Color.Red);
                s.Draw(manaBar, manaRect, Color.Blue);
               
        }
        #endregion       
        
        #region Update Text values

        public void incScore(int value)
        {
            score += value;
            switch (score)
            {
                case 100: setMultiplier(2); break;
                case 300: setMultiplier(3); break;
                case 1000: setMultiplier(4); break;
            };
        }
        public void incEnemiesRemaining(int value)
        {
            enemiesRemain += value;
        }        

        public void setMultiplier(int value)
        {
            multiplier = value;
        }

        public void decScore(int value)
        {
            score -= value;
           
        }       
        public void decEnemiesRemaining(int value)
        {
            enemiesRemain -= value;
            if (enemiesRemain <= 0 )
                story=true;
           
        }       
       //Set variables
        public void resetVariables(int Score, int multi, int enemiesRemaining)
        {
              enemiesRemaining=enemiesRemain;
            multi = multiplier;
            Score = score;
        }
        #endregion
        
    
       
    }
}
