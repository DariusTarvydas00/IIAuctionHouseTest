using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IAdminService
    {
        List<Admin> GetAllAdmins();
        Admin GetAdminById(int id);
        Admin CreateAdmin(string firstName, string lastName, AccDetails accDetails, Proprietary proprietaries);
        Admin DeleteAdmin(int id);
        Admin UpdateAdmin(Admin admin);
    }
}