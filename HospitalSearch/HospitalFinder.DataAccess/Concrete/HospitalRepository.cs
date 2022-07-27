using HospitalFinder.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFinder.DataAccess.Concrete
{
    public class HospitalRepository : IHospitalRepository
    {
        public Hospital CreateHospital(Hospital hospital)
        {
            using(var hospitalDbContext = new HospitalDbContext())
            {
                hospitalDbContext.hospitals.Add(hospital);
                hospitalDbContext.SaveChanges();
                return hospital;
            }
        }

        public void DeleteHospital(int id)
        {
            using (var hospitalDbContext = new HospitalDbContext())
            {
                var deleteHospital = GetHospitalById(id);
                hospitalDbContext.hospitals.Remove(deleteHospital);
                hospitalDbContext.SaveChanges();
            }
        }

        public List<Hospital> GetAllHospital()
        {
            using (var hospitalDbContext = new HospitalDbContext())
            {
                // Context in içindeki DbSet kullandığımız yerden geldi.
                return hospitalDbContext.hospitals.ToList();
            }
        }

        public Hospital GetHospitalById(int id)
        {
            using(var hospitalDbContext = new HospitalDbContext())
            {
                return hospitalDbContext.hospitals.Find(id);
            }
        }

        public Hospital UpdateHospital(Hospital hospital)
        {
            using (var hospitalDbContext = new HospitalDbContext())
            {
                hospitalDbContext.hospitals.Update(hospital);
                hospitalDbContext.SaveChanges();
                return hospital;
            } 
        }
    }
}
