using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class MeteoriteBall : Ball
    {
        public int TrailLifetime { get; protected set; }

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed,int trailLifetime)
            : base(topLeft, speed)
        {
            this.TrailLifetime = trailLifetime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> trail = new List<TrailObject>() { new TrailObject(this.topLeft, this.TrailLifetime) };
            return trail;
        }
    }
}
