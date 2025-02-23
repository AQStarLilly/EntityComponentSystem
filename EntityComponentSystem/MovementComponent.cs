using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Responsible for player movement 
public class MovementComponent : Component
{
    public float Speed { get; set; } = 200f; // Movement speed in pixels per second

    public override void Update(GameTime gameTime)
    {
        // Read keyboard state.
        KeyboardState state = Keyboard.GetState();
        Vector2 inputDirection = Vector2.Zero;
        if (state.IsKeyDown(Keys.Up))
            inputDirection.Y -= 1;
        if (state.IsKeyDown(Keys.Down))
            inputDirection.Y += 1;
        if (state.IsKeyDown(Keys.Left))
            inputDirection.X -= 1;
        if (state.IsKeyDown(Keys.Right))
            inputDirection.X += 1;

        // Normalize the direction to avoid faster diagonal movement.
        if (inputDirection != Vector2.Zero)
            inputDirection.Normalize();

        // Calculate the movement.
        Vector2 velocity = inputDirection * Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

        // Update the owner's position (Owner implements ITransformable).
        if (Owner is ITransformable transformable)
        {
            transformable.Position += velocity;
        }
    }
}