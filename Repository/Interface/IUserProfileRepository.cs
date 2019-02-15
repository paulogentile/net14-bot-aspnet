using SimpleBot.Model;

namespace SimpleBot.Repository.Interface
{
    public interface IUserProfileRepository
    {
        UserProfile GetProfile(string id);
        void SetProfile(string id, UserProfile profile);
    }
}
