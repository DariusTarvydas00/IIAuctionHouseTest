using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}