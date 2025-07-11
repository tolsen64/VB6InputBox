namespace VB6InputBox
{
    public class InputBox : IDisposable
    {
        public Form form { get; private set; }
        public string Value { get; private set; }

        public InputBox(string prompt, string title = "", string defaultValue = "", int? xpos = null, int? ypos = null)
        {
            InitializeComponent();
            lblPrompt.Text = prompt;
            form.Text = title;
            txtValue.Text = defaultValue;
            if (xpos.HasValue && ypos.HasValue)
                form.Location = new Point(xpos.Value, ypos.Value);
            form.ShowDialog();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Value = txtValue.Text;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            form.DialogResult = DialogResult.Cancel;
            form.Close();
        }

        private void InitializeComponent()
        {
            form = new Form();
            OK_Button = new Button();
            Cancel_Button = new Button();
            txtValue = new TextBox();
            lblPrompt = new Label();
            form.SuspendLayout();
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OK_Button.Location = new Point(254, 12);
            OK_Button.Margin = new Padding(4, 3, 4, 3);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(77, 27);
            OK_Button.TabIndex = 1;
            OK_Button.Text = "OK";
            OK_Button.Click += OK_Button_Click;
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cancel_Button.DialogResult = DialogResult.Cancel;
            Cancel_Button.Location = new Point(254, 45);
            Cancel_Button.Margin = new Padding(4, 3, 4, 3);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(77, 27);
            Cancel_Button.TabIndex = 2;
            Cancel_Button.Text = "Cancel";
            Cancel_Button.Click += Cancel_Button_Click;
            // 
            // txtValue
            // 
            txtValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtValue.Location = new Point(12, 86);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(320, 23);
            txtValue.TabIndex = 0;
            // 
            // lblPrompt
            // 
            lblPrompt.Location = new Point(12, 9);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(235, 74);
            lblPrompt.TabIndex = 3;
            // 
            // InputBox
            // 
            form.AcceptButton = OK_Button;
            form.AutoScaleDimensions = new SizeF(7F, 15F);
            form.AutoScaleMode = AutoScaleMode.Font;
            form.CancelButton = Cancel_Button;
            form.ClientSize = new Size(344, 121);
            form.Controls.Add(lblPrompt);
            form.Controls.Add(txtValue);
            form.Controls.Add(Cancel_Button);
            form.Controls.Add(OK_Button);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.Margin = new Padding(4, 3, 4, 3);
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.Name = "InputBox";
            form.ShowInTaskbar = false;
            form.StartPosition = FormStartPosition.CenterParent;
            form.ResumeLayout(false);
            form.PerformLayout();
        }

        public void Dispose()
        {
            if (form != null)
            {
                form.Dispose();
                form = null;
            }
        }

        internal Button OK_Button;
        internal Button Cancel_Button;
        private TextBox txtValue;
        private Label lblPrompt;
    }
}
