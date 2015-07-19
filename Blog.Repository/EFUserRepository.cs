using System.Collections.Generic;
using System.Linq;
using System.Configuration;

using Blog.Entities;

namespace Blog.Repository
{
    public class EFUserRepository : IUserRepository
    {
        #region Fields
        BlogEntities entities = new BlogEntities();
        private readonly string _connectionString;
        #endregion

        #region Constructors
        public EFUserRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public EFUserRepository()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["BlogEntities"].ConnectionString;
        }
        #endregion
        public User GetUser(string login)
        {
            return entities.User.Single<User>(u => u.Login == login);
        }
        public List<User> GetUsers()
        {
            return entities.User.Select<User, User>(u => u).ToList();
        }
        public void UpdateUser(int Id, bool? IsEnable, bool? IsAdmin)
        {
            User user = entities.User.Find(Id);

            if (IsEnable != null)
            {
                user.IsEnable = (bool)IsEnable;
            }
            if (IsAdmin != null)
            {
                user.IsAdmin = (bool)IsAdmin;
            }

            entities.SaveChanges();
        }
        public void CreateUser(User user)
        {
            entities.User.Add(user);
            entities.SaveChanges();
        }
    }
}
