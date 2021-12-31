using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PMS_Business.Interfaces;
using PMS_Models;
using AutoMapper;
using PMS_Repository.Interfaces;
using PMS_Repository.Dtos;

namespace PMS_Business.Implementations
{
    public class PatientBusiness : IPatientBusiness
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;
        public PatientBusiness(IPatientRepository patientRepository,IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }


        public async Task<bool> AddPatient(PatientModel patient)
        {
            var patientDetails = _mapper.Map<Patient>(patient);
            return (await _patientRepository.AddPatient(patientDetails)>0);
        }

        public async Task<bool> EditPatient(PatientModel patient)
        {
            var patientDetails = _mapper.Map<Patient>(patient);
            // to work later
            return false;
        }

        public async Task<IEnumerable<PatientModel>> GetAll()
        {
            var details = await _patientRepository.GetAll();
            return  _mapper.Map<IEnumerable<PatientModel>>(details);
        }

        public async Task<PatientModel> GetPatientById(int id)
        {
            var patiendDetails = await _patientRepository.GetPatientById(id);
            return _mapper.Map<PatientModel>(patiendDetails);
        }

        public async Task<bool> RemovePatient(int patientId)
        {
           var removePatient = await _patientRepository.RemovePatient(patientId);
            return removePatient;
        }

        
    }
}
