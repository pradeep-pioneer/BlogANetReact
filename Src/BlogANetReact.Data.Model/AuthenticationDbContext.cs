﻿using BlogANetReact.Data.Entities;
using BlogANetReact.Data.Entities.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlogANetReact.Data.Model
{
    public class AuthenticationDbContext : IdentityDbContext<UserEntity, RoleEntity, Guid>, IAuthenticationDbContext
    {
        
    }
}