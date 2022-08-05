
namespace Goods2
{
    partial class SotrudnikiLent
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
            System.Windows.Forms.Label кОД_СОТРУДНИКАLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SotrudnikiLent));
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label вОЗРАСТLabel;
            System.Windows.Forms.Label пОЛLabel;
            System.Windows.Forms.Label аДРЕСLabel;
            System.Windows.Forms.Label тЕЛЕФОНLabel;
            System.Windows.Forms.Label пАСПОРТНЫЕ_ДАННЫЕLabel;
            System.Windows.Forms.Label кОД_ДОЛЖНОСТИLabel;
            this.transportDataSet = new Goods2.TransportDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Goods2.TransportDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new Goods2.TransportDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.кОД_СОТРУДНИКАTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.сотрудникиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.вОЗРАСТTextBox = new System.Windows.Forms.TextBox();
            this.пОЛTextBox = new System.Windows.Forms.TextBox();
            this.аДРЕСTextBox = new System.Windows.Forms.TextBox();
            this.тЕЛЕФОНTextBox = new System.Windows.Forms.TextBox();
            this.пАСПОРТНЫЕ_ДАННЫЕTextBox = new System.Windows.Forms.TextBox();
            this.кОД_ДОЛЖНОСТИTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            кОД_СОТРУДНИКАLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            вОЗРАСТLabel = new System.Windows.Forms.Label();
            пОЛLabel = new System.Windows.Forms.Label();
            аДРЕСLabel = new System.Windows.Forms.Label();
            тЕЛЕФОНLabel = new System.Windows.Forms.Label();
            пАСПОРТНЫЕ_ДАННЫЕLabel = new System.Windows.Forms.Label();
            кОД_ДОЛЖНОСТИLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).BeginInit();
            this.сотрудникиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.transportDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Goods2.TransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Виды_автомобилейTableAdapter = null;
            this.tableAdapterManager.Виды_грузовTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_автомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // сотрудникиBindingNavigator
            // 
            this.сотрудникиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сотрудникиBindingNavigator.BindingSource = this.сотрудникиBindingSource;
            this.сотрудникиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сотрудникиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сотрудникиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.сотрудникиBindingNavigatorSaveItem});
            this.сотрудникиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сотрудникиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сотрудникиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сотрудникиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сотрудникиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сотрудникиBindingNavigator.Name = "сотрудникиBindingNavigator";
            this.сотрудникиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сотрудникиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.сотрудникиBindingNavigator.TabIndex = 0;
            this.сотрудникиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // кОД_СОТРУДНИКАLabel
            // 
            кОД_СОТРУДНИКАLabel.AutoSize = true;
            кОД_СОТРУДНИКАLabel.Location = new System.Drawing.Point(260, 119);
            кОД_СОТРУДНИКАLabel.Name = "кОД_СОТРУДНИКАLabel";
            кОД_СОТРУДНИКАLabel.Size = new System.Drawing.Size(113, 13);
            кОД_СОТРУДНИКАLabel.TabIndex = 1;
            кОД_СОТРУДНИКАLabel.Text = "КОД СОТРУДНИКА:";
            // 
            // кОД_СОТРУДНИКАTextBox
            // 
            this.кОД_СОТРУДНИКАTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "КОД_СОТРУДНИКА", true));
            this.кОД_СОТРУДНИКАTextBox.Location = new System.Drawing.Point(379, 116);
            this.кОД_СОТРУДНИКАTextBox.Name = "кОД_СОТРУДНИКАTextBox";
            this.кОД_СОТРУДНИКАTextBox.Size = new System.Drawing.Size(100, 20);
            this.кОД_СОТРУДНИКАTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // сотрудникиBindingNavigatorSaveItem
            // 
            this.сотрудникиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сотрудникиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сотрудникиBindingNavigatorSaveItem.Image")));
            this.сотрудникиBindingNavigatorSaveItem.Name = "сотрудникиBindingNavigatorSaveItem";
            this.сотрудникиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.сотрудникиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сотрудникиBindingNavigatorSaveItem.Click += new System.EventHandler(this.сотрудникиBindingNavigatorSaveItem_Click);
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(336, 145);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(379, 142);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // вОЗРАСТLabel
            // 
            вОЗРАСТLabel.AutoSize = true;
            вОЗРАСТLabel.Location = new System.Drawing.Point(313, 171);
            вОЗРАСТLabel.Name = "вОЗРАСТLabel";
            вОЗРАСТLabel.Size = new System.Drawing.Size(60, 13);
            вОЗРАСТLabel.TabIndex = 5;
            вОЗРАСТLabel.Text = "ВОЗРАСТ:";
            // 
            // вОЗРАСТTextBox
            // 
            this.вОЗРАСТTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ВОЗРАСТ", true));
            this.вОЗРАСТTextBox.Location = new System.Drawing.Point(379, 168);
            this.вОЗРАСТTextBox.Name = "вОЗРАСТTextBox";
            this.вОЗРАСТTextBox.Size = new System.Drawing.Size(100, 20);
            this.вОЗРАСТTextBox.TabIndex = 6;
            // 
            // пОЛLabel
            // 
            пОЛLabel.AutoSize = true;
            пОЛLabel.Location = new System.Drawing.Point(339, 197);
            пОЛLabel.Name = "пОЛLabel";
            пОЛLabel.Size = new System.Drawing.Size(34, 13);
            пОЛLabel.TabIndex = 7;
            пОЛLabel.Text = "ПОЛ:";
            // 
            // пОЛTextBox
            // 
            this.пОЛTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ПОЛ", true));
            this.пОЛTextBox.Location = new System.Drawing.Point(379, 194);
            this.пОЛTextBox.Name = "пОЛTextBox";
            this.пОЛTextBox.Size = new System.Drawing.Size(100, 20);
            this.пОЛTextBox.TabIndex = 8;
            // 
            // аДРЕСLabel
            // 
            аДРЕСLabel.AutoSize = true;
            аДРЕСLabel.Location = new System.Drawing.Point(326, 223);
            аДРЕСLabel.Name = "аДРЕСLabel";
            аДРЕСLabel.Size = new System.Drawing.Size(47, 13);
            аДРЕСLabel.TabIndex = 9;
            аДРЕСLabel.Text = "АДРЕС:";
            // 
            // аДРЕСTextBox
            // 
            this.аДРЕСTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "АДРЕС", true));
            this.аДРЕСTextBox.Location = new System.Drawing.Point(379, 220);
            this.аДРЕСTextBox.Name = "аДРЕСTextBox";
            this.аДРЕСTextBox.Size = new System.Drawing.Size(100, 20);
            this.аДРЕСTextBox.TabIndex = 10;
            // 
            // тЕЛЕФОНLabel
            // 
            тЕЛЕФОНLabel.AutoSize = true;
            тЕЛЕФОНLabel.Location = new System.Drawing.Point(307, 249);
            тЕЛЕФОНLabel.Name = "тЕЛЕФОНLabel";
            тЕЛЕФОНLabel.Size = new System.Drawing.Size(66, 13);
            тЕЛЕФОНLabel.TabIndex = 11;
            тЕЛЕФОНLabel.Text = "ТЕЛЕФОН:";
            // 
            // тЕЛЕФОНTextBox
            // 
            this.тЕЛЕФОНTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ТЕЛЕФОН", true));
            this.тЕЛЕФОНTextBox.Location = new System.Drawing.Point(379, 246);
            this.тЕЛЕФОНTextBox.Name = "тЕЛЕФОНTextBox";
            this.тЕЛЕФОНTextBox.Size = new System.Drawing.Size(100, 20);
            this.тЕЛЕФОНTextBox.TabIndex = 12;
            // 
            // пАСПОРТНЫЕ_ДАННЫЕLabel
            // 
            пАСПОРТНЫЕ_ДАННЫЕLabel.AutoSize = true;
            пАСПОРТНЫЕ_ДАННЫЕLabel.Location = new System.Drawing.Point(234, 275);
            пАСПОРТНЫЕ_ДАННЫЕLabel.Name = "пАСПОРТНЫЕ_ДАННЫЕLabel";
            пАСПОРТНЫЕ_ДАННЫЕLabel.Size = new System.Drawing.Size(139, 13);
            пАСПОРТНЫЕ_ДАННЫЕLabel.TabIndex = 13;
            пАСПОРТНЫЕ_ДАННЫЕLabel.Text = "ПАСПОРТНЫЕ ДАННЫЕ:";
            // 
            // пАСПОРТНЫЕ_ДАННЫЕTextBox
            // 
            this.пАСПОРТНЫЕ_ДАННЫЕTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ПАСПОРТНЫЕ_ДАННЫЕ", true));
            this.пАСПОРТНЫЕ_ДАННЫЕTextBox.Location = new System.Drawing.Point(379, 272);
            this.пАСПОРТНЫЕ_ДАННЫЕTextBox.Name = "пАСПОРТНЫЕ_ДАННЫЕTextBox";
            this.пАСПОРТНЫЕ_ДАННЫЕTextBox.Size = new System.Drawing.Size(100, 20);
            this.пАСПОРТНЫЕ_ДАННЫЕTextBox.TabIndex = 14;
            // 
            // кОД_ДОЛЖНОСТИLabel
            // 
            кОД_ДОЛЖНОСТИLabel.AutoSize = true;
            кОД_ДОЛЖНОСТИLabel.Location = new System.Drawing.Point(262, 301);
            кОД_ДОЛЖНОСТИLabel.Name = "кОД_ДОЛЖНОСТИLabel";
            кОД_ДОЛЖНОСТИLabel.Size = new System.Drawing.Size(111, 13);
            кОД_ДОЛЖНОСТИLabel.TabIndex = 15;
            кОД_ДОЛЖНОСТИLabel.Text = "КОД ДОЛЖНОСТИ:";
            // 
            // кОД_ДОЛЖНОСТИTextBox
            // 
            this.кОД_ДОЛЖНОСТИTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "КОД_ДОЛЖНОСТИ", true));
            this.кОД_ДОЛЖНОСТИTextBox.Location = new System.Drawing.Point(379, 298);
            this.кОД_ДОЛЖНОСТИTextBox.Name = "кОД_ДОЛЖНОСТИTextBox";
            this.кОД_ДОЛЖНОСТИTextBox.Size = new System.Drawing.Size(100, 20);
            this.кОД_ДОЛЖНОСТИTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(161, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ленточная форма таблицы \"Сотрудники\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(378, 416);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 42;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(485, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 41;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(378, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 40);
            this.button5.TabIndex = 40;
            this.button5.Text = "Следующая запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 39;
            this.button4.Text = "Последняя запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(485, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 38;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(379, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 37;
            this.button2.Text = "Предыдущая запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "Первая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SotrudnikiLent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(кОД_ДОЛЖНОСТИLabel);
            this.Controls.Add(this.кОД_ДОЛЖНОСТИTextBox);
            this.Controls.Add(пАСПОРТНЫЕ_ДАННЫЕLabel);
            this.Controls.Add(this.пАСПОРТНЫЕ_ДАННЫЕTextBox);
            this.Controls.Add(тЕЛЕФОНLabel);
            this.Controls.Add(this.тЕЛЕФОНTextBox);
            this.Controls.Add(аДРЕСLabel);
            this.Controls.Add(this.аДРЕСTextBox);
            this.Controls.Add(пОЛLabel);
            this.Controls.Add(this.пОЛTextBox);
            this.Controls.Add(вОЗРАСТLabel);
            this.Controls.Add(this.вОЗРАСТTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(кОД_СОТРУДНИКАLabel);
            this.Controls.Add(this.кОД_СОТРУДНИКАTextBox);
            this.Controls.Add(this.сотрудникиBindingNavigator);
            this.Name = "SotrudnikiLent";
            this.Text = "SotrudnikiLent";
            this.Load += new System.EventHandler(this.SotrudnikiLent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingNavigator)).EndInit();
            this.сотрудникиBindingNavigator.ResumeLayout(false);
            this.сотрудникиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private TransportDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private TransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сотрудникиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton сотрудникиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кОД_СОТРУДНИКАTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox вОЗРАСТTextBox;
        private System.Windows.Forms.TextBox пОЛTextBox;
        private System.Windows.Forms.TextBox аДРЕСTextBox;
        private System.Windows.Forms.TextBox тЕЛЕФОНTextBox;
        private System.Windows.Forms.TextBox пАСПОРТНЫЕ_ДАННЫЕTextBox;
        private System.Windows.Forms.TextBox кОД_ДОЛЖНОСТИTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}