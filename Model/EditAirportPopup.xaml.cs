using CommunityToolkit.Maui.Views;
using CS341Lab3.Model;

namespace CS341Lab3;
/// <summary>
/// Popup form that asks user for the information to replace original info.
/// </summary>
public partial class EditAirportPopup : Popup
{
    /// <summary>
    /// Default constructor.
    /// </summary>
    /// <param name="airport"> the currently selected airport </param>
    public EditAirportPopup(Airport airport)
	{
		InitializeComponent();

		//Use the current selected row to populate the fields by default, that way the user doesn't have to re-do the fields they don't want to change
        CityENT.Text = airport.City;
        DateENT.Text = airport.DateVisited.ToShortDateString();
        RatingENT.Text = airport.Rating.ToString();

        CityENT.Focus();
    }

	/// <summary>
	/// Cancels the edit and returns null to indicate the cancellation to caller.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    async void BtnCancel_Clicked(object sender, EventArgs e) => await CloseAsync(null);

	/// <summary>
	/// Sends back the information entered in the popup form. Caller will handle error-checking.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    async void BtnCommit_Clicked(object sender, EventArgs e) => await CloseAsync(new EditAirportUserInput(CityENT.Text, DateENT.Text, RatingENT.Text));
}