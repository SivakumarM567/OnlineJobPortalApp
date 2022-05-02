using OnlineJobPortal.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Entity;
using System.Linq;

namespace OnlineJobPortal.DAL.Repositories
{
    public class JobseekersRepository : IJobseekersRepository
    {
        private JobDbContext _jobDbContext;
        public JobseekersRepository(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }
        public string Delete(int Id)
        {
            JobseekersDetails jobseeker = _jobDbContext.jobseekersDetails.Find(Id);
            if (jobseeker != null)
            {
                _jobDbContext.jobseekersDetails.Remove(jobseeker);
                _jobDbContext.SaveChanges();
            }
            return "Deleted";
        }
        public JobseekersDetails Get(int Experience)
        {
            JobseekersDetails jobseeker = _jobDbContext.jobseekersDetails.Find(Experience);
            return jobseeker;
        }
        public List<JobseekersDetails> GetAll()
        {
            List<JobseekersDetails> jobseekerslist = _jobDbContext.jobseekersDetails.ToList();
            return jobseekerslist;
        }
        public string Save(JobseekersDetails jobseekersDetails)
        {
            _jobDbContext.jobseekersDetails.Add(jobseekersDetails);
            _jobDbContext.SaveChanges();
            return "Saved";
        }
        public string Update(JobseekersDetails jobseekersDetails)
        {
            _jobDbContext.Entry(jobseekersDetails).State = EntityState.Modified;
            _jobDbContext.SaveChanges();
            return "Updated";
        }
    }
}
