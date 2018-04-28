namespace MedicalStorage
{
    partial class AddRacxod
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
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label менеджерIDLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.менеджерIDComboBox = new System.Windows.Forms.ComboBox();
            this.менеджерыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new MedicalStorage.DataSet();
            this.расходBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расходTableAdapter = new MedicalStorage.DataSetTableAdapters.РасходTableAdapter();
            this.tableAdapterManager = new MedicalStorage.DataSetTableAdapters.TableAdapterManager();
            this.менеджерыTableAdapter = new MedicalStorage.DataSetTableAdapters.МенеджерыTableAdapter();
            this.составРасходаTableAdapter = new MedicalStorage.DataSetTableAdapters.СоставРасходаTableAdapter();
            this.составРасходаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            датаLabel = new System.Windows.Forms.Label();
            менеджерIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расходBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.составРасходаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.BackColor = System.Drawing.Color.Transparent;
            датаLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            датаLabel.Location = new System.Drawing.Point(67, 17);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(42, 15);
            датаLabel.TabIndex = 29;
            датаLabel.Text = "Дата:";
            // 
            // менеджерIDLabel
            // 
            менеджерIDLabel.AutoSize = true;
            менеджерIDLabel.BackColor = System.Drawing.Color.Transparent;
            менеджерIDLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            менеджерIDLabel.Location = new System.Drawing.Point(50, 37);
            менеджерIDLabel.Name = "менеджерIDLabel";
            менеджерIDLabel.Size = new System.Drawing.Size(77, 15);
            менеджерIDLabel.TabIndex = 33;
            менеджерIDLabel.Text = "Фармацевт:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(19, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 43);
            this.button2.TabIndex = 37;
            this.button2.Text = "Добавить товар";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(19, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 125);
            this.panel1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(195, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 43);
            this.button1.TabIndex = 35;
            this.button1.Text = "Оформить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.Location = new System.Drawing.Point(154, 12);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.датаDateTimePicker.TabIndex = 30;
            // 
            // менеджерIDComboBox
            // 
            this.менеджерIDComboBox.DataSource = this.менеджерыBindingSource;
            this.менеджерIDComboBox.DisplayMember = "ФИО";
            this.менеджерIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.менеджерIDComboBox.FormattingEnabled = true;
            this.менеджерIDComboBox.Location = new System.Drawing.Point(154, 35);
            this.менеджерIDComboBox.Name = "менеджерIDComboBox";
            this.менеджерIDComboBox.Size = new System.Drawing.Size(129, 21);
            this.менеджерIDComboBox.TabIndex = 34;
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
            // расходBindingSource
            // 
            this.расходBindingSource.DataMember = "Расход";
            this.расходBindingSource.DataSource = this.dataSet;
            // 
            // расходTableAdapter
            // 
            this.расходTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = MedicalStorage.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ГруппыТоваровTableAdapter = null;
            this.tableAdapterManager.МенеджерыTableAdapter = this.менеджерыTableAdapter;
            this.tableAdapterManager.ПоставщикиTableAdapter = null;
            this.tableAdapterManager.ПриходTableAdapter = null;
            this.tableAdapterManager.РасходTableAdapter = this.расходTableAdapter;
            this.tableAdapterManager.РеквизитыTableAdapter = null;
            this.tableAdapterManager.СоставПриходаTableAdapter = null;
            this.tableAdapterManager.СоставРасходаTableAdapter = this.составРасходаTableAdapter;
            this.tableAdapterManager.СоставСчетаTableAdapter = null;
            this.tableAdapterManager.СчетаTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // менеджерыTableAdapter
            // 
            this.менеджерыTableAdapter.ClearBeforeFill = true;
            // 
            // составРасходаTableAdapter
            // 
            this.составРасходаTableAdapter.ClearBeforeFill = true;
            // 
            // составРасходаBindingSource
            // 
            this.составРасходаBindingSource.DataMember = "СоставРасхода";
            this.составРасходаBindingSource.DataSource = this.dataSet;
            // 
            // AddRacxod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::MedicalStorage.Properties.Resources._78578f2695538f1;
            this.ClientSize = new System.Drawing.Size(337, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(менеджерIDLabel);
            this.Controls.Add(this.менеджерIDComboBox);
            this.Name = "AddRacxod";
            this.Text = "Оформление расхода";
            this.Load += new System.EventHandler(this.AddRacxod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.менеджерыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расходBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.составРасходаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.ComboBox менеджерIDComboBox;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource расходBindingSource;
        private DataSetTableAdapters.РасходTableAdapter расходTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetTableAdapters.СоставРасходаTableAdapter составРасходаTableAdapter;
        private System.Windows.Forms.BindingSource составРасходаBindingSource;
        private DataSetTableAdapters.МенеджерыTableAdapter менеджерыTableAdapter;
        private System.Windows.Forms.BindingSource менеджерыBindingSource;
    }
}