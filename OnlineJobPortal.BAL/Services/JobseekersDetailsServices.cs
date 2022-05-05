using System;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.DAL.Repositories;
using OnlineJobPortal.Entity;

namespace OnlineJobPortal.BAL.Services
{
    public class JobseekersDetailsServices
    {
        private IJobseekersRepository _jobseekersRepository;
        public JobseekersDetailsServices(IJobseekersRepository jobseekersRepository)
        {
            _jobseekersRepository = jobseekersRepository;
        }
        public string Save(JobseekersDetails jobseekersDetails)
        {
            return _jobseekersRepository.Save(jobseekersDetails);
        }
        public string Delete(int Id)
        {
            return _jobseekersRepository.Delete(Id);
        }
        public JobseekersDetails Get(int Experience)
        {
            return _jobseekersRepository.Get(Experience);
        }
        public string Update(JobseekersDetails jobseekersDetails)
        {
            return _jobseekersRepository.Update(jobseekersDetails);
        }
        public List<JobseekersDetails> GetAll()
        {
            return _jobseekersRepository.GetAll();
        }
    }
}
