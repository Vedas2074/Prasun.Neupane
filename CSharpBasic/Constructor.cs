namespace LearningClasses
{
    internal class Person
    {
        //default parameter less constructor
        public Person()
        {

        }
         //Parameterized constructor
        public Person(string n, string add)
        {
            this.Name = n;
            this.Address = add;
            
        }
        public Person(string n, string add, byte a)
        {
            this.Name = n;
            this.Address = add;
            this.Age = a;
        }
       
        public string Name {get;set;}

        public string Address {get; set;}

        public byte Age {get; set;}

        public static string scientificName = "Homo-sapiens";
        public static void Do()
        {
            
        }
    }

}