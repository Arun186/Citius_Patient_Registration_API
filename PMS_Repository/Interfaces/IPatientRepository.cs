using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PMS_Repository.Dtos;

namespace PMS_Repository.Interfaces
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAll();

        Task<Patient> GetPatientById(int id);

        Task<int> AddPatient(Patient patient);

        Task<bool> RemovePatient(int patientId);

        Task<int> EditPatient(Patient patient);
        
    }
}
