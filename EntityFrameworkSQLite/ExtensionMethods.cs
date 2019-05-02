// ***********************************************************************
// Assembly         : EntityFrameworkSQLite
// Author           : Bassam alugili
//
// ***********************************************************************
// <copyright file="ExtensionMethods.cs" company="EntityFrameworkSQLite">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkSQLite
{
  /// <summary>
  /// Class ExtensionMethods.
  /// </summary>
  public static class ExtensionMethods
    {
    /// <summary>
    /// Migrates the database.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="webHost">The web host.</param>
    /// <returns>IWebHost.</returns>
    public static IWebHost CreateDatabase<T>(this IWebHost webHost) where T : DbContext
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var db = services.GetRequiredService<T>();
                    db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Database Creation/Migrations failed!");
                }
            }
            return webHost;
        }
    }
}