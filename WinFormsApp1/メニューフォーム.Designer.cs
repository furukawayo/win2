namespace WinFormsApp1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveForm = new Button();
            ListForm = new Button();
            SuspendLayout();
            // 
            // saveForm
            // 
            saveForm.Dock = DockStyle.Top;
            saveForm.Location = new Point(0, 0);
            saveForm.Name = "saveForm";
            saveForm.Size = new Size(800, 45);
            saveForm.TabIndex = 0;
            saveForm.Text = "ユーザー登録";
            saveForm.UseVisualStyleBackColor = true;
            saveForm.Click += saveForm_Click;
            // 
            // ListForm
            // 
            ListForm.Dock = DockStyle.Top;
            ListForm.Location = new Point(0, 45);
            ListForm.Name = "ListForm";
            ListForm.Size = new Size(800, 45);
            ListForm.TabIndex = 1;
            ListForm.Text = "ユーザーリスト";
            ListForm.UseVisualStyleBackColor = true;
            ListForm.Click += ListForm_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListForm);
            Controls.Add(saveForm);
            Name = "Menu";
            Text = "メニューフォーム";
            ResumeLayout(false);
        }

        #endregion

        private Button saveForm;
        private Button ListForm;
    }
}