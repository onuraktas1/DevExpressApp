using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.DAL.Repositories;
using CafeOtomasyon.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Concrete.EntityFramework
{
    public class EfRolRepository : EntityRepositoryBase<Rol>, IRolDal
    {
    }
}
