using playbook.MongoData.Interface;
using playbook.MongoData.Model;
using playbook.MongoData.Service;

namespace playbook.MongoData.Repository
{
    public class CarRepository : EntityService<Car>, ICarRepository
    {
    }
}
