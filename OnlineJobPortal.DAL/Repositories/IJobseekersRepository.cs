using System;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.Entity;

namespace OnlineJobPortal.DAL.Repositories
{
    interface IJobseekersDetails
    {
        string Save(JobseekersDetails jobseekersDetails);
        string Update(JobseekersDetails jobseekersDetails);
        string Delete(int Id);
        JobseekersDetails Get(int Experience);
        List<JobseekersDetails> GetAll();
    }
}
