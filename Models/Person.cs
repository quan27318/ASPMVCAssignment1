using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASTNETAssignment.Models
{
    public class Person
    {
        public string? FirstName{get; set;}
        public string? LastName{get; set;}
        public string? Gender{get; set;}
        public int? DateOfBirth{get; set;}
        public int? PhoneNumber{get; set;}
        public int? Age{get; set;}
        public string? BirthPlace{get; set;}
        public bool? IsGraduated{get; set;}
    }
        public List<Person> GetList()
    {
        return new List<Person>
        {
            new Person{
                FirstName = "Quan",
                LastName = "Pham Dinh",
                Gender = "Male",
                DateOfBirth = 2000,
                PhoneNumber = 0123456778,
                BirthPlace = "Ha Noi",
                Age =22,
                IsGraduated = false
            },
            new Person{
                FirstName = "Tien Thanh",
                LastName = "Do",
                Gender = "Male",
                DateOfBirth = 2000,
                PhoneNumber = 01234545667,
                BirthPlace = "Nam dinh",
                Age = 23,
                IsGraduated = false
            },
            new Person{
                FirstName = "Lieu",
                LastName = "Dao Thi Hong",
                Gender = "Female",
                DateOfBirth = 2001,
                PhoneNumber = 01298332132,
                BirthPlace = "Thanh hoa",
                Age = 21,
                IsGraduated = true
            }
        };
    }
    public List<Person> GetMalePerson(List<Person> persons)
    {

        var malePerson = from person in persons where person.Gender == "Male" select person;
        return malePerson.ToList();
    }
    public List<Person> GetFullNamePerson(List<Person> persons)
    {
        var fullname = from person in persons select person;
        return fullname.ToList();
    }
    public List<Person> GetPersonOver2000(List<Person> persons)
    {
        var over2000 = from person in persons where (person.DateOfBirth > 2000) select person;
        return over2000.ToList();
    }
    public List<Person> GetPersonIs2000(List<Person> persons)
    {
        var Is2000 = from person in persons where (person.DateOfBirth == 2000) select person;
        return Is2000.ToList();
    }
    public List<Person> GetPersonUnder2000(List<Person> persons)
    {
        var under2000 = from person in persons where (person.DateOfBirth < 2000) select person;
        return under2000.ToList();
    }
    public List<Person> GetPersonBornInHN(List<Person> persons)
    {
        var bornInHN = from person in persons where person.BirthPlace == "Ha Noi" select person;
        return bornInHN.ToList();
    }
}