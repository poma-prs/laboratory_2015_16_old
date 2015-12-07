namespace Terminal
{
    partial class TerminalForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.OperatorSelectionTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.MegaphoneRadioButton = new System.Windows.Forms.RadioButton();
            this.BeelineRadioButton = new System.Windows.Forms.RadioButton();
            this.MTSRadioButton = new System.Windows.Forms.RadioButton();
            this.ButtonNext1 = new System.Windows.Forms.Button();
            this.PhoneNumberInputingTabPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonBack1 = new System.Windows.Forms.Button();
            this.PhoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ButtonNext2 = new System.Windows.Forms.Button();
            this.MoneyInsertingTabPage = new System.Windows.Forms.TabPage();
            this.Button5000Rubles = new System.Windows.Forms.Button();
            this.Button1000Rubles = new System.Windows.Forms.Button();
            this.Button500Rubles = new System.Windows.Forms.Button();
            this.Button100Rubles = new System.Windows.Forms.Button();
            this.Button50Rubles = new System.Windows.Forms.Button();
            this.Button10Rubles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCancel1 = new System.Windows.Forms.Button();
            this.InsertedMoneyTextBox = new System.Windows.Forms.TextBox();
            this.ButtonNext3 = new System.Windows.Forms.Button();
            this.TransactionCommitingTabPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.InsertedMoneyLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ButtonCancel2 = new System.Windows.Forms.Button();
            this.ButtonBack2 = new System.Windows.Forms.Button();
            this.ButtonCommitTransaction = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.OperatorSelectionTabPage.SuspendLayout();
            this.PhoneNumberInputingTabPage.SuspendLayout();
            this.MoneyInsertingTabPage.SuspendLayout();
            this.TransactionCommitingTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.OperatorSelectionTabPage);
            this.tabControl.Controls.Add(this.PhoneNumberInputingTabPage);
            this.tabControl.Controls.Add(this.MoneyInsertingTabPage);
            this.tabControl.Controls.Add(this.TransactionCommitingTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(464, 289);
            this.tabControl.TabIndex = 0;
            // 
            // OperatorSelectionTabPage
            // 
            this.OperatorSelectionTabPage.Controls.Add(this.label6);
            this.OperatorSelectionTabPage.Controls.Add(this.MegaphoneRadioButton);
            this.OperatorSelectionTabPage.Controls.Add(this.BeelineRadioButton);
            this.OperatorSelectionTabPage.Controls.Add(this.MTSRadioButton);
            this.OperatorSelectionTabPage.Controls.Add(this.ButtonNext1);
            this.OperatorSelectionTabPage.Location = new System.Drawing.Point(4, 22);
            this.OperatorSelectionTabPage.Name = "OperatorSelectionTabPage";
            this.OperatorSelectionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OperatorSelectionTabPage.Size = new System.Drawing.Size(456, 263);
            this.OperatorSelectionTabPage.TabIndex = 0;
            this.OperatorSelectionTabPage.Text = "Выбор оператора";
            this.OperatorSelectionTabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Выберите оператора сотовой связи";
            // 
            // MegaphoneRadioButton
            // 
            this.MegaphoneRadioButton.AutoSize = true;
            this.MegaphoneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MegaphoneRadioButton.Location = new System.Drawing.Point(12, 105);
            this.MegaphoneRadioButton.Name = "MegaphoneRadioButton";
            this.MegaphoneRadioButton.Size = new System.Drawing.Size(121, 29);
            this.MegaphoneRadioButton.TabIndex = 3;
            this.MegaphoneRadioButton.TabStop = true;
            this.MegaphoneRadioButton.Text = "Мегафон";
            this.MegaphoneRadioButton.UseVisualStyleBackColor = true;
            this.MegaphoneRadioButton.CheckedChanged += new System.EventHandler(this.MegaphoneRadioButton_CheckedChanged);
            // 
            // BeelineRadioButton
            // 
            this.BeelineRadioButton.AutoSize = true;
            this.BeelineRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeelineRadioButton.Location = new System.Drawing.Point(12, 70);
            this.BeelineRadioButton.Name = "BeelineRadioButton";
            this.BeelineRadioButton.Size = new System.Drawing.Size(104, 29);
            this.BeelineRadioButton.TabIndex = 2;
            this.BeelineRadioButton.TabStop = true;
            this.BeelineRadioButton.Text = "Билайн";
            this.BeelineRadioButton.UseVisualStyleBackColor = true;
            this.BeelineRadioButton.CheckedChanged += new System.EventHandler(this.BeelineRadioButton_CheckedChanged);
            // 
            // MTSRadioButton
            // 
            this.MTSRadioButton.AutoSize = true;
            this.MTSRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MTSRadioButton.Location = new System.Drawing.Point(12, 35);
            this.MTSRadioButton.Name = "MTSRadioButton";
            this.MTSRadioButton.Size = new System.Drawing.Size(76, 29);
            this.MTSRadioButton.TabIndex = 1;
            this.MTSRadioButton.TabStop = true;
            this.MTSRadioButton.Text = "МТС";
            this.MTSRadioButton.UseVisualStyleBackColor = true;
            this.MTSRadioButton.CheckedChanged += new System.EventHandler(this.MTSRadioButton_CheckedChanged);
            // 
            // ButtonNext1
            // 
            this.ButtonNext1.Enabled = false;
            this.ButtonNext1.Location = new System.Drawing.Point(373, 232);
            this.ButtonNext1.Name = "ButtonNext1";
            this.ButtonNext1.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext1.TabIndex = 0;
            this.ButtonNext1.Text = "Далее";
            this.ButtonNext1.UseVisualStyleBackColor = true;
            this.ButtonNext1.Click += new System.EventHandler(this.ButtonNext1_Click);
            // 
            // PhoneNumberInputingTabPage
            // 
            this.PhoneNumberInputingTabPage.Controls.Add(this.label5);
            this.PhoneNumberInputingTabPage.Controls.Add(this.ButtonBack1);
            this.PhoneNumberInputingTabPage.Controls.Add(this.PhoneNumberMaskedTextBox);
            this.PhoneNumberInputingTabPage.Controls.Add(this.ButtonNext2);
            this.PhoneNumberInputingTabPage.Location = new System.Drawing.Point(4, 22);
            this.PhoneNumberInputingTabPage.Name = "PhoneNumberInputingTabPage";
            this.PhoneNumberInputingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PhoneNumberInputingTabPage.Size = new System.Drawing.Size(456, 263);
            this.PhoneNumberInputingTabPage.TabIndex = 1;
            this.PhoneNumberInputingTabPage.Text = "Ввод номера телефона";
            this.PhoneNumberInputingTabPage.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Введите номер мобильного телефона";
            // 
            // ButtonBack1
            // 
            this.ButtonBack1.Location = new System.Drawing.Point(292, 232);
            this.ButtonBack1.Name = "ButtonBack1";
            this.ButtonBack1.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack1.TabIndex = 2;
            this.ButtonBack1.Text = "Назад";
            this.ButtonBack1.UseVisualStyleBackColor = true;
            this.ButtonBack1.Click += new System.EventHandler(this.ButtonBack1_Click);
            // 
            // PhoneNumberMaskedTextBox
            // 
            this.PhoneNumberMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberMaskedTextBox.Location = new System.Drawing.Point(12, 35);
            this.PhoneNumberMaskedTextBox.Mask = "+7 (999) 000-0000";
            this.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox";
            this.PhoneNumberMaskedTextBox.Size = new System.Drawing.Size(186, 31);
            this.PhoneNumberMaskedTextBox.TabIndex = 1;
            // 
            // ButtonNext2
            // 
            this.ButtonNext2.Enabled = false;
            this.ButtonNext2.Location = new System.Drawing.Point(373, 232);
            this.ButtonNext2.Name = "ButtonNext2";
            this.ButtonNext2.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext2.TabIndex = 0;
            this.ButtonNext2.Text = "Далее";
            this.ButtonNext2.UseVisualStyleBackColor = true;
            this.ButtonNext2.Click += new System.EventHandler(this.ButtonNext2_Click);
            // 
            // MoneyInsertingTabPage
            // 
            this.MoneyInsertingTabPage.Controls.Add(this.Button5000Rubles);
            this.MoneyInsertingTabPage.Controls.Add(this.Button1000Rubles);
            this.MoneyInsertingTabPage.Controls.Add(this.Button500Rubles);
            this.MoneyInsertingTabPage.Controls.Add(this.Button100Rubles);
            this.MoneyInsertingTabPage.Controls.Add(this.Button50Rubles);
            this.MoneyInsertingTabPage.Controls.Add(this.Button10Rubles);
            this.MoneyInsertingTabPage.Controls.Add(this.label4);
            this.MoneyInsertingTabPage.Controls.Add(this.label3);
            this.MoneyInsertingTabPage.Controls.Add(this.label2);
            this.MoneyInsertingTabPage.Controls.Add(this.label1);
            this.MoneyInsertingTabPage.Controls.Add(this.ButtonCancel1);
            this.MoneyInsertingTabPage.Controls.Add(this.InsertedMoneyTextBox);
            this.MoneyInsertingTabPage.Controls.Add(this.ButtonNext3);
            this.MoneyInsertingTabPage.Location = new System.Drawing.Point(4, 22);
            this.MoneyInsertingTabPage.Name = "MoneyInsertingTabPage";
            this.MoneyInsertingTabPage.Size = new System.Drawing.Size(456, 263);
            this.MoneyInsertingTabPage.TabIndex = 2;
            this.MoneyInsertingTabPage.Text = "Прием наличных";
            this.MoneyInsertingTabPage.UseVisualStyleBackColor = true;
            // 
            // Button5000Rubles
            // 
            this.Button5000Rubles.Location = new System.Drawing.Point(178, 173);
            this.Button5000Rubles.Name = "Button5000Rubles";
            this.Button5000Rubles.Size = new System.Drawing.Size(77, 23);
            this.Button5000Rubles.TabIndex = 12;
            this.Button5000Rubles.Text = "5000 рублей";
            this.Button5000Rubles.UseVisualStyleBackColor = true;
            // 
            // Button1000Rubles
            // 
            this.Button1000Rubles.Location = new System.Drawing.Point(178, 144);
            this.Button1000Rubles.Name = "Button1000Rubles";
            this.Button1000Rubles.Size = new System.Drawing.Size(77, 23);
            this.Button1000Rubles.TabIndex = 11;
            this.Button1000Rubles.Text = "1000 рублей";
            this.Button1000Rubles.UseVisualStyleBackColor = true;
            // 
            // Button500Rubles
            // 
            this.Button500Rubles.Location = new System.Drawing.Point(95, 173);
            this.Button500Rubles.Name = "Button500Rubles";
            this.Button500Rubles.Size = new System.Drawing.Size(77, 23);
            this.Button500Rubles.TabIndex = 10;
            this.Button500Rubles.Text = "500 рублей";
            this.Button500Rubles.UseVisualStyleBackColor = true;
            // 
            // Button100Rubles
            // 
            this.Button100Rubles.Location = new System.Drawing.Point(95, 144);
            this.Button100Rubles.Name = "Button100Rubles";
            this.Button100Rubles.Size = new System.Drawing.Size(77, 23);
            this.Button100Rubles.TabIndex = 9;
            this.Button100Rubles.Text = "100 рублей";
            this.Button100Rubles.UseVisualStyleBackColor = true;
            // 
            // Button50Rubles
            // 
            this.Button50Rubles.Location = new System.Drawing.Point(13, 173);
            this.Button50Rubles.Name = "Button50Rubles";
            this.Button50Rubles.Size = new System.Drawing.Size(77, 23);
            this.Button50Rubles.TabIndex = 8;
            this.Button50Rubles.Text = "50 рублей";
            this.Button50Rubles.UseVisualStyleBackColor = true;
            // 
            // Button10Rubles
            // 
            this.Button10Rubles.Location = new System.Drawing.Point(12, 144);
            this.Button10Rubles.Name = "Button10Rubles";
            this.Button10Rubles.Size = new System.Drawing.Size(77, 23);
            this.Button10Rubles.TabIndex = 7;
            this.Button10Rubles.Text = "10 рублей";
            this.Button10Rubles.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(271, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "рублей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Минимальная сумма пополнения - 50 рублей";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Вставьте купюры в купюроприемник";
            // 
            // ButtonCancel1
            // 
            this.ButtonCancel1.Location = new System.Drawing.Point(292, 232);
            this.ButtonCancel1.Name = "ButtonCancel1";
            this.ButtonCancel1.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel1.TabIndex = 2;
            this.ButtonCancel1.Text = "Отмена";
            this.ButtonCancel1.UseVisualStyleBackColor = true;
            // 
            // InsertedMoneyTextBox
            // 
            this.InsertedMoneyTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.InsertedMoneyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertedMoneyTextBox.Location = new System.Drawing.Point(104, 89);
            this.InsertedMoneyTextBox.Name = "InsertedMoneyTextBox";
            this.InsertedMoneyTextBox.ReadOnly = true;
            this.InsertedMoneyTextBox.Size = new System.Drawing.Size(161, 31);
            this.InsertedMoneyTextBox.TabIndex = 1;
            this.InsertedMoneyTextBox.Text = "0";
            this.InsertedMoneyTextBox.TextChanged += new System.EventHandler(this.RecievedMoneyTextBox_TextChanged);
            // 
            // ButtonNext3
            // 
            this.ButtonNext3.Enabled = false;
            this.ButtonNext3.Location = new System.Drawing.Point(373, 232);
            this.ButtonNext3.Name = "ButtonNext3";
            this.ButtonNext3.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext3.TabIndex = 0;
            this.ButtonNext3.Text = "Далее";
            this.ButtonNext3.UseVisualStyleBackColor = true;
            this.ButtonNext3.Click += new System.EventHandler(this.ButtonNext3_Click);
            // 
            // TransactionCommitingTabPage
            // 
            this.TransactionCommitingTabPage.Controls.Add(this.label9);
            this.TransactionCommitingTabPage.Controls.Add(this.InsertedMoneyLabel);
            this.TransactionCommitingTabPage.Controls.Add(this.label8);
            this.TransactionCommitingTabPage.Controls.Add(this.PhoneNumberLabel);
            this.TransactionCommitingTabPage.Controls.Add(this.label7);
            this.TransactionCommitingTabPage.Controls.Add(this.ButtonCancel2);
            this.TransactionCommitingTabPage.Controls.Add(this.ButtonBack2);
            this.TransactionCommitingTabPage.Controls.Add(this.ButtonCommitTransaction);
            this.TransactionCommitingTabPage.Location = new System.Drawing.Point(4, 22);
            this.TransactionCommitingTabPage.Name = "TransactionCommitingTabPage";
            this.TransactionCommitingTabPage.Size = new System.Drawing.Size(456, 263);
            this.TransactionCommitingTabPage.TabIndex = 3;
            this.TransactionCommitingTabPage.Text = "Подтверждение оплаты";
            this.TransactionCommitingTabPage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(211, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "рублей";
            // 
            // InsertedMoneyLabel
            // 
            this.InsertedMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertedMoneyLabel.Location = new System.Drawing.Point(105, 57);
            this.InsertedMoneyLabel.Name = "InsertedMoneyLabel";
            this.InsertedMoneyLabel.Size = new System.Drawing.Size(100, 23);
            this.InsertedMoneyLabel.TabIndex = 6;
            this.InsertedMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(9, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "на сумму";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(9, 32);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(186, 24);
            this.PhoneNumberLabel.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Подтверждение пополнения счета";
            // 
            // ButtonCancel2
            // 
            this.ButtonCancel2.Location = new System.Drawing.Point(211, 232);
            this.ButtonCancel2.Name = "ButtonCancel2";
            this.ButtonCancel2.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel2.TabIndex = 2;
            this.ButtonCancel2.Text = "Отмена";
            this.ButtonCancel2.UseVisualStyleBackColor = true;
            // 
            // ButtonBack2
            // 
            this.ButtonBack2.Location = new System.Drawing.Point(292, 232);
            this.ButtonBack2.Name = "ButtonBack2";
            this.ButtonBack2.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack2.TabIndex = 1;
            this.ButtonBack2.Text = "Назад";
            this.ButtonBack2.UseVisualStyleBackColor = true;
            this.ButtonBack2.Click += new System.EventHandler(this.ButtonBack2_Click);
            // 
            // ButtonCommitTransaction
            // 
            this.ButtonCommitTransaction.Location = new System.Drawing.Point(373, 232);
            this.ButtonCommitTransaction.Name = "ButtonCommitTransaction";
            this.ButtonCommitTransaction.Size = new System.Drawing.Size(75, 23);
            this.ButtonCommitTransaction.TabIndex = 0;
            this.ButtonCommitTransaction.Text = "Оплатить";
            this.ButtonCommitTransaction.UseVisualStyleBackColor = true;
            this.ButtonCommitTransaction.Click += new System.EventHandler(this.ButtonCommitTransaction_Click);
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 289);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TerminalForm";
            this.Text = "Терминал оплаты мобильной связи";
            this.tabControl.ResumeLayout(false);
            this.OperatorSelectionTabPage.ResumeLayout(false);
            this.OperatorSelectionTabPage.PerformLayout();
            this.PhoneNumberInputingTabPage.ResumeLayout(false);
            this.PhoneNumberInputingTabPage.PerformLayout();
            this.MoneyInsertingTabPage.ResumeLayout(false);
            this.MoneyInsertingTabPage.PerformLayout();
            this.TransactionCommitingTabPage.ResumeLayout(false);
            this.TransactionCommitingTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage OperatorSelectionTabPage;
        private System.Windows.Forms.TabPage PhoneNumberInputingTabPage;
        private System.Windows.Forms.Button ButtonNext1;
        private System.Windows.Forms.TabPage MoneyInsertingTabPage;
        private System.Windows.Forms.TabPage TransactionCommitingTabPage;
        private System.Windows.Forms.Button ButtonNext2;
        private System.Windows.Forms.Button ButtonNext3;
        private System.Windows.Forms.Button ButtonCommitTransaction;
        private System.Windows.Forms.RadioButton MegaphoneRadioButton;
        private System.Windows.Forms.RadioButton BeelineRadioButton;
        private System.Windows.Forms.RadioButton MTSRadioButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedTextBox;
        private System.Windows.Forms.TextBox InsertedMoneyTextBox;
        private System.Windows.Forms.Button ButtonBack1;
        private System.Windows.Forms.Button ButtonCancel1;
        private System.Windows.Forms.Button ButtonBack2;
        private System.Windows.Forms.Button Button5000Rubles;
        private System.Windows.Forms.Button Button1000Rubles;
        private System.Windows.Forms.Button Button500Rubles;
        private System.Windows.Forms.Button Button100Rubles;
        private System.Windows.Forms.Button Button50Rubles;
        private System.Windows.Forms.Button Button10Rubles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCancel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label InsertedMoneyLabel;
    }
}

