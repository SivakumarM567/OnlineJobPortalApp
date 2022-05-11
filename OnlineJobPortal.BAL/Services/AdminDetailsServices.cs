using System;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.DAL.Repositories;
using OnlineJobPortal.Entity;

namespace OnlineJobPortal.BAL.Services
{
    public class AdminDetailsServices
    {
        private IAdminRepository _adminRepository;
        public AdminDetailsServices(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public string Save(AdminDetails adminDetails)
        {
            return _adminRepository.Save(adminDetails);
        }
        public string Update(AdminDetails adminDetails)
        {
            return _adminRepository.Update(adminDetails);
        }
        public string Delete(int AdminId)
        {
            return _adminRepository.Delete(AdminId);
        }
    }
}
