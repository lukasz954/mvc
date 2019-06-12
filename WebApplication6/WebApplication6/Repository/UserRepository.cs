using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication6.Models;
using WebApplication6.TestData;

namespace WebApplication6.Repository
{
    public class UserRepository : IRepository<User>
    {
        private UserData _userData;
        public UserRepository()
        {
            _userData = new UserData();
        }
        public List<User> EntitiesList { get => _userData.Users().ToList(); set =>_userData.Users(); }

        public void Add(User entity) => EntitiesList.Add(entity);

        public void Delete(User entity) => EntitiesList.Remove(entity);
        public IEnumerable<User> Get() => EntitiesList;

        public User GetById(int id) => EntitiesList.Single(x => x.Id == id);

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}