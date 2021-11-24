using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IAdminService
    {
        List<Admin> GetAllAdmins();
    }
}