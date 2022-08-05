
namespace Goods2
{
    partial class LentDolznosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LentDolznosti));
            System.Windows.Forms.Label кОД_ДОЛЖНОСТИLabel;
            System.Windows.Forms.Label нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel;
            System.Windows.Forms.Label оКЛАДLabel;
            System.Windows.Forms.Label оБЯЗАННОСТИLabel;
            System.Windows.Forms.Label тРЕБОВАНИЯLabel;
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transportDataSet = new Goods2.TransportDataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new Goods2.TransportDataSetTableAdapters.ДолжностиTableAdapter();
            this.tableAdapterManager = new Goods2.TransportDataSetTableAdapters.TableAdapterManager();
            this.должностиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.должностиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.кОД_ДОЛЖНОСТИTextBox = new System.Windows.Forms.TextBox();
            this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox = new System.Windows.Forms.TextBox();
            this.оКЛАДTextBox = new System.Windows.Forms.TextBox();
            this.оБЯЗАННОСТИTextBox = new System.Windows.Forms.TextBox();
            this.тРЕБОВАНИЯTextBox = new System.Windows.Forms.TextBox();
            кОД_ДОЛЖНОСТИLabel = new System.Windows.Forms.Label();
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel = new System.Windows.Forms.Label();
            оКЛАДLabel = new System.Windows.Forms.Label();
            оБЯЗАННОСТИLabel = new System.Windows.Forms.Label();
            тРЕБОВАНИЯLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).BeginInit();
            this.должностиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(368, 336);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 53;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(474, 290);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 52;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(367, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 40);
            this.button5.TabIndex = 51;
            this.button5.Text = "Следующая запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(261, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 50;
            this.button4.Text = "Последняя запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 49;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 48;
            this.button2.Text = "Предыдущая запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 47;
            this.button1.Text = "Первая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(195, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ленточная форма таблицы \"Должности\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.transportDataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Goods2.TransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Виды_автомобилейTableAdapter = null;
            this.tableAdapterManager.Виды_грузовTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.Марки_автомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // должностиBindingNavigator
            // 
            this.должностиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.должностиBindingNavigator.BindingSource = this.должностиBindingSource;
            this.должностиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.должностиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.должностиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.должностиBindingNavigatorSaveItem});
            this.должностиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.должностиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.должностиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.должностиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.должностиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.должностиBindingNavigator.Name = "должностиBindingNavigator";
            this.должностиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.должностиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.должностиBindingNavigator.TabIndex = 54;
            this.должностиBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // должностиBindingNavigatorSaveItem
            // 
            this.должностиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.должностиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("должностиBindingNavigatorSaveItem.Image")));
            this.должностиBindingNavigatorSaveItem.Name = "должностиBindingNavigatorSaveItem";
            this.должностиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.должностиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.должностиBindingNavigatorSaveItem.Click += new System.EventHandler(this.должностиBindingNavigatorSaveItem_Click);
            // 
            // кОД_ДОЛЖНОСТИLabel
            // 
            кОД_ДОЛЖНОСТИLabel.AutoSize = true;
            кОД_ДОЛЖНОСТИLabel.Location = new System.Drawing.Point(251, 117);
            кОД_ДОЛЖНОСТИLabel.Name = "кОД_ДОЛЖНОСТИLabel";
            кОД_ДОЛЖНОСТИLabel.Size = new System.Drawing.Size(111, 13);
            кОД_ДОЛЖНОСТИLabel.TabIndex = 54;
            кОД_ДОЛЖНОСТИLabel.Text = "КОД ДОЛЖНОСТИ:";
            // 
            // кОД_ДОЛЖНОСТИTextBox
            // 
            this.кОД_ДОЛЖНОСТИTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "КОД_ДОЛЖНОСТИ", true));
            this.кОД_ДОЛЖНОСТИTextBox.Location = new System.Drawing.Point(368, 114);
            this.кОД_ДОЛЖНОСТИTextBox.Name = "кОД_ДОЛЖНОСТИTextBox";
            this.кОД_ДОЛЖНОСТИTextBox.Size = new System.Drawing.Size(100, 20);
            this.кОД_ДОЛЖНОСТИTextBox.TabIndex = 55;
            // 
            // нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel
            // 
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel.AutoSize = true;
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel.Location = new System.Drawing.Point(183, 143);
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel.Name = "нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel";
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel.Size = new System.Drawing.Size(179, 13);
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel.TabIndex = 55;
            нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel.Text = "НАИМЕНОВАНИЕ ДОЛЖНОСТИ:";
            // 
            // нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox
            // 
            this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "НАИМЕНОВАНИЕ_ДОЛЖНОСТИ", true));
            this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox.Location = new System.Drawing.Point(368, 140);
            this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox.Name = "нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox";
            this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox.Size = new System.Drawing.Size(100, 20);
            this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox.TabIndex = 56;
            // 
            // оКЛАДLabel
            // 
            оКЛАДLabel.AutoSize = true;
            оКЛАДLabel.Location = new System.Drawing.Point(313, 169);
            оКЛАДLabel.Name = "оКЛАДLabel";
            оКЛАДLabel.Size = new System.Drawing.Size(49, 13);
            оКЛАДLabel.TabIndex = 56;
            оКЛАДLabel.Text = "ОКЛАД:";
            // 
            // оКЛАДTextBox
            // 
            this.оКЛАДTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "ОКЛАД", true));
            this.оКЛАДTextBox.Location = new System.Drawing.Point(368, 166);
            this.оКЛАДTextBox.Name = "оКЛАДTextBox";
            this.оКЛАДTextBox.Size = new System.Drawing.Size(100, 20);
            this.оКЛАДTextBox.TabIndex = 57;
            // 
            // оБЯЗАННОСТИLabel
            // 
            оБЯЗАННОСТИLabel.AutoSize = true;
            оБЯЗАННОСТИLabel.Location = new System.Drawing.Point(269, 195);
            оБЯЗАННОСТИLabel.Name = "оБЯЗАННОСТИLabel";
            оБЯЗАННОСТИLabel.Size = new System.Drawing.Size(93, 13);
            оБЯЗАННОСТИLabel.TabIndex = 57;
            оБЯЗАННОСТИLabel.Text = "ОБЯЗАННОСТИ:";
            // 
            // оБЯЗАННОСТИTextBox
            // 
            this.оБЯЗАННОСТИTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "ОБЯЗАННОСТИ", true));
            this.оБЯЗАННОСТИTextBox.Location = new System.Drawing.Point(368, 192);
            this.оБЯЗАННОСТИTextBox.Name = "оБЯЗАННОСТИTextBox";
            this.оБЯЗАННОСТИTextBox.Size = new System.Drawing.Size(100, 20);
            this.оБЯЗАННОСТИTextBox.TabIndex = 58;
            // 
            // тРЕБОВАНИЯLabel
            // 
            тРЕБОВАНИЯLabel.AutoSize = true;
            тРЕБОВАНИЯLabel.Location = new System.Drawing.Point(278, 221);
            тРЕБОВАНИЯLabel.Name = "тРЕБОВАНИЯLabel";
            тРЕБОВАНИЯLabel.Size = new System.Drawing.Size(84, 13);
            тРЕБОВАНИЯLabel.TabIndex = 58;
            тРЕБОВАНИЯLabel.Text = "ТРЕБОВАНИЯ:";
            // 
            // тРЕБОВАНИЯTextBox
            // 
            this.тРЕБОВАНИЯTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "ТРЕБОВАНИЯ", true));
            this.тРЕБОВАНИЯTextBox.Location = new System.Drawing.Point(368, 218);
            this.тРЕБОВАНИЯTextBox.Name = "тРЕБОВАНИЯTextBox";
            this.тРЕБОВАНИЯTextBox.Size = new System.Drawing.Size(100, 20);
            this.тРЕБОВАНИЯTextBox.TabIndex = 59;
            // 
            // LentDolznosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(тРЕБОВАНИЯLabel);
            this.Controls.Add(this.тРЕБОВАНИЯTextBox);
            this.Controls.Add(оБЯЗАННОСТИLabel);
            this.Controls.Add(this.оБЯЗАННОСТИTextBox);
            this.Controls.Add(оКЛАДLabel);
            this.Controls.Add(this.оКЛАДTextBox);
            this.Controls.Add(нАИМЕНОВАНИЕ_ДОЛЖНОСТИLabel);
            this.Controls.Add(this.нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox);
            this.Controls.Add(кОД_ДОЛЖНОСТИLabel);
            this.Controls.Add(this.кОД_ДОЛЖНОСТИTextBox);
            this.Controls.Add(this.должностиBindingNavigator);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "LentDolznosti";
            this.Text = "LentDolznosti";
            this.Load += new System.EventHandler(this.LentDolznosti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingNavigator)).EndInit();
            this.должностиBindingNavigator.ResumeLayout(false);
            this.должностиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private TransportDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private TransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator должностиBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton должностиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кОД_ДОЛЖНОСТИTextBox;
        private System.Windows.Forms.TextBox нАИМЕНОВАНИЕ_ДОЛЖНОСТИTextBox;
        private System.Windows.Forms.TextBox оКЛАДTextBox;
        private System.Windows.Forms.TextBox оБЯЗАННОСТИTextBox;
        private System.Windows.Forms.TextBox тРЕБОВАНИЯTextBox;
    }
}