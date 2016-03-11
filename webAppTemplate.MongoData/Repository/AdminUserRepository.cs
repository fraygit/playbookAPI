using MongoDB.Driver;
using playbook.MongoData.Interface;
using playbook.MongoData.Model;
using playbook.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playbook.MongoData.Repository
{
    public class AdminUserRepository : EntityService<AdminUser>, IAdminUserRepository
    {
        public async Task<AdminUser> Get(string adminUsername)
        {
            var builder = Builders<AdminUser>.Filter;
            var filter = builder.Eq("Email", adminUsername);
            var users = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (users.Any())
                return users.FirstOrDefault();
            return null;
        }
    }
}
