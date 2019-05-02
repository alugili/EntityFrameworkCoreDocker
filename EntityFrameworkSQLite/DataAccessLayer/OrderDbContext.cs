// ***********************************************************************
// Assembly         : EntityFrameworkSQLite
// Author           : Bassam Alugili
//
// ***********************************************************************
// <copyright file="OrderDbContext.cs" company="EntityFrameworkSQLite">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using EntityFrameworkSQLite.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkSQLite.DataAccessLayer
{
  /// <summary>
  /// Class OrderDbContext.
  /// Implements the <see cref="Microsoft.EntityFrameworkCore.DbContext" />
  /// </summary>
  /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
  public class OrderDbContext : DbContext
  {
    /// <summary>
    /// Gets or sets the orders.
    /// </summary>
    /// <value>The orders.</value>
    public DbSet<Order> Orders { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrderDbContext"/> class.
    /// </summary>
    /// <param name="options">The options.</param>
    public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
    {
    }

    /// <summary>
    /// Override this method to further configure the model that was discovered by convention from the entity types
    /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
    /// and re-used for subsequent instances of your derived context.
    /// </summary>
    /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
    /// define extension methods on this object that allow you to configure aspects of the model that are specific
    /// to a given database.</param>
    /// <remarks>If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
    /// then this method will not be run.</remarks>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Order>().HasData
          (
          new Order { OrderId = 1, Name = "MSDN Order" },
          new Order { OrderId = 2, Name = "Docker Order" },
          new Order { OrderId = 3, Name = "EFCore Order" }
          );
    }
  }
}