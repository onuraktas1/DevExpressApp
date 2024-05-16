using CafeOtomasyon.DAL.Concrete;
using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.DAL.Abstract
{
    public interface IMasaDal : IEntityRepository<Masa>
    {
    }
}
