using System.Collections.Generic;
using System.Threading.Tasks;

namespace MvvmCTK.Initiate.Services
{
    public interface ICarCollection
    {
        IEnumerable<string> GetAllCars();
        Task<IEnumerable<string>> GetAllCarsAsync();
        void AddCar(string car);
    }
}