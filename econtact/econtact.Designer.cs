namespace econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxLogo = new PictureBox();
            lblContactID = new Label();
            txtboxContactID = new TextBox();
            txtboxFirstName = new TextBox();
            lblFirstName = new Label();
            txtboxLastName = new TextBox();
            lblLastName = new Label();
            txtboxContactNumber = new TextBox();
            lblContactNumber = new Label();
            txtboxAddress = new TextBox();
            lblAddress = new Label();
            cmbGender = new ComboBox();
            lblGender = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dtvContactList = new DataGridView();
            lblSearch = new Label();
            txtboxSearch = new TextBox();
            btnClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtvContactList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(410, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(227, 64);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.BackColor = Color.Transparent;
            lblContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblContactID.Location = new Point(52, 91);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(104, 28);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID";
            // 
            // txtboxContactID
            // 
            txtboxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtboxContactID.Location = new Point(184, 91);
            txtboxContactID.Name = "txtboxContactID";
            txtboxContactID.Size = new Size(210, 34);
            txtboxContactID.TabIndex = 2;
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtboxFirstName.Location = new Point(184, 136);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(210, 34);
            txtboxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFirstName.Location = new Point(50, 142);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 28);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            // 
            // txtboxLastName
            // 
            txtboxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtboxLastName.Location = new Point(184, 191);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(210, 34);
            txtboxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblLastName.Location = new Point(50, 197);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(103, 28);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            // 
            // txtboxContactNumber
            // 
            txtboxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtboxContactNumber.Location = new Point(184, 250);
            txtboxContactNumber.Name = "txtboxContactNumber";
            txtboxContactNumber.Size = new Size(210, 34);
            txtboxContactNumber.TabIndex = 8;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblContactNumber.Location = new Point(41, 253);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(112, 28);
            lblContactNumber.TabIndex = 7;
            lblContactNumber.Text = "Contact No";
            // 
            // txtboxAddress
            // 
            txtboxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtboxAddress.Location = new Point(184, 307);
            txtboxAddress.Multiline = true;
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(210, 100);
            txtboxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAddress.Location = new Point(52, 339);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(184, 439);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(210, 36);
            cmbGender.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblGender.Location = new Point(41, 439);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(76, 28);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(184, 528);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(133, 56);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(327, 528);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 56);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(494, 528);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 56);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(664, 528);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 56);
            btnClear.TabIndex = 15;
            btnClear.Text = " Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dtvContactList
            // 
            dtvContactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvContactList.Location = new Point(475, 152);
            dtvContactList.Name = "dtvContactList";
            dtvContactList.RowHeadersWidth = 51;
            dtvContactList.Size = new Size(506, 339);
            dtvContactList.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSearch.Location = new Point(485, 99);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 18;
            lblSearch.Text = "Search";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtboxSearch
            // 
            txtboxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtboxSearch.Location = new Point(561, 99);
            txtboxSearch.Name = "txtboxSearch";
            txtboxSearch.Size = new Size(383, 34);
            txtboxSearch.TabIndex = 19;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(1029, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(65, 56);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 20;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 611);
            Controls.Add(btnClose);
            Controls.Add(txtboxSearch);
            Controls.Add(lblSearch);
            Controls.Add(dtvContactList);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxContactNumber);
            Controls.Add(lblContactNumber);
            Controls.Add(txtboxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtboxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtboxContactID);
            Controls.Add(lblContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Econtact";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtvContactList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblContactID;
        private TextBox txtboxContactID;
        private TextBox txtboxFirstName;
        private Label lblFirstName;
        private TextBox txtboxLastName;
        private Label lblLastName;
        private TextBox txtboxContactNumber;
        private Label lblContactNumber;
        private TextBox txtboxAddress;
        private Label lblAddress;
        private ComboBox cmbGender;
        private Label lblGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dtvContactList;
        private Label lblSearch;
        private TextBox txtboxSearch;
        private PictureBox btnClose;
    }
}
