using MVCEFPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCEFPractice.DAL
{
    public class BusinessInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BusinessContext>
    {
        protected override void Seed(BusinessContext context)
        {
            List<Company> companies = new List<Company>
            {
                new Company{ Name="CompanyA", Address="123 Main St", Phone="123-456-7890"},
                new Company{ Name="CompanyB", Address="456 Main St", Phone="234-567-8901"},
                new Company{ Name="CompanyC", Address="789 Main St", Phone="345-678-9012"}
            };

            companies.ForEach(c => context.Companies.Add(c));
            context.SaveChanges();

            List<User> users = new List<User>
            {
                new User{ FirstName="Bob", LastName="Smith", Username="bsmith", CompanyID=1},
                new User{ FirstName="Jennifer", LastName="Smith", Username="jsmith", CompanyID=1},
                new User{ FirstName="Jim", LastName="Beam", Username="jbeam", CompanyID=2},
                new User{ FirstName="Johnny", LastName="Walker", Username="jwalker", CompanyID=3}
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();
        }
    }
}