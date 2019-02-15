using SimpleBot.Model;
using SimpleBot.Repository;
using SimpleBot.Repository.Interface;

namespace SimpleBot.Logic
{
    public class SimpleBotUser
    {
        static IUserProfileRepository _userProfile;

        static SimpleBotUser()
        {
            _userProfile = new UserProfileMongoRepository("mongodb://127.0.0.1");
        }

        public static string Reply(Message message)
        {
            var id = message.Id;

            var profile = _userProfile.GetProfile(id);

            profile.Visitas += 1;

            _userProfile.SetProfile(id, profile);

            return $"{message.User} disse '{message.Text} e mandou {profile.Visitas} mensagens'";
        }

    }
}