﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstWebServer.Models.Entities;

namespace MyFirstWebServer.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<SubscribeModel> Subscribers { get; set; }
    
    public DbSet<TagModel> Tags { get; set; }
    public DbSet<CategoryModel> Categories { get; set; }
    public DbSet<PostModel> Posts { get; set; }
    
    public DbSet<PersonModel> Persons { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
}