using System;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.DAL.Data;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Entity;
using System.Linq;


namespace OnlineJobPortal.DAL.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private JobDbContext _jobDbContext;
        public AdminRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }
        public string Delete(int AdminId)
        {
            AdminDetails admin = _jobDbContext.adminDetails.Find(AdminId);
            if (admin != null)
            {
                _jobDbContext.adminDetails.Remove(admin);
                _jobDbContext.SaveChanges();
            }
            return "Deleted";
        }

        public string Save(AdminDetails adminDetails)
        {
            _jobDbContext.adminDetails.Add(adminDetails);
            _jobDbContext.SaveChanges();
            return "Saved";
        }

        public string Update(AdminDetails adminDetails)
        {
            _jobDbContext.Entry(adminDetails).State = EntityState.Modified;
            _jobDbContext.SaveChanges();
            return "Updated";
        }
    }
}
