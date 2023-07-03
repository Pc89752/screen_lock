using System;
using System.Net.Http;

namespace screen_lock
{
    public class Walkway : TableLayoutPanel
    {
        private Label _key = new Label();
        private TextBox _txtKey = new TextBox();
        private Button _btnLogin = new Button();
        public Walkway()
        {
            AutoSize = true;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.AutoSize = true;

            panel.Controls.Add(_key);
            panel.Controls.Add(_txtKey);

            Controls.Add(panel);
            Controls.Add(_btnLogin);
            _key.Margin = new Padding(0,0,0,0);
            _key.Text = "金鑰:";
            _txtKey.PasswordChar = '*';
            _btnLogin.Text = "Submit";
            _txtKey.Width = 150;
            Controls.Add(_key, 0, 0);
            Controls.Add(_txtKey, 1, 0);
            Controls.Add(_btnLogin, 1, 2);
        }

        public Button BtnLogin
        {
            get {return _btnLogin;}
        }

        public String Key
        {
            get {return _key.Text;}
        }

        public String txtKey
        {
            get {return _txtKey.Text;}
        }
        

        // [STAThread]
        // static void Main()
        // {
        //     Application.EnableVisualStyles();
        //     Application.SetCompatibleTextRenderingDefault(false);
        //     Form mainForm = new Form();
        //     mainForm.FormBorderStyle = FormBorderStyle.FixedDialog;
        //     mainForm.Controls.Add(new walkway());
        //     Application.Run(mainForm);
        // }
    }
}