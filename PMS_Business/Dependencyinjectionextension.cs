
using System;
using System.Collections.Generic;
using System.Text;
using PMS_Repository.Interfaces;
using PMS_Repository.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace PMS_Models
{
   public static class Dependencyinjectionextension
    {
        public static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services)
        {
            services.AddTransient<IPatientRepository,PatientRepository>();
            return services;
        }
    }
}
