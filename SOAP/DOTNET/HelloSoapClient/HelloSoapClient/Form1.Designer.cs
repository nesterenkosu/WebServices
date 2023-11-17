
namespace HelloSoapClient
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Result2 = new System.Windows.Forms.Label();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_Result1 = new System.Windows.Forms.Label();
            this.cityinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Нажмите на кнопку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Result2
            // 
            this.lb_Result2.AutoSize = true;
            this.lb_Result2.Location = new System.Drawing.Point(26, 147);
            this.lb_Result2.Name = "lb_Result2";
            this.lb_Result2.Size = new System.Drawing.Size(0, 17);
            this.lb_Result2.TabIndex = 1;
            // 
            // tb_Age
            // 
            this.tb_Age.Location = new System.Drawing.Point(178, 67);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(100, 22);
            this.tb_Age.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите ваше имя";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(178, 38);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 22);
            this.tb_Name.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lb_Result1);
            this.groupBox1.Location = new System.Drawing.Point(29, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HelloWorld";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.tb_City);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(382, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 320);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GetCityInfo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lb_Result2);
            this.groupBox3.Controls.Add(this.tb_Age);
            this.groupBox3.Controls.Add(this.tb_Name);
            this.groupBox3.Location = new System.Drawing.Point(29, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(302, 178);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GreetUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Укажите ваш возраст";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 30);
            this.button4.TabIndex = 0;
            this.button4.Text = "Нажмите на кнопку";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tb_City
            // 
            this.tb_City.Location = new System.Drawing.Point(212, 33);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(100, 22);
            this.tb_City.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Укажите название города";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 30);
            this.button5.TabIndex = 0;
            this.button5.Text = "Нажмите на кнопку";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cityinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 86);
            this.dataGridView1.TabIndex = 3;
            // 
            // lb_Result1
            // 
            this.lb_Result1.AutoSize = true;
            this.lb_Result1.Location = new System.Drawing.Point(17, 80);
            this.lb_Result1.Name = "lb_Result1";
            this.lb_Result1.Size = new System.Drawing.Size(0, 17);
            this.lb_Result1.TabIndex = 1;
            // 
            // cityinfoBindingSource
            // 
            this.cityinfoBindingSource.DataSource = typeof(HelloSoapClient.MyServiceReference.cityinfo);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Width = 125;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 390);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Клиент демонстрационного SOAP-сервиса";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Result2;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Result1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cityinfoBindingSource;
    }
}

