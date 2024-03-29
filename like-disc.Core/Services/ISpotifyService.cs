﻿using like_disc.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace like_disc.Core.Services
{
    public interface ISpotifyService<TEntity> where TEntity : class
    {
        public Task<TEntity> Get(string param, Token token);
    }
}
