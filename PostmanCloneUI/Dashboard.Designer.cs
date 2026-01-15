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
        inputTextBox = new TextBox();
        outputTextBox = new TextBox();
        resultLabel = new Label();
        callApi = new Button();
        statusStrip = new StatusStrip();
        systemStatus = new ToolStripStatusLabel();
        statusStrip.SuspendLayout();
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
        // inputTextBox
        // 
        inputTextBox.BorderStyle = BorderStyle.FixedSingle;
        inputTextBox.Location = new Point(187, 164);
        inputTextBox.Name = "inputTextBox";
        inputTextBox.Size = new Size(1003, 63);
        inputTextBox.TabIndex = 2;
        // 
        // outputTextBox
        // 
        outputTextBox.BackColor = Color.White;
        outputTextBox.BorderStyle = BorderStyle.FixedSingle;
        outputTextBox.Location = new Point(109, 323);
        outputTextBox.Multiline = true;
        outputTextBox.Name = "outputTextBox";
        outputTextBox.ReadOnly = true;
        outputTextBox.ScrollBars = ScrollBars.Vertical;
        outputTextBox.Size = new Size(1239, 488);
        outputTextBox.TabIndex = 3;
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(97, 263);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(137, 57);
        resultLabel.TabIndex = 4;
        resultLabel.Text = "Result";
        resultLabel.Click += textboxLabel_Click;
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
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(23F, 57F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1434, 949);
        Controls.Add(statusStrip);
        Controls.Add(callApi);
        Controls.Add(resultLabel);
        Controls.Add(outputTextBox);
        Controls.Add(inputTextBox);
        Controls.Add(inputLabel);
        Controls.Add(appHeader);
        Font = new Font("Segoe UI", 18F);
        Margin = new Padding(6);
        Name = "Dashboard";
        Text = "Postman Clone by Marcus Grönnå";
        Load += Form1_Load;
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label appHeader;
    private Label inputLabel;
    private TextBox inputTextBox;
    private TextBox outputTextBox;
    private Label resultLabel;
    private Button callApi;
    private StatusStrip statusStrip;
    private ToolStripStatusLabel systemStatus;
}

