using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IProprietaryService
    {
        List<Proprietary> GetAllProprietaries();
    }
}