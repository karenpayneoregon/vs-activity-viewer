namespace VisualStudioLogViewer;

partial class Form1
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
        listBox1 = new ListBox();
        ViewCurrentButton = new Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(12, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(328, 424);
        listBox1.TabIndex = 0;
        // 
        // ViewCurrentButton
        // 
        ViewCurrentButton.Enabled = false;
        ViewCurrentButton.Location = new Point(355, 12);
        ViewCurrentButton.Name = "ViewCurrentButton";
        ViewCurrentButton.Size = new Size(162, 49);
        ViewCurrentButton.TabIndex = 1;
        ViewCurrentButton.Text = "View current";
        ViewCurrentButton.UseVisualStyleBackColor = true;
        ViewCurrentButton.Click += ViewCurrentButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(529, 450);
        Controls.Add(ViewCurrentButton);
        Controls.Add(listBox1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "VS Activity log viewer";
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
    private Button ViewCurrentButton;
}
