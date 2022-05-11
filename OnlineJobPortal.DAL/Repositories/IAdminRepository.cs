using System;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.Entity;

namespace OnlineJobPortal.DAL.Repositories
{
    public interface IAdminRepository
    {
        string Save(AdminDetails adminDetails);
        string Update(AdminDetails adminDetails);
        string Delete(int AdminId);
    }
}
