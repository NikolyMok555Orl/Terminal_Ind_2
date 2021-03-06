
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
            this.buttonToCassira = new System.Windows.Forms.Button();
            this.buttonDeleteLast = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.labelProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAtTheCheckout = new System.Windows.Forms.Panel();
            this.buttonDeleteLastBuyer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTakePurchases = new System.Windows.Forms.Button();
            this.buttonGiveMoney = new System.Windows.Forms.Button();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonShowDiscount = new System.Windows.Forms.Button();
            this.comboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.labelSumFinal = new System.Windows.Forms.Label();
            this.textBoxReceipt = new System.Windows.Forms.TextBox();
            this.dataGridViewPurchasesOnTape = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSurrender = new System.Windows.Forms.Label();
            this.panelAddPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            this.panelAtTheCheckout.SuspendLayout();
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
            // buttonToCassira
            // 
            this.buttonToCassira.Location = new System.Drawing.Point(4, 62);
            this.buttonToCassira.Name = "buttonToCassira";
            this.buttonToCassira.Size = new System.Drawing.Size(277, 102);
            this.buttonToCassira.TabIndex = 6;
            this.buttonToCassira.Text = "Отправиться к кассе";
            this.buttonToCassira.UseVisualStyleBackColor = true;
            this.buttonToCassira.Click += new System.EventHandler(this.buttonToCassira_Click);
            // 
            // buttonDeleteLast
            // 
            this.buttonDeleteLast.Location = new System.Drawing.Point(287, 141);
            this.buttonDeleteLast.Name = "buttonDeleteLast";
            this.buttonDeleteLast.Size = new System.Drawing.Size(485, 23);
            this.buttonDeleteLast.TabIndex = 5;
            this.buttonDeleteLast.Text = "Положить на полку последний товар";
            this.buttonDeleteLast.UseVisualStyleBackColor = true;
            this.buttonDeleteLast.Click += new System.EventHandler(this.buttonDeleteLast_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(206, 30);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Location = new System.Drawing.Point(287, 25);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.ReadOnly = true;
            this.dataGridViewPurchases.Size = new System.Drawing.Size(485, 115);
            this.dataGridViewPurchases.TabIndex = 3;
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
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxProduct.Location = new System.Drawing.Point(75, 32);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProduct.TabIndex = 1;
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
            // panelAtTheCheckout
            // 
            this.panelAtTheCheckout.Controls.Add(this.labelSurrender);
            this.panelAtTheCheckout.Controls.Add(this.buttonDeleteLastBuyer);
            this.panelAtTheCheckout.Controls.Add(this.label3);
            this.panelAtTheCheckout.Controls.Add(this.buttonTakePurchases);
            this.panelAtTheCheckout.Controls.Add(this.buttonGiveMoney);
            this.panelAtTheCheckout.Controls.Add(this.textBoxMoney);
            this.panelAtTheCheckout.Controls.Add(this.buttonShowDiscount);
            this.panelAtTheCheckout.Controls.Add(this.comboBoxDiscount);
            this.panelAtTheCheckout.Controls.Add(this.labelSumFinal);
            this.panelAtTheCheckout.Controls.Add(this.textBoxReceipt);
            this.panelAtTheCheckout.Controls.Add(this.dataGridViewPurchasesOnTape);
            this.panelAtTheCheckout.Controls.Add(this.label2);
            this.panelAtTheCheckout.Location = new System.Drawing.Point(12, 177);
            this.panelAtTheCheckout.Name = "panelAtTheCheckout";
            this.panelAtTheCheckout.Size = new System.Drawing.Size(775, 380);
            this.panelAtTheCheckout.TabIndex = 1;
            // 
            // buttonDeleteLastBuyer
            // 
            this.buttonDeleteLastBuyer.Location = new System.Drawing.Point(211, 193);
            this.buttonDeleteLastBuyer.Name = "buttonDeleteLastBuyer";
            this.buttonDeleteLastBuyer.Size = new System.Drawing.Size(148, 23);
            this.buttonDeleteLastBuyer.TabIndex = 11;
            this.buttonDeleteLastBuyer.Text = "Убрать последнее";
            this.buttonDeleteLastBuyer.UseVisualStyleBackColor = true;
            this.buttonDeleteLastBuyer.Click += new System.EventHandler(this.buttonDeleteLastBuyer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Деньги кассиру";
            // 
            // buttonTakePurchases
            // 
            this.buttonTakePurchases.Location = new System.Drawing.Point(3, 346);
            this.buttonTakePurchases.Name = "buttonTakePurchases";
            this.buttonTakePurchases.Size = new System.Drawing.Size(766, 31);
            this.buttonTakePurchases.TabIndex = 9;
            this.buttonTakePurchases.Text = "Забрать покупки";
            this.buttonTakePurchases.UseVisualStyleBackColor = true;
            this.buttonTakePurchases.Click += new System.EventHandler(this.buttonTakePurchases_Click);
            // 
            // buttonGiveMoney
            // 
            this.buttonGiveMoney.Location = new System.Drawing.Point(633, 174);
            this.buttonGiveMoney.Name = "buttonGiveMoney";
            this.buttonGiveMoney.Size = new System.Drawing.Size(136, 23);
            this.buttonGiveMoney.TabIndex = 8;
            this.buttonGiveMoney.Text = "Дать деньги";
            this.buttonGiveMoney.UseVisualStyleBackColor = true;
            this.buttonGiveMoney.Click += new System.EventHandler(this.buttonGiveMoney_Click);
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(527, 173);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoney.TabIndex = 7;
            // 
            // buttonShowDiscount
            // 
            this.buttonShowDiscount.Location = new System.Drawing.Point(130, 170);
            this.buttonShowDiscount.Name = "buttonShowDiscount";
            this.buttonShowDiscount.Size = new System.Drawing.Size(75, 46);
            this.buttonShowDiscount.TabIndex = 6;
            this.buttonShowDiscount.Text = "Показать дисконт";
            this.buttonShowDiscount.UseVisualStyleBackColor = true;
            this.buttonShowDiscount.Click += new System.EventHandler(this.buttonShowDiscount_Click);
            // 
            // comboBoxDiscount
            // 
            this.comboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscount.FormattingEnabled = true;
            this.comboBoxDiscount.Location = new System.Drawing.Point(3, 172);
            this.comboBoxDiscount.Name = "comboBoxDiscount";
            this.comboBoxDiscount.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiscount.TabIndex = 5;
            // 
            // labelSumFinal
            // 
            this.labelSumFinal.AutoSize = true;
            this.labelSumFinal.Location = new System.Drawing.Point(228, 175);
            this.labelSumFinal.Name = "labelSumFinal";
            this.labelSumFinal.Size = new System.Drawing.Size(91, 13);
            this.labelSumFinal.TabIndex = 4;
            this.labelSumFinal.Text = "Сумма к оплате:";
            // 
            // textBoxReceipt
            // 
            this.textBoxReceipt.Location = new System.Drawing.Point(3, 222);
            this.textBoxReceipt.Multiline = true;
            this.textBoxReceipt.Name = "textBoxReceipt";
            this.textBoxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceipt.Size = new System.Drawing.Size(769, 118);
            this.textBoxReceipt.TabIndex = 3;
            // 
            // dataGridViewPurchasesOnTape
            // 
            this.dataGridViewPurchasesOnTape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchasesOnTape.Location = new System.Drawing.Point(4, 31);
            this.dataGridViewPurchasesOnTape.Name = "dataGridViewPurchasesOnTape";
            this.dataGridViewPurchasesOnTape.Size = new System.Drawing.Size(768, 135);
            this.dataGridViewPurchasesOnTape.TabIndex = 2;
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
            // labelSurrender
            // 
            this.labelSurrender.AutoSize = true;
            this.labelSurrender.Location = new System.Drawing.Point(436, 202);
            this.labelSurrender.Name = "labelSurrender";
            this.labelSurrender.Size = new System.Drawing.Size(37, 13);
            this.labelSurrender.TabIndex = 12;
            this.labelSurrender.Text = "Сдача";
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.panelAtTheCheckout);
            this.Controls.Add(this.panelAddPurchase);
            this.Name = "BuyerForm";
            this.Text = "Покупатель";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            this.panelAddPurchase.ResumeLayout(false);
            this.panelAddPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            this.panelAtTheCheckout.ResumeLayout(false);
            this.panelAtTheCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchasesOnTape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAtTheCheckout;
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
        private System.Windows.Forms.Label labelSumFinal;
        private System.Windows.Forms.TextBox textBoxReceipt;
        private System.Windows.Forms.DataGridView dataGridViewPurchasesOnTape;
        private System.Windows.Forms.Button buttonTakePurchases;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteLastBuyer;
        private System.Windows.Forms.Label labelSurrender;
    }
}

