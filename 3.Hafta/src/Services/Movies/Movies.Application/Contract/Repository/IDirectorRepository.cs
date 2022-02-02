﻿using Movies.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Contract.Repository
{
    public interface IDirectorRepository : IAsyncRepository<Director>
    {
    }
}
