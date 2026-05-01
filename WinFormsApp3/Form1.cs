namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            Town town = new Town();

            fTown ft = new fTown(ref town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(town);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Забороняє користувачу самому додавати порожні рядки внизу
            gvTowns.AllowUserToAddRows = false;

            // Забороняє редагувати комірки прямо в таблиці (тільки через форму fTown)
            gvTowns.ReadOnly = true;

            // Робить так, щоб при натисканні виділявся весь рядок, а не одна клітинка
            gvTowns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            gvTowns.DataSource = bindSrcTowns;

            // 1. Налаштовуємо таблицю (Код з Лістингу 7.3)
            gvTowns.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "Країна";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Region";
            column.Name = "Регіон";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Population";
            column.Name = "Мешканців";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearIncome";
            column.Name = "Річн. дохід";
            gvTowns.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Square";
            column.Name = "Площа";
            column.Width = 80;
            gvTowns.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPort";
            column.Name = "Порт";
            column.Width = 60;
            gvTowns.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasAirport";
            column.Name = "Аеропорт";
            column.Width = 60;
            gvTowns.Columns.Add(column);

            // 2. Додаємо початковий запис
            bindSrcTowns.Add(new Town("Львів", "Україна", "Львівська обл.", 800000, 2000000, 400, false, true));

            // 3. Оновлюємо відступи кнопок (Лістинг 7.1)
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void gvTowns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Town town = (Town)bindSrcTowns.List[bindSrcTowns.Position];

            fTown ft = new fTown(ref town);
            if (ft.ShowDialog() == DialogResult.OK)

            {
                bindSrcTowns.List[bindSrcTowns.Position] = town;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (bindSrcTowns.Current != null &&
        MessageBox.Show("Видалити цей запис?", "Увага", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
