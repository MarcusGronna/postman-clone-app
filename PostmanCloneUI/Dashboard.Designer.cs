namespace PostmanCloneUI;

partial class Dashboard
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        appHeader = new Label();
        inputLabel = new Label();
        urlInput = new TextBox();
        callApi = new Button();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        httpVerbSelection = new ComboBox();
        callData = new TabControl();
        bodyTab = new TabPage();
        inputTextBox = new TextBox();
        resultTab = new TabPage();
        resultTextBox = new TextBox();
        statusStrip.SuspendLayout();
        callData.SuspendLayout();
        bodyTab.SuspendLayout();
        resultTab.SuspendLayout();
        SuspendLayout();
        // 
        // appHeader
        // 
        appHeader.AutoSize = true;
        appHeader.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        appHeader.Location = new Point(97, 58);
        appHeader.Name = "appHeader";
        appHeader.Size = new Size(442, 74);
        appHeader.TabIndex = 0;
        appHeader.Text = "Postman Clone";
        appHeader.Click += appHeader_Click;
        // 
        // inputLabel
        // 
        inputLabel.AutoSize = true;
        inputLabel.Location = new Point(97, 164);
        inputLabel.Name = "inputLabel";
        inputLabel.Size = new Size(96, 57);
        inputLabel.TabIndex = 1;
        inputLabel.Text = "API:";
        inputLabel.Click += inputLabel_Click;
        // 
        // urlInput
        // 
        urlInput.BorderStyle = BorderStyle.FixedSingle;
        urlInput.Location = new Point(382, 164);
        urlInput.Name = "urlInput";
        urlInput.Size = new Size(808, 63);
        urlInput.TabIndex = 2;
        // 
        // callApi
        // 
        callApi.Location = new Point(1196, 164);
        callApi.Name = "callApi";
        callApi.Size = new Size(152, 63);
        callApi.TabIndex = 5;
        callApi.Text = "GO";
        callApi.UseVisualStyleBackColor = true;
        callApi.Click += callApi_Click;
        // 
        // statusStrip
        // 
        statusStrip.ImageScalingSize = new Size(28, 28);
        statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
        statusStrip.Location = new Point(0, 902);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new Size(1434, 47);
        statusStrip.TabIndex = 6;
        statusStrip.Text = "statusStrip1";
        // 
        // systemStatus
        // 
        systemStatus.Font = new Font("Segoe UI", 12F);
        systemStatus.Name = "systemStatus";
        systemStatus.Size = new Size(92, 38);
        systemStatus.Text = "Ready";
        // 
        // httpVerbSelection
        // 
        httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
        httpVerbSelection.FormattingEnabled = true;
        httpVerbSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
        httpVerbSelection.Location = new Point(188, 162);
        httpVerbSelection.Name = "httpVerbSelection";
        httpVerbSelection.Size = new Size(188, 65);
        httpVerbSelection.TabIndex = 7;
        httpVerbSelection.SelectedIndexChanged += comboBox_SelectedIndexChanged;
        // 
        // callData
        // 
        callData.Controls.Add(bodyTab);
        callData.Controls.Add(resultTab);
        callData.Cursor = Cursors.Hand;
        callData.Location = new Point(97, 256);
        callData.Name = "callData";
        callData.SelectedIndex = 0;
        callData.Size = new Size(1251, 624);
        callData.TabIndex = 8;
        // 
        // bodyTab
        // 
        bodyTab.Controls.Add(inputTextBox);
        bodyTab.Location = new Point(4, 66);
        bodyTab.Name = "bodyTab";
        bodyTab.Padding = new Padding(3);
        bodyTab.Size = new Size(1243, 554);
        bodyTab.TabIndex = 0;
        bodyTab.Text = "Body";
        bodyTab.UseVisualStyleBackColor = true;
        // 
        // inputTextBox
        // 
        inputTextBox.BackColor = Color.White;
        inputTextBox.BorderStyle = BorderStyle.FixedSingle;
        inputTextBox.Dock = DockStyle.Fill;
        inputTextBox.Location = new Point(3, 3);
        inputTextBox.Multiline = true;
        inputTextBox.Name = "inputTextBox";
        inputTextBox.ScrollBars = ScrollBars.Vertical;
        inputTextBox.Size = new Size(1237, 548);
        inputTextBox.TabIndex = 4;
        // 
        // resultTab
        // 
        resultTab.Controls.Add(resultTextBox);
        resultTab.Location = new Point(4, 66);
        resultTab.Name = "resultTab";
        resultTab.Padding = new Padding(3);
        resultTab.Size = new Size(1243, 554);
        resultTab.TabIndex = 1;
        resultTab.Text = "Result";
        resultTab.UseVisualStyleBackColor = true;
        // 
        // resultTextBox
        // 
        resultTextBox.BackColor = Color.White;
        resultTextBox.BorderStyle = BorderStyle.FixedSingle;
        resultTextBox.Dock = DockStyle.Fill;
        resultTextBox.Location = new Point(3, 3);
        resultTextBox.Multiline = true;
        resultTextBox.Name = "resultTextBox";
        resultTextBox.ReadOnly = true;
        resultTextBox.ScrollBars = ScrollBars.Vertical;
        resultTextBox.Size = new Size(1237, 548);
        resultTextBox.TabIndex = 4;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(23F, 57F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1434, 949);
        Controls.Add(callData);
        Controls.Add(httpVerbSelection);
        Controls.Add(statusStrip);
        Controls.Add(callApi);
        Controls.Add(urlInput);
        Controls.Add(inputLabel);
        Controls.Add(appHeader);
        Font = new Font("Segoe UI", 18F);
        Margin = new Padding(6);
        Name = "Dashboard";
        Text = "Postman Clone by Marcus Grönnå";
        Load += Form1_Load;
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        callData.ResumeLayout(false);
        bodyTab.ResumeLayout(false);
        bodyTab.PerformLayout();
        resultTab.ResumeLayout(false);
        resultTab.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label appHeader;
    private Label inputLabel;
    private TextBox urlInput;
    private Button callApi;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
    private ComboBox httpVerbSelection;
    private TabControl callData;
    private TabPage bodyTab;
    private TextBox inputTextBox;
    private TabPage resultTab;
    private TextBox resultTextBox;
}

