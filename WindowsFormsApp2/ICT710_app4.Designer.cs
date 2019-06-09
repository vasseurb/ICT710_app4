namespace WindowsFormsApp2
{
    partial class ICT710_app4
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
            this.txt_employee_name = new System.Windows.Forms.TextBox();
            this.txt_hours_per_week = new System.Windows.Forms.TextBox();
            this.txt_hourly_rate = new System.Windows.Forms.TextBox();
            this.txt_payroll_output = new System.Windows.Forms.TextBox();
            this.btn_process_pay = new System.Windows.Forms.Button();
            this.btn_clear_form = new System.Windows.Forms.Button();
            this.lbl_employee_name = new System.Windows.Forms.Label();
            this.lbl_hours_per_week = new System.Windows.Forms.Label();
            this.lbl_hourly_rate = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_employee_name
            // 
            this.txt_employee_name.Location = new System.Drawing.Point(142, 59);
            this.txt_employee_name.Name = "txt_employee_name";
            this.txt_employee_name.Size = new System.Drawing.Size(100, 20);
            this.txt_employee_name.TabIndex = 10;
            this.txt_employee_name.Validating += new System.ComponentModel.CancelEventHandler(this.txt_employee_name_Validating);
            // 
            // txt_hours_per_week
            // 
            this.txt_hours_per_week.Location = new System.Drawing.Point(142, 95);
            this.txt_hours_per_week.Name = "txt_hours_per_week";
            this.txt_hours_per_week.Size = new System.Drawing.Size(100, 20);
            this.txt_hours_per_week.TabIndex = 20;
            this.txt_hours_per_week.Validating += new System.ComponentModel.CancelEventHandler(this.txt_hours_per_week_Validating);
            // 
            // txt_hourly_rate
            // 
            this.txt_hourly_rate.Location = new System.Drawing.Point(142, 136);
            this.txt_hourly_rate.Name = "txt_hourly_rate";
            this.txt_hourly_rate.Size = new System.Drawing.Size(100, 20);
            this.txt_hourly_rate.TabIndex = 30;
            this.txt_hourly_rate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_hourly_rate_Validating);
            // 
            // txt_payroll_output
            // 
            this.txt_payroll_output.Location = new System.Drawing.Point(31, 222);
            this.txt_payroll_output.Multiline = true;
            this.txt_payroll_output.Name = "txt_payroll_output";
            this.txt_payroll_output.ReadOnly = true;
            this.txt_payroll_output.Size = new System.Drawing.Size(461, 72);
            this.txt_payroll_output.TabIndex = 60;
            this.txt_payroll_output.TabStop = false;
            // 
            // btn_process_pay
            // 
            this.btn_process_pay.Location = new System.Drawing.Point(142, 180);
            this.btn_process_pay.Name = "btn_process_pay";
            this.btn_process_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_process_pay.TabIndex = 40;
            this.btn_process_pay.Text = "Process Pay";
            this.btn_process_pay.UseVisualStyleBackColor = true;
            this.btn_process_pay.Click += new System.EventHandler(this.btn_process_pay_Click);
            // 
            // btn_clear_form
            // 
            this.btn_clear_form.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_clear_form.Location = new System.Drawing.Point(278, 180);
            this.btn_clear_form.Name = "btn_clear_form";
            this.btn_clear_form.Size = new System.Drawing.Size(75, 23);
            this.btn_clear_form.TabIndex = 50;
            this.btn_clear_form.Text = "Clear Form";
            this.btn_clear_form.UseVisualStyleBackColor = true;
            this.btn_clear_form.Click += new System.EventHandler(this.btn_clear_form_Click);
            // 
            // lbl_employee_name
            // 
            this.lbl_employee_name.AutoSize = true;
            this.lbl_employee_name.Location = new System.Drawing.Point(28, 65);
            this.lbl_employee_name.Name = "lbl_employee_name";
            this.lbl_employee_name.Size = new System.Drawing.Size(84, 13);
            this.lbl_employee_name.TabIndex = 61;
            this.lbl_employee_name.Text = "Employee Name";
            // 
            // lbl_hours_per_week
            // 
            this.lbl_hours_per_week.AutoSize = true;
            this.lbl_hours_per_week.Location = new System.Drawing.Point(31, 101);
            this.lbl_hours_per_week.Name = "lbl_hours_per_week";
            this.lbl_hours_per_week.Size = new System.Drawing.Size(85, 13);
            this.lbl_hours_per_week.TabIndex = 62;
            this.lbl_hours_per_week.Text = "Hours per Week";
            // 
            // lbl_hourly_rate
            // 
            this.lbl_hourly_rate.AutoSize = true;
            this.lbl_hourly_rate.Location = new System.Drawing.Point(31, 142);
            this.lbl_hourly_rate.Name = "lbl_hourly_rate";
            this.lbl_hourly_rate.Size = new System.Drawing.Size(63, 13);
            this.lbl_hourly_rate.TabIndex = 63;
            this.lbl_hourly_rate.Text = "Hourly Rate";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(31, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(190, 20);
            this.lbl_title.TabIndex = 64;
            this.lbl_title.Text = "Process Employee Pay";
            // 
            // ICT710_app4
            // 
            this.AcceptButton = this.btn_process_pay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_clear_form;
            this.ClientSize = new System.Drawing.Size(524, 316);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_hourly_rate);
            this.Controls.Add(this.lbl_hours_per_week);
            this.Controls.Add(this.lbl_employee_name);
            this.Controls.Add(this.btn_clear_form);
            this.Controls.Add(this.btn_process_pay);
            this.Controls.Add(this.txt_payroll_output);
            this.Controls.Add(this.txt_hourly_rate);
            this.Controls.Add(this.txt_hours_per_week);
            this.Controls.Add(this.txt_employee_name);
            this.Name = "ICT710_app4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Employee Pay";
            this.Load += new System.EventHandler(this.ICT710_app4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_employee_name;
        private System.Windows.Forms.TextBox txt_hours_per_week;
        private System.Windows.Forms.TextBox txt_hourly_rate;
        private System.Windows.Forms.TextBox txt_payroll_output;
        private System.Windows.Forms.Button btn_process_pay;
        private System.Windows.Forms.Button btn_clear_form;
        private System.Windows.Forms.Label lbl_employee_name;
        private System.Windows.Forms.Label lbl_hours_per_week;
        private System.Windows.Forms.Label lbl_hourly_rate;
        private System.Windows.Forms.Label lbl_title;
    }
}

