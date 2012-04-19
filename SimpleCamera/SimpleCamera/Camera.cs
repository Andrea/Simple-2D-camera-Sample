using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SimpleCamera
{
	public class Camera
	{
		public Matrix Transform { get; private set; }
		public Viewport Viewport { get; private set; }

		public Camera(Viewport viewport)
		{
			Transform = Matrix.Identity;
			Viewport = viewport;
		}

		public void Update(GameTime gameTime, float rotation, Vector2 position, float zoom)
		{
			Transform = Matrix.CreateTranslation(position.X, position.Y, 0) *
						Matrix.CreateTranslation(Viewport.Width / 2, Viewport.Height / 2, 0) 
				/*
						Matrix.CreateRotationZ(rotation) *
						Matrix.CreateScale(zoom) *
                       */;
		}
	}
}