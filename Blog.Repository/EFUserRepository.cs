using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.Objects;

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

        public void UpdateUser(int Id, bool IsEnable)
        { 
            using ( ObjectContext context = new ObjectContext(_connectionString))
            {
                User user = context.CreateObjectSet<User>().First(u => u.Id == Id);
                user.IsEnable = IsEnable;
                context.SaveChanges();
            }
        }
    }
}
