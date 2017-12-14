using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel : BaseViewModel
    {
        // #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        // list for Jobs
        public List<Job> Jobs { get; set; }

        // Value in empty string
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";

    }
}