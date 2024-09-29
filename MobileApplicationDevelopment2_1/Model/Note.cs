namespace MobileApplicationDevelopment2_1.Model;

public class Note
{
    public string Name { get; set; }

    public string Text { get; set; }

    public DateTime Date { get; set; }

    public Note()
    {
        Name = string.Empty;
        Text = string.Empty;
        Date = DateTime.MinValue;
    }

    public Note(string name, string text, DateTime date)
    {
        Name = name;
        Text = text;
        Date = date;
    }
}
