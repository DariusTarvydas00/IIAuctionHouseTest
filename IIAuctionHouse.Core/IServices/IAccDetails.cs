using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IAccDetails
    {
        List<AccDetails> GetAllAccDetails();
    }
}