using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public interface ITransformable
{
    Vector2 Position { get; set; }
}

public class GameObject : ITransformable
{
    // Position that components can use.
    public Vector2 Position { get; set; }

    // List to store all attached components.
    private List<Component> components = new List<Component>();

    // Adds a component and sets its owner.
    public void AddComponent(Component component)
    {
        component.Owner = this;
        components.Add(component);
        component.Initialize();
    }

    // Generic method to retrieve a component.
    public T GetComponent<T>() where T : Component
    {
        return components.OfType<T>().FirstOrDefault();
    }

    // Update all components.
    public void Update(GameTime gameTime)
    {
        foreach (var component in components)
        {
            component.Update(gameTime);
        }
    }

    // Draw all components.
    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
        foreach (var component in components)
        {
            component.Draw(gameTime, spriteBatch);
        }
    }
}
