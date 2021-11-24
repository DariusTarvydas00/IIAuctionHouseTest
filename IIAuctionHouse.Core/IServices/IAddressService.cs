﻿using System.Collections.Generic;
using Core.Models;

namespace Core.IServices
{
    public interface IAddressService
    {
        List<Address> GetAddresses();
        Address GetAddressById(int id);
        Address DeleteAddress(int id);
        Address UpdateAddress(Address address);
        Address CreateAddress(Address address);
    }
}