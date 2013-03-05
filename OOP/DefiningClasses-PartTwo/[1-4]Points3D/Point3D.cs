public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Point3D(int X,int Y,int Z):this()
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }

    public override string ToString()
    {
        return string.Format("(X, Y, Z) : ({0}, {1}, {2})", this.X, this.Y, this.Z );
    }

    static readonly Point3D pointO = new Point3D(0, 0, 0);

    static public Point3D PointO { get { return pointO; } }
}