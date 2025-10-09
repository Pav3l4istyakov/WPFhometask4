using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFhometask4
{
    public class ToDo
    {
        private string caseTitle;
        private DateTime completionDate;
        private string caseDescription;

        public ToDo(string casetitle, DateTime completiondate, string casedescription)
        {
            this.caseTitle = casetitle;
            this.completionDate = completiondate;
            this.caseDescription = casedescription;
        }

        public string CaseTitle
        {
           get { return caseTitle; }
        }

        public DateTime CompletionDate_
        {
           get { return completionDate; }
        }

        public string Description
        {
           get { return caseDescription; }
        }
    }
}