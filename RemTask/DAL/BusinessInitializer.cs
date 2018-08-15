using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RemTask.Models;

namespace RemTask.DAL
{
    public class BusinessInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BusinessContext>
    {
        protected override void Seed(BusinessContext context)
        {

            var profiles = new List<Profile>
            {
            new Profile{Email = "tf049@outlook.com", Company = "TK Enterprises", LastName = "Fields", FirstName="Tom" },
            new Profile{Email = "kf049@outlook.com", Company = "TK Enterprises", LastName = "Fields", FirstName="Kathy" },
            };
            profiles.ForEach(s => context.Profiles.Add(s));
            context.SaveChanges();

            var events = new List<TaskD>
            {
            new TaskD {ProfileID = 1, Category = "Home", Event = "Change filters", Due = DateTime.Parse("2018-09-01"), Freq = "Quarterly", Assign = "Tom", Location = "Furnace/AC", Purpose = "regular maintenance" },
            new TaskD {ProfileID = 1, Category = "Car", Event = "Recall Notice service", Due = DateTime.Parse("2018-08-23"), Freq = "Once", Assign = "Tom", Location = "Tom O'Brien Jeep", Purpose = "Computer Software fix" },
            new TaskD {ProfileID = 2, Category = "Home", Event = "Clean closet", Due = DateTime.Parse("8/25/2018"), Freq = "Daily", Assign = "Kathy", Location = "House", Purpose = "Keep closet clean" },
            new TaskD {ProfileID = 1, Category = "Work", Event = "Demo HelpMinder for blue badge", Due = DateTime.Parse("4/26/2018"), Freq = "Once", Assign = "Tom", Location = "EFA", Purpose = "required milestone" },
            new TaskD {ProfileID = 1, Category = "Work", Event = "Red Badge Project", Due = DateTime.Parse("5/23/2018"), Freq = "Once", Assign = "Tom", Location = "EFA", Purpose = "required milestone" },
            new TaskD {ProfileID = 1, Category = "Car", Event = "Jeep recall notice", Due = DateTime.Parse("8/23/2018"), Freq = "Once", Assign = "Tom", Location = "Tom O'Brien Jeep", Purpose = "Fix Cruise control computer error" },
            new TaskD {ProfileID = 1, Category = "Car", Event = "Recall Notice", Due = DateTime.Parse("8/23/2018"), Freq = "Once", Assign = "Tom", Location = "Tom O'Brien Jeep", Purpose = "Computer Software fix" },
            new TaskD {ProfileID = 1, Category = "Home", Event = "Change filters", Due = DateTime.Parse("9/1/2018"), Freq = "Quarterly", Assign = "Tom", Location = "Furnace/AC", Purpose = "regular maintenance" },
            new TaskD {ProfileID = 1, Category = "Running", Event = "Registered for Navy HalfMarathon", Due = DateTime.Parse("9/16/2018"), Freq = "Annually", Assign = "Tom", Location = "Washington, DC", Purpose = "Half Marathon at Katies" },
            new TaskD {ProfileID = 1, Category = "Home", Event = "Turn off outside faucets", Due = DateTime.Parse("11/1/2018"), Freq = "Annually", Assign = "Tom", Location = "House", Purpose = "no pipe freeze and burst" },
            new TaskD {ProfileID = 1, Category = "Financial", Event = "Pay any estimated tax", Due = DateTime.Parse("1/15/2019"), Freq = "Annually", Assign = "Tom", Location = "IRS", Purpose = "Stay in IRS good graces" },
            new TaskD {ProfileID = 1, Category = "Home", Event = "Paint house", Due = DateTime.Parse("6/15/2021"), Freq = "Once", Assign = "Tom", Location = "Short's painting", Purpose = "regular house maintenance" },
            new TaskD {ProfileID = 1, Category = "Home", Event = "Change filters", Due = DateTime.Parse("7/1/2021"), Freq = "Quarterly", Assign = "Tom", Location = "House", Purpose = "Clean air; maintain HVAC" },
            };
            events.ForEach(s => context.TaskDs.Add(s));
            context.SaveChanges();

        }
    }
}