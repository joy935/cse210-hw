using System;

// create a class
public class Streak
{
    /* create and initialize the class attribute _listDatesInJournal 
    which is a list of dates from the journal */
    public List<string> _listDatesInJournal = new List<string>();

    /* GetTheDates is a method that open, read and close a file and 
    save all the dates from the file as a string */
    public string GetTheDates(string filename)
    {
        /* open a file, read all lines of the file into the string array 
        lines and close the file */ 
        string[] lines = System.IO.File.ReadAllLines(filename);

        // iterate through all lines in the file
        foreach (string line in lines)
        {
            // split each line at the tilde character
            string[] elements = line.Split("~");

            // if there are all the elements (date, prompt and entry)
            if (elements.Length >= 3)
            {
                // trim to remove leading/trailing spaces
                string date = elements[0].Trim();
                // add the date in the list _listDatesInJournal
                _listDatesInJournal.Add(date);   
            }
        }
        /* if the lenght of the list _listDatesInJournal is
        superior at 0, so if there are items in the list */
        if (_listDatesInJournal.Count > 0)
        {
            /* join each item separated by a comma and return
            the list as a string */
            return string.Join(", ", _listDatesInJournal);
        }
        // if the list _listDatesInJournal is empty
        else
        {
            // return a no valid message
            return "No valid date found.";
        }   
    }

    /*GetMonth is a method that gets the month from the date*/
    public int GetMonth(string date)
    {
        // convert the date
        DateTime dt = Convert.ToDateTime(date);
        // get and save the month as an integer
        int month = dt.Month;
        // return the month number
        return month;
    }

    /*GetDay is a method that gets the day from the date */
    public int GetDay(string date)
    {
        // convert the date
        DateTime dt = Convert.ToDateTime(date);
        // get and save the day as an integer
        int day = dt.Day;
        // return the day number
        return day;
    }

    public int GetLastDay(string date)
    {
        DateTime dt = Convert.ToDateTime(date);
        int lastDay = DateTime.DaysInMonth(dt.Year, dt.Month);
        return lastDay;
    }

    /*GetInfoDate is a method that update the streak (here named 
    consecutive) according to the dates in the journal */
    public int GetInfoDates()
    {
        // create and initialize the streak at 0
        int consecutive = 0;
        /* create and initialize the difference of the 
        two months compared at 0 */
        int resultMonth = 0;
        /* loop starting at index 0 the dates in the list _listDatesInJournal
        until the last date in the list and one date at a time */
        for (int i = 0; i < _listDatesInJournal.Count - 1; i++)
        {
            // compute the difference of two following months as resultMonth
            resultMonth = GetMonth(_listDatesInJournal[i+1]) - GetMonth(_listDatesInJournal[i]);
            // compute the difference of two following days as resultDay
            int resultDay = GetDay(_listDatesInJournal[i+1]) - GetDay(_listDatesInJournal[i]);
            // nextDay corresponds to the second dayte used in the comparison
            int nextDay = GetDay(_listDatesInJournal[i+1]);
            // firstDay corresponds to the first date used in the comparison
            int firstDay = GetDay(_listDatesInJournal[i]);
            // lastDay corresponds tot the last day of the month in the first date in the comparison
            int lastDay = GetLastDay(_listDatesInJournal[i]);

            // if the entries has the same month and a day apart
            if (resultMonth == 0 && resultDay == 1)
            {
                // add +1 to the streak
                consecutive++;
            }
            /* if the entries are a month apart but the second
            day compared is the first day of the month */
            else if (resultMonth == 1 && nextDay == 1 && firstDay == lastDay)
            {
                // add +1 to the streak
                consecutive++;
            }
            // if the entries has no consecutive dates
            else
            {
                // set the streak at 0
                consecutive = 0;
            }
            
        }
        // return the streak
        return consecutive;
    }
}

