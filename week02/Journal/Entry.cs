public class Entry
{
    public string _date; //the date the entry Journal was created 
    public string _promptText; //the prompt question that was asked
    public string _entryText; // the users response to the prompt questions

    public void Display() //display the entry date , prompt and response
    {
        Console.WriteLine($"{_date} - {_promptText} ");
        Console.WriteLine($"{_entryText}");
        
    }
}