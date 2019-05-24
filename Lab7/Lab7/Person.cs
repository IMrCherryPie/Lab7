using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Person
    {
        private string fam = "";
        public string Fam
        {
            // стратегия: Read,Write-once (Чтение, запись при первом обращении)
            set { if (fam == "") fam = value; }
            get { return (fam); }
        }
        private string status;
        public string Status
        {
            //стратегия: Read,Write
            set { fam = value; }
            get { return (status); }

        }
        private int age;
        public int Age
        {
            //стратегия: Read,Write
            set
            {
                age = value;
                if (age < 7) status = "ребенок";
                else if (age < 17) status = "школьник"; else if (age < 22) status = "студент"; else status = "служащий";
            }
            get { return (age); }
        }
        public int salary;
        public int Salary
        {
            //стратегия: Write-only
            set { salary = value; }
            get { return salary; }
        }
    }
}
