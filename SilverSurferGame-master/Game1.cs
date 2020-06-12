using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace SilverSurferGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Text text = new Text();
        Boss boss = new Boss();
        Player player = new Player();
        Enemies enemies = new Enemies();
        GameWindow gameWind = new GameWindow();

        List<Enemies> enemys = new List<Enemies>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";           
        }
      
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            graphics.PreferredBackBufferWidth = 1300;
            graphics.PreferredBackBufferHeight = 700;
            graphics.ApplyChanges();

            text.spriteFontSetup(this.Content);

            player.Initializeplayer();

            enemies.loadContent(this.Content, "Enemy1", 0);
            base.Initialize();
        }

      
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            gameWind.LoadContent(this.Content);
            boss.LoadContent(this.Content);
            player.LoadContent(this.Content);
            enemies.loadContent(this.Content, "Enemy1", 0);
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            enemies.update(0);
            // TODO: Add your update logic here
            player.check_movement();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            gameWind.checkInput(spriteBatch);

            if (gameWind.playing == true)
            {

                player.Draw(spriteBatch);
                enemies.draw(spriteBatch, 0);
                gameWind.drawHealthandManaBars(spriteBatch);
                //Player weapon hits enemy
                if (player.p_WeaponHitbox.Intersects(enemies.hitBox[0]))
                {
                    enemies.resetEnemyPosition(0);
                    gameWind.decEnemiesRemaining(1);
                    player.resetWeaponPosition();
                    gameWind.incScore(10);
                    player.fire = false;
                }
                if (player.p_Hitbox.Intersects(enemies.hitBox[0]))
                {
                    enemies.resetEnemyPosition(0);
                    gameWind.incEnemiesRemaining(1);
                    gameWind.decScore(10);
                }
                if (gameWind.Pause == true)
                {
                    gameWind.stopScroll();
                    enemies.stopUpdate(1);
                }
                if (gameWind.enemiesRemain < 1)
                {
                    boss.Draw(spriteBatch);
                }
               

                // TODO: Add your drawing code here

                base.Draw(gameTime);
            } spriteBatch.End();

        }
    }
}
