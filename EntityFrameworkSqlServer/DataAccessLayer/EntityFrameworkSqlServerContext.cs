// ***********************************************************************
// Assembly         : EntityFrameworkSqlServer
// Author           : Bassam Alugili
// ***********************************************************************
// <copyright file="EntityFrameworkSqlServerContext.cs" company="EntityFrameworkSqlServer">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using EntityFrameworkSqlServer.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSqlServer.DataAccessLayer
{
  /// <summary>
  /// Class EntityFrameworkSqlServerContext. This class cannot be inherited.
  /// Implements the <see cref="Microsoft.EntityFrameworkCore.DbContext" />
  /// </summary>
  /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
  public sealed class EntityFrameworkSqlServerContext : DbContext
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityFrameworkSqlServerContext"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public EntityFrameworkSqlServerContext(DbContextOptions<EntityFrameworkSqlServerContext> options)
      : base(options)
    {
      this.Database.EnsureCreated();
    }

    /// <summary>
    /// Gets or sets the products.
    /// </summary>
    /// <value>The products.</value>
    public DbSet<Product> Products { get; set; }
  }
}