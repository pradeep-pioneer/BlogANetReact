using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogANetReact.Data.Model
{
    public interface IAuthenticationDbContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<RoleEntity> Roles { get; set; }
    }
}
