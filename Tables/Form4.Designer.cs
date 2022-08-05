
namespace Goods2
{
    partial class Form4
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
            System.Windows.Forms.Label кодвидатовараLabel;
            System.Windows.Forms.Label ценазаединицуLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label номервариантаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label датазаказаLabel;
            System.Windows.Forms.Label кодзаказчикаLabel;
            System.Windows.Forms.Label коднаименованияLabel;
            this.tovaryDataSet = new Goods2.TovaryDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new Goods2.TovaryDataSetTableAdapters.ЗаказыTableAdapter();
            this.tableAdapterManager = new Goods2.TovaryDataSetTableAdapters.TableAdapterManager();
            this.заказыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.заказыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.номервариантаTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.tovaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиятовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tovaryDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиятовараTableAdapter = new Goods2.TovaryDataSetTableAdapters.НаименованиятовараTableAdapter();
            this.датазаказаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.кодзаказчикаTextBox = new System.Windows.Forms.TextBox();
            this.наименованиятовараBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.коднаименованияTextBox = new System.Windows.Forms.TextBox();
            кодвидатовараLabel = new System.Windows.Forms.Label();
            ценазаединицуLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            номервариантаLabel = new System.Windows.Forms.Label();
            датазаказаLabel = new System.Windows.Forms.Label();
            кодзаказчикаLabel = new System.Windows.Forms.Label();
            коднаименованияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).BeginInit();
            this.заказыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименованиятовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименованиятовараBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // кодвидатовараLabel
            // 
            кодвидатовараLabel.AutoSize = true;
            кодвидатовараLabel.Location = new System.Drawing.Point(291, 118);
            кодвидатовараLabel.Name = "кодвидатовараLabel";
            кодвидатовараLabel.Size = new System.Drawing.Size(88, 13);
            кодвидатовараLabel.TabIndex = 1;
            кодвидатовараLabel.Text = "Кодвидатовара:";
            // 
            // ценазаединицуLabel
            // 
            ценазаединицуLabel.AutoSize = true;
            ценазаединицуLabel.Location = new System.Drawing.Point(290, 170);
            ценазаединицуLabel.Name = "ценазаединицуLabel";
            ценазаединицуLabel.Size = new System.Drawing.Size(89, 13);
            ценазаединицуLabel.TabIndex = 5;
            ценазаединицуLabel.Text = "Ценазаединицу:";
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(310, 196);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(69, 13);
            количествоLabel.TabIndex = 7;
            количествоLabel.Text = "Количество:";
            // 
            // номервариантаLabel
            // 
            номервариантаLabel.AutoSize = true;
            номервариантаLabel.Location = new System.Drawing.Point(288, 248);
            номервариантаLabel.Name = "номервариантаLabel";
            номервариантаLabel.Size = new System.Drawing.Size(91, 13);
            номервариантаLabel.TabIndex = 11;
            номервариантаLabel.Text = "Номерварианта:";
            // 
            // tovaryDataSet
            // 
            this.tovaryDataSet.DataSetName = "TovaryDataSet";
            this.tovaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.tovaryDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Goods2.TovaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВидытовараTableAdapter = null;
            this.tableAdapterManager.ЗаказчикиTableAdapter = null;
            this.tableAdapterManager.ЗаказыTableAdapter = this.заказыTableAdapter;
            this.tableAdapterManager.НаименованиятовараTableAdapter = null;
            // 
            // заказыBindingNavigator
            // 
            this.заказыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказыBindingNavigator.BindingSource = this.заказыBindingSource;
            this.заказыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказыBindingNavigatorSaveItem});
            this.заказыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказыBindingNavigator.Name = "заказыBindingNavigator";
            this.заказыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказыBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.заказыBindingNavigator.TabIndex = 0;
            this.заказыBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // заказыBindingNavigatorSaveItem
            // 
            this.заказыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказыBindingNavigatorSaveItem.Image")));
            this.заказыBindingNavigatorSaveItem.Name = "заказыBindingNavigatorSaveItem";
            this.заказыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.заказыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказыBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказыBindingNavigatorSaveItem_Click);
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(385, 193);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.количествоTextBox.TabIndex = 8;
            // 
            // номервариантаTextBox
            // 
            this.номервариантаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Номерварианта", true));
            this.номервариантаTextBox.Location = new System.Drawing.Point(385, 245);
            this.номервариантаTextBox.Name = "номервариантаTextBox";
            this.номервариантаTextBox.Size = new System.Drawing.Size(100, 20);
            this.номервариантаTextBox.TabIndex = 12;
            this.номервариантаTextBox.TextChanged += new System.EventHandler(this.номервариантаTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(275, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 68);
            this.label1.TabIndex = 15;
            this.label1.Text = "Таблица \"Заказы\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(458, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(458, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(364, 369);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Кодвидатовара", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(385, 115);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 24;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Ценазаединицу", true));
            this.maskedTextBox3.Location = new System.Drawing.Point(385, 167);
            this.maskedTextBox3.Mask = "0000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox3.TabIndex = 25;
            // 
            // tovaryDataSetBindingSource
            // 
            this.tovaryDataSetBindingSource.DataSource = this.tovaryDataSet;
            this.tovaryDataSetBindingSource.Position = 0;
            // 
            // наименованиятовараBindingSource
            // 
            this.наименованиятовараBindingSource.DataMember = "Наименованиятовара";
            this.наименованиятовараBindingSource.DataSource = this.tovaryDataSetBindingSource;
            // 
            // tovaryDataSetBindingSource1
            // 
            this.tovaryDataSetBindingSource1.DataSource = this.tovaryDataSet;
            this.tovaryDataSetBindingSource1.Position = 0;
            // 
            // наименованиятовараTableAdapter
            // 
            this.наименованиятовараTableAdapter.ClearBeforeFill = true;
            // 
            // датазаказаDateTimePicker
            // 
            this.датазаказаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказыBindingSource, "Датазаказа", true));
            this.датазаказаDateTimePicker.Location = new System.Drawing.Point(385, 220);
            this.датазаказаDateTimePicker.Name = "датазаказаDateTimePicker";
            this.датазаказаDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.датазаказаDateTimePicker.TabIndex = 28;
            // 
            // датазаказаLabel
            // 
            датазаказаLabel.AutoSize = true;
            датазаказаLabel.Location = new System.Drawing.Point(307, 224);
            датазаказаLabel.Name = "датазаказаLabel";
            датазаказаLabel.Size = new System.Drawing.Size(72, 13);
            датазаказаLabel.TabIndex = 27;
            датазаказаLabel.Text = "Датазаказа:";
            // 
            // кодзаказчикаLabel
            // 
            кодзаказчикаLabel.AutoSize = true;
            кодзаказчикаLabel.Location = new System.Drawing.Point(297, 274);
            кодзаказчикаLabel.Name = "кодзаказчикаLabel";
            кодзаказчикаLabel.Size = new System.Drawing.Size(82, 13);
            кодзаказчикаLabel.TabIndex = 28;
            кодзаказчикаLabel.Text = "Кодзаказчика:";
            // 
            // кодзаказчикаTextBox
            // 
            this.кодзаказчикаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Кодзаказчика", true));
            this.кодзаказчикаTextBox.Location = new System.Drawing.Point(385, 271);
            this.кодзаказчикаTextBox.Name = "кодзаказчикаTextBox";
            this.кодзаказчикаTextBox.Size = new System.Drawing.Size(100, 20);
            this.кодзаказчикаTextBox.TabIndex = 29;
            // 
            // наименованиятовараBindingSource1
            // 
            this.наименованиятовараBindingSource1.DataMember = "Наименованиятовара";
            this.наименованиятовараBindingSource1.DataSource = this.tovaryDataSetBindingSource;
            // 
            // коднаименованияLabel
            // 
            коднаименованияLabel.AutoSize = true;
            коднаименованияLabel.Location = new System.Drawing.Point(276, 144);
            коднаименованияLabel.Name = "коднаименованияLabel";
            коднаименованияLabel.Size = new System.Drawing.Size(103, 13);
            коднаименованияLabel.TabIndex = 29;
            коднаименованияLabel.Text = "Коднаименования:";
            // 
            // коднаименованияTextBox
            // 
            this.коднаименованияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказыBindingSource, "Коднаименования", true));
            this.коднаименованияTextBox.Location = new System.Drawing.Point(385, 141);
            this.коднаименованияTextBox.Name = "коднаименованияTextBox";
            this.коднаименованияTextBox.Size = new System.Drawing.Size(100, 20);
            this.коднаименованияTextBox.TabIndex = 30;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(коднаименованияLabel);
            this.Controls.Add(this.коднаименованияTextBox);
            this.Controls.Add(кодзаказчикаLabel);
            this.Controls.Add(this.кодзаказчикаTextBox);
            this.Controls.Add(датазаказаLabel);
            this.Controls.Add(this.датазаказаDateTimePicker);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(номервариантаLabel);
            this.Controls.Add(this.номервариантаTextBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(ценазаединицуLabel);
            this.Controls.Add(кодвидатовараLabel);
            this.Controls.Add(this.заказыBindingNavigator);
            this.Name = "Form4";
            this.Text = "Таблица \"Заказы\"";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingNavigator)).EndInit();
            this.заказыBindingNavigator.ResumeLayout(false);
            this.заказыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименованиятовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tovaryDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.наименованиятовараBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TovaryDataSet tovaryDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private TovaryDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private TovaryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.TextBox номервариантаTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.BindingSource tovaryDataSetBindingSource;
        private System.Windows.Forms.BindingSource tovaryDataSetBindingSource1;
        private System.Windows.Forms.BindingSource наименованиятовараBindingSource;
        private TovaryDataSetTableAdapters.НаименованиятовараTableAdapter наименованиятовараTableAdapter;
        private System.Windows.Forms.DateTimePicker датазаказаDateTimePicker;
        private System.Windows.Forms.TextBox кодзаказчикаTextBox;
        private System.Windows.Forms.BindingSource наименованиятовараBindingSource1;
        private System.Windows.Forms.TextBox коднаименованияTextBox;
    }
}