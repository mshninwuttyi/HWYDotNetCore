namespace HWYDotNetCore.WinFormsApp
{
    partial class FrmBlog
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContent = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 79);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 1;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 135);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Author :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 196);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 3;
            label3.Text = "Content :";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(220, 218);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(375, 109);
            txtContent.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(220, 157);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(375, 25);
            txtAuthor.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(220, 101);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(375, 25);
            txtTitle.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(117, 117, 117);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(220, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(56, 142, 60);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(316, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // FrmBlog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthor);
            Controls.Add(txtContent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmBlog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContent;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Button btnCancel;
        private Button btnSave;
    }
}
