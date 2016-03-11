# WebAPIMongoTemplate

### Description
This project aims to be a boilerplate for C# Web API project using MongoDB backend. 

### Structure

The project is broken down into 3 projects

1. Data Layer
2. Web API
3. Website

### Data Layer

To Create a new data model:
1. Create a data model class under webAppTemplate.MongoData > Model which inherit MongoEntity
e.g.
```csharp
using webAppTemplate.MongoData.Entities.Base;

namespace webAppTemplate.MongoData.Model
{
    public class Car : MongoEntity
    {
        public string Make { get; set; }
    }
}
```
2. Create a repository interface under webAppTemplate.MongoData > Interface which inherits IEntityService<YourNewModel>

```csharp
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;

namespace webAppTemplate.MongoData.Interface
{
    public interface ICarRepository : IEntityService<Car>
    {
    }
}
```


3. Create a repository class under webAppTemplate.MongoData > Repository which inherits EntityService<YourNewModel> and YourNewRepositoryInterface

```csharp 
using webAppTemplate.MongoData.Interface;
using webAppTemplate.MongoData.Model;
using webAppTemplate.MongoData.Service;

namespace webAppTemplate.MongoData.Repository
{
    public class CarRepository : EntityService<Car>, ICarRepository
    {
    }
}
```

### Web API

web api uses simple injector. If you have a new repository, register the class in Webapi > Global.asax.cs add the code:

```csharp
container.Register<YourNewRepositoryInterface, YourNewRepository>(Lifestyle.Scoped);
```

### Todo's

1. Authorization and Token
2. YeoMan
3. Angular/React sample website 


License
----

MIT

