﻿using System;
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
                return connection.Query<Person>("dbo.People_GetByLastName @LastName", new { Lastname = lastName }).AsList();

            }
        }

        public void InsertPerson(string firstName, string lastName, string email, string phone)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                Person newPerson = new Person { FirstName = firstName, LastName = lastName, EmailAddress = email, PhoneNumber = phone };

            }
        }
    }
}
