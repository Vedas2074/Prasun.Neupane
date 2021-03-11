using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()

        {
            //LINQ - Language INtegrated Query
            int[] numbers = { 12,13,45,67,78,89,98,10,2345};
            
            //method syntax
           var result1 = numbers.Where(num => num > 50).Select(num =>num);

           //Query expression syntax
            var result2 = from num in numbers
                          where num > 50
                          select num; 

            // Restriction - where
            var result3 = from num in numbers
                          where num > 50 && num < 70
                          select num; 

            
            //Projections -select
            var result4 = from num in numbers
                              where num % 2 == 0
                              select num*num;

            //Ordering - orderby, orderby descending
            var result5 = from num in numbers
                            orderby num descending
                            select num;


            //displaying certain numbers,skipping numbers
            var result6 = numbers.Skip(5).Take(6);

            // check even,odd
            var result7 = numbers.Any(num => num % 2 == 0);
            var result8 = numbers.All(num => num % 2 == 0);
            var result9 = numbers.Contains(45);


            //Generations, range,repeat
            var result11 = Enumerable.Range(1,100);
            var result12 = Enumerable.Repeat("Hello World",20);

            
        }
        void LearnLinqOnComplexCollection()
        {
           
            Country c1 = new Country("Nepal","Kathmandu","Asia",29136808);
            Country c2 = new Country("India","Kathmandu","Asia",291368088,DateTime.Parse("1947/1/1"));
            Country c3 = new Country("England","GB","Europe",4913345608);
            Country c4 = new Country("Japan","Tokyo","Asia",2566808,DateTime.Parse("1956/10/11"));
            Country c5 = new Country("America","Washigton","NorthAmerica",29136808,DateTime.Parse("1898/02/14"));
            Country c6 = new Country("Australia","Canberra","Australia",29136808,DateTime.Parse("1923/12/12"));
            Country c7 = new Country("Pakistan","Islamabad","Asia",29136808,DateTime.Parse("1963/2/18"));
            // c1.Name = "Nepal";
            // c1.Capitol = "kathmandu"
             var countries = new List<Country> {c1,c2,c3,c4,c5,c6,c7};
             
            //List all asian country names
             var result10 = from country in countries
                            where country.Continent == "Asia"
                            select country.Name;

            //List all asian country names which are never been invaded
            //List all europian countries in ascending order that has popn less than 500k
            Console.WriteLine(result10);
            
        }
    }
}
