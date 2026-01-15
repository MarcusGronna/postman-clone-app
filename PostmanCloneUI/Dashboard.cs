using System.Text.Json.Nodes;
using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    // jsonplaceholder.typicode.com for mockdata 

    private readonly ApiCalls _api;
    public Dashboard()
    {
        InitializeComponent();
        _api = new ApiCalls();
    }
    private async void callApi_Click(object sender, EventArgs e)
    {
        string url = inputTextBox.Text;

        try
        {
            systemStatus.Text = "Calling Api...";

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

