using CSharpEducationCamp301.DataAccessLayer.Abstract;
using CSharpEducationCamp301.DataAccessLayer.Repositories;
using CSharpEducationCamp301.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEducationCamp301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>, IAdminDal
    {
    }
}
