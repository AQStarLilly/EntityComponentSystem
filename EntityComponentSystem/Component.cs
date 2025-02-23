using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Base class - all concrete components inherit from this one
public abstract class Component
{
    public GameObject Owner { get; set; }


    // Base methods that other components can override for there own needs
    public virtual void Initialize() { }

    public virtual void Update(GameTime gameTime) { }

    public virtual void Draw(GameTime gameTime, SpriteBatch spriteBatch) { }
}

