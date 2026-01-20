using PostmanCloneLibrary;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    // https://jsonplaceholder.typicode.com/todos for mockdata 
    // https://jsonplaceholder.typicode.com/posts
    //      method: "POST",
    //      body:{
    //        "title": "foo",
    //        "body": "bar",
    //        "userId": 1,
    //        }

    private readonly IApiCalls _api;
    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.Text = "GET";
        _api = new ApiCalls();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        callData.SelectedTab = resultTab;
        systemStatus.Text = "Calling Api...";
        resultTextBox.Text = "";

        if (_api.IsValidUrl(urlInput.Text) == false)
        {
            systemStatus.Text = "Invalid url";
            resultTextBox.Text = "Invalid url...";
            return;
        }

        HttpAction httpAction;
        if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out httpAction) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            resultTextBox.Text = await _api.CallApiAsync(urlInput.Text, inputTextBox.Text, httpAction);
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultTextBox.Text = "Error: " + ex.Message;
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

    private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

