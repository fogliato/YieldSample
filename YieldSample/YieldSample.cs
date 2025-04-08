namespace YieldSample
{
    public class YieldSamplePratice
    {
        public List<CarDto> Cars { get; set; }

        public YieldSamplePratice()
        {
            Cars = GetCars();
        }

        public List<CarDto> GetCars()
        {
            List<CarDto> cars = new List<CarDto>();
            var car1 = new CarDto
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2020,
                Color = "Blue",
                LicensePlate = "ABC123",
                Vin = "1HGCM82633A123456",
                Mileage = 15000,
                OwnerName = "John Doe",
                OwnerAddress = "123 Main St, Springfield, IL",
                OwnerPhoneNumber = "555-1234"
            };
            cars.Add(car1);
            var car2 = new CarDto
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2019,
                Color = "Red",
                LicensePlate = "XYZ789",
                Vin = "1HGCM82633A654321",
                Mileage = 20000,
                OwnerName = "Jane Smith",
                OwnerAddress = "456 Elm St, Springfield, IL",
                OwnerPhoneNumber = "555-5678"
            };
            cars.Add(car2);
            var car3 = new CarDto
            {
                Make = "Ford",
                Model = "Mustang",
                Year = 2021,
                Color = "Black",
                LicensePlate = "LMN456",
                Vin = "1HGCM82633A987654",
                Mileage = 5000,
                OwnerName = "Alice Johnson",
                OwnerAddress = "789 Oak St, Springfield, IL",
                OwnerPhoneNumber = "555-9012"
            };
            cars.Add(car3);
            return cars;
        }

        public IEnumerable<CarDto> Get2025CarsWithYield()
        {
            foreach (var car in Cars)
            {
                car.Year = 2025;
                yield return car;
            }
        }

        public List<CarDto> Get2025CarsWithoutYield()
        {
            List<CarDto> cars = new List<CarDto>();
            foreach (var car in Cars)
            {
                car.Year = 2025;
                cars.Add(car);
            }
            return cars;
        }
    }
}
