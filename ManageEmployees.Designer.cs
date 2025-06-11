namespace Project6
{
    partial class ManageEmployees
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
            this.groupBoxPresonalInfo = new System.Windows.Forms.GroupBox();
            this.dtpQuit = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHire = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxJobInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrows = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtContractPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBoxDayTracker = new System.Windows.Forms.GroupBox();
            this.btnAddDay = new System.Windows.Forms.Button();
            this.txtEmployeeIdDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radioVacation = new System.Windows.Forms.RadioButton();
            this.radioSick = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBoxPresonalInfo.SuspendLayout();
            this.groupBoxJobInfo.SuspendLayout();
            this.groupBoxActions.SuspendLayout();
            this.groupBoxDayTracker.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPresonalInfo
            // 
            this.groupBoxPresonalInfo.Controls.Add(this.dtpQuit);
            this.groupBoxPresonalInfo.Controls.Add(this.label6);
            this.groupBoxPresonalInfo.Controls.Add(this.dtpHire);
            this.groupBoxPresonalInfo.Controls.Add(this.label5);
            this.groupBoxPresonalInfo.Controls.Add(this.txtPhone);
            this.groupBoxPresonalInfo.Controls.Add(this.label4);
            this.groupBoxPresonalInfo.Controls.Add(this.txtAddress);
            this.groupBoxPresonalInfo.Controls.Add(this.label3);
            this.groupBoxPresonalInfo.Controls.Add(this.txtName);
            this.groupBoxPresonalInfo.Controls.Add(this.label2);
            this.groupBoxPresonalInfo.Controls.Add(this.txtID);
            this.groupBoxPresonalInfo.Controls.Add(this.label1);
            this.groupBoxPresonalInfo.Location = new System.Drawing.Point(13, 23);
            this.groupBoxPresonalInfo.Name = "groupBoxPresonalInfo";
            this.groupBoxPresonalInfo.Size = new System.Drawing.Size(421, 316);
            this.groupBoxPresonalInfo.TabIndex = 0;
            this.groupBoxPresonalInfo.TabStop = false;
            this.groupBoxPresonalInfo.Text = "Personal Information";
            this.groupBoxPresonalInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpQuit
            // 
            this.dtpQuit.Location = new System.Drawing.Point(235, 246);
            this.dtpQuit.Name = "dtpQuit";
            this.dtpQuit.Size = new System.Drawing.Size(168, 26);
            this.dtpQuit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Quit date:";
            // 
            // dtpHire
            // 
            this.dtpHire.Location = new System.Drawing.Point(235, 201);
            this.dtpHire.Name = "dtpHire";
            this.dtpHire.Size = new System.Drawing.Size(168, 26);
            this.dtpHire.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hire date:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(235, 154);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(168, 26);
            this.txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone number:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(235, 114);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 26);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 26);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee\'s Full Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(235, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(168, 26);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s ID:";
            // 
            // groupBoxJobInfo
            // 
            this.groupBoxJobInfo.Controls.Add(this.comboBoxType);
            this.groupBoxJobInfo.Controls.Add(this.label9);
            this.groupBoxJobInfo.Controls.Add(this.btnBrows);
            this.groupBoxJobInfo.Controls.Add(this.txtSalary);
            this.groupBoxJobInfo.Controls.Add(this.label11);
            this.groupBoxJobInfo.Controls.Add(this.txtContractPath);
            this.groupBoxJobInfo.Controls.Add(this.label8);
            this.groupBoxJobInfo.Controls.Add(this.comboBoxStatus);
            this.groupBoxJobInfo.Controls.Add(this.label7);
            this.groupBoxJobInfo.Location = new System.Drawing.Point(440, 23);
            this.groupBoxJobInfo.Name = "groupBoxJobInfo";
            this.groupBoxJobInfo.Size = new System.Drawing.Size(490, 191);
            this.groupBoxJobInfo.TabIndex = 1;
            this.groupBoxJobInfo.TabStop = false;
            this.groupBoxJobInfo.Text = "Job/Employment Information";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(221, 105);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(154, 28);
            this.comboBoxType.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Employee type:";
            // 
            // btnBrows
            // 
            this.btnBrows.Location = new System.Drawing.Point(393, 147);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(91, 29);
            this.btnBrows.TabIndex = 2;
            this.btnBrows.Text = "📁Brows..";
            this.btnBrows.UseVisualStyleBackColor = true;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(221, 69);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(154, 26);
            this.txtSalary.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Show contract file path:";
            // 
            // txtContractPath
            // 
            this.txtContractPath.Location = new System.Drawing.Point(221, 148);
            this.txtContractPath.Name = "txtContractPath";
            this.txtContractPath.Size = new System.Drawing.Size(154, 26);
            this.txtContractPath.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Salary:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Resigned",
            "Fired",
            "Unpaid leave"});
            this.comboBoxStatus.Location = new System.Drawing.Point(221, 31);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(154, 28);
            this.comboBoxStatus.TabIndex = 0;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status:";
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnSearch);
            this.groupBoxActions.Controls.Add(this.txtSearch);
            this.groupBoxActions.Controls.Add(this.label10);
            this.groupBoxActions.Controls.Add(this.btnReset);
            this.groupBoxActions.Controls.Add(this.btnRemove);
            this.groupBoxActions.Controls.Add(this.btnEdit);
            this.groupBoxActions.Controls.Add(this.btnCreate);
            this.groupBoxActions.Location = new System.Drawing.Point(440, 220);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(490, 126);
            this.groupBoxActions.TabIndex = 2;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(363, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 29);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "🧹Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(232, 78);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 29);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "🗑️Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(121, 78);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "✏️ Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(13, 78);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 29);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "➕ Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxDayTracker
            // 
            this.groupBoxDayTracker.Controls.Add(this.btnAddDay);
            this.groupBoxDayTracker.Controls.Add(this.txtEmployeeIdDate);
            this.groupBoxDayTracker.Controls.Add(this.label14);
            this.groupBoxDayTracker.Controls.Add(this.radioVacation);
            this.groupBoxDayTracker.Controls.Add(this.radioSick);
            this.groupBoxDayTracker.Controls.Add(this.label13);
            this.groupBoxDayTracker.Controls.Add(this.monthCalendar1);
            this.groupBoxDayTracker.Controls.Add(this.label12);
            this.groupBoxDayTracker.Location = new System.Drawing.Point(13, 345);
            this.groupBoxDayTracker.Name = "groupBoxDayTracker";
            this.groupBoxDayTracker.Size = new System.Drawing.Size(770, 293);
            this.groupBoxDayTracker.TabIndex = 3;
            this.groupBoxDayTracker.TabStop = false;
            this.groupBoxDayTracker.Text = "\"Days off\" Tracker";
            // 
            // btnAddDay
            // 
            this.btnAddDay.Location = new System.Drawing.Point(456, 202);
            this.btnAddDay.Name = "btnAddDay";
            this.btnAddDay.Size = new System.Drawing.Size(171, 36);
            this.btnAddDay.TabIndex = 7;
            this.btnAddDay.Text = "Add day+";
            this.btnAddDay.UseVisualStyleBackColor = true;
            this.btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // txtEmployeeIdDate
            // 
            this.txtEmployeeIdDate.Location = new System.Drawing.Point(456, 160);
            this.txtEmployeeIdDate.Name = "txtEmployeeIdDate";
            this.txtEmployeeIdDate.Size = new System.Drawing.Size(172, 26);
            this.txtEmployeeIdDate.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "For (Employee ID):";
            // 
            // radioVacation
            // 
            this.radioVacation.AutoSize = true;
            this.radioVacation.Location = new System.Drawing.Point(457, 88);
            this.radioVacation.Name = "radioVacation";
            this.radioVacation.Size = new System.Drawing.Size(117, 24);
            this.radioVacation.TabIndex = 4;
            this.radioVacation.TabStop = true;
            this.radioVacation.Text = "Vaction day";
            this.radioVacation.UseVisualStyleBackColor = true;
            // 
            // radioSick
            // 
            this.radioSick.AutoSize = true;
            this.radioSick.Location = new System.Drawing.Point(457, 58);
            this.radioSick.Name = "radioSick";
            this.radioSick.Size = new System.Drawing.Size(127, 24);
            this.radioSick.TabIndex = 3;
            this.radioSick.TabStop = true;
            this.radioSick.Text = "Sickness day\r\n";
            this.radioSick.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(452, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "set as:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(109, 28);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Pick a date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Search Employee by ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(194, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 26);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(335, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 27);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "🔍Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 626);
            this.Controls.Add(this.groupBoxDayTracker);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxJobInfo);
            this.Controls.Add(this.groupBoxPresonalInfo);
            this.Name = "ManageEmployees";
            this.Text = "ManageEmployees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load_1);
            this.groupBoxPresonalInfo.ResumeLayout(false);
            this.groupBoxPresonalInfo.PerformLayout();
            this.groupBoxJobInfo.ResumeLayout(false);
            this.groupBoxJobInfo.PerformLayout();
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.groupBoxDayTracker.ResumeLayout(false);
            this.groupBoxDayTracker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPresonalInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpQuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox groupBoxJobInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.TextBox txtContractPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBoxDayTracker;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioVacation;
        private System.Windows.Forms.RadioButton radioSick;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmployeeIdDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddDay;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSearch;
    }
}