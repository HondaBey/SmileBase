using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileBase
{
       public class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Street { get; set; }
        string StreetNumber { get; set; }
        string Zip { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string MobilePhone { get; set; }
        string EmailAddress { get; set; }
    }

    public class Student : Person
    {
        int Id { get; set; }
        string SchoolName { get; set; }
        string SchoolClass { get; set; }
        string SchoolClassExtension { get; set; }
        string SchoolLevel { get; set; }
        DateTime DateOfBirth { get; set; }
        List<Fach> Faecher { get; set; }
        KontaktPerson KontaktPerson { get; set; }
        KontaktPerson KontaktPerson2 { get; set; }
    }

    public class KontaktPerson : Person
    {
        RelationType RelationType { get; set; }
    }

    public enum RelationType
    {
        None = 0,
        Mother = 1,
        Father = 2,
        Sister = 3,
        Brother = 4,

        /// <summary>
        /// Selbstzahler
        /// </summary>
        Self = 98,
        Others = 99
    }

    public enum Fach
    {
        None = 0,
        Maths = 1,
        English = 2,
        German = 3
    }

    public enum StudentStatus
    {
        None = 0,
        active = 1,
        inactive = 2
    }
}
