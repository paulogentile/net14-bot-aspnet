using SimpleBot.Model;
using SimpleBot.Repository.Interface;
using System.Collections.Generic;

namespace SimpleBot.Repository
{
    public class UserProfileMemRepository : IUserProfileRepository
    {
        static Dictionary<string, UserProfile> _dictProfiles = new Dictionary<string, UserProfile>();

        public UserProfile GetProfile(string id)
        {
            _dictProfiles.TryGetValue(id, out var profile);

            if (profile == null)
            {
                return new UserProfile()
                {
                    Id = id,
                    Visitas = 0
                };
            }

            return profile;
        }

        public void SetProfile(string id, UserProfile profile)
        {
            _dictProfiles[id] = profile;
        }
    }
}