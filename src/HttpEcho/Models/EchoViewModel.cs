using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HttpEcho.Models
{
    public class EchoViewModel
    {
        [Display(Name ="Query String")]
        public SortedList<string, string> QueryString { get; set; }

        [Display(Name = "Form Items")]
        public SortedList<string, string> FormItems { get; set; }

        [Display(Name = "Request Variables")]
        public SortedList<string, string> RequestVariables { get; set; }

        [Display(Name = "Action")]
        public string Action { get; set; }

        [Display(Name ="Method")]
        public string Method { get; set; }


        public EchoViewModel()
        {
            this.QueryString = new SortedList<string, string>();
            this.FormItems = new SortedList<string, string>();
            this.RequestVariables = new SortedList<string, string>();
        }




    }
}
