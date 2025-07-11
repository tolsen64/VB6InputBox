# VB6InputBox
<img width="346" height="153" alt="image" src="https://github.com/user-attachments/assets/9718d0da-e1db-4be9-9e18-14bbd29d3dfe" />

```CSharp
private void btnTest_Click(object sender, EventArgs e)
{
    using InputBox vB6InputBox = new InputBox("Required method for Designer support. Do not modify the contents of this method with the code editor.", "Enter your name:");
    if (vB6InputBox.form.DialogResult == DialogResult.OK)
    {
        string userInput = vB6InputBox.Value;
        MessageBox.Show($"You entered: {userInput}", "Input Received", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    else
    {
        MessageBox.Show("Input was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
```
