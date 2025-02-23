using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public abstract class Component
{
    public GameObject Owner { get; set; }

    public virtual void Initialize() { }

    public virtual void Update(GameTime gameTime) { }

    public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch) { }
}

