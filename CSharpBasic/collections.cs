using System.Collections.Generic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> otherName = new List<string>{"prasun","mahesh"};
        List<string> names = new List<string>();
        names.Add("APrasun");
        names.Add("CPrasun");
        names.Add("DPrasun");
        names.Add("BPrasun");

        names.Sort();

        
    }
    public void Dictionary()
    {
        // Holds key value pairs
        Dictionary<string,int> Age = new Dictionary<string, int>();
        
        Dictionary<string, string> countryCapital = new Dictionary<string, string>();
        countryCapital.Add("Nepal","Kathmandu");
        countryCapital.Add("Japan","Tokyo");
        countryCapital.Add("China","Beijing");
        countryCapital.Add("Nepal","Kathmandu");

    }
}