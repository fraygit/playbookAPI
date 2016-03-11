﻿using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using playbook.MongoData.Entities.Base;

namespace playbook.MongoData.Service
{
    public interface IEntityService<T> where T : IMongoEntity
    {
        void Create(T entity);
        Task<List<T>> ListAll();
        Task<bool> CreateSync(T entity);
        Task<DeleteResult> Delete(string id);
        Task<ReplaceOneResult> Update(string id, T entity);
        Task<T> Get(string id);
    }
}
