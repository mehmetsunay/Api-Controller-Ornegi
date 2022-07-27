using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.Business.Abstract
{
    public interface IHospitalService
    {
        List<Hospital> GetAllHospital();
        Hospital GetHospitalById(int id);
        Hospital CreateHospital(Hospital hospital);
        Hospital UpdateHospital(Hospital hospital);
        void DeleteHospital(int id);
    }
}
