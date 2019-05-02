// ***********************************************************************
// Assembly         : EntityFrameworkSQLite
// Author           : Bassam Alugili
// ***********************************************************************
// <copyright file="Order.cs" company="EntityFrameworkSQLite">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.ObjectModel;

namespace EntityFrameworkSQLite.Entities
{
  /// <summary>
  /// Class Order.
  /// </summary>
  public class Order
  {
    /// <summary>
    /// Gets or sets the order identifier.
    /// </summary>
    /// <value>The order identifier.</value>
    public int OrderId { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the product ids.
    /// </summary>
    /// <value>The product ids.</value>
    Collection<int> ProductIds { get; set; } = new Collection<int>();
  }
}