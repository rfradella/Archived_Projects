using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SilverSurferGame
{
    public class Enemies
    {
        //Classes 
        Player p = new Player();
      
        //Texture
        Texture2D[] enemyTex = new Texture2D[4];//0-2 for enemies 3 forboss
        
        //Hitbox
        public Rectangle[] hitBox = new Rectangle[4];
        
        //position
        public Vector2[] position = new Vector2[4];//0-2 for enemies 3 forboss
       
        //Movement speed
        float speed = 2.0f;
       
        //currentEnemy
        public int enemyNumber;

        Random rand = new Random();
      
        public void loadContent(ContentManager c, string path, int enemyNumber)
        {
            //load enemy
            enemyTex[enemyNumber] = c.Load<Texture2D>(@"Enemies\" + path);
           
            //set position  
            position[0] = new Vector2(1000,300);          
        }
       
        public void draw(SpriteBatch s, int enemyNum)
        {     
            //draw enemy
            s.Draw(enemyTex[enemyNum], position[enemyNum], Color.White); 
                           
        }

        public void update(int enemyNum)
        {
            //move enemy
                position[enemyNum].X -= speed;
           
            //setup Hitbox
                hitBox[enemyNum] = new Rectangle((int)position[enemyNum].X, (int)position[enemyNum].Y, 125, 125);                        

            //reset x after out of screen
                if (position[enemyNum].X <= 0)              
                    resetEnemyPosition(enemyNum);
              
                                              
              
        }

        public void resetEnemyPosition(int enemyNum)
        {
            position[enemyNum].X = 1300;
            position[enemyNum].Y = rand.Next(65, 490) + 10;
        }

        public void stopUpdate(int enemyNum)
        {

            //stop movement
            speed = 0;

            //set position out of screen
            position[enemyNum].X = 1300;


        }

      
    }
}