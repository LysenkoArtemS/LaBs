using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    public class Person
    {
        public Person(int personID, string personFirstName,string personLastName,
            DateTime personBirthday, int streetRegistrationID, int? streetLiveId)
        {
            if (streetRegistrationID != streetLiveId)
            {
                LiveID = streetLiveId;
            }
            else
            {
                LiveID = null;
            }
            ID = personID;
            FirstName = personFirstName;
            LastName = personLastName;
            Birthday = personBirthday;
            RegistrationID = streetRegistrationID;

        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public int RegistrationID { get; set; }
        public int? LiveID { get; set; }
    }
}
