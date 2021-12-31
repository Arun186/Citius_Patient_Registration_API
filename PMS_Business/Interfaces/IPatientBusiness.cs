
using System.Collections.Generic;
using System.Threading.Tasks;
using PMS_Models;

namespace PMS_Business.Interfaces
{
    public interface IPatientBusiness
    {
        Task<IEnumerable<PatientModel>> GetAll();

        Task<PatientModel> GetPatientById(int id);

        Task<bool> AddPatient(PatientModel patient);

        Task<bool> RemovePatient(int patientId);

        Task<bool> EditPatient(PatientModel patient);
    }
}
