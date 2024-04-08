<<<<<<< HEAD
﻿namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region GroupByQuery
    /// <summary>
    /// Group products by Size property. orderby is optional, but generally used
    /// </summary>
    public List<IGrouping<string, Product>> GroupByQuery()
    {
      List<IGrouping<string, Product>> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Size
              group prod by prod.Size).ToList();
=======
﻿namespace LINQSamples {
  public class SamplesViewModel : ViewModelBase {
    #region CountQuery
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountQuery() {
      int value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      value = (from prod in products select prod).Count();

      return value;
    }
    #endregion

    #region CountMethod
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountMethod() {
      int value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      value = products.Count;

      return value;
    }
    #endregion

    #region CountFilteredQuery
    /// <summary>
    /// Can either add a where clause or a predicate in the Count() method
    /// </summary>
    public int CountFilteredQuery() {
      int value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products
               select prod)
               .Count(prod => prod.Color == "Red");

      // Write Query Syntax #2 Here
      value = (from prod in products
               where prod.Color == "Red"
               select prod)
               .Count();

      return value;
    }
    #endregion

    #region CountFilteredMethod
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountFilteredMethod() {
      int value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Count(p => p.Color == "Red");

      // Write Method Syntax #2 Here
      value = products.Where(p => p.Color == "Red").Count();

      return value;
    }
    #endregion

    #region MinQuery
    /// <summary>
    /// Get the minimum value of a single property in a collection
    /// </summary>
    public decimal MinQuery() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products select prod.ListPrice).Min();

      // Write Query Syntax #2 Here
      value = (from prod in products select prod).Min(prod => prod.ListPrice);

      return value;
    }
    #endregion

    #region MinMethod
    /// <summary>
    /// Get the minimum value of a single property in a collection
    /// </summary>
    public decimal MinMethod() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(p => p.ListPrice).Min();

      // Write Method Syntax #2 Here
      value = products.Min(p => p.ListPrice);

      return value;
    }
    #endregion

    #region MaxQuery
    /// <summary>
    /// Get the maximum value of a single property in a collection
    /// </summary>
    public decimal MaxQuery() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products select prod.ListPrice).Max();

      // Write Query Syntax #2 Here
      value = (from prod in products select prod).Max(prod => prod.ListPrice);

      return value;
    }
    #endregion

    #region MaxMethod
    /// <summary>
    /// Get the maximum value of a single property in a collection
    /// </summary>
    public decimal MaxMethod() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(p => p.ListPrice).Max();

      // Write Method Syntax #2 Here
      value = products.Max(p => p.ListPrice);

      return value;
    }
    #endregion

    #region MinByQuery
    /// <summary>
    /// Get the minimum value of a single property in a collection, but return the object
    /// </summary>
    public Product MinByQuery() {
      Product product;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      product = (from prod in products select prod).MinBy(prod => prod.ListPrice);

      return product;
    }
    #endregion

    #region MinByMethod
    /// <summary>
    /// Get the minimum value of a single property in a collection, but return the object
    /// </summary>
    public Product MinByMethod() {
      Product product;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      product = products.MinBy(p => p.ListPrice);

      return product;
    }
    #endregion

    #region MaxByQuery
    /// <summary>
    /// Get the maximum value of a single property in a collection, but return the object
    /// </summary>
    public Product MaxByQuery() {
      Product product;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      product = (from prod in products select prod).MaxBy(prod => prod.ListPrice);

      return product;
    }
    #endregion

    #region MaxByMethod
    /// <summary>
    /// Get the maximum value of a single property in a collection, but return the object
    /// </summary>
    public Product MaxByMethod() {
      Product product;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      product = products.MaxBy(p => p.ListPrice);

      return product;
    }
    #endregion

    #region AverageQuery
    /// <summary>
    /// Get the average of all values within a single property in a collection
    /// </summary>
    public decimal AverageQuery() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products select prod.ListPrice).Average();

      // Write Query Syntax #2 Here
      value = (from prod in products select prod).Average(prod => prod.ListPrice);

      return value;
    }
    #endregion

    #region AverageMethod
    /// <summary>
    /// Get the average of all values within a single property in a collection
    /// </summary>
    public decimal AverageMethod() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(p => p.ListPrice).Average();

      // Write Method Syntax #2 Here
      value = products.Average(p => p.ListPrice);

      return value;
    }
    #endregion

    #region SumQuery
    /// <summary>
    /// Gets the sum of the values of a single property in a collection
    /// </summary>
    public decimal SumQuery() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products select prod.ListPrice).Sum();

      // Write Query Syntax #2 Here
      value = (from prod in products select prod).Sum(prod => prod.ListPrice);

      return value;
    }
    #endregion

    #region SumMethod
    /// <summary>
    /// Gets the sum of the values of a single property in a collection
    /// </summary>
    public decimal SumMethod() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(p => p.ListPrice).Sum();

      // Write Method Syntax #1 Here
      value = products.Sum(p => p.ListPrice);

      return value;
    }
    #endregion

    #region AggregateQuery
    /// <summary>
    /// Aggregate allows you to iterate over a collection and perform an accumulation of values.
    /// With this operator you can simulate count, sum, etc.
    /// </summary>
    public decimal AggregateQuery() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      value = (from prod in products
               select prod)
                .Aggregate(0M, (sum, prod) =>
                          sum += prod.ListPrice);

      return value;
    }
    #endregion

    #region AggregateMethod
    /// <summary>
    /// Aggregate allows you to iterate over a collection and perform an accumulation of values.
    /// With this operator you can simulate count, sum, etc.
    /// </summary>
    public decimal AggregateMethod() {
      decimal value;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      value = products.Aggregate(0M, (sum, prod) => sum += prod.ListPrice);

      return value;
    }
    #endregion

    #region AggregateCustomQuery
    /// <summary>
    /// Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
    /// </summary>
    public decimal AggregateCustomQuery() {
      decimal value;
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      value = (from sale in sales
               select sale)
                .Aggregate(0M, (sum, sale) =>
                          sum += (sale.OrderQty * sale.UnitPrice));
>>>>>>> Modulo_13

      return value;
    }
    #endregion

