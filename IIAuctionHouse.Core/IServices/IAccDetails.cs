using System;
using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IAccDetails
    {
        List<AccDetails> GetAllAccDetails();
        AccDetails GetAccDetailsById(int id);
        AccDetails DeleteAccDetails(int id);
        AccDetails CreateAccDetails(string address, int phoneNumber, string email, DateTime accCreationDate);
        AccDetails UpdateAccDetails(AccDetails accDetails);
    }
}