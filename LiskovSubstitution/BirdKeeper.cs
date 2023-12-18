using LiskovSubstitution.Birds;
using System.Collections.Generic;

namespace LiskovSubstitution
{
    public class Birdkeeper
    {
        private List<Bird> birds;
        private List<FlyingBird> flyingBirds;

        public Birdkeeper()
        {
            this.birds = new List<Bird>();
            this.flyingBirds = new List<FlyingBird>();
        }

        public void AddBird(Bird bird)
        {
            if (bird is FlyingBird)
            {
                this.flyingBirds.Add((FlyingBird)bird);
            }
            this.birds.Add(bird);
        }

        public void BirdsFlyAround()
        {
            foreach (FlyingBird b in this.flyingBirds)
            {
                b.Fly();
            }
        }

        public void FeedBirds()
        {
            foreach (Bird b in this.birds)
            {
                b.Eat();
            }
        }
    }
}