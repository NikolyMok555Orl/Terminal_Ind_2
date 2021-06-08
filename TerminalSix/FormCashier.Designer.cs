﻿
namespace TerminalStore
{
    partial class FormCashier
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
            this.panelCassier = new System.Windows.Forms.Panel();
            this.panelWorkMoney = new System.Windows.Forms.Panel();
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCountAndWight = new System.Windows.Forms.TextBox();
            this.buttonWriteCountAndWight = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.labelFirstPurchase = new System.Windows.Forms.Label();
            this.buttonAdd5000 = new System.Windows.Forms.Button();
            this.buttonHandOverMoney = new System.Windows.Forms.Button();
            this.labelWorkBox = new System.Windows.Forms.Label();
            this.buttonTotal = new System.Windows.Forms.Button();
            this.labelDiscountCard = new System.Windows.Forms.Label();
            this.buttonWriteDiscount = new System.Windows.Forms.Button();
            this.buttonDeleteLast = new System.Windows.Forms.Button();
            this.buttonEndDay = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelThisProduct = new System.Windows.Forms.Label();
            this.panelCassier.SuspendLayout();
            this.panelWorkMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCassier
            // 
            this.panelCassier.Controls.Add(this.labelThisProduct);
            this.panelCassier.Controls.Add(this.buttonDeleteLast);
            this.panelCassier.Controls.Add(this.buttonWriteDiscount);
            this.panelCassier.Controls.Add(this.labelDiscountCard);
            this.panelCassier.Controls.Add(this.buttonTotal);
            this.panelCassier.Controls.Add(this.labelFirstPurchase);
            this.panelCassier.Controls.Add(this.buttonWriteCountAndWight);
            this.panelCassier.Controls.Add(this.textBoxCountAndWight);
            this.panelCassier.Controls.Add(this.label1);
            this.panelCassier.Controls.Add(this.buttonRead);
            this.panelCassier.Controls.Add(this.dataGridViewPurchase);
            this.panelCassier.Location = new System.Drawing.Point(13, 13);
            this.panelCassier.Name = "panelCassier";
            this.panelCassier.Size = new System.Drawing.Size(824, 321);
            this.panelCassier.TabIndex = 0;
            // 
            // panelWorkMoney
            // 
            this.panelWorkMoney.Controls.Add(this.labelWorkBox);
            this.panelWorkMoney.Controls.Add(this.buttonHandOverMoney);
            this.panelWorkMoney.Controls.Add(this.buttonAdd5000);
            this.panelWorkMoney.Location = new System.Drawing.Point(13, 340);
            this.panelWorkMoney.Name = "panelWorkMoney";
            this.panelWorkMoney.Size = new System.Drawing.Size(281, 100);
            this.panelWorkMoney.TabIndex = 1;
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(3, 63);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.Size = new System.Drawing.Size(818, 173);
            this.dataGridViewPurchase.TabIndex = 0;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(4, 29);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(817, 28);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Взять и считать штрих код";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вес/количество";
            // 
            // textBoxCountAndWight
            // 
            this.textBoxCountAndWight.Location = new System.Drawing.Point(95, 271);
            this.textBoxCountAndWight.Name = "textBoxCountAndWight";
            this.textBoxCountAndWight.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountAndWight.TabIndex = 3;
            // 
            // buttonWriteCountAndWight
            // 
            this.buttonWriteCountAndWight.Location = new System.Drawing.Point(203, 269);
            this.buttonWriteCountAndWight.Name = "buttonWriteCountAndWight";
            this.buttonWriteCountAndWight.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteCountAndWight.TabIndex = 4;
            this.buttonWriteCountAndWight.Text = "Ввести";
            this.buttonWriteCountAndWight.UseVisualStyleBackColor = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // labelFirstPurchase
            // 
            this.labelFirstPurchase.AutoSize = true;
            this.labelFirstPurchase.Location = new System.Drawing.Point(6, 10);
            this.labelFirstPurchase.Name = "labelFirstPurchase";
            this.labelFirstPurchase.Size = new System.Drawing.Size(69, 13);
            this.labelFirstPurchase.TabIndex = 5;
            this.labelFirstPurchase.Text = "Лента пуста";
            // 
            // buttonAdd5000
            // 
            this.buttonAdd5000.Location = new System.Drawing.Point(3, 26);
            this.buttonAdd5000.Name = "buttonAdd5000";
            this.buttonAdd5000.Size = new System.Drawing.Size(275, 40);
            this.buttonAdd5000.TabIndex = 0;
            this.buttonAdd5000.Text = "Разместить 5000 рублей";
            this.buttonAdd5000.UseVisualStyleBackColor = true;
            // 
            // buttonHandOverMoney
            // 
            this.buttonHandOverMoney.Location = new System.Drawing.Point(4, 72);
            this.buttonHandOverMoney.Name = "buttonHandOverMoney";
            this.buttonHandOverMoney.Size = new System.Drawing.Size(274, 23);
            this.buttonHandOverMoney.TabIndex = 1;
            this.buttonHandOverMoney.Text = "Сдать кассу";
            this.buttonHandOverMoney.UseVisualStyleBackColor = true;
            // 
            // labelWorkBox
            // 
            this.labelWorkBox.AutoSize = true;
            this.labelWorkBox.Location = new System.Drawing.Point(26, 10);
            this.labelWorkBox.Name = "labelWorkBox";
            this.labelWorkBox.Size = new System.Drawing.Size(155, 13);
            this.labelWorkBox.TabIndex = 2;
            this.labelWorkBox.Text = "Работа с коробкой деньгами";
            // 
            // buttonTotal
            // 
            this.buttonTotal.Location = new System.Drawing.Point(577, 242);
            this.buttonTotal.Name = "buttonTotal";
            this.buttonTotal.Size = new System.Drawing.Size(244, 76);
            this.buttonTotal.TabIndex = 6;
            this.buttonTotal.Text = "Итог";
            this.buttonTotal.UseVisualStyleBackColor = true;
            // 
            // labelDiscountCard
            // 
            this.labelDiscountCard.AutoSize = true;
            this.labelDiscountCard.Location = new System.Drawing.Point(6, 297);
            this.labelDiscountCard.Name = "labelDiscountCard";
            this.labelDiscountCard.Size = new System.Drawing.Size(37, 13);
            this.labelDiscountCard.TabIndex = 7;
            this.labelDiscountCard.Text = "Карта";
            // 
            // buttonWriteDiscount
            // 
            this.buttonWriteDiscount.Location = new System.Drawing.Point(59, 295);
            this.buttonWriteDiscount.Name = "buttonWriteDiscount";
            this.buttonWriteDiscount.Size = new System.Drawing.Size(139, 23);
            this.buttonWriteDiscount.TabIndex = 8;
            this.buttonWriteDiscount.Text = "Считать карту";
            this.buttonWriteDiscount.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteLast
            // 
            this.buttonDeleteLast.Location = new System.Drawing.Point(313, 242);
            this.buttonDeleteLast.Name = "buttonDeleteLast";
            this.buttonDeleteLast.Size = new System.Drawing.Size(258, 23);
            this.buttonDeleteLast.TabIndex = 9;
            this.buttonDeleteLast.Text = "Удалить позицию в чек";
            this.buttonDeleteLast.UseVisualStyleBackColor = true;
            // 
            // buttonEndDay
            // 
            this.buttonEndDay.Location = new System.Drawing.Point(566, 340);
            this.buttonEndDay.Name = "buttonEndDay";
            this.buttonEndDay.Size = new System.Drawing.Size(268, 100);
            this.buttonEndDay.TabIndex = 3;
            this.buttonEndDay.Text = "Закончить день. Отправить данные на сервак";
            this.buttonEndDay.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(300, 340);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(260, 100);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Открыть кассу";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // labelThisProduct
            // 
            this.labelThisProduct.AutoSize = true;
            this.labelThisProduct.Location = new System.Drawing.Point(6, 247);
            this.labelThisProduct.Name = "labelThisProduct";
            this.labelThisProduct.Size = new System.Drawing.Size(84, 13);
            this.labelThisProduct.TabIndex = 10;
            this.labelThisProduct.Text = "Текущий товар";
            // 
            // FormCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 452);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonEndDay);
            this.Controls.Add(this.panelWorkMoney);
            this.Controls.Add(this.panelCassier);
            this.Name = "FormCashier";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCassier.ResumeLayout(false);
            this.panelCassier.PerformLayout();
            this.panelWorkMoney.ResumeLayout(false);
            this.panelWorkMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCassier;
        private System.Windows.Forms.Button buttonDeleteLast;
        private System.Windows.Forms.Button buttonWriteDiscount;
        private System.Windows.Forms.Label labelDiscountCard;
        private System.Windows.Forms.Button buttonTotal;
        private System.Windows.Forms.Label labelFirstPurchase;
        private System.Windows.Forms.Button buttonWriteCountAndWight;
        private System.Windows.Forms.TextBox textBoxCountAndWight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.Panel panelWorkMoney;
        private System.Windows.Forms.Button buttonEndDay;
        private System.Windows.Forms.Label labelWorkBox;
        private System.Windows.Forms.Button buttonHandOverMoney;
        private System.Windows.Forms.Button buttonAdd5000;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelThisProduct;
    }
}

