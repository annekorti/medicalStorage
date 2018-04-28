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
    public partial class AddRacxod : Form
    {
        public AddRacxod()
        {
            InitializeComponent();
        }

        private void AddRacxod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Менеджеры". При необходимости она может быть перемещена или удалена.
            this.менеджерыTableAdapter.Fill(this.dataSet.Менеджеры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.СоставРасхода". При необходимости она может быть перемещена или удалена.
            this.составРасходаTableAdapter.Fill(this.dataSet.СоставРасхода);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Расход". При необходимости она может быть перемещена или удалена.
            this.расходTableAdapter.Fill(this.dataSet.Расход);

            spisok = new List<Tovar>();

        }
        private List<Tovar> spisok;

        private Tovar CreateTovar()
        {
            var t = new Tovar(true, spisok);
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
            if (менеджерIDComboBox.SelectedIndex < 0 || spisok.Count == 0)
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("Не для всех товаров указано количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            расходTableAdapter.Insert(датаDateTimePicker.Value.Date, (int)менеджерIDComboBox.SelectedValue);
            расходTableAdapter.Fill(dataSet.Расход);

            int id = dataSet.Расход.Last().Шифр;

            using (var dbAdapter = new DbAdapter())
            {
                foreach (var t in spisok)
                {
                    составРасходаTableAdapter.Insert(id, t.TovarId, t.Count,t.Cena*t.Count);
                    dbAdapter.UpdateTovar(t.TovarId, -t.Count);
                }
                составРасходаTableAdapter.Fill(dataSet.СоставРасхода);
            }

            MessageBox.Show("Расход успешно оформлен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var t = CreateTovar();
            spisok.Add(t);
        }
    }
}
