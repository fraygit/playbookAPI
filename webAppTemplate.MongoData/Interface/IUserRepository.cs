using playbook.MongoData.Model;
using playbook.MongoData.Service;
using System.Threading.Tasks;

namespace playbook.MongoData.Interface
{
    public interface IUserRepository : IEntityService<User>
    {
        Task<User> GetUser(string username);
    }
}
