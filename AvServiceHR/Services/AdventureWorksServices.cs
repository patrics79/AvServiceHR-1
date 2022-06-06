using AvServiceHR.Contexts;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AvServiceHR.Services
{
    public class AdventureWorksServices
    {

        private readonly AdventureWorks2017Context _advContext;

        string connectionString;

        public AdventureWorksServices(AdventureWorks2017Context context)
        {
            _advContext = context;

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            connectionString = configuration.GetConnectionString("AdventureWorksConnection");

        }


        /// <summary>
        /// IMPLEMENTARE CON DAPPER
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductIdMiniInfo>> GetProductsQtyMaggioreDi100(int locationId)
        {
            
            var connection = new SqlConnection(connectionString);

            string sqlSelect = $@"  
                             --- paste query here ----
                           ";
            var preGiorn = (await connection.QueryAsync<ProductIdMiniInfo>(sqlSelect, commandTimeout: 500)).ToList();
            throw new NotImplementedException();

        }


        /// IMPLEMENTARE CON DAPPER
        /// <summary>
        /// Restituisce tutti i prodotti di quella locationId
        /// </summary>
        /// 
        /// <returns></returns>
        public async Task<List<ProductIdMiniInfo>> GetProductsQtyLocationId(int locationID)
        {

            var connection = new SqlConnection(connectionString);

            string sqlSelect = $@"  
                           --- paste query here ----
                           ";
            var preGiorn = (await connection.QueryAsync<ProductIdMiniInfo>(sqlSelect, commandTimeout: 500)).ToList();
            throw new NotImplementedException();

        }



        /// IMPLEMENTARE CON EF
        /// </summary>
        /// <returns></returns>
        public async Task<List<ProductIdMiniInfo>> SearchPerson(string firstName, string LastName)
        {

         
            throw new NotImplementedException();

        }





    }
}

public class ProductIdMiniInfo
{
    public int ProductId { get; set; }
    public int Name { get; set; }

    public int ProductNumber { get; set; }

    public string LocationName { get; set; }
    public int Quantity { get; set; }
}
