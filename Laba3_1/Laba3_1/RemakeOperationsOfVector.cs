using System;

public struct Vector
{
	public double X { get; set; }
	public double Y { get; set; }
	public double Z { get; set; }

	public Vector(double x, double y, double z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public static Vector operator +(Vector v1, Vector v2)
	{
		return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
	}

	public static double operator *(Vector v1, Vector v2)
	{
		return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
	}

	public static Vector operator *(Vector v1, double number)
	{
		return new Vector(v1.X * number, v1.Y * number, v1.Z * number);
	}

	public static Vector operator *(double number, Vector v1)
	{
		return v1 * number;
	}

	public double Length()
	{ 
		return Math.Sqrt(X* X+Y* Y+Z* Z);
	}
	
	public static bool operator <(Vector v1, Vector v2)
	{
		return v1.Length() < v2.Length();
	}

	public static bool operator > (Vector v1, Vector v2 )
	{
		return v1.Length() > v2.Length();
	}

    public static bool operator <=(Vector v1, Vector v2)
    {
        return v1.Length() <= v2.Length();
    }

    // Переопределение оператора сравнения "больше или равно"
    public static bool operator >=(Vector v1, Vector v2)
    {
        return v1.Length() >= v2.Length();
    }

    // Переопределение оператора сравнения "равно"
    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
    }

    // Переопределение оператора сравнения "не равно"
    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    // Переопределение метода Equals для сравнения векторов
    public override bool Equals(object obj)
    {
        if (obj is Vector other)
        {
            return this == other;
        }
        return false;
    }

    // Переопределение метода GetHashCode для сравнения векторов
    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
    }

    // Переопределение метода ToString для удобного вывода вектора
    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

}
