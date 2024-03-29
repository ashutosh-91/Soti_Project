﻿using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class DoctorRepositoryImpl : DoctorRepository
    {
        private readonly AppDbContext _context;
        public DoctorRepositoryImpl(AppDbContext _con)
        {
            _context = _con;
        }
        public bool AddDoctor(IDoctor doctor)
        {
            try
            {


                _context.Doctors.Add(doctor);
                int rows = _context.SaveChanges();
                if (rows > 0)
                {
                    return true;
                }
                return false;
            } catch (Exception ex)
            {
                return false;
            }
        
        }

        public bool DeleteDoctor(int id)
        {
            try
            {
                var doctor = _context.Doctors.FirstOrDefault(x => x.DoctorId == id);

                if (doctor != null)
                {
                    _context.Doctors.Remove(doctor);
                    int rows = _context.SaveChanges();
                    if (rows > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public List<IDoctor> GetAllDoctors()
        {
            return _context.Doctors.ToList();
        }

        public bool UpdateDoctorDetails(IDoctor doctor)
        {
            try
            {
                var doc = _context.Doctors.FirstOrDefault(x => x.DoctorId == doctor.DoctorId);
                doc.DoctorName = doctor.DoctorName;
                int rows = _context.SaveChanges();
                if (rows > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
           

        }
    }
}
