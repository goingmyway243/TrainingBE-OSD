﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public abstract class BaseEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
