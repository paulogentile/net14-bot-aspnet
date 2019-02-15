using System.Data.Entity;
using System.Linq;
using SimpleBot.Model;
using SimpleBot.Repository.Interface;
using SimpleBot.Infra;

namespace SimpleBot.Repository
{
    public class UserProfileSqlRepository : IUserProfileRepository
    {
        private DbContext _context;

        public UserProfileSqlRepository(string connectionString)
        {
            var db = new Context(connectionString);
            this._context = db;
        }

        public UserProfile GetProfile(string id)
        {
            var profile = _context.Set<UserProfile>().FirstOrDefault(x => x.Id == id);

            if (profile == null)
                return null;

            return new UserProfile
            {
                Id = profile.Id,
                Visitas = profile.Visitas
            };
        }

        public void SetProfile(string id, UserProfile profile)
        {
            _context.Set<UserProfile>().Add(profile);
            _context.SaveChanges();
        }
    }
}