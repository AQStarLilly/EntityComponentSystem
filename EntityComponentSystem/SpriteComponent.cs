using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class SpriteComponent : Component
{
    public Texture2D Texture { get; set; }
    public Color Tint { get; set; } = Color.White;
    public Vector2 Origin { get; set; } = Vector2.Zero;

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        if (Texture != null && Owner is ITransformable transformable)
        {
            spriteBatch.Draw(Texture, transformable.Position, null, Tint, 0f, Origin, 1f, SpriteEffects.None, 0f);
        }
    }
}
