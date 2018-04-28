namespace MedicalStorage
{
    partial class AddPrixod
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
            System.Windows.Forms.Label поставщикIDLabel;
            System.Windows.Forms.Label менеджерIDLabel;
            System.Windows.Forms.Label датаLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.менеджерIDComboBox = new System.Windows.Forms.ComboBox();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MedicalStorage.DataSet();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.поставщикIDComboBox = new System.Windows.Forms.ComboBox();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менеджерыTableAdapter = new MedicalStorage.DataSetTableAdapters.МенеджерыTableAdapter();
            this.tableAdapterManager = new MedicalStorage.DataSetTableAdapters.TableAdapterManager();
            this.поставщикиTableAdapter = new MedicalStorage.DataSetTableAdapters.ПоставщикиTableAdapter();
            this.приходTableAdapter = new MedicalStorage.DataSetTableAdapters.ПриходTableAdapter();
            this.составПриходаTableAdapter = new MedicalStorage.DataSetTableAdapters.СоставПриходаTableAdapter();
            this.составПриходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            поставщикIDLabel = new System.Windows.Forms.Label();
            менеджерIDLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составПриходаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // поставщикIDLabel
            // 
            поставщикIDLabel.AutoSize = true;
            поставщикIDLabel.BackColor = System.Drawing.Color.Transparent;
            поставщикIDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            поставщикIDLabel.Location = new System.Drawing.Point(12, 67);
            поставщикIDLabel.Name = "поставщикIDLabel";
            поставщикIDLabel.Size = new System.Drawing.Size(91, 17);
            поставщикIDLabel.TabIndex = 27;
            поставщикIDLabel.Text = "Поставщик:";
            // 
            // менеджерIDLabel
            // 
            менеджерIDLabel.AutoSize = true;
            менеджерIDLabel.BackColor = System.Drawing.Color.Transparent;
            менеджерIDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            менеджерIDLabel.Location = new System.Drawing.Point(19, 40);
            менеджерIDLabel.Name = "менеджерIDLabel";
            менеджерIDLabel.Size = new System.Drawing.Size(89, 17);
            менеджерIDLabel.TabIndex = 29;
            менеджерIDLabel.Text = "Фармацевт:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.BackColor = System.Drawing.Color.Transparent;
            датаLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(54, 18);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(49, 17);
            датаLabel.TabIndex = 25;
            датаLabel.Text = "Дата:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 40);
            this.button2.TabIndex = 24;
            this.button2.Text = "Добавить товар";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(208, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 32;
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
            this.panel1.Location = new System.Drawing.Point(15, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 126);
            this.panel1.TabIndex = 31;
            // 
            // менеджерIDComboBox
            // 
            this.менеджерIDComboBox.DataSource = this.менеджерыBindingSource;
            this.менеджерIDComboBox.DisplayMember = "ФИО";
            this.менеджерIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.менеджерIDComboBox.FormattingEnabled = true;
            this.менеджерIDComboBox.Location = new System.Drawing.Point(109, 38);
            this.менеджерIDComboBox.Name = "менеджерIDComboBox";
            this.менеджерIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.менеджерIDComboBox.TabIndex = 30;
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
            this.датаDateTimePicker.Location = new System.Drawing.Point(109, 12);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.датаDateTimePicker.TabIndex = 26;
            // 
            // поставщикIDComboBox
            // 
            this.поставщикIDComboBox.DataSource = this.поставщикиBindingSource;
            this.поставщикIDComboBox.DisplayMember = "Наименование";
            this.поставщикIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.поставщикIDComboBox.FormattingEnabled = true;
            this.поставщикIDComboBox.Location = new System.Drawing.Point(109, 65);
            this.поставщикIDComboBox.Name = "поставщикIDComboBox";
            this.поставщикIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.поставщикIDComboBox.TabIndex = 28;
            this.поставщикIDComboBox.ValueMember = "Шифр";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.dataSet;
            // 
            // менеджерыTableAdapter
            // 
            this.менеджерыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MedicalStorage.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыТоваровTableAdapter = null;
            this.tableAdapterManager.МенеджерыTableAdapter = this.менеджерыTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = this.поставщикиTableAdapter;
            this.tableAdapterManager.ПриходTableAdapter = this.приходTableAdapter;
            this.tableAdapterManager.РасходTableAdapter = null;
            this.tableAdapterManager.РеквизитыTableAdapter = null;
            this.tableAdapterManager.СоставПриходаTableAdapter = this.составПриходаTableAdapter;
            this.tableAdapterManager.СоставРасходаTableAdapter = null;
            this.tableAdapterManager.СоставСчетаTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // приходTableAdapter
            // 
            this.приходTableAdapter.ClearBeforeFill = true;
            // 
            // составПриходаTableAdapter
            // 
            this.составПриходаTableAdapter.ClearBeforeFill = true;
            // 
            // составПриходаBindingSource
            // 
            this.составПриходаBindingSource.DataMember = "СоставПрихода";
            this.составПриходаBindingSource.DataSource = this.dataSet;
            // 
            // AddPrixod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MedicalStorage.Properties.Resources._78578f2695538f1;
            this.ClientSize = new System.Drawing.Size(341, 281);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.менеджерIDComboBox);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(this.поставщикIDComboBox);
            this.Controls.Add(поставщикIDLabel);
            this.Controls.Add(менеджерIDLabel);
            this.Controls.Add(датаLabel);
            this.MaximizeBox = false;
            this.Name = "AddPrixod";
            this.Text = "Оформление прихода";
            this.Load += new System.EventHandler(this.AddPrixod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составПриходаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox менеджерIDComboBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.ComboBox поставщикIDComboBox;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
        private DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private DataSetTableAdapters.ПриходTableAdapter приходTableAdapter;
        private DataSetTableAdapters.СоставПриходаTableAdapter составПриходаTableAdapter;
        private System.Windows.Forms.BindingSource составПриходаBindingSource;
    }
}