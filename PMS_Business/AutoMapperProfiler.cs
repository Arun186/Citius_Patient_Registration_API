using System;
using System.Collections.Generic;
using System.Text;
using PMS_Models;
using PMS_Repository.Dtos;
using AutoMapper;

namespace PMS_Business
{
    public class AutoMapperProfiler:Profile
    {
        public AutoMapperProfiler()
        {
            CreateMap<PatientModel, Patient>().ReverseMap(); 
        }
    }
}
