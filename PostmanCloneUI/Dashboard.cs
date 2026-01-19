using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    // https://jsonplaceholder.typicode.com/todos for mockdata 

    private readonly IApiCalls _api;
    public Dashboard()
    {
        InitializeComponent();
        _api = new ApiCalls();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling Api...";
        outputTextBox.Text = "";
        string url = inputTextBox.Text;

        if (_api.IsValidUrl(url) == false)
        {
            systemStatus.Text = "Invalid url";
            return;
        }

        try
        {
            var respone = await _api.CallApiAsync(url);

            outputTextBox.Text = respone;
            systemStatus.Text = "Ready";
                
        }
        catch (Exception ex)
        {
            outputTextBox.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void appHeader_Click(object sender, EventArgs e)
    {

    }

    private void inputLabel_Click(object sender, EventArgs e)
    {

    }


    private void textboxLabel_Click(object sender, EventArgs e)
    {

    }
}

