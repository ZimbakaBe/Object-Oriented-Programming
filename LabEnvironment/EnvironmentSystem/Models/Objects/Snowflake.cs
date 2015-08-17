namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;

    public class Snowflake : MovingObject
    {
        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
            this.CollisionGroup = CollisionGroup.Snowflake;
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] { { '*' } };
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObject = collisionInfo.HitObject;
            if (hitObject is Ground)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            throw new System.NotImplementedException();
        }
    }
}
