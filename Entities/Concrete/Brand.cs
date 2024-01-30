﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int BrandId { get; set; }
        public required string BrandName { get; set; }
    }
}
