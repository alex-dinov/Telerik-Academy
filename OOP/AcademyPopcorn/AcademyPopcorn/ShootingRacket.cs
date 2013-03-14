using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ShootingRacket : Racket
    {

        public ShootingRacket(MatrixCoords topLeft, int width) 
            : base(topLeft,width)
        {
        }

        private bool fire = false;

        public void Fire()
        {
            this.fire = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (fire)
            {
                this.fire = false;
                List<Bullet> bullets = new List<Bullet>()
                {
                    new Bullet(new MatrixCoords(this.topLeft.Row + 2,(this.TopLeft.Col + (this.Width * 2)) / 2))
                };
                return bullets;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
