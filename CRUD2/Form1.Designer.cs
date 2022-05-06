namespace CRUD2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProdutosAddressTextBox = new System.Windows.Forms.TextBox();
            this.ProdutosNameTextBox = new System.Windows.Forms.TextBox();
            this.ProdutosEmailTextBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.UsuarioList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProdutosTelephoneTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // ProdutosAddressTextBox
            // 
            this.ProdutosAddressTextBox.Location = new System.Drawing.Point(385, 63);
            this.ProdutosAddressTextBox.Name = "ProdutosAddressTextBox";
            this.ProdutosAddressTextBox.Size = new System.Drawing.Size(190, 23);
            this.ProdutosAddressTextBox.TabIndex = 6;
            // 
            // ProdutosNameTextBox
            // 
            this.ProdutosNameTextBox.Location = new System.Drawing.Point(105, 63);
            this.ProdutosNameTextBox.Name = "ProdutosNameTextBox";
            this.ProdutosNameTextBox.Size = new System.Drawing.Size(190, 23);
            this.ProdutosNameTextBox.TabIndex = 7;
            // 
            // ProdutosEmailTextBox
            // 
            this.ProdutosEmailTextBox.Location = new System.Drawing.Point(105, 97);
            this.ProdutosEmailTextBox.Name = "ProdutosEmailTextBox";
            this.ProdutosEmailTextBox.Size = new System.Drawing.Size(190, 23);
            this.ProdutosEmailTextBox.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 23);
            this.textBox4.TabIndex = 9;
            // 
            // UsuarioList
            // 
            this.UsuarioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuarioList.Location = new System.Drawing.Point(40, 199);
            this.UsuarioList.Name = "UsuarioList";
            this.UsuarioList.RowTemplate.Height = 25;
            this.UsuarioList.Size = new System.Drawing.Size(515, 239);
            this.UsuarioList.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProdutosTelephoneTextBox
            // 
            this.ProdutosTelephoneTextBox.Location = new System.Drawing.Point(385, 24);
            this.ProdutosTelephoneTextBox.Mask = "(00) 00000-0000";
            this.ProdutosTelephoneTextBox.Name = "ProdutosTelephoneTextBox";
            this.ProdutosTelephoneTextBox.Size = new System.Drawing.Size(190, 23);
            this.ProdutosTelephoneTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UsuarioList);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ProdutosEmailTextBox);
            this.Controls.Add(this.ProdutosNameTextBox);
            this.Controls.Add(this.ProdutosAddressTextBox);
            this.Controls.Add(this.ProdutosTelephoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ProdutosAddressTextBox;
        private TextBox ProdutosNameTextBox;
        private TextBox ProdutosEmailTextBox;
        private TextBox textBox4;
        private DataGridView UsuarioList;
        private Button button1;
        private Button button2;
        private Button button3;
        private MaskedTextBox ProdutosTelephoneTextBox;
    }
}