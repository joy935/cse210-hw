using System;

class Program
{
    public class Job
    {
        public string _compagny = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;

        public void DisplayJobDetails()
        {
            Console.WriteLine($"{_jobTitle} ({_compagny}) {_startYear}-{_endYear}");
        }
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._compagny = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        
        Job job2 = new Job();
        job2._compagny = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Console.WriteLine(job1._compagny);
        Console.WriteLine(job2._compagny);

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
    }
}