using System;
using System.Collections.Generic;
using System.Text;

namespace ArquiExample
{
     class officeWorker
    {
        public class OfficeWorker : Teacher, Person
        {
            private string degre;
            public string position { get; set; }

            public int moneyEarned { get; set; }

            public OfficeWorker()
            {
                degre = "Master in administration public";
                position = "administration";
            }
            public void extraHours()
            {
                moneyEarned = 5000;

            }
            public void positon()
            {

            }
    }
}
