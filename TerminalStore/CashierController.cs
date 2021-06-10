using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalStore
{
   

    public class CashierController
    {
        ShoppingSession shoppingSession;
        List<ShoppingSession> shoppingSessionDay;
        СashierMap cassiraMap;
        BuyerForm buyerForm;
        DiscountCard discountCard;
        DataGridView dataGridProduct;
        double money;
        bool excessMoney;
        BuyerController buyerController;
        List<Product> products;
        Label tapeLabel, thisProductLabel, labelSum, labelDiscount;
        bool isService;
        double sumThis, paymentSum;

        public bool ExcessMoney { get => excessMoney;  }



        /// <summary>
        /// Добавление покупки
        /// </summary>
        /// <param name="shoppingSession"></param>
        public delegate void HappenConsidered(ShoppingSession shoppingSession);
        event HappenConsidered happenConsidered;

        /// <summary>
        /// Итог. Показ суммы
        /// </summary>
        /// <param name="shoppingSession"></param>
        public delegate void HappenEndSessiongShowSum(ShoppingSession shoppingSession, double sum);
        event HappenEndSessiongShowSum happenEndSessiongShowSum;

        /// <summary>
        /// Итог. Печать чека
        /// </summary>
        /// <param name="shoppingSession"></param>
        public delegate void HappenWriteReceipt(string receipt, double surrender);
        event HappenWriteReceipt happenWriteReceipt;

        public CashierController(Label tape,Label thisProduct, Label labelSum, DataGridView dataGridProduct, Label labelDiscount)
        {
            this.tapeLabel = tape;
            this.thisProductLabel = thisProduct;
            this.labelSum = labelSum;
            this.dataGridProduct = dataGridProduct;
            this.labelDiscount = labelDiscount;
            money = 0;
            excessMoney = false;
            isService = false;
        }


        public void SetStartMoney()
        {
            money = 5000;
            isService = false;
        }

        /// <summary>
        /// Отдать деньги менеджеру
        /// </summary>
        public void HandOverMoney()
        {
            money = 0;
            excessMoney = false;
            MessageBox.Show("Деньги сданы менеджеру");
        }

        public void SetСashierMap(ref ComboBox comboBoxСashierMap)
        {
            // List<Product> products =Product.GetAllProduct();
            // comboBoxAllProduct.Items.AddRange((object)products);
            using (TerminalContext terminalContext = new TerminalContext())
            {
                terminalContext.СashierMap.Load();
                comboBoxСashierMap.DataSource = terminalContext.СashierMap.Local;
                comboBoxСashierMap.ValueMember = "CassiraMapId";
                comboBoxСashierMap.DisplayMember = "Login";
            }

        }

        /// <summary>
        /// Вход кассира
        /// </summary>
        /// <param name="idCassiraMap"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public bool EntrerCassira(int idCassiraMap, String pass)
        {
            using (TerminalContext terminalContext = new TerminalContext())
            {

                cassiraMap = terminalContext.СashierMap.FirstOrDefault(p => p.CassiraMapId == idCassiraMap && p.Pass.Equals(pass));
                if (cassiraMap != null )
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Старт кассы
        /// </summary>
        /// <returns></returns>
        public bool CanStart()
        {
            if (money >= 5000) return true;
            return false;
        }


        public void StartCashbox()
        {
            buyerController = new BuyerController(this);
            shoppingSessionDay = new List<ShoppingSession>();
            buyerForm = new BuyerForm(buyerController);
            buyerForm.Show();
        }

        public bool StartSessionShoping(List<Product> products, HappenConsidered happenConsidered, HappenEndSessiongShowSum happenEndSessiongShowSum, HappenWriteReceipt happenWriteReceipt)
        {
            if (!isService)
            {
                this.products = products;
                tapeLabel.Text = products.First().ToString();
                shoppingSession = new ShoppingSession(cassiraMap);
                MessageBox.Show("Подошёл покупатель");
                this.happenConsidered = happenConsidered;
                this.happenEndSessiongShowSum = happenEndSessiongShowSum;
                sumThis = 0;
                paymentSum = 0;
                this.happenWriteReceipt = happenWriteReceipt;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Считывание продукта
        /// </summary>
        /// <param name="dataGridProduct"></param>
        public void ReadProduct()
        {
            if (products.Count > 0)
            {
                Product product = products.First();
                products.Remove(product);
                //shoppingSession = new ShoppingSession(cassiraMap.CassiraMapId);
                Purchase purchase = new Purchase(product, 0, shoppingSession);
                shoppingSession.Purchases.Add(purchase);
                SetDateGrid.SetReceipt(dataGridProduct, shoppingSession);
                thisProductLabel.Text = product.ToString();
                happenConsidered?.Invoke(shoppingSession);
                if (products.Count > 0) tapeLabel.Text = products.First().ToString();
                else tapeLabel.Text = "Лента пуста";
            }
            else
            {
                MessageBox.Show("Товаров на ленте закончилось");
            }

        }


        public void SetCountWight(int countAndWight, DataGridView dataGridProduct)
        {
            if (countAndWight > 0 && shoppingSession.Purchases!=null) {
                shoppingSession.Purchases.Last().SizeAndCount= countAndWight;
                SetDateGrid.SetReceipt(dataGridProduct, shoppingSession);
                happenConsidered?.Invoke(shoppingSession);


            }
        }

        /// <summary>
        /// Показ итоговый суммы
        /// </summary>
        public bool SayFinalSum()
        {
            double sum = 0;

            if (products.Count==0)
            {
               
                foreach (var purchase in shoppingSession.Purchases)
                {
                    double sumThis = 0;
                    //sum+= purchase.
                    //purchase.SizeAndCount;
                    using (TerminalContext terminalContext = new TerminalContext())
                    {
                        Product product= terminalContext.Product.FirstOrDefault(p => p.ProductId == purchase.ProductId);
                        if (product is null) return false;
                        double sizeDiscount = 0;

                        if(shoppingSession.DiscountCard != null)
                        {
                            sizeDiscount = shoppingSession.DiscountCard.GetSizeDiscountOnProduct(product);
                        }

                        sumThis = product.PriceOfOne() * purchase.SizeAndCount*(1- sizeDiscount);
                    }
                    sum += sumThis;
                    this.sumThis = sum;
                }
                happenEndSessiongShowSum?.Invoke(shoppingSession, sum);
                return true;

            }
            else
            {
                MessageBox.Show("Продукты ещё на ленте");
                return false;
            }
        }

        /// <summary>
        /// Оплата
        /// </summary>
        /// <returns></returns>
        public bool Pay(double payment)
        {
            if (sumThis > payment) return false;
            if ((sumThis - payment) > money) return false;
            paymentSum = payment;
            
            labelSum.Text = paymentSum + " руб.";
            return true;
        }
        
        /// <summary>
        /// Полить деньги к кассу
        /// </summary>
        /// <param name="paymentSum"></param>
        private void PutMoney(double paymentSum)
        {
            money += paymentSum;
            if (money > 200000)
            {
                excessMoney = true;
                isService = true;

            }
        }


        public void GiveCheckAndChange()
        {
            PutMoney(paymentSum);
            shoppingSessionDay.Add(shoppingSession);
            happenWriteReceipt?.Invoke(CheckPrint(), paymentSum-sumThis);


        }

        public bool PurchasePaid()
        {
            if (paymentSum > 0) return true;
            else
            {
                MessageBox.Show("Погоди кассир, деньги получи сперва");
                return false;

            }

        }
        //Печать чека
        private string CheckPrint()
        {
            string check = "";
            double sumWithoutDiscount = 0;
            double sumTotal = 0;
            foreach (var purchase in shoppingSession.Purchases)
            {
                string position = "";
                position +="Код: "+ purchase.ProductId+" ";
                position +="Товар "+ purchase.Product.Name + " ";
                position +="Кол/вес "+ purchase.SizeAndCount + " " + purchase.Product.IsWightStr + " ";
                position+="Цена "+ purchase.Product.Price + " ";
                double sizeDiscount = 0;

                if (shoppingSession.DiscountCard != null)
                {
                    sizeDiscount = shoppingSession.DiscountCard.GetSizeDiscountOnProduct(purchase.Product);
                }
                double sumThis = (purchase.Product.PriceOfOne()) * purchase.SizeAndCount;
                sumWithoutDiscount += sumThis;
                double sumDiscount = sumThis - sumThis*(1 - sizeDiscount);
                sumThis *= (1 - sizeDiscount);
                sumTotal += sumThis;
                position += "Стоимость " + sumThis + " ";
                if(sumDiscount > 0)
                {
                    position += "Скидка " + sumDiscount + " ";
                }
                check += position + System.Environment.NewLine;
            }

            check += "Общая скидка " + (sumWithoutDiscount-sumTotal) + System.Environment.NewLine;
            check += "Общая сумма " + (sumTotal) + System.Environment.NewLine;
            check += "Кассир " + (shoppingSession.СashierMap.Name) + System.Environment.NewLine;
            check += "Сумма покупателя " + (paymentSum) + System.Environment.NewLine;
            check += "Сдача " + (paymentSum- sumTotal) + System.Environment.NewLine;
            check += "Спасибо за покупку";
            return check;

        }

        /// <summary>
        /// Окончания дня
        /// </summary>
        /// <returns></returns>
        public bool EndTheDay()
        {


            HandOverMoney();
            isService = true;
            if (shoppingSessionDay.Count > 0)
            {
                if (ShoppingSession.SendShoppingSessionDay(shoppingSessionDay))
                {
                    MessageBox.Show("Пока кассир");
                    return true;
                }

            }

            return false;
        }

        public void PutDiscointCard(DiscountCard discountCard)
        {
            this.discountCard = discountCard;
            labelDiscount.Text = discountCard.Name;
            MessageBox.Show("Возьмети пожалуйста дискотную карту");

        }

        public void TakeDiscointCard()
        {
            if(discountCard != null)
            {
                shoppingSession.DiscountCard = discountCard;
                SetDateGrid.SetReceipt(dataGridProduct, shoppingSession);

            }
            else
            {
                MessageBox.Show("Плохой покупатель. Карту не положил");
            }


        }


        public void DeleteLastProduct()
        {
            if (shoppingSession is null) return;

            if (shoppingSession.Purchases.Count > 0)
            {
                shoppingSession.Purchases.RemoveAt(shoppingSession.Purchases.Count-1);
                SetDateGrid.SetReceipt(dataGridProduct, shoppingSession);
                
                happenConsidered?.Invoke(shoppingSession);
                if (shoppingSession.Purchases.Count > 0)
                {
                    thisProductLabel.Text = shoppingSession.Purchases.Last().Product.ToString();
                }
                else
                {
                    thisProductLabel.Text = "Удаленно всё";
                }




            }
        }
    }
}
