using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // JobFieldType Column
        public JobFieldType Column { get; set; }

        // public/changable list to display all columns
        public List<JobFieldType> Columns { get; set; }

        // public/changable empty string to display title
        public string Title { get; set; } = "";

        public BaseViewModel()
        {
            // Fill the previously created public list of all columns with info

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }

        }
    }
}