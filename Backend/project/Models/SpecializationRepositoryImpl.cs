using System.Numerics;

namespace project.Models
{
    public class SpecializationRepositoryImpl : SpecializationRepository
    {
        private readonly AppDbContext _context;
        public SpecializationRepositoryImpl(AppDbContext _con)
        {
            _context = _con;
        }
        public bool AddSpecialization(Specialization specialization)
        {
            _context.Specializations.Add(specialization);
            int rows = _context.SaveChanges();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteSpecialization(string code)
        {
            var specialization = _context.Specializations.FirstOrDefault(x => x.SpecializationCode == code);
            if (specialization != null)
            {
                _context.Specializations.Remove(specialization);
                int rows = _context.SaveChanges();
                if (rows > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Specialization> GetAllSpecializations()
        {
            return _context.Specializations.ToList();
        }

        public Specialization GetSpecializationByCode(string code)
        {
            return _context.Specializations.FirstOrDefault(x => x.SpecializationCode == code);
        }
        public Specialization GetSpecializationByName(string name)
        {
            return _context.Specializations.FirstOrDefault(x=>x.SpecializationName==name);
        }

        public bool UpdateSpecialization(Specialization specialization)
        {
            var data = GetSpecializationByCode(specialization.SpecializationCode);
            data.SpecializationCode = specialization.SpecializationCode;
            data.SpecializationName = specialization.SpecializationName;
            int rows = _context.SaveChanges();
            if (rows > 0)
            {
                return true;
            }
            return false;
        }


       

    }
}
