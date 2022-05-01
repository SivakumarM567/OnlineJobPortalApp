using OnlineJobPortal.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineJobPortal.DAL.Repositories
{
    class JobseekersDetails : IJobseekersDetails
    {
        private JobDbContext _jobDbContext;
        public JobseekersDetails(JobDbContext jobDbContext)
        {
            _jobDbContext = jobDbContext;
        }
        public string Delete(int Id)
        {
            return "Deleted";
        }
        public JobseekersDetails Get(int Experience)
        {
            throw new NotImplementedException();
        }
        public List<JobseekersDetails> GetAll()
        {
            throw new NotImplementedException();
        }
        public string Save(JobseekersDetails jobseekersDetails)
        {
            throw new NotImplementedException();
        }
        public string Update(JobseekersDetails jobseekersDetails)
        {
            throw new NotImplementedException();
        }
    }
}
