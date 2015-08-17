namespace EnvironmentSystem.Interfaces
{
    using EnvironmentSystem.Models;
    using EnvironmentSystem.Models.DataStructures;

    /// <summary>
    /// Check if the object is colliding with other object
    /// </summary>
    public interface ICollidable
    {
        Rectangle Bounds { get; }

        CollisionGroup CollisionGroup { get; }

        void RespondToCollision(CollisionInfo collisionInfo);
    }
}