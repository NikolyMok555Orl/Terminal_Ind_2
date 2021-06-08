
namespace TerminalStore
{
    partial class BuyerForm
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
            this.panelAddPurchase = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteLast = new System.Windows.Forms.Button();
            this.buttonToCassira = new System.Windows.Forms.Button();
            this.dataGridViewPurchasesOnTape = new System.Windows.Forms.DataGridView();
            this.textBoxReceipt = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.buttonShowDiscount = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonGiveMoney = new System.Windows.Forms.Button();
            this.panelAddPurchase.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasesOnTape)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddPurchase
            // 
            this.panelAddPurchase.Controls.Add(this.buttonToCassira);
            this.panelAddPurchase.Controls.Add(this.buttonDeleteLast);
            this.panelAddPurchase.Controls.Add(this.buttonAddProduct);
            this.panelAddPurchase.Controls.Add(this.dataGridViewPurchases);
            this.panelAddPurchase.Controls.Add(this.labelProduct);
            this.panelAddPurchase.Controls.Add(this.comboBoxProduct);
            this.panelAddPurchase.Controls.Add(this.label1);
            this.panelAddPurchase.Location = new System.Drawing.Point(13, 4);
            this.panelAddPurchase.Name = "panelAddPurchase";
            this.panelAddPurchase.Size = new System.Drawing.Size(775, 167);
            this.panelAddPurchase.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonGiveMoney);
            this.panel2.Controls.Add(this.textBoxMoney);
            this.panel2.Controls.Add(this.buttonShowDiscount);
            this.panel2.Controls.Add(this.comboBoxDiscount);
            this.panel2.Controls.Add(this.labelSum);
            this.panel2.Controls.Add(this.textBoxReceipt);
            this.panel2.Controls.Add(this.dataGridViewPurchasesOnTape);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 355);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создать список покупок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Касса";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(75, 32);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduct.TabIndex = 1;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(17, 35);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(57, 13);
            this.labelProduct.TabIndex = 2;
            this.labelProduct.Text = "Продукты";
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Location = new System.Drawing.Point(287, 25);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.Size = new System.Drawing.Size(485, 115);
            this.dataGridViewPurchases.TabIndex = 3;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(206, 30);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteLast
            // 
            this.buttonDeleteLast.Location = new System.Drawing.Point(287, 141);
            this.buttonDeleteLast.Name = "buttonDeleteLast";
            this.buttonDeleteLast.Size = new System.Drawing.Size(485, 23);
            this.buttonDeleteLast.TabIndex = 5;
            this.buttonDeleteLast.Text = "Положить на полку последний товар";
            this.buttonDeleteLast.UseVisualStyleBackColor = true;
            // 
            // buttonToCassira
            // 
            this.buttonToCassira.Location = new System.Drawing.Point(4, 62);
            this.buttonToCassira.Name = "buttonToCassira";
            this.buttonToCassira.Size = new System.Drawing.Size(277, 102);
            this.buttonToCassira.TabIndex = 6;
            this.buttonToCassira.Text = "Отправиться к кассе";
            this.buttonToCassira.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPurchasesOnTape
            // 
            this.dataGridViewPurchasesOnTape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchasesOnTape.Location = new System.Drawing.Point(4, 31);
            this.dataGridViewPurchasesOnTape.Name = "dataGridViewPurchasesOnTape";
            this.dataGridViewPurchasesOnTape.Size = new System.Drawing.Size(768, 135);
            this.dataGridViewPurchasesOnTape.TabIndex = 2;
            // 
            // textBoxReceipt
            // 
            this.textBoxReceipt.Location = new System.Drawing.Point(3, 224);
            this.textBoxReceipt.Multiline = true;
            this.textBoxReceipt.Name = "textBoxReceipt";
            this.textBoxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceipt.Size = new System.Drawing.Size(769, 91);
            this.textBoxReceipt.TabIndex = 3;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(228, 175);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(41, 13);
            this.labelSum.TabIndex = 4;
            this.labelSum.Text = "Сумма";
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Location = new System.Drawing.Point(3, 172);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiscount.TabIndex = 5;
            // 
            // buttonShowDiscount
            // 
            this.buttonShowDiscount.Location = new System.Drawing.Point(131, 172);
            this.buttonShowDiscount.Name = "buttonShowDiscount";
            this.buttonShowDiscount.Size = new System.Drawing.Size(75, 46);
            this.buttonShowDiscount.TabIndex = 6;
            this.buttonShowDiscount.Text = "Показать дисконт";
            this.buttonShowDiscount.UseVisualStyleBackColor = true;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(5, 321);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoney.TabIndex = 7;
            // 
            // buttonGiveMoney
            // 
            this.buttonGiveMoney.Location = new System.Drawing.Point(112, 321);
            this.buttonGiveMoney.Name = "buttonGiveMoney";
            this.buttonGiveMoney.Size = new System.Drawing.Size(136, 23);
            this.buttonGiveMoney.TabIndex = 8;
            this.buttonGiveMoney.Text = "Дать деньги";
            this.buttonGiveMoney.UseVisualStyleBackColor = true;
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAddPurchase);
            this.Name = "BuyerForm";
            this.Text = "Form1";
            this.panelAddPurchase.ResumeLayout(false);
            this.panelAddPurchase.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasesOnTape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonToCassira;
        private System.Windows.Forms.Button buttonDeleteLast;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.DataGridView dataGridViewPurchases;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button buttonGiveMoney;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonShowDiscount;
        private System.Windows.Forms.ComboBox comboBoxDiscount;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.TextBox textBoxReceipt;
        private System.Windows.Forms.DataGridView dataGridViewPurchasesOnTape;
    }
}

