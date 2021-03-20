using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id{get; set;}

    [Required(ErrorMessage="We need FirstName")]
    [Display(Name = "First Name")]
    public string FirstName{get; set;}

    [Required(ErrorMessage="We need LastName")]
    [Display(Name = "Last Name")]

    public string SurName{get; set;}

    public string Address{get; set;}

    public char? Gender{get; set;} = 'M';

    public double? Salary{get; set;}
    public static List<Person> GetEmployee()
    {
        Person emp11 = new Person(){Id = 1,FirstName = "Prasun",SurName = "Neupane",Address = "Dang",Salary = 2000};
        Person emp12 = new Person(){Id = 2,FirstName = "Bishnu",SurName = "Rawal",Address = "Dhanusha",Salary = 40000};
        Person emp13 = new Person(){Id = 3,FirstName = "Bibek",SurName = "Roka",Address = "Dadeldhura",Salary = 1000};
        Person emp14 = new Person(){Id = 4,FirstName = "Binish",SurName = "Regmi",Address = "Dhangadi",Salary = 5000};
        Person emp15 = new Person(){Id = 5,FirstName = "Binay",SurName = "Rana",Address = "Dhading",Salary = 6000};

        List<Person> employees = new List<Person>(){emp11,emp12,emp13,emp14,emp15};
        return employees;
    }

}