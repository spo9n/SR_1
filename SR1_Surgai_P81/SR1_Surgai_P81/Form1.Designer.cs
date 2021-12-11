
namespace SR1_Surgai_P81
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.yearOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.groupNumberTextBox = new System.Windows.Forms.TextBox();
            this.marksTextBox = new System.Windows.Forms.TextBox();
            this.fullnameLabel = new System.Windows.Forms.Label();
            this.yearOfBirthLabel = new System.Windows.Forms.Label();
            this.groupNumberLabel = new System.Windows.Forms.Label();
            this.marksLabel = new System.Windows.Forms.Label();
            this.taskSolutionButton = new System.Windows.Forms.Button();
            this.fullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfBirthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.physMarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathMarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infMarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chemMarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameColumn,
            this.yearOfBirthColumn,
            this.groupNumberColumn,
            this.physMarkColumn,
            this.mathMarkColumn,
            this.infMarkColumn,
            this.chemMarkColumn,
            this.avgMark});
            this.dataGridView.Location = new System.Drawing.Point(347, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(431, 239);
            this.dataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(117, 236);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(98, 28);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Створити";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(29, 54);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.fullNameTextBox.TabIndex = 2;
            // 
            // yearOfBirthTextBox
            // 
            this.yearOfBirthTextBox.Location = new System.Drawing.Point(29, 103);
            this.yearOfBirthTextBox.Name = "yearOfBirthTextBox";
            this.yearOfBirthTextBox.Size = new System.Drawing.Size(167, 20);
            this.yearOfBirthTextBox.TabIndex = 3;
            // 
            // groupNumberTextBox
            // 
            this.groupNumberTextBox.Location = new System.Drawing.Point(29, 146);
            this.groupNumberTextBox.Name = "groupNumberTextBox";
            this.groupNumberTextBox.Size = new System.Drawing.Size(167, 20);
            this.groupNumberTextBox.TabIndex = 4;
            // 
            // marksTextBox
            // 
            this.marksTextBox.Location = new System.Drawing.Point(29, 194);
            this.marksTextBox.Name = "marksTextBox";
            this.marksTextBox.Size = new System.Drawing.Size(167, 20);
            this.marksTextBox.TabIndex = 5;
            // 
            // fullnameLabel
            // 
            this.fullnameLabel.AutoSize = true;
            this.fullnameLabel.Location = new System.Drawing.Point(29, 35);
            this.fullnameLabel.Name = "fullnameLabel";
            this.fullnameLabel.Size = new System.Drawing.Size(112, 13);
            this.fullnameLabel.TabIndex = 6;
            this.fullnameLabel.Text = "Прізвище та ініціали:";
            // 
            // yearOfBirthLabel
            // 
            this.yearOfBirthLabel.AutoSize = true;
            this.yearOfBirthLabel.Location = new System.Drawing.Point(29, 87);
            this.yearOfBirthLabel.Name = "yearOfBirthLabel";
            this.yearOfBirthLabel.Size = new System.Drawing.Size(90, 13);
            this.yearOfBirthLabel.TabIndex = 7;
            this.yearOfBirthLabel.Text = "Рік народження:";
            // 
            // groupNumberLabel
            // 
            this.groupNumberLabel.AutoSize = true;
            this.groupNumberLabel.Location = new System.Drawing.Point(29, 130);
            this.groupNumberLabel.Name = "groupNumberLabel";
            this.groupNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.groupNumberLabel.TabIndex = 8;
            this.groupNumberLabel.Text = "Номер групи:";
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Location = new System.Drawing.Point(29, 178);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(312, 13);
            this.marksLabel.TabIndex = 9;
            this.marksLabel.Text = "Оцінки (фізики, математика, інформатика, хімія) через кому";
            // 
            // taskSolutionButton
            // 
            this.taskSolutionButton.Location = new System.Drawing.Point(542, 282);
            this.taskSolutionButton.Name = "taskSolutionButton";
            this.taskSolutionButton.Size = new System.Drawing.Size(236, 27);
            this.taskSolutionButton.TabIndex = 11;
            this.taskSolutionButton.Text = "Рішення індивідуального завдання";
            this.taskSolutionButton.UseVisualStyleBackColor = true;
            this.taskSolutionButton.Click += new System.EventHandler(this.taskSolutionButton_Click);
            // 
            // fullNameColumn
            // 
            this.fullNameColumn.HeaderText = "Прізвище та ініціали";
            this.fullNameColumn.Name = "fullNameColumn";
            // 
            // yearOfBirthColumn
            // 
            this.yearOfBirthColumn.HeaderText = "Рік народження";
            this.yearOfBirthColumn.Name = "yearOfBirthColumn";
            // 
            // groupNumberColumn
            // 
            this.groupNumberColumn.HeaderText = "Номер групи";
            this.groupNumberColumn.Name = "groupNumberColumn";
            // 
            // physMarkColumn
            // 
            this.physMarkColumn.HeaderText = "Фізика";
            this.physMarkColumn.Name = "physMarkColumn";
            // 
            // mathMarkColumn
            // 
            this.mathMarkColumn.HeaderText = "Математика";
            this.mathMarkColumn.Name = "mathMarkColumn";
            // 
            // infMarkColumn
            // 
            this.infMarkColumn.HeaderText = "Інформатика";
            this.infMarkColumn.Name = "infMarkColumn";
            // 
            // chemMarkColumn
            // 
            this.chemMarkColumn.HeaderText = "Хімія";
            this.chemMarkColumn.Name = "chemMarkColumn";
            // 
            // avgMark
            // 
            this.avgMark.HeaderText = "Середній бал";
            this.avgMark.Name = "avgMark";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(347, 282);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(114, 27);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Скидання";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.taskSolutionButton);
            this.Controls.Add(this.marksLabel);
            this.Controls.Add(this.groupNumberLabel);
            this.Controls.Add(this.yearOfBirthLabel);
            this.Controls.Add(this.fullnameLabel);
            this.Controls.Add(this.marksTextBox);
            this.Controls.Add(this.groupNumberTextBox);
            this.Controls.Add(this.yearOfBirthTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна, Сургай П-81";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox yearOfBirthTextBox;
        private System.Windows.Forms.TextBox groupNumberTextBox;
        private System.Windows.Forms.TextBox marksTextBox;
        private System.Windows.Forms.Label fullnameLabel;
        private System.Windows.Forms.Label yearOfBirthLabel;
        private System.Windows.Forms.Label groupNumberLabel;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.Button taskSolutionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfBirthColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn physMarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathMarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infMarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chemMarkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgMark;
        private System.Windows.Forms.Button resetButton;
    }
}

