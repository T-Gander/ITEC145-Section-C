namespace ITEC145__Section_C__
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnToGrid = new System.Windows.Forms.Button();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.txtCopy = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressLine1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(188, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load data from file to list";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnToGrid
            // 
            this.btnToGrid.Location = new System.Drawing.Point(12, 41);
            this.btnToGrid.Name = "btnToGrid";
            this.btnToGrid.Size = new System.Drawing.Size(188, 23);
            this.btnToGrid.TabIndex = 1;
            this.btnToGrid.Text = "Move data from List to Grid";
            this.btnToGrid.UseVisualStyleBackColor = true;
            this.btnToGrid.Click += new System.EventHandler(this.btnToGrid_Click);
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(206, 12);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(345, 23);
            this.txtRead.TabIndex = 2;
            // 
            // txtCopy
            // 
            this.txtCopy.Location = new System.Drawing.Point(206, 41);
            this.txtCopy.Name = "txtCopy";
            this.txtCopy.Size = new System.Drawing.Size(345, 23);
            this.txtCopy.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.Surname,
            this.AddressLine1,
            this.City,
            this.Province,
            this.Postcode});
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(539, 192);
            this.dataGridView1.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // AddressLine1
            // 
            this.AddressLine1.HeaderText = "Address Line 1";
            this.AddressLine1.Name = "AddressLine1";
            this.AddressLine1.Width = 110;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Province
            // 
            this.Province.HeaderText = "Province";
            this.Province.Name = "Province";
            // 
            // Postcode
            // 
            this.Postcode.HeaderText = "Postcode";
            this.Postcode.Name = "Postcode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCopy);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.btnToGrid);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Loading Lists Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLoad;
        private Button btnToGrid;
        private TextBox txtRead;
        private TextBox txtCopy;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn AddressLine1;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Province;
        private DataGridViewTextBoxColumn Postcode;
    }
}