using CafeOtomasyon.DAL.Abstract;
using CafeOtomasyon.Entity.Abstract;
using CafeOtomasyon.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Abstract
{
    public interface IMenuService : IGenericService<Menu>
    {

    }
}
