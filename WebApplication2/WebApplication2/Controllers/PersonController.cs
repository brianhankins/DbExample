using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("")]
        public List<Person> Test()
        {
            var people = new List<Person>();

            var connectionString = "Server=localhost;Database=TestDb;Trusted_Connection=True;";
            var sql = "SELECT * FROM testdb..Persons";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var firstName = reader["firstName"].ToString();
                    var lastName = reader["lastName"].ToString();
                    var ageOfPerson = (int)reader["age"];
                    var isCool = (bool)reader["isCool"];
                    var person = new Person(firstName, lastName, ageOfPerson, isCool);
                    people.Add(person);
                }
                connection.Close();
            }

            return people;
        }
    }
}
