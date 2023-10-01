using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // Here's an example that explores principles and patterns for designing focused and easy-to-understand classes in C#

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public string GetMake()
        {
            return make;
        }

        public string GetModel()
        {
            return model;
        }

        public int GetYear()
        {
            return year;
        }

        public double GetPrice()
        {
            return price;
        }
    }

    public class CarCatalog
    {
        private List<Car> cars;

        public CarCatalog()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        public List<Car> GetCars()
        {
            return cars;
        }

        public List<Car> GetCarsByMake(string make)
        {
            return cars.Where(c => c.GetMake() == make).ToList();
        }

        public List<Car> GetCarsByYear(int year)
        {
            return cars.Where(c => c.GetYear() == year).ToList();
        }
    }

    // In this example, we have a  Car  class that represents a car object with properties such as make, model, year, and price.
    // The class provides getter methods for accessing these properties. 

    // The CarCatalog  class manages a collection of cars.It has methods to add and remove cars, as well as retrieve the list of cars.
    // It also provides additional methods to filter cars by make or year. 

    // By following principles like Single Responsibility, Encapsulation, and using patterns like the Repository pattern, we design focused and easy-to-understand classes.
    // These classes have clear responsibilities and provide well-defined interfaces for interacting with the car objects and managing the car catalog.
}
