using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IAccDetailsService
    {
        List<AccDetails> GetAllAccDetails();
    }
}