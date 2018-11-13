using FunWithForms.Models;

namespace FunWithForms.Repositories
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(AutoContext db) : base(db)
        { }
    }
}
