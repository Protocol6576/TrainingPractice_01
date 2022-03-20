using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAA_Task_06
{
    class Dossier
    {
        private string firstName;
        private string lastName;
        private string patronymic;

        public Dossier (string FirstName, string LastName, string Patronymic)
        {
            firstName = FirstName;
            lastName = LastName;
            patronymic = Patronymic;
        }

        public string ShowData()
        {
            string colnc = lastName + " " + firstName + " " + patronymic;
            return colnc;
        }

        public string TakeLName()
        {
            return lastName;
        }
    }
}
