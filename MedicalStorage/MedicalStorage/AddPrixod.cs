using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalStorage
{
    public partial class AddPrixod : Form
    {
        public AddPrixod()
        {
            InitializeComponent();
        }

        private void AddPrixod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.СоставПрихода". При необходимости она может быть перемещена или удалена.
            this.составПриходаTableAdapter.Fill(this.dataSet.СоставПрихода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Приход". При необходимости она может быть перемещена или удалена.
            this.приходTableAdapter.Fill(this.dataSet.Приход);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.dataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Менеджеры". При необходимости она может быть перемещена или удалена.
            this.менеджерыTableAdapter.Fill(this.dataSet.Менеджеры);

            spisok = new List<Tovar>();
        }

        private List<Tovar> spisok;

        private Tovar CreateTovar()
        {
            var t = new Tovar(false, spisok);
            panel1.Controls.Add(t);
            t.Dock = DockStyle.Top;
            t.Closed += t_Closed;
            return t;
        }

        void t_Closed(object sender, EventArgs e)
        {
            var t = (sender as Tovar);
            spisok.Remove(t);
            t.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (менеджерIDComboBox.SelectedIndex < 0 || поставщикIDComboBox.SelectedIndex < 0 || spisok.Count == 0)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (var t in spisok)
            {
                if (t.TovarId == -1)
                {
                    MessageBox.Show("Какой-то из товаров отсутствует на складе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (t.Count == 0)
                {
                    MessageBox.Show("Укажите количество!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            приходTableAdapter.Insert(датаDateTimePicker.Value.Date, (int)поставщикIDComboBox.SelectedValue, (int)менеджерIDComboBox.SelectedValue);
            приходTableAdapter.Fill(dataSet.Приход);

            int id = dataSet.Приход.Last().Шифр;

            using (var dbAdapter = new DbAdapter())
            {
                foreach (var t in spisok)
                {
                    составПриходаTableAdapter.Insert(id, t.TovarId, t.Count, t.CenaZak * t.Count);
                    dbAdapter.UpdateTovar(t.TovarId, t.Count);
                }
                составПриходаTableAdapter.Fill(dataSet.СоставПрихода);
            }

            MessageBox.Show("Приход успешно оформлен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = CreateTovar();
            spisok.Add(t);
        }
    }
}
