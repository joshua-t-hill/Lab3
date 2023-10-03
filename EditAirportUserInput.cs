namespace CS341Lab3;
/// <summary>
/// Object to hold user input during edit popup.
/// </summary>
internal class EditAirportUserInput
{
    public string City { get; private set; }
    public string Date { get; private set; }
    public string Rating { get; private set; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="city"> new city for edit </param>
    /// <param name="date"> new date for edit </param>
    /// <param name="rating"> new rating for edit </param>
    public EditAirportUserInput(string city, string date, string rating)
    {
        City = city;
        Date = date;
        Rating = rating;
    }
}
