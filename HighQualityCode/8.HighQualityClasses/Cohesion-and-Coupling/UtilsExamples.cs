﻿using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CubeUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CubeUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            CubeUtils.Width = 3;
            CubeUtils.Height = 4;
            CubeUtils.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", CubeUtils.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", CubeUtils.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", CubeUtils.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", CubeUtils.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", CubeUtils.CalcDiagonalYZ());
        }
    }
}
