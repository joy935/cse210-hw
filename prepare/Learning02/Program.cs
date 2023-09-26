using System;

class Program
{
    public class Job
    {
        public string _compagny = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;


        public void showCompagny()
        {
            Console.WriteLine(_compagny);
        }
        public void showJobTitle()
        {
            Console.WriteLine(_jobTitle);
        }
        public void showStartYear()
        {
            Console.WriteLine(_startYear);
        }
        public void showEndYear()
        {
            Console.WriteLine(_endYear);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._compagny = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2010;
        
        Job job2 = new Job();
        job2._compagny = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2010;
        job2._endYear = 2023;

        job1.showCompagny();
        job2.showCompagny();
    }
}