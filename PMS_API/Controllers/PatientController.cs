using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMS_Business.Interfaces;
using PMS_Models;
using Microsoft.AspNetCore.Authorization;

namespace PMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PatientController : ControllerBase
    {
        private readonly IPatientBusiness _patientBusiness;
        public PatientController(IPatientBusiness patientBusiness)
        {
            _patientBusiness = patientBusiness;
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Physician,Nurse,Patient")]
        public async Task<ActionResult<IEnumerable<PatientModel>>> GetAllPatients()
        {
            var patients = await _patientBusiness.GetAll();
            return Ok(patients);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Physician,Nurse,Patient")]
        public async Task<ActionResult<bool>> AddPatient(PatientModel patientModel)
        {
            try
            {


                var result = await _patientBusiness.AddPatient(patientModel);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
