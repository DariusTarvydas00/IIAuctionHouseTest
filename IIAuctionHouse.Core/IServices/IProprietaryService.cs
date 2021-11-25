using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IProprietaryService
    {
        List<Proprietary> GetAllProprietaries();
        Proprietary GetProprietaryById(int id);
        Proprietary DeleteProprietary(int id);
        Proprietary CreateProprietary(string city, string cadastreNumber, string forestryEnterprise, double geoLocationX, double geoLocationY);
        Proprietary UpdateProprietary(Proprietary proprietary);
    }
}