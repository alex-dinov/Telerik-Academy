﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Blast : MovingObject
    {
        public Blast(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { {'-'} }, speed)
        {
        }

        public override void Update()
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
    }
}
