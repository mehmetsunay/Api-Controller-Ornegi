using HospitalFinder;
using HospitalFinder.Business.Abstract;
using HospitalFinder.Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelfinder.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private IHospitalService _hospitalService;


        public HospitalController()
        {
            _hospitalService = new HospitalManager();
        }

        [HttpGet]
        public List<Hospital> Get()
        {

            return _hospitalService.GetAllHospital();

        }


        [HttpGet("{id}")]
        public Hospital Get(int id)
        {

            return _hospitalService.GetHospitalById(id);

        }
        [HttpPost]
        public Hospital Post([FromBody] Hospital hospital)
        {
            return _hospitalService.CreateHospital(hospital);
        }
        [HttpPut]
        public Hospital Put([FromBody] Hospital hospital)
        {
            return _hospitalService.UpdateHospital(hospital);
        }

       public void Delete(int id)
        {
            _hospitalService.DeleteHospital(id);
        }
    }
}
