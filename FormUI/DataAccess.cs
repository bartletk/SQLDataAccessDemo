using System.Collections.Generic;
using System.Data;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {   
                //Original call to db
                //var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }'").AsList();
                
                //Modified with stored procedure.
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { Lastname = lastName }).AsList();

                return output;
            }
        }
    }
}
