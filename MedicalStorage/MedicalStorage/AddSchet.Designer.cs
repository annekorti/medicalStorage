namespace MedicalStorage
{
    partial class AddSchet
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label менеджерIDLabel;
            System.Windows.Forms.Label датаLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.менеджерIDComboBox = new System.Windows.Forms.ComboBox();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MedicalStorage.DataSet();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.счетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.счетаTableAdapter = new MedicalStorage.DataSetTableAdapters.СчетаTableAdapter();
            this.tableAdapterManager = new MedicalStorage.DataSetTableAdapters.TableAdapterManager();
            this.менеджерыTableAdapter = new MedicalStorage.DataSetTableAdapters.МенеджерыTableAdapter();
            this.составСчетаTableAdapter = new MedicalStorage.DataSetTableAdapters.СоставСчетаTableAdapter();
            this.составСчетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расходTableAdapter = new MedicalStorage.DataSetTableAdapters.РасходTableAdapter();
            this.составРасходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.составРасходаTableAdapter = new MedicalStorage.DataSetTableAdapters.СоставРасходаTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            менеджерIDLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составСчетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составРасходаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // менеджерIDLabel
            // 
            менеджерIDLabel.AutoSize = true;
            менеджерIDLabel.BackColor = System.Drawing.Color.Transparent;
            менеджерIDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            менеджерIDLabel.Location = new System.Drawing.Point(237, 19);
            менеджерIDLabel.Name = "менеджерIDLabel";
            менеджерIDLabel.Size = new System.Drawing.Size(89, 17);
            менеджерIDLabel.TabIndex = 24;
            менеджерIDLabel.Text = "Фармацевт:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.BackColor = System.Drawing.Color.Transparent;
            датаLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(32, 18);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(49, 17);
            датаLabel.TabIndex = 22;
            датаLabel.Text = "Дата:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(139, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 46);
            this.button2.TabIndex = 30;
            this.button2.Text = "Добавить товар";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(266, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 29;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(15, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 147);
            this.panel1.TabIndex = 28;
            // 
            // менеджерIDComboBox
            // 
            this.менеджерIDComboBox.DataSource = this.менеджерыBindingSource;
            this.менеджерIDComboBox.DisplayMember = "ФИО";
            this.менеджерIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.менеджерIDComboBox.FormattingEnabled = true;
            this.менеджерIDComboBox.Location = new System.Drawing.Point(332, 18);
            this.менеджерIDComboBox.Name = "менеджерIDComboBox";
            this.менеджерIDComboBox.Size = new System.Drawing.Size(182, 21);
            this.менеджерIDComboBox.TabIndex = 25;
            this.менеджерIDComboBox.ValueMember = "Шифр";
            // 
            // менеджерыBindingSource
            // 
            this.менеджерыBindingSource.DataMember = "Менеджеры";
            this.менеджерыBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.Location = new System.Drawing.Point(87, 18);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(138, 20);
            this.датаDateTimePicker.TabIndex = 23;
            // 
            // счетаBindingSource
            // 
            this.счетаBindingSource.DataMember = "Счета";
            this.счетаBindingSource.DataSource = this.dataSet;
            // 
            // счетаTableAdapter
            // 
            this.счетаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MedicalStorage.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыТоваровTableAdapter = null;
            this.tableAdapterManager.МенеджерыTableAdapter = this.менеджерыTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПриходTableAdapter = null;
            this.tableAdapterManager.РасходTableAdapter = null;
            this.tableAdapterManager.РеквизитыTableAdapter = null;
            this.tableAdapterManager.СоставПриходаTableAdapter = null;
            this.tableAdapterManager.СоставРасходаTableAdapter = null;
            this.tableAdapterManager.СоставСчетаTableAdapter = this.составСчетаTableAdapter;
            this.tableAdapterManager.СчетаTableAdapter = this.счетаTableAdapter;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // менеджерыTableAdapter
            // 
            this.менеджерыTableAdapter.ClearBeforeFill = true;
            // 
            // составСчетаTableAdapter
            // 
            this.составСчетаTableAdapter.ClearBeforeFill = true;
            // 
            // составСчетаBindingSource
            // 
            this.составСчетаBindingSource.DataMember = "СоставСчета";
            this.составСчетаBindingSource.DataSource = this.dataSet;
            // 
            // расходBindingSource
            // 
            this.расходBindingSource.DataMember = "Расход";
            this.расходBindingSource.DataSource = this.dataSet;
            // 
            // расходTableAdapter
            // 
            this.расходTableAdapter.ClearBeforeFill = true;
            // 
            // составРасходаBindingSource
            // 
            this.составРасходаBindingSource.DataMember = "СоставРасхода";
            this.составРасходаBindingSource.DataSource = this.dataSet;
            // 
            // составРасходаTableAdapter
            // 
            this.составРасходаTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(393, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 46);
            this.button3.TabIndex = 31;
            this.button3.Text = "Наличие в других аптеках";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddSchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MedicalStorage.Properties.Resources._78578f2695538f1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 262);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(менеджерIDLabel);
            this.Controls.Add(this.менеджерIDComboBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.MaximizeBox = false;
            this.Name = "AddSchet";
            this.Text = "Оформление счета";
            this.Load += new System.EventHandler(this.AddSchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.счетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составСчетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составРасходаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox менеджерIDComboBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource счетаBindingSource;
        private DataSetTableAdapters.СчетаTableAdapter счетаTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetTableAdapters.СоставСчетаTableAdapter составСчетаTableAdapter;
        private System.Windows.Forms.BindingSource составСчетаBindingSource;
        private DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private System.Windows.Forms.BindingSource расходBindingSource;
        private DataSetTableAdapters.РасходTableAdapter расходTableAdapter;
        private System.Windows.Forms.BindingSource составРасходаBindingSource;
        private DataSetTableAdapters.СоставРасходаTableAdapter составРасходаTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}