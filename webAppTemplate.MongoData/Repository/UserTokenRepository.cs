﻿using MongoDB.Driver;
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
    public class UserTokenRepository : EntityService<UserToken>, IUserTokenRepository
    {
        public async Task<UserToken> GetUserToken(string username)
        {
            var builder = Builders<UserToken>.Filter;
            var filter = builder.Eq("Email", username);
            var token = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (token != null){         
                if (token.Any())
                {
                    return token.FirstOrDefault();
                }
            }
            return null;
        }

        public async Task<bool> IsTokenValid(string userToken)
        {
            var builder = Builders<UserToken>.Filter;
            var filter = builder.Eq("Token", userToken);
            var token = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (token != null)
            {
                if (token.Any())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
