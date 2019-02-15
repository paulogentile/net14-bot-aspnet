﻿using System.Data.Entity;

namespace SimpleBot.Infra
{
    public class Context : DbContext
    {
        public Context(string connectionString) : base(connectionString)
        {
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserProfileConfiguration());
            base.OnModelCreating(modelBuilder);

        }
    }
}