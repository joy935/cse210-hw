using System;

public class Streak
{
    public List<string> _listDatesInJournal = new List<string>();

    public string GetTheDates(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] elements = line.Split("~");
            if (elements.Length >= 3)
            {
                // trim to remove leading/trailing spaces
                string date = elements[0].Trim();
                _listDatesInJournal.Add(date);   
            }
        }
        if (_listDatesInJournal.Count > 0)
        {
            return string.Join(", ", _listDatesInJournal);
        }
        else
        {
            return "No valid date found.";
        }   
    }

    public int GetMonth(string date)
    {
        DateTime dt = Convert.ToDateTime(date);
        int month = dt.Month;
        return month;
    }

    public int GetDay(string date)
    {
        DateTime dt = Convert.ToDateTime(date);
        int day = dt.Day;
        return day;
    }

    public int GetInfoDates()
    {
        int consecutive = 0;
        int resultMonth = 0;
        for (int i = 0; i < _listDatesInJournal.Count - 1; i++)
        {
            resultMonth = GetMonth(_listDatesInJournal[i+1]) - GetMonth(_listDatesInJournal[i]);
            int resultDay = GetDay(_listDatesInJournal[i+1]) - GetDay(_listDatesInJournal[i]);
            int nextDay = GetDay(_listDatesInJournal[i+1]);
            
            if (resultMonth == 0 && resultDay == 1)
            {
                consecutive++;
            }
            else if (resultMonth == 1 && nextDay == 1)
            {
                consecutive++;
            }
            else
            {
                consecutive = 0;
            }
            
        }
        return consecutive;
    }
}


