using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using playbook.MongoData.Interface;
using playbook.MongoData.Model;
using playbook.MongoData.Service;

namespace playbook.MongoData.Repository
{
    public class UserRepository : EntityService<User>, IUserRepository
    {
        public async Task<User> GetUser(string username)
        {
            var builder = Builders<User>.Filter;
            var filter = builder.Eq("Email", username);
            var users = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (users.Any())
                return users.FirstOrDefault();
	        return null;
        }
    }
}
