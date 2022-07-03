namespace Examen11042022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userslistView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.surnameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.activeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.inUsecolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.skillsTabControl = new System.Windows.Forms.TabControl();
            this.Customer = new System.Windows.Forms.TabPage();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.feelabel = new System.Windows.Forms.Label();
            this.unsubscribeTextBox = new System.Windows.Forms.TextBox();
            this.subscribeDateTextBox = new System.Windows.Forms.TextBox();
            this.unsubscribeLabel = new System.Windows.Forms.Label();
            this.subscribeDateLabel = new System.Windows.Forms.Label();
            this.Trainer = new System.Windows.Forms.TabPage();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.contractStartDateTextBox = new System.Windows.Forms.TextBox();
            this.contractStartDateLabel = new System.Windows.Forms.Label();
            this.contractEndDateTextBox = new System.Windows.Forms.TextBox();
            this.contractEndDateLabel = new System.Windows.Forms.Label();
            this.sportsLabel = new System.Windows.Forms.Label();
            this.sportsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Assistant = new System.Windows.Forms.TabPage();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.baseSalarytextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.contractStartDatePersonaTextBox = new System.Windows.Forms.TextBox();
            this.contractStartDatePersonalLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.inUseCheckBox = new System.Windows.Forms.CheckBox();
            this.skillsTabControl.SuspendLayout();
            this.Customer.SuspendLayout();
            this.Trainer.SuspendLayout();
            this.Assistant.SuspendLayout();
            this.SuspendLayout();
            // 
            // userslistView
            // 
            this.userslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.surnameColumnHeader,
            this.activeColumnHeader,
            this.inUsecolumnHeader});
            this.userslistView.HideSelection = false;
            this.userslistView.Location = new System.Drawing.Point(6, 73);
            this.userslistView.Margin = new System.Windows.Forms.Padding(2);
            this.userslistView.MultiSelect = false;
            this.userslistView.Name = "userslistView";
            this.userslistView.Size = new System.Drawing.Size(328, 350);
            this.userslistView.TabIndex = 1;
            this.userslistView.UseCompatibleStateImageBehavior = false;
            this.userslistView.View = System.Windows.Forms.View.Details;
            this.userslistView.SelectedIndexChanged += new System.EventHandler(this.userslistView_SelectedIndexChanged);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Nombre";
            this.nameColumnHeader.Width = 100;
            // 
            // surnameColumnHeader
            // 
            this.surnameColumnHeader.Text = "Apellidos";
            this.surnameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameColumnHeader.Width = 120;
            // 
            // activeColumnHeader
            // 
            this.activeColumnHeader.Text = "Activo";
            this.activeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activeColumnHeader.Width = 80;
            // 
            // inUsecolumnHeader
            // 
            this.inUsecolumnHeader.Text = "En las instalciones";
            this.inUsecolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inUsecolumnHeader.Width = 160;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(116, 32);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(131, 28);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Lista Usuarios";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subTitleLabel.Location = new System.Drawing.Point(430, 32);
            this.subTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(129, 28);
            this.subTitleLabel.TabIndex = 3;
            this.subTitleLabel.Text = "Ficha Usuario";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(356, 74);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(17, 15);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(379, 73);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(54, 23);
            this.idTextBox.TabIndex = 4;
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(345, 106);
            this.dniLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(27, 15);
            this.dniLabel.TabIndex = 7;
            this.dniLabel.Text = "DNI";
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(379, 102);
            this.dniTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(54, 23);
            this.dniTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(443, 73);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 15);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Nombre";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(508, 73);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(185, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(443, 104);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 15);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Apellidos";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(508, 104);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(185, 23);
            this.surnameTextBox.TabIndex = 10;
            // 
            // skillsTabControl
            // 
            this.skillsTabControl.Controls.Add(this.Customer);
            this.skillsTabControl.Controls.Add(this.Trainer);
            this.skillsTabControl.Controls.Add(this.Assistant);
            this.skillsTabControl.Location = new System.Drawing.Point(345, 142);
            this.skillsTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.skillsTabControl.Name = "skillsTabControl";
            this.skillsTabControl.SelectedIndex = 0;
            this.skillsTabControl.Size = new System.Drawing.Size(346, 245);
            this.skillsTabControl.TabIndex = 12;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.feeTextBox);
            this.Customer.Controls.Add(this.feelabel);
            this.Customer.Controls.Add(this.unsubscribeTextBox);
            this.Customer.Controls.Add(this.subscribeDateTextBox);
            this.Customer.Controls.Add(this.unsubscribeLabel);
            this.Customer.Controls.Add(this.subscribeDateLabel);
            this.Customer.Location = new System.Drawing.Point(4, 24);
            this.Customer.Margin = new System.Windows.Forms.Padding(2);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(2);
            this.Customer.Size = new System.Drawing.Size(338, 217);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Cliente";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(134, 140);
            this.feeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(106, 23);
            this.feeTextBox.TabIndex = 5;
            // 
            // feelabel
            // 
            this.feelabel.AutoSize = true;
            this.feelabel.Location = new System.Drawing.Point(32, 144);
            this.feelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feelabel.Name = "feelabel";
            this.feelabel.Size = new System.Drawing.Size(35, 15);
            this.feelabel.TabIndex = 4;
            this.feelabel.Text = "Tarifa";
            // 
            // unsubscribeTextBox
            // 
            this.unsubscribeTextBox.Location = new System.Drawing.Point(134, 98);
            this.unsubscribeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.unsubscribeTextBox.Name = "unsubscribeTextBox";
            this.unsubscribeTextBox.Size = new System.Drawing.Size(167, 23);
            this.unsubscribeTextBox.TabIndex = 3;
            // 
            // subscribeDateTextBox
            // 
            this.subscribeDateTextBox.Location = new System.Drawing.Point(134, 51);
            this.subscribeDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.subscribeDateTextBox.Name = "subscribeDateTextBox";
            this.subscribeDateTextBox.Size = new System.Drawing.Size(167, 23);
            this.subscribeDateTextBox.TabIndex = 2;
            // 
            // unsubscribeLabel
            // 
            this.unsubscribeLabel.AutoSize = true;
            this.unsubscribeLabel.Location = new System.Drawing.Point(32, 98);
            this.unsubscribeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unsubscribeLabel.Name = "unsubscribeLabel";
            this.unsubscribeLabel.Size = new System.Drawing.Size(79, 15);
            this.unsubscribeLabel.TabIndex = 1;
            this.unsubscribeLabel.Text = "Fecha de baja";
            // 
            // subscribeDateLabel
            // 
            this.subscribeDateLabel.AutoSize = true;
            this.subscribeDateLabel.Location = new System.Drawing.Point(32, 51);
            this.subscribeDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subscribeDateLabel.Name = "subscribeDateLabel";
            this.subscribeDateLabel.Size = new System.Drawing.Size(78, 15);
            this.subscribeDateLabel.TabIndex = 0;
            this.subscribeDateLabel.Text = "Fecha de Alta";
            // 
            // Trainer
            // 
            this.Trainer.Controls.Add(this.SalaryTextBox);
            this.Trainer.Controls.Add(this.SalaryLabel);
            this.Trainer.Controls.Add(this.contractStartDateTextBox);
            this.Trainer.Controls.Add(this.contractStartDateLabel);
            this.Trainer.Controls.Add(this.contractEndDateTextBox);
            this.Trainer.Controls.Add(this.contractEndDateLabel);
            this.Trainer.Controls.Add(this.sportsLabel);
            this.Trainer.Controls.Add(this.sportsCheckedListBox);
            this.Trainer.Location = new System.Drawing.Point(4, 24);
            this.Trainer.Margin = new System.Windows.Forms.Padding(2);
            this.Trainer.Name = "Trainer";
            this.Trainer.Padding = new System.Windows.Forms.Padding(2);
            this.Trainer.Size = new System.Drawing.Size(338, 217);
            this.Trainer.TabIndex = 1;
            this.Trainer.Text = "Entrenador";
            this.Trainer.UseVisualStyleBackColor = true;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(160, 191);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(164, 23);
            this.SalaryTextBox.TabIndex = 7;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(24, 195);
            this.SalaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(88, 15);
            this.SalaryLabel.TabIndex = 6;
            this.SalaryLabel.Text = "Precio por hora";
            // 
            // contractStartDateTextBox
            // 
            this.contractStartDateTextBox.Location = new System.Drawing.Point(160, 121);
            this.contractStartDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractStartDateTextBox.Name = "contractStartDateTextBox";
            this.contractStartDateTextBox.Size = new System.Drawing.Size(164, 23);
            this.contractStartDateTextBox.TabIndex = 5;
            // 
            // contractStartDateLabel
            // 
            this.contractStartDateLabel.AutoSize = true;
            this.contractStartDateLabel.Location = new System.Drawing.Point(24, 121);
            this.contractStartDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractStartDateLabel.Name = "contractStartDateLabel";
            this.contractStartDateLabel.Size = new System.Drawing.Size(124, 15);
            this.contractStartDateLabel.TabIndex = 4;
            this.contractStartDateLabel.Text = "Fecha de contratación";
            // 
            // contractEndDateTextBox
            // 
            this.contractEndDateTextBox.Location = new System.Drawing.Point(160, 157);
            this.contractEndDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractEndDateTextBox.Name = "contractEndDateTextBox";
            this.contractEndDateTextBox.Size = new System.Drawing.Size(164, 23);
            this.contractEndDateTextBox.TabIndex = 3;
            // 
            // contractEndDateLabel
            // 
            this.contractEndDateLabel.AutoSize = true;
            this.contractEndDateLabel.Location = new System.Drawing.Point(24, 161);
            this.contractEndDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractEndDateLabel.Name = "contractEndDateLabel";
            this.contractEndDateLabel.Size = new System.Drawing.Size(109, 15);
            this.contractEndDateLabel.TabIndex = 2;
            this.contractEndDateLabel.Text = "Fin de contratación";
            // 
            // sportsLabel
            // 
            this.sportsLabel.AutoSize = true;
            this.sportsLabel.Location = new System.Drawing.Point(24, 30);
            this.sportsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sportsLabel.Name = "sportsLabel";
            this.sportsLabel.Size = new System.Drawing.Size(109, 30);
            this.sportsLabel.TabIndex = 1;
            this.sportsLabel.Text = "Entrenamientos del\nque es monitor";
            // 
            // sportsCheckedListBox
            // 
            this.sportsCheckedListBox.FormattingEnabled = true;
            this.sportsCheckedListBox.Items.AddRange(new object[] {
            "Entrenador personal",
            "CrossFit",
            "Musculacion",
            "Boxeo",
            "Lucha personal",
            "Judo",
            "Lucha Olimpica",
            "Natación",
            "Velocidad",
            "Salto",
            "Mantenimeinto",
            "Ponerse en forma",
            "Salud",
            "Recuperación"});
            this.sportsCheckedListBox.Location = new System.Drawing.Point(160, 22);
            this.sportsCheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.sportsCheckedListBox.Name = "sportsCheckedListBox";
            this.sportsCheckedListBox.Size = new System.Drawing.Size(164, 76);
            this.sportsCheckedListBox.TabIndex = 0;
            // 
            // Assistant
            // 
            this.Assistant.Controls.Add(this.roundLabel);
            this.Assistant.Controls.Add(this.roundComboBox);
            this.Assistant.Controls.Add(this.baseSalarytextBox);
            this.Assistant.Controls.Add(this.baseSalaryLabel);
            this.Assistant.Controls.Add(this.functionTextBox);
            this.Assistant.Controls.Add(this.functionLabel);
            this.Assistant.Controls.Add(this.contractStartDatePersonaTextBox);
            this.Assistant.Controls.Add(this.contractStartDatePersonalLabel);
            this.Assistant.Location = new System.Drawing.Point(4, 24);
            this.Assistant.Margin = new System.Windows.Forms.Padding(2);
            this.Assistant.Name = "Assistant";
            this.Assistant.Padding = new System.Windows.Forms.Padding(2);
            this.Assistant.Size = new System.Drawing.Size(338, 217);
            this.Assistant.TabIndex = 2;
            this.Assistant.Text = "Otro Personal";
            this.Assistant.UseVisualStyleBackColor = true;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(32, 170);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(67, 15);
            this.roundLabel.TabIndex = 7;
            this.roundLabel.Text = "roundLabel";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Items.AddRange(new object[] {
            "Mañana",
            "Medio dia",
            "Tarde",
            "Noche"});
            this.roundComboBox.Location = new System.Drawing.Point(174, 166);
            this.roundComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(129, 23);
            this.roundComboBox.TabIndex = 6;
            // 
            // baseSalarytextBox
            // 
            this.baseSalarytextBox.Location = new System.Drawing.Point(174, 124);
            this.baseSalarytextBox.Margin = new System.Windows.Forms.Padding(2);
            this.baseSalarytextBox.Name = "baseSalarytextBox";
            this.baseSalarytextBox.Size = new System.Drawing.Size(129, 23);
            this.baseSalarytextBox.TabIndex = 5;
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Location = new System.Drawing.Point(32, 128);
            this.baseSalaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(42, 15);
            this.baseSalaryLabel.TabIndex = 4;
            this.baseSalaryLabel.Text = "Salario";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(174, 74);
            this.functionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(129, 23);
            this.functionTextBox.TabIndex = 3;
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(32, 77);
            this.functionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(45, 15);
            this.functionLabel.TabIndex = 2;
            this.functionLabel.Text = "Trabajo";
            // 
            // contractStartDatePersonaTextBox
            // 
            this.contractStartDatePersonaTextBox.Location = new System.Drawing.Point(174, 30);
            this.contractStartDatePersonaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.contractStartDatePersonaTextBox.Name = "contractStartDatePersonaTextBox";
            this.contractStartDatePersonaTextBox.Size = new System.Drawing.Size(129, 23);
            this.contractStartDatePersonaTextBox.TabIndex = 1;
            // 
            // contractStartDatePersonalLabel
            // 
            this.contractStartDatePersonalLabel.AutoSize = true;
            this.contractStartDatePersonalLabel.Location = new System.Drawing.Point(32, 34);
            this.contractStartDatePersonalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contractStartDatePersonalLabel.Name = "contractStartDatePersonalLabel";
            this.contractStartDatePersonalLabel.Size = new System.Drawing.Size(124, 15);
            this.contractStartDatePersonalLabel.TabIndex = 0;
            this.contractStartDatePersonalLabel.Text = "Fecha de contratación";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(511, 400);
            this.newButton.Margin = new System.Windows.Forms.Padding(2);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(78, 20);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(610, 400);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(78, 20);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(345, 390);
            this.activeCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(92, 19);
            this.activeCheckBox.TabIndex = 15;
            this.activeCheckBox.Text = "¿Está activo?";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // inUseCheckBox
            // 
            this.inUseCheckBox.AutoSize = true;
            this.inUseCheckBox.Location = new System.Drawing.Point(345, 411);
            this.inUseCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.inUseCheckBox.Name = "inUseCheckBox";
            this.inUseCheckBox.Size = new System.Drawing.Size(121, 19);
            this.inUseCheckBox.TabIndex = 16;
            this.inUseCheckBox.Text = "En las instalciones";
            this.inUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 461);
            this.Controls.Add(this.inUseCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.skillsTabControl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.userslistView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "GymStayInHome";
            this.skillsTabControl.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.Trainer.ResumeLayout(false);
            this.Trainer.PerformLayout();
            this.Assistant.ResumeLayout(false);
            this.Assistant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView userslistView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabControl skillsTabControl;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage Trainer;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage Assistant;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader surnameColumnHeader;
        private System.Windows.Forms.ColumnHeader activeColumnHeader;
        private System.Windows.Forms.ColumnHeader inUsecolumnHeader;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.CheckBox inUseCheckBox;
        private System.Windows.Forms.TextBox unsubscribeTextBox;
        private System.Windows.Forms.TextBox subscribeDateTextBox;
        private System.Windows.Forms.Label unsubscribeLabel;
        private System.Windows.Forms.Label subscribeDateLabel;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.Label feelabel;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox contractStartDateTextBox;
        private System.Windows.Forms.Label contractStartDateLabel;
        private System.Windows.Forms.TextBox contractEndDateTextBox;
        private System.Windows.Forms.Label contractEndDateLabel;
        private System.Windows.Forms.Label sportsLabel;
        private System.Windows.Forms.CheckedListBox sportsCheckedListBox;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.TextBox baseSalarytextBox;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox contractStartDatePersonaTextBox;
        private System.Windows.Forms.Label contractStartDatePersonalLabel;
    }
}
