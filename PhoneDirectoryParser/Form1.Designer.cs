﻿namespace PhoneDirectoryParser
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonProgramInfo = new System.Windows.Forms.Button();
            this.buttonToExcel = new System.Windows.Forms.Button();
            this.buttonOpenPhoneDirectory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalledNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAndTimeToStartAConversation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DurationOfMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonProgramInfo);
            this.panel1.Controls.Add(this.buttonToExcel);
            this.panel1.Controls.Add(this.buttonOpenPhoneDirectory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 22);
            this.panel1.TabIndex = 2;
            // 
            // buttonProgramInfo
            // 
            this.buttonProgramInfo.BackColor = System.Drawing.Color.White;
            this.buttonProgramInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonProgramInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProgramInfo.Location = new System.Drawing.Point(0, 0);
            this.buttonProgramInfo.Name = "buttonProgramInfo";
            this.buttonProgramInfo.Size = new System.Drawing.Size(90, 22);
            this.buttonProgramInfo.TabIndex = 5;
            this.buttonProgramInfo.Text = "О программе";
            this.buttonProgramInfo.UseVisualStyleBackColor = false;
            this.buttonProgramInfo.Click += new System.EventHandler(this.ButtonProgramInfo_Click);
            // 
            // buttonToExcel
            // 
            this.buttonToExcel.BackColor = System.Drawing.Color.White;
            this.buttonToExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonToExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonToExcel.Location = new System.Drawing.Point(650, 0);
            this.buttonToExcel.Name = "buttonToExcel";
            this.buttonToExcel.Size = new System.Drawing.Size(186, 22);
            this.buttonToExcel.TabIndex = 4;
            this.buttonToExcel.Text = "Экспорт в Excel";
            this.buttonToExcel.UseVisualStyleBackColor = false;
            this.buttonToExcel.Click += new System.EventHandler(this.ButtonToExcel_Click);
            // 
            // buttonOpenPhoneDirectory
            // 
            this.buttonOpenPhoneDirectory.BackColor = System.Drawing.Color.White;
            this.buttonOpenPhoneDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOpenPhoneDirectory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPhoneDirectory.Location = new System.Drawing.Point(0, 0);
            this.buttonOpenPhoneDirectory.Name = "buttonOpenPhoneDirectory";
            this.buttonOpenPhoneDirectory.Size = new System.Drawing.Size(836, 22);
            this.buttonOpenPhoneDirectory.TabIndex = 3;
            this.buttonOpenPhoneDirectory.Text = "Открыть телефонный справочник";
            this.buttonOpenPhoneDirectory.UseVisualStyleBackColor = false;
            this.buttonOpenPhoneDirectory.Click += new System.EventHandler(this.ButtonOpenPhoneDirectory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNumber,
            this.NameOfService,
            this.Direction,
            this.CalledNumber,
            this.DateAndTimeToStartAConversation,
            this.DurationOfMinutes,
            this.Cost});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(836, 604);
            this.dataGridView1.TabIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.FillWeight = 78.17258F;
            this.PhoneNumber.HeaderText = "Телефонный номер";
            this.PhoneNumber.MinimumWidth = 60;
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // NameOfService
            // 
            this.NameOfService.FillWeight = 493.079F;
            this.NameOfService.HeaderText = "Наименование услуги";
            this.NameOfService.MinimumWidth = 150;
            this.NameOfService.Name = "NameOfService";
            // 
            // Direction
            // 
            this.Direction.FillWeight = 25.74969F;
            this.Direction.HeaderText = "Направление";
            this.Direction.MinimumWidth = 50;
            this.Direction.Name = "Direction";
            // 
            // CalledNumber
            // 
            this.CalledNumber.FillWeight = 25.74969F;
            this.CalledNumber.HeaderText = "Номер вызываемого абонента";
            this.CalledNumber.MinimumWidth = 60;
            this.CalledNumber.Name = "CalledNumber";
            // 
            // DateAndTimeToStartAConversation
            // 
            this.DateAndTimeToStartAConversation.FillWeight = 25.74969F;
            this.DateAndTimeToStartAConversation.HeaderText = "Дата, Время начала";
            this.DateAndTimeToStartAConversation.MinimumWidth = 90;
            this.DateAndTimeToStartAConversation.Name = "DateAndTimeToStartAConversation";
            // 
            // DurationOfMinutes
            // 
            this.DurationOfMinutes.FillWeight = 25.74969F;
            this.DurationOfMinutes.HeaderText = "Прод. (мин)";
            this.DurationOfMinutes.MinimumWidth = 10;
            this.DurationOfMinutes.Name = "DurationOfMinutes";
            // 
            // Cost
            // 
            this.Cost.FillWeight = 25.74969F;
            this.Cost.HeaderText = "Стоимость (руб)";
            this.Cost.MinimumWidth = 55;
            this.Cost.Name = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 626);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Журнал телефонных разговоров";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOpenPhoneDirectory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfService;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalledNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAndTimeToStartAConversation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationOfMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button buttonProgramInfo;
    }
}

