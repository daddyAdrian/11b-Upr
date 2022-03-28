using NUnit.Framework;
using System;
using CarManager;

namespace CarManager.Tests
{
    [TestFixture]
    public class CarTests
    {
        
        
            [SetUp]
            public void Setup()
            {
            }

            [Test]
            public void ConstructorShouldInitializeCorrectly()
            {
            //public Car(string make, string model, double fuelConsumption, double fuelCapacity)
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
            


            }

            [Test]
            public void ModelShouldThrowArgExWhenNameIsNull()
            {
            string make = "aaa";
            string model = null;
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            var ex =Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Model cannot be null or empty!"));

            }

            [Test]
            public void MakeShouldThrowArgExWhenNameIsNull()
            {
            string make = null;
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Make cannot be null or empty!"));

        }

            [Test]
            public void FuelConsumptionShouldThrowArgExWhenIsBellowZero()
            {

            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = -1;
            double fuelCapacity = 40;

            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

            [Test]
            public void FuelConsumptionShouldThrowArgExWhenIsZero()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 0;
            double fuelCapacity = 40;

            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Fuel consumption cannot be zero or negative!"));
        }

            [Test]
            public void FuelCapacityShouldThrowArgExWhenIsZero()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 0;

            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

            [Test]
            public void FuelCapacityShouldThrowArgExWhenIsBellowZero()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = -1;

            var ex = Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            Assert.That(ex.Message, Is.EqualTo("Fuel capacity cannot be zero or negative!"));
        }

            [Test]
            [TestCase(null, "Golf", 5, 100)]
            [TestCase("Wv", null, 5, 100)]
            [TestCase("Wv", "Golf", -5, 100)]
            [TestCase("Wv", "Golf", 5, -100)]
            [TestCase("Wv", "Golf", 5, 0)]
            
            public void ValidateAllProperties(string make, string model, double fuelConsumption, double fuelCapacity)
            {
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
            }


            [Test]
            public void ShouldRefuelNormally()
            {

            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(10);
            Assert.AreEqual(10, car.FuelAmount);

        }

            [Test]
            public void ShouldRefuelUntillTotalFuelCapacity()
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(50);
            Assert.AreEqual(40, car.FuelAmount);
        }

            [Test]
            [TestCase(-50)]
            [TestCase(0)]
            //TO DO
            public void ShouldRefuelThrowArgExWhenInputAmountIsBelloZero(double inputAmount)
            {
            string make = "aaa";
            string model = "bbb";
            double fuelConsumption = 5;
            double fuelCapacity = 40;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<ArgumentException>(() => car.Refuel(inputAmount));
        }

            [Test]
            public void ShouldDriveNormally()
            {
                Car car = new Car("Vw", "Golf", 2, 100);
                car.Refuel(30);
                car.Drive(20);
                Assert.AreEqual(29.60, car.FuelAmount);
            }

            [Test]
            public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
            {
                Car car = new Car("Vw", "Golf", 2, 100);
                Assert.Throws<InvalidOperationException>(() => car.Drive(20));
            }
        }

    }
