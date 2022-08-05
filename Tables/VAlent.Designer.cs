
namespace Goods2
{
    partial class VAlent
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
            System.Windows.Forms.Label кОД_ВИДА_АВТОМОБИЛЯLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAlent));
            System.Windows.Forms.Label нАИМЕНОВАНИЕLabel;
            System.Windows.Forms.Label оПИСАНИЕLabel;
            this.transportDataSet = new Goods2.TransportDataSet();
            this.виды_автомобилейBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виды_автомобилейTableAdapter = new Goods2.TransportDataSetTableAdapters.Виды_автомобилейTableAdapter();
            this.tableAdapterManager = new Goods2.TransportDataSetTableAdapters.TableAdapterManager();
            this.виды_автомобилейBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.кОД_ВИДА_АВТОМОБИЛЯTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.виды_автомобилейBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.нАИМЕНОВАНИЕTextBox = new System.Windows.Forms.TextBox();
            this.оПИСАНИЕTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            кОД_ВИДА_АВТОМОБИЛЯLabel = new System.Windows.Forms.Label();
            нАИМЕНОВАНИЕLabel = new System.Windows.Forms.Label();
            оПИСАНИЕLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_автомобилейBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_автомобилейBindingNavigator)).BeginInit();
            this.виды_автомобилейBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // transportDataSet
            // 
            this.transportDataSet.DataSetName = "TransportDataSet";
            this.transportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // виды_автомобилейBindingSource
            // 
            this.виды_автомобилейBindingSource.DataMember = "Виды_автомобилей";
            this.виды_автомобилейBindingSource.DataSource = this.transportDataSet;
            // 
            // виды_автомобилейTableAdapter
            // 
            this.виды_автомобилейTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Goods2.TransportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвтомобилиTableAdapter = null;
            this.tableAdapterManager.Виды_автомобилейTableAdapter = this.виды_автомобилейTableAdapter;
            this.tableAdapterManager.Виды_грузовTableAdapter = null;
            this.tableAdapterManager.ГрузыTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.Марки_автомобилейTableAdapter = null;
            this.tableAdapterManager.РейсыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // виды_автомобилейBindingNavigator
            // 
            this.виды_автомобилейBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.виды_автомобилейBindingNavigator.BindingSource = this.виды_автомобилейBindingSource;
            this.виды_автомобилейBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.виды_автомобилейBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.виды_автомобилейBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.виды_автомобилейBindingNavigatorSaveItem});
            this.виды_автомобилейBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.виды_автомобилейBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.виды_автомобилейBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.виды_автомобилейBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.виды_автомобилейBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.виды_автомобилейBindingNavigator.Name = "виды_автомобилейBindingNavigator";
            this.виды_автомобилейBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.виды_автомобилейBindingNavigator.Size = new System.Drawing.Size(552, 25);
            this.виды_автомобилейBindingNavigator.TabIndex = 0;
            this.виды_автомобилейBindingNavigator.Text = "bindingNavigator1";
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
            // кОД_ВИДА_АВТОМОБИЛЯLabel
            // 
            кОД_ВИДА_АВТОМОБИЛЯLabel.AutoSize = true;
            кОД_ВИДА_АВТОМОБИЛЯLabel.Location = new System.Drawing.Point(71, 114);
            кОД_ВИДА_АВТОМОБИЛЯLabel.Name = "кОД_ВИДА_АВТОМОБИЛЯLabel";
            кОД_ВИДА_АВТОМОБИЛЯLabel.Size = new System.Drawing.Size(148, 13);
            кОД_ВИДА_АВТОМОБИЛЯLabel.TabIndex = 1;
            кОД_ВИДА_АВТОМОБИЛЯLabel.Text = "КОД ВИДА АВТОМОБИЛЯ:";
            // 
            // кОД_ВИДА_АВТОМОБИЛЯTextBox
            // 
            this.кОД_ВИДА_АВТОМОБИЛЯTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_автомобилейBindingSource, "КОД_ВИДА_АВТОМОБИЛЯ", true));
            this.кОД_ВИДА_АВТОМОБИЛЯTextBox.Location = new System.Drawing.Point(225, 111);
            this.кОД_ВИДА_АВТОМОБИЛЯTextBox.Name = "кОД_ВИДА_АВТОМОБИЛЯTextBox";
            this.кОД_ВИДА_АВТОМОБИЛЯTextBox.Size = new System.Drawing.Size(100, 20);
            this.кОД_ВИДА_АВТОМОБИЛЯTextBox.TabIndex = 2;
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
            // виды_автомобилейBindingNavigatorSaveItem
            // 
            this.виды_автомобилейBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.виды_автомобилейBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("виды_автомобилейBindingNavigatorSaveItem.Image")));
            this.виды_автомобилейBindingNavigatorSaveItem.Name = "виды_автомобилейBindingNavigatorSaveItem";
            this.виды_автомобилейBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.виды_автомобилейBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.виды_автомобилейBindingNavigatorSaveItem.Click += new System.EventHandler(this.виды_автомобилейBindingNavigatorSaveItem_Click);
            // 
            // нАИМЕНОВАНИЕLabel
            // 
            нАИМЕНОВАНИЕLabel.AutoSize = true;
            нАИМЕНОВАНИЕLabel.Location = new System.Drawing.Point(116, 140);
            нАИМЕНОВАНИЕLabel.Name = "нАИМЕНОВАНИЕLabel";
            нАИМЕНОВАНИЕLabel.Size = new System.Drawing.Size(102, 13);
            нАИМЕНОВАНИЕLabel.TabIndex = 3;
            нАИМЕНОВАНИЕLabel.Text = "НАИМЕНОВАНИЕ:";
            // 
            // нАИМЕНОВАНИЕTextBox
            // 
            this.нАИМЕНОВАНИЕTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_автомобилейBindingSource, "НАИМЕНОВАНИЕ", true));
            this.нАИМЕНОВАНИЕTextBox.Location = new System.Drawing.Point(224, 137);
            this.нАИМЕНОВАНИЕTextBox.Name = "нАИМЕНОВАНИЕTextBox";
            this.нАИМЕНОВАНИЕTextBox.Size = new System.Drawing.Size(100, 20);
            this.нАИМЕНОВАНИЕTextBox.TabIndex = 4;
            // 
            // оПИСАНИЕLabel
            // 
            оПИСАНИЕLabel.AutoSize = true;
            оПИСАНИЕLabel.Location = new System.Drawing.Point(147, 166);
            оПИСАНИЕLabel.Name = "оПИСАНИЕLabel";
            оПИСАНИЕLabel.Size = new System.Drawing.Size(71, 13);
            оПИСАНИЕLabel.TabIndex = 5;
            оПИСАНИЕLabel.Text = "ОПИСАНИЕ:";
            // 
            // оПИСАНИЕTextBox
            // 
            this.оПИСАНИЕTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виды_автомобилейBindingSource, "ОПИСАНИЕ", true));
            this.оПИСАНИЕTextBox.Location = new System.Drawing.Point(224, 163);
            this.оПИСАНИЕTextBox.Name = "оПИСАНИЕTextBox";
            this.оПИСАНИЕTextBox.Size = new System.Drawing.Size(100, 20);
            this.оПИСАНИЕTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(30, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ленточная форма таблицы \"Виды автомобилей\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(224, 290);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 40);
            this.button7.TabIndex = 35;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(331, 244);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 40);
            this.button6.TabIndex = 34;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 244);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 40);
            this.button5.TabIndex = 33;
            this.button5.Text = "Следующая запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(118, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 40);
            this.button4.TabIndex = 32;
            this.button4.Text = "Последняя запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 31;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Предыдущая запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Первая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VAlent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 374);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(оПИСАНИЕLabel);
            this.Controls.Add(this.оПИСАНИЕTextBox);
            this.Controls.Add(нАИМЕНОВАНИЕLabel);
            this.Controls.Add(this.нАИМЕНОВАНИЕTextBox);
            this.Controls.Add(кОД_ВИДА_АВТОМОБИЛЯLabel);
            this.Controls.Add(this.кОД_ВИДА_АВТОМОБИЛЯTextBox);
            this.Controls.Add(this.виды_автомобилейBindingNavigator);
            this.Name = "VAlent";
            this.Text = "VAlent";
            this.Load += new System.EventHandler(this.VAlent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_автомобилейBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виды_автомобилейBindingNavigator)).EndInit();
            this.виды_автомобилейBindingNavigator.ResumeLayout(false);
            this.виды_автомобилейBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TransportDataSet transportDataSet;
        private System.Windows.Forms.BindingSource виды_автомобилейBindingSource;
        private TransportDataSetTableAdapters.Виды_автомобилейTableAdapter виды_автомобилейTableAdapter;
        private TransportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator виды_автомобилейBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton виды_автомобилейBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox кОД_ВИДА_АВТОМОБИЛЯTextBox;
        private System.Windows.Forms.TextBox нАИМЕНОВАНИЕTextBox;
        private System.Windows.Forms.TextBox оПИСАНИЕTextBox;
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