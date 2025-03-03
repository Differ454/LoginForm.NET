namespace LoginForm
{
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserName = new TextBox();
            Password = new TextBox();
            button_Login = new Button();
            button_Clear = new Button();
            button_Exit = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Siemens Slab", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 29);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Siemens Slab", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 94);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Siemens Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 138);
            label3.Name = "label3";
            label3.Size = new Size(73, 17);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // UserName
            // 
            UserName.Location = new Point(271, 94);
            UserName.Name = "UserName";
            UserName.Size = new Size(250, 23);
            UserName.TabIndex = 3;
            // 
            // Password
            // 
            Password.Location = new Point(271, 138);
            Password.Name = "Password";
            Password.Size = new Size(250, 23);
            Password.TabIndex = 4;
            // 
            // button_Login
            // 
            button_Login.Location = new Point(446, 193);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(75, 23);
            button_Login.TabIndex = 5;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = true;
            button_Login.Click += button_Login_Click;
            // 
            // button_Clear
            // 
            button_Clear.Location = new Point(271, 193);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(75, 23);
            button_Clear.TabIndex = 6;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Exit
            // 
            button_Exit.Location = new Point(128, 241);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(75, 23);
            button_Exit.TabIndex = 7;
            button_Exit.Text = "Exit";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(button_Exit);
            Controls.Add(button_Clear);
            Controls.Add(button_Login);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LoginForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserName;
        private TextBox Password;
        private Button button_Login;
        private Button button_Clear;
        private Button button_Exit;
        private BindingSource bindingSource1;
    }
}