<<<<<<< HEAD
    #region GroupByMethod
    /// <summary>
    /// Group products by Size property. orderby is optional, but generally used
    /// </summary>
    public List<IGrouping<string, Product>> GroupByMethod()
    {
      List<IGrouping<string, Product>> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.OrderBy(p => p.Size).GroupBy(p => p.Size).ToList();
=======
    #region AggregateCustomMethod
    /// <summary>
    /// Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
    /// </summary>
    public decimal AggregateCustomMethod() {
      decimal value;
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      value = sales.Aggregate(0M, (sum, sale) => sum += (sale.OrderQty * sale.UnitPrice));
>>>>>>> Modulo_13

      return value;
    }
    #endregion

<<<<<<< HEAD
    #region GroupByUsingKeyQuery
    /// <summary>
    /// After selecting 'into' new variable, can sort on the 'Key' property. Key property has the value of what you grouped on.
    /// </summary>
    public List<IGrouping<string, Product>> GroupByUsingKeyQuery()
    {
      List<IGrouping<string, Product>> list;
      // Load all Product Data
=======
    #region AggregateUsingGroupByQuery
    /// <summary>
    /// Group products by Size property and calculate min/max/average prices
    /// </summary>
    public List<ProductStats> AggregateUsingGroupByQuery() {
      List<ProductStats> list;
      // Load all Sales Data
>>>>>>> Modulo_13
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
<<<<<<< HEAD
              group prod by prod.Size into sizes
              orderby sizes.Key
              select sizes).ToList();
=======
              group prod by prod.Size into sizeGroup
              where sizeGroup.Count() > 0
              select new ProductStats
              {
                Size = sizeGroup.Key,
                TotalProducts = sizeGroup.Count(),
                MinListPrice = sizeGroup.Min(s => s.ListPrice),
                MaxListPrice = sizeGroup.Max(s => s.ListPrice),
                AverageListPrice = sizeGroup.Average(s => s.ListPrice)
              }
              into result
              orderby result.Size
              select result).ToList();
>>>>>>> Modulo_13

      return list;
    }
    #endregion

<<<<<<< HEAD
    #region GroupByUsingKeyMethod
    /// <summary>
    /// After selecting 'into' new variable, can sort on the 'Key' property. Key property has the value of what you grouped on.
    /// </summary>
    public List<IGrouping<string, Product>> GroupByUsingKeyMethod()
    {
      List<IGrouping<string, Product>> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.GroupBy(prod => prod.Size)
                     .OrderBy(sizes => sizes.Key)
                     .Select(sizes => sizes).ToList();
=======
    #region AggregateUsingGroupByMethod
    /// <summary>
    /// Group products by Size property and calculate min/max/average prices
    /// </summary>
    public List<ProductStats> AggregateUsingGroupByMethod() {
      List<ProductStats> list;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.GroupBy(sale => sale.Size)
                      .Select(sizeGroup => new ProductStats
                      {
                        Size = sizeGroup.Key,
                        TotalProducts = sizeGroup.Count(),
                        MinListPrice = sizeGroup.Min(s => s.ListPrice),
                        MaxListPrice = sizeGroup.Max(s => s.ListPrice),
                        AverageListPrice = sizeGroup.Average(s => s.ListPrice)
                      })
                      .OrderBy(result => result.Size).ToList();
>>>>>>> Modulo_13

      return list;
    }
    #endregion

<<<<<<< HEAD
    #region GroupByWhereQuery
    /// <summary>
    /// Group products by Size property and where the group has more than 2 members
    /// This simulates a HAVING clause in SQL
    /// </summary>
    public List<IGrouping<string, Product>> GroupByWhereQuery()
    {
      List<IGrouping<string, Product>> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Size
              group prod by prod.Size into sizes
              where sizes.Count() > 2
              select sizes).ToList();

      return list;
    }
    #endregion

    #region GroupByWhereMethod
    /// <summary>
    /// Group products by Size property and where the group has more than 2 members
    /// This simulates a HAVING clause in SQL
    /// </summary>
    public List<IGrouping<string, Product>> GroupByWhereMethod()
    {
      List<IGrouping<string, Product>> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.OrderBy(p => p.Size)
                     .GroupBy(prod => prod.Size)
                     .Where(sizes => sizes.Count() > 2)
                     .Select(sizes => sizes).ToList();

      return list;
    }
    #endregion

    #region GroupBySubQueryQuery
    /// <summary>
    /// Group Sales by SalesOrderID, add Products into new Sales Order object using a subquery
    /// </summary>
    public List<SaleProducts> GroupBySubQueryQuery()
    {
      List<SaleProducts> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      list = (from sale in sales
              orderby sale.SalesOrderID
              group sale by sale.SalesOrderID into newSales
              select new SaleProducts
              {
                SalesOrderID = newSales.Key,
                Products = (from prod in products
                            orderby prod.ProductID
                            join sale in sales on prod.ProductID equals sale.ProductID
                            where sale.SalesOrderID == newSales.Key
                            select prod).ToList()
              }).ToList();

      return list;
    }
    #endregion

    #region GroupBySubQueryMethod
    /// <summary>
    /// Group Sales by SalesOrderID, add Products into new Sales Order object using a subquery
    /// </summary>
    public List<SaleProducts> GroupBySubQueryMethod()
    {
      List<SaleProducts> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      list = sales.OrderBy(s => s.SalesOrderID)
                  .GroupBy(sale => sale.SalesOrderID)
                  .Select(newSales => new SaleProducts
                  {
                    SalesOrderID = newSales.Key,
                    Products = products.OrderBy(p => p.ProductID)
                      .Join(newSales, prod => prod.ProductID,
                            sale => sale.ProductID,
                            (prod, sale) => prod).ToList()
                  }).ToList();
=======
    #region AggregateMoreEfficientMethod
    /// <summary>
    /// Use Aggregate with some custom methods to gather the data in one pass 
    /// </summary>
    public List<ProductStats> AggregateMoreEfficientMethod() {
      List<ProductStats> list;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.GroupBy(sale => sale.Size)
              .Where(sizeGroup => sizeGroup.Count() > 0)
              .Select(sizeGroup => {
                // Create the accumulator object and set the Size
                ProductStats acc = new()
                {
                  Size = sizeGroup.Key
                };
>>>>>>> Modulo_13

                // Iterate over the collection one time
                // and calculate all stats for this Size Group
                sizeGroup.Aggregate(acc, (acc, prod) => acc.Accumulate(prod),
                                    acc => acc.ComputeAverage());

<<<<<<< HEAD
    #region GroupByDistinctQuery
    /// <summary>
    /// The Distinct() operator can be simulated using the GroupBy() and FirstOrDefault() operators
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> GroupByDistinctQuery()
    {
      List<string> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      list = (from prod in products
              orderby prod.Color
              group prod by prod.Color into groupedColors
              select groupedColors.FirstOrDefault().Color).ToList();

      return list;
    }
    #endregion

    #region GroupByDistinctMethod
    /// <summary>
    /// The Distinct() operator can be simulated using the GroupBy() and FirstOrDefault() operators
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> GroupByDistinctMethod()
    {
      List<string> list;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.GroupBy(p => p.Color)
                      .Select(groupedColors => groupedColors.FirstOrDefault().Color)
                      .OrderBy(c => c).ToList();
=======
                // return the accumulated results
                return acc;
              })
              .OrderBy(result => result.Size).ToList();
>>>>>>> Modulo_13

      return list;
    }
    #endregion
  }
}
