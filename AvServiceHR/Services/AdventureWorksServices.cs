using AvServiceHR.infrastructure.Models;

using Dapper;
using Microsoft.EntityFrameworkCore;
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
        /// restituire tutti i prodotti con quantita' maggiori  100

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
        /// Restituisce tutti i prodotti di quella  determinata locationId
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
        public async Task<List<Person>> SearchPerson(string firstName, string LastName)
        {
            //_advContext db context

            throw new NotImplementedException();

        }



        /// IMPLEMENTARE CON EF
        /// </summary>
        /// <returns></returns>
        public async Task<List<Person>> GetPersonTypeSc()
        {
            return await _advContext.Person.Where(w => w.PersonType == "SC").ToListAsync();        

        }


        /// IMPLEMENTARE CON EF
        /// </summary>
        /// <returns></returns>
        public async Task<List<Person>> GetPersonFilter(string nome, string cognome)
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
