#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using System.Collections;

#endregion

namespace LinqGroupBy
{
    class CustomerOrdersGroupedByShippers : SampleQuery
    {
        # region Variable Declaration

        NorthwindwithImage db;

        #endregion

        # region Method

        # region Override Method

        public override void InitializeGrid(GridGroupingControl grid, NorthwindwithImage db)
        {
            this.db = db;

            var customerQuery = from customer in db.Customers
                                group customer by customer.Country into g
                                select new
                                {
                                    Key = g.Key,
                                    Count = g.Count(),
                                    //Details = g
                                };

            var customerTotals = customerQuery.Count();

            // Pass in a sample query for determing optimal column widths.
            // Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            var customerSampleQuery = from c in db.Customers
                                      select c;

            PassThroughGroupingResult customerQueryResults = new PassThroughGroupingResult(
                    "Customer",
                    customerQuery,
                    typeof(Customers),
                    customerTotals,
                    new QueryGroupsDetailsDelegate(GetDetailsForCountry),
                    customerSampleQuery.Take(10),
                    "Country"
                    );

            var orderSampleQuery =  from p in db.Orders
                                    select p;

            PassThroughGroupingResult orderResults = new PassThroughGroupingResult(
                    "Orders",
                    new NestedQueryResultsDelegate(this.GetOrdersForCustomerGroupedByShippers),
                    typeof(Orders),
                    new QueryGroupsDetailsDelegate(GetDetailsForOrders),
                    orderSampleQuery.Take(10),
                    "Shipper_CompanyName"
                    );

            grid.SourceListSet.Add("Customer", customerQueryResults);
            grid.SourceListSet.Add("Orders", orderResults);
           
            grid.DataSource = customerQueryResults;

            // Clear out otherwise autopopulated UniformChildList relations
            // for Orders and CustomerCustomerDemos.
            grid.TableDescriptor.Relations.Clear();

            GridRelationDescriptor orders = new GridRelationDescriptor("Orders");
            orders.RelationKeys.Add("CustomerID", "CustomerID");
            orders.ChildTableName = "Orders";
            orders.RelationKind = RelationKind.RelatedMasterDetails;
            orders.ChildTableDescriptor.Relations.Clear();

            grid.TableDescriptor.Relations.Add(orders);

            // Question: When consumer of customerQuery accesses nested lists such as Orders
            // will Linq fire a separate select statement or will they already
            // be in memory?

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords;

        }

        #endregion

        # region Public Method

        public IEnumerable GetDetailsForCountry(Group group)
        {
            // If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
            string country = (string) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key");

            // TODO: If country is null find a way to query for it more efficiently ...
            if (country == null)
            {
                return
                    from p in db.Customers
                    where !(p.Country != null)
                    select p;
            }

            var query =
                from p in db.Customers
                where p.Country == country
                select p
                ;

            return query;
        }

        public IEnumerable GetOrdersForCustomerGroupedByShippers(object[] keys, out object totals)
        {
            var orderQuery =
                from p in db.Orders
                where p.CustomerID.Equals(keys[0])
                group p by p.ShipAddress into g
                select new
                {
                   // Caption = g.Key..CompanyName,
                    Key = g.Key,
                    Count = g.Count(),
                  
                };

            totals = (from p in db.Orders
                      where p.CustomerID.Equals(keys[0])
                      group p by 0 into g
                      select new
                      {
                          CustomerID = keys[0],
                          Count = g.Count(),
                      })
                      .Single();

            return orderQuery;
        }

        public IEnumerable GetDetailsForOrders(Group group)
        {
            int? shipperID = (int?) PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key.ShipperID");
            
            string customerID = (string) PassThroughGroupingResult.GetValue(group.ParentChildTable.PassThroughItem, "CustomerID");

            var orderQuery =
                from p in db.Orders
                where p.CustomerID.Equals(customerID)
                && p.ShipVia == shipperID
                select p
                ;

            return orderQuery;
        }

        #endregion

        #endregion

    }
}
