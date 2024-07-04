using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmCTK.Initiate.Services
{
    public class MemoryCarCollection : ICarCollection
    {
        private List<string> _cars = new List<string>{"Lambo", "BMW", "Audi", "Toyota"};

        public IEnumerable<string> GetAllCars()
        {
            return _cars;
        }

        public async Task<IEnumerable<string>> GetAllCarsAsync()
        {
            await Task.Delay(3000);
            return _cars;
        }

        public void AddCar(string car)
        {
            _cars.Add(car);
        }
    }
}