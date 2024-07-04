using System.Collections.Generic;

namespace MvvmCTK.Services
{
    public interface ICarCollection
    {
        IEnumerable<string> GetAllCars();
        void AddCar(string car);
    }
}