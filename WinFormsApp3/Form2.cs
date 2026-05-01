using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class fTown : Form
    {
        private Town _town;
        public fTown(ref Town town)
        {
            InitializeComponent();
            _town = town;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fTown_Load(object sender, EventArgs e)
        {
            if (_town != null)
            {
                // Виводимо дані об'єкта в текстові поля (якщо це редагування)
                tbName.Text = _town.Name;
                tbCountry.Text = _town.Country;
                tbRegion.Text = _town.Region;
                tbPopulation.Text = _town.Population.ToString();
                tbYearIncome.Text = _town.YearIncome.ToString("0.00");
                tbSquare.Text = _town.Square.ToString("0.000");
                chbHasPort.Checked = _town.HasPort;
                chbHasAirport.Checked = _town.HasAirport;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Зберігаємо дані з полів назад в об'єкт
            _town.Name = tbName.Text.Trim();
            _town.Country = tbCountry.Text.Trim();
            _town.Region = tbRegion.Text.Trim();
            _town.Population = int.Parse(tbPopulation.Text.Trim());
            _town.YearIncome = double.Parse(tbYearIncome.Text.Trim());
            _town.Square = double.Parse(tbSquare.Text.Trim());
            _town.HasPort = chbHasPort.Checked;
            _town.HasAirport = chbHasAirport.Checked;

            DialogResult = DialogResult.OK; // Закриваємо форму з успіхом
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; // Закриваємо без збереження
        }
    }
}
