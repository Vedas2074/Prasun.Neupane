using System.Collections.Generic;

public class Person
{
    public string FirstName{get; set;}

    public string SurName{get; set;}

    public string Address{get; set;}

    public char Gender{get; set;} = 'M';

    public double Salary{get; set;}
    public static List<Person> GetEmployee()
    {
        Person emp11 = new Person(){FirstName = "Prasun",SurName = "Neupane",Address = "Dang",Salary = 2000};
        Person emp12 = new Person(){FirstName = "Bishnu",SurName = "Rawal",Address = "Dhanusha",Salary = 40000};
        Person emp13 = new Person(){FirstName = "Bibek",SurName = "Roka",Address = "Dadeldhura",Salary = 1000};
        Person emp14 = new Person(){FirstName = "Binish",SurName = "Regmi",Address = "Dhangadi",Salary = 5000};
        Person emp15 = new Person(){FirstName = "Binay",SurName = "Rana",Address = "Dhading",Salary = 6000};

        List<Person> employees = new List<Person>(){emp11,emp12,emp13,emp14,emp15};
        return employees;
    }

}

