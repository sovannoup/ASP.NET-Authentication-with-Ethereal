using Exchange.Controllers.Request;
using Exchange.Controllers.Response;
using Exchange.Models;

namespace Exchange.Services
{
    public interface IUserService
    {
        UserInfoResponse GetUser(string auth);
        string Login(UserLoginRequest request);
        string CreateUser(CreateUserRequest req);
        string UpdateUser(UpdateUserInfoRequest req);
        string DeleteUser(string auth);
        bool SendMail(string mail, string content);
        string ConfirmEmail(string token);
        Task<string> ForgetPassword(ForgetPasswordRequest req);
        string ChangePassword(string token, string password);
    }
}
