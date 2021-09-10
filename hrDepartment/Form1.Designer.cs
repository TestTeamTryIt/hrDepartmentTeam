
namespace hrDepartment
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupPhoto = new System.Windows.Forms.GroupBox();
            this.empPhoto = new System.Windows.Forms.PictureBox();
            this.photoDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.photoAdd = new System.Windows.Forms.Button();
            this.groupDepsEmps = new System.Windows.Forms.GroupBox();
            this.empList = new System.Windows.Forms.ListBox();
            this.depDel = new System.Windows.Forms.Button();
            this.depSave = new System.Windows.Forms.Button();
            this.depAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.depName = new System.Windows.Forms.TextBox();
            this.deps = new System.Windows.Forms.Label();
            this.depList = new System.Windows.Forms.ComboBox();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.clearFields = new System.Windows.Forms.Button();
            this.empDel = new System.Windows.Forms.Button();
            this.empDataChange = new System.Windows.Forms.Button();
            this.empAdd = new System.Windows.Forms.Button();
            this.empSalary = new System.Windows.Forms.NumericUpDown();
            this.empBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.empPos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.groupPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).BeginInit();
            this.groupDepsEmps.SuspendLayout();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPhoto
            // 
            this.groupPhoto.Controls.Add(this.empPhoto);
            this.groupPhoto.Controls.Add(this.photoDel);
            this.groupPhoto.Controls.Add(this.label3);
            this.groupPhoto.Controls.Add(this.photoAdd);
            this.groupPhoto.Location = new System.Drawing.Point(284, 0);
            this.groupPhoto.Name = "groupPhoto";
            this.groupPhoto.Size = new System.Drawing.Size(280, 511);
            this.groupPhoto.TabIndex = 0;
            this.groupPhoto.TabStop = false;
            this.groupPhoto.Text = "Фото";
            // 
            // empPhoto
            // 
            this.empPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.empPhoto.Image = global::hrDepartment.Properties.Resources.profile;
            this.empPhoto.InitialImage = null;
            this.empPhoto.Location = new System.Drawing.Point(6, 42);
            this.empPhoto.Name = "empPhoto";
            this.empPhoto.Size = new System.Drawing.Size(270, 360);
            this.empPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPhoto.TabIndex = 0;
            this.empPhoto.TabStop = false;
            // 
            // photoDel
            // 
            this.photoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoDel.Location = new System.Drawing.Point(148, 437);
            this.photoDel.Name = "photoDel";
            this.photoDel.Size = new System.Drawing.Size(110, 30);
            this.photoDel.TabIndex = 4;
            this.photoDel.Text = "Видалити";
            this.photoDel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фото співробітника";
            // 
            // photoAdd
            // 
            this.photoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoAdd.Location = new System.Drawing.Point(22, 437);
            this.photoAdd.Name = "photoAdd";
            this.photoAdd.Size = new System.Drawing.Size(110, 30);
            this.photoAdd.TabIndex = 4;
            this.photoAdd.Text = "Додати / Змінити";
            this.photoAdd.UseVisualStyleBackColor = true;
            this.photoAdd.Click += new System.EventHandler(this.photoAdd_Click);
            // 
            // groupDepsEmps
            // 
            this.groupDepsEmps.Controls.Add(this.empList);
            this.groupDepsEmps.Controls.Add(this.depDel);
            this.groupDepsEmps.Controls.Add(this.depSave);
            this.groupDepsEmps.Controls.Add(this.depAdd);
            this.groupDepsEmps.Controls.Add(this.label2);
            this.groupDepsEmps.Controls.Add(this.depName);
            this.groupDepsEmps.Controls.Add(this.deps);
            this.groupDepsEmps.Controls.Add(this.depList);
            this.groupDepsEmps.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupDepsEmps.Location = new System.Drawing.Point(0, 0);
            this.groupDepsEmps.Name = "groupDepsEmps";
            this.groupDepsEmps.Size = new System.Drawing.Size(280, 511);
            this.groupDepsEmps.TabIndex = 0;
            this.groupDepsEmps.TabStop = false;
            this.groupDepsEmps.Text = "Співробітники";
            // 
            // empList
            // 
            this.empList.FormattingEnabled = true;
            this.empList.ItemHeight = 15;
            this.empList.Location = new System.Drawing.Point(5, 185);
            this.empList.Name = "empList";
            this.empList.ScrollAlwaysVisible = true;
            this.empList.Size = new System.Drawing.Size(270, 319);
            this.empList.TabIndex = 5;
            this.empList.SelectedIndexChanged += new System.EventHandler(this.empList_SelectedIndexChanged);
            // 
            // depDel
            // 
            this.depDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depDel.Location = new System.Drawing.Point(183, 118);
            this.depDel.Name = "depDel";
            this.depDel.Size = new System.Drawing.Size(75, 30);
            this.depDel.TabIndex = 4;
            this.depDel.Text = "Видалити";
            this.depDel.UseVisualStyleBackColor = true;
            this.depDel.Click += new System.EventHandler(this.depDel_Click);
            // 
            // depSave
            // 
            this.depSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depSave.Location = new System.Drawing.Point(102, 118);
            this.depSave.Name = "depSave";
            this.depSave.Size = new System.Drawing.Size(75, 30);
            this.depSave.TabIndex = 4;
            this.depSave.Text = "Змінити";
            this.depSave.UseVisualStyleBackColor = true;
            this.depSave.Click += new System.EventHandler(this.depSave_Click);
            // 
            // depAdd
            // 
            this.depAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depAdd.Location = new System.Drawing.Point(21, 118);
            this.depAdd.Name = "depAdd";
            this.depAdd.Size = new System.Drawing.Size(75, 30);
            this.depAdd.TabIndex = 4;
            this.depAdd.Text = "Додати";
            this.depAdd.UseVisualStyleBackColor = true;
            this.depAdd.Click += new System.EventHandler(this.depAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список співробітників:";
            // 
            // depName
            // 
            this.depName.Location = new System.Drawing.Point(5, 73);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(270, 21);
            this.depName.TabIndex = 3;
            // 
            // deps
            // 
            this.deps.AutoSize = true;
            this.deps.Location = new System.Drawing.Point(6, 24);
            this.deps.Name = "deps";
            this.deps.Size = new System.Drawing.Size(143, 15);
            this.deps.TabIndex = 1;
            this.deps.Text = "Список департаментів:";
            // 
            // depList
            // 
            this.depList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depList.FormattingEnabled = true;
            this.depList.Location = new System.Drawing.Point(5, 42);
            this.depList.Name = "depList";
            this.depList.Size = new System.Drawing.Size(270, 23);
            this.depList.TabIndex = 0;
            this.depList.SelectedIndexChanged += new System.EventHandler(this.depList_SelectedIndexChanged);
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.clearFields);
            this.groupInfo.Controls.Add(this.empDel);
            this.groupInfo.Controls.Add(this.empDataChange);
            this.groupInfo.Controls.Add(this.empAdd);
            this.groupInfo.Controls.Add(this.empSalary);
            this.groupInfo.Controls.Add(this.empBirth);
            this.groupInfo.Controls.Add(this.label5);
            this.groupInfo.Controls.Add(this.label10);
            this.groupInfo.Controls.Add(this.label9);
            this.groupInfo.Controls.Add(this.empPos);
            this.groupInfo.Controls.Add(this.label8);
            this.groupInfo.Controls.Add(this.empEmail);
            this.groupInfo.Controls.Add(this.label7);
            this.groupInfo.Controls.Add(this.empPhone);
            this.groupInfo.Controls.Add(this.label6);
            this.groupInfo.Controls.Add(this.empAddr);
            this.groupInfo.Controls.Add(this.label4);
            this.groupInfo.Controls.Add(this.empName);
            this.groupInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupInfo.Location = new System.Drawing.Point(568, 0);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(280, 511);
            this.groupInfo.TabIndex = 0;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Інформація";
            // 
            // clearFields
            // 
            this.clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFields.Location = new System.Drawing.Point(6, 364);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(270, 31);
            this.clearFields.TabIndex = 4;
            this.clearFields.Text = "Очистити форму";
            this.clearFields.UseVisualStyleBackColor = true;
            this.clearFields.Click += new System.EventHandler(this.clearFields_Click);
            // 
            // empDel
            // 
            this.empDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empDel.Location = new System.Drawing.Point(6, 473);
            this.empDel.Name = "empDel";
            this.empDel.Size = new System.Drawing.Size(270, 30);
            this.empDel.TabIndex = 4;
            this.empDel.Text = "Видалити співробітника";
            this.empDel.UseVisualStyleBackColor = true;
            this.empDel.Click += new System.EventHandler(this.empDel_Click);
            // 
            // empDataChange
            // 
            this.empDataChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empDataChange.Location = new System.Drawing.Point(6, 437);
            this.empDataChange.Name = "empDataChange";
            this.empDataChange.Size = new System.Drawing.Size(270, 30);
            this.empDataChange.TabIndex = 4;
            this.empDataChange.Text = "Змінити дані";
            this.empDataChange.UseVisualStyleBackColor = true;
            this.empDataChange.Click += new System.EventHandler(this.empDataChange_Click);
            // 
            // empAdd
            // 
            this.empAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empAdd.Location = new System.Drawing.Point(6, 401);
            this.empAdd.Name = "empAdd";
            this.empAdd.Size = new System.Drawing.Size(270, 30);
            this.empAdd.TabIndex = 4;
            this.empAdd.Text = "Додати співробітника";
            this.empAdd.UseVisualStyleBackColor = true;
            this.empAdd.Click += new System.EventHandler(this.empAdd_Click);
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(128, 304);
            this.empSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(148, 21);
            this.empSalary.TabIndex = 5;
            // 
            // empBirth
            // 
            this.empBirth.Location = new System.Drawing.Point(6, 87);
            this.empBirth.Name = "empBirth";
            this.empBirth.Size = new System.Drawing.Size(270, 21);
            this.empBirth.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дата народження:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Заробітна плата:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Посада:";
            // 
            // empPos
            // 
            this.empPos.Location = new System.Drawing.Point(6, 263);
            this.empPos.Name = "empPos";
            this.empPos.Size = new System.Drawing.Size(270, 21);
            this.empPos.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email:";
            // 
            // empEmail
            // 
            this.empEmail.Location = new System.Drawing.Point(6, 219);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(270, 21);
            this.empEmail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Телефон:";
            // 
            // empPhone
            // 
            this.empPhone.Location = new System.Drawing.Point(6, 175);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(270, 21);
            this.empPhone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Адреса:";
            // 
            // empAddr
            // 
            this.empAddr.Location = new System.Drawing.Point(6, 131);
            this.empAddr.Name = "empAddr";
            this.empAddr.Size = new System.Drawing.Size(270, 21);
            this.empAddr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Прізвище, ім\'я:";
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(6, 44);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(270, 21);
            this.empName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 511);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupDepsEmps);
            this.Controls.Add(this.groupPhoto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система управления отделом кадров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPhoto.ResumeLayout(false);
            this.groupPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).EndInit();
            this.groupDepsEmps.ResumeLayout(false);
            this.groupDepsEmps.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPhoto;
        private System.Windows.Forms.GroupBox groupDepsEmps;
        private System.Windows.Forms.Label deps;
        private System.Windows.Forms.ComboBox depList;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Button photoDel;
        private System.Windows.Forms.Button depDel;
        private System.Windows.Forms.Button photoAdd;
        private System.Windows.Forms.Button depSave;
        private System.Windows.Forms.Button depAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depName;
        private System.Windows.Forms.PictureBox empPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox empList;
        private System.Windows.Forms.DateTimePicker empBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button empDel;
        private System.Windows.Forms.Button empDataChange;
        private System.Windows.Forms.Button empAdd;
        private System.Windows.Forms.NumericUpDown empSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empPos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empEmail;
    }
}

