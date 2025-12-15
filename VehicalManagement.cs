using System;

class Vehicle
{
    private string brand;
    private string model;
    private double price;

    protected int wheels;

    public double Price
    {
        get { return price; }
    }

    public virtual void Input()
    {
        Console.Write("Enter Brand: ");
        brand = Console.ReadLine();

        Console.Write("Enter Model: ");
        model = Console.ReadLine();

        Console.Write("Enter Price: ");
        price = double.Parse(Console.ReadLine());
    }

    public virtual double CalculateInsurance()
    {
        return price * 0.05; 
    }

    public virtual void Display()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Insurance: " + CalculateInsurance());
    }
}

class Bike : Vehicle
{
    private int engineCC;

    public override void Input()
    {
        base.Input();
        wheels = 2;

        Console.Write("Enter Engine CC: ");
        engineCC = int.Parse(Console.ReadLine());
    }

    public override double CalculateInsurance()
    {
        double baseIns = base.CalculateInsurance();

        if (engineCC <= 150)
	{
            return baseIns + Price * 0.02;
	}
        else if (engineCC <= 300)
	{
            return baseIns + Price * 0.05;
	}
        else
	{
            return baseIns + Price * 0.08;
	}
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Engine CC: " + engineCC);
        Console.WriteLine("---------------------");
    }
}

class Car : Vehicle
{
    private string fuelType;

    public override void Input()
    {
        base.Input();
        wheels = 4;

        Console.Write("Enter Fuel Type: ");
        fuelType = Console.ReadLine();
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Fuel Type: " + fuelType);
        Console.WriteLine("---------------------");
    }
}

class Truck : Vehicle
{
    private double loadInTons;

    public override void Input()
    {
        base.Input();
        wheels = 6;

        Console.Write("Enter Load in Tons: ");
        loadInTons = double.Parse(Console.ReadLine());
    }

    public override double CalculateInsurance()
    {
        return base.CalculateInsurance() + (loadInTons * 1000);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Load in Tons: " + loadInTons);
        Console.WriteLine("---------------------");
    }
}

class VehicleManagement
{
    private Vehicle[] vehicles;
    private int count;

    public VehicleManagement(int size)
    {
        vehicles = new Vehicle[size];
        count = 0;
    }

    public void AddVehicle(Vehicle v)
    {
        v.Input();
        vehicles[count++] = v;
    }

    public void DisplayAll()
    {
        for (int i = 0; i < count; i++)
        {
            vehicles[i].Display();
        }
    }

    public void MaxPriceVehicle()
    {
        Vehicle max = vehicles[0];

        for (int i = 1; i < count; i++)
        {
            if (vehicles[i].Price > max.Price)
	    {
                max = vehicles[i];
	    }
        }

        Console.WriteLine("Maximum Price Vehicle:");
        max.Display();
    }

    public void MaxInsuranceVehicle()
    {
        Vehicle max = vehicles[0];

        for (int i = 1; i < count; i++)
        {
            if (vehicles[i].CalculateInsurance() > max.CalculateInsurance())
            {
		   max = vehicles[i];
	    }
        }

        Console.WriteLine("Maximum Insurance Vehicle:");
        max.Display();
    }
}

class Program
{
    static void Main()
    {
        VehicleManagement vm = new VehicleManagement(3);

        Console.WriteLine("Enter Bike Details");
        vm.AddVehicle(new Bike());

        Console.WriteLine("\nEnter Car Details");
        vm.AddVehicle(new Car());

        Console.WriteLine("\nEnter Truck Details");
        vm.AddVehicle(new Truck());

        Console.WriteLine("\nAll Vehicle Details:");
        vm.DisplayAll();

        vm.MaxPriceVehicle();
        vm.MaxInsuranceVehicle();
    }
}
