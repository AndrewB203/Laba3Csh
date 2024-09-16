using System;
using System.Collections.Generic;

public class Car : IEquatable<Car>
{
	public string Name { get; set; }
	public string Engine { get; set; }
	public double MaxSpeed { get; set; }

	public Car(string name, string engine, double maxspeed )
	{
		Name = name;
		Engine = engine;
		MaxSpeed = maxspeed;
	}

	public override string ToString()
	{
		return Name;
	}

	public bool Equals(Car other)
	{
		if (other == null) return false;
		return Name == other.Name && Engine == other.Engine && MaxSpeed == other.MaxSpeed;  
	}

	public override bool Equals (object obj)
	{
        if (obj == null) return false;
        if (GetType() != obj.GetType()) return false;
        return Equals((Car)obj);
    }

	public override int GetHashCode()
	{
		return HashCode.Combine(Name, Engine, MaxSpeed);
	}

}

public class CarsCatalog
{
	private List<Car> cars;

	public CarsCatalog()
	{
		cars = new List<Car>();
	}

	public void AddCar (Car car)
	{
		cars.Add(car);
	}

	public string this[int index]
	{
		get
		{
			if (index < 0 || index >= cars.Count)
				throw new IndexOutOfRangeException("Index is out of range.");
			Car car = cars[index];
			return $"{car.Name} - {car.Engine}";
		}
	}
}
