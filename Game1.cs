using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Exercicio_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D imagem;
        private Vector2 position;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            imagem = Content.Load<Texture2D>("imagem");
            position = new Vector2(0, 0);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.W)) 
            {
                position.Y -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S)) 
            {
                position.Y += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                position.X -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                position.X += 1;
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.GreenYellow);

            _spriteBatch.Begin();
            _spriteBatch.Draw(imagem, position, null, Color.White, 0f, Vector2.Zero, 0.2f, SpriteEffects.None, 0f);
            _spriteBatch.End();


           
            base.Draw(gameTime);
        }
    }
}
