using System;
using System.Collections.Generic;

using System.Threading.Tasks;
using PMS_Repository.Dtos;
using PMS_Repository.Interfaces;
using System.Transactions;
using System.Linq;


namespace PMS_Repository.Implementations
{
    public class PatientRepository : IPatientRepository
    {

        private readonly UnitOfWork.UnitOfWork _unitOfWork;

        #region Public Constructor

        public PatientRepository()
        {
            _unitOfWork = new UnitOfWork.UnitOfWork();
        }

        #endregion

        public async Task<int> AddPatient(Patient patient)
        {

            patient.CreatedAt = DateTime.Now;
            _unitOfWork.PatientRepository.Insert(patient);
            return await _unitOfWork.Save();
        }

        public Task<int> EditPatient(Patient patient)
        {
            return null;
        }

        public async Task<IEnumerable<Patient>> GetAll()
        {
            var patients = await _unitOfWork.PatientRepository.GetAll();
            if (patients != null)
            {
                return patients;
            }
            return null;
        }

        public async Task<Patient> GetPatientById(int id)
        {
            var patient = await _unitOfWork.PatientRepository.GetByID(id);
            if (patient != null)
            {
                return patient;
            }
            return null;
        }

        public async Task<bool> RemovePatient(int patientId)
        {
            bool result = false;
            if (patientId > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var patient = await _unitOfWork.PatientRepository.GetByID(patientId);
                    if (patient != null)
                    {
                        _unitOfWork.PatientRepository.Delete(patient);
                        _unitOfWork.Save();
                        scope.Complete();
                        result = true;

                    }
                }
            }
            return result;
        }
    }
}
