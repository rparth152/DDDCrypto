using AutoMapper;
using CryptoWebAPI.Application.Interfaces;
using CryptoWebAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWebAPI.Application.Mapping
{
    public class Mapping : Profile
    {
        public Mapping() {
            CreateMap<UserMaster, UsersDTO>();
        }
    }
}
