using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProofOfConcept
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D Robot;
        Texture2D BrickBlock;
        Texture2D FireBall;
        Texture2D Background;

        Vector2 RobotPosition;
        Vector2 FireBallPosition;

        SpriteFont DefaultFont;

        bool FireBallShot = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Robot = Content.Load<Texture2D>("robot");
            FireBall = Content.Load<Texture2D>("fireball");
            BrickBlock = Content.Load<Texture2D>("BrickBlock");
            Background = Content.Load<Texture2D>("BackGround");

            DefaultFont = Content.Load<SpriteFont>("defaultFont");

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            Vector2 Movement = Vector2.Zero;

            KeyboardState KeyState = Keyboard.GetState();
            

            if (KeyState.IsKeyDown(Keys.Right))
            {
                Movement.X ++;
            }
            if (KeyState.IsKeyDown(Keys.Left))
            {
                Movement.X--;
            }
            if (KeyState.IsKeyDown(Keys.Down))
            {
                Movement.Y++;
            }
            if (KeyState.IsKeyDown(Keys.Up))
            {
                Movement.Y--;
            }
            if (KeyState.IsKeyDown(Keys.Space))
            {
                FireBallShot = true;
            }

            if (FireBallShot)
            {
                FireBallPosition.X += 5;
                if (FireBallPosition.X > GraphicsDevice.Viewport.Width)
                {
                    FireBallShot = false;
                }
            }

            RobotPosition += Movement;
            

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(Background, Vector2.Zero, Color.White);
            spriteBatch.Draw(Robot,RobotPosition,Color.White);
            spriteBatch.DrawString(DefaultFont, "Roman is de Man", Vector2.Zero, Color.Purple);
            if(FireBallShot) spriteBatch.Draw(FireBall, FireBallPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
