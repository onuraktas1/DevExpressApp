﻿using CafeOtomasyon.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Business.Abstract
{
    public interface IMasaService : IGenericService<Masa>
    {
        public List<Masa> GetAllMasaWithKullanici();
    }
}
