using HospitalFinder.Business.Abstract;
using HospitalFinder.DataAccess.Abstract;
using HospitalFinder.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.Business.Concrete
{
    public class HospitalManager : IHospitalService
    {
        private IHospitalRepository _hospitalRepository;

        public HospitalManager()
        {
            _hospitalRepository = new HospitalRepository();
        }
        public Hospital CreateHospital(Hospital hospital)
        {
            return _hospitalRepository.CreateHospital(hospital);
        }

        public void DeleteHospital(int id)
        {
            _hospitalRepository.DeleteHospital(id);
        }

        public List<Hospital> GetAllHospital()
        {
            return _hospitalRepository.GetAllHospital();
        }

        public Hospital GetHospitalById(int id)
        {
            if (id>0)
            {
                return _hospitalRepository.GetHospitalById(id);
            }
            throw new Exception("id sıfırdan küçük olamaz");
        }

        public Hospital UpdateHospital(Hospital hospital)
        {
            return _hospitalRepository.UpdateHospital(hospital);
        }
    }
}
