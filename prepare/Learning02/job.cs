using System;

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
