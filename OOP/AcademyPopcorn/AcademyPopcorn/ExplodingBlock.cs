using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block
    {
        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {

        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<Blast> blasts = new List<Blast>()
                {
                    new Blast(this.topLeft,new MatrixCoords(-1, -1)),
                    new Blast(this.topLeft,new MatrixCoords(-1, 0)),
                    new Blast(this.topLeft,new MatrixCoords(-1, 1)),
                    new Blast(this.topLeft,new MatrixCoords(0, -1)),
                    new Blast(this.topLeft,new MatrixCoords(0, 1)),
                    new Blast(this.topLeft,new MatrixCoords(1, -1)),
                    new Blast(this.topLeft,new MatrixCoords(1, 0)),
                    new Blast(this.topLeft,new MatrixCoords(1, 1)),
                };

                return blasts;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
