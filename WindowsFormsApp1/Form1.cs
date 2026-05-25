using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TourAgencyApp;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private LinkedList<TourOrder> _orders = new LinkedList<TourOrder>();
        private LinkedListNode<TourOrder> _currentNode = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateUI()
        {
            if (_currentNode != null)
            {
                TourOrder o = _currentNode.Value;
                txtDisplay.Text = "ТИП: " + o.GetTourType() + Environment.NewLine +
                                  "Код: " + o.OrderCode + Environment.NewLine +
                                  "Клієнт: " + o.CustomerName + Environment.NewLine +
                                  "Тур: " + o.TourName + Environment.NewLine +
                                  "Сума: " + string.Format("{0:F2}", o.CalculateTotal()) + " грн";
            }
            else
            {
                txtDisplay.Text = "Список порожній";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TourOrder n;
            if (numDiscount.Value > 0)
                n = new HotTour { DiscountPercent = (double)numDiscount.Value };
            else
                n = new StandardTour();

            n.OrderCode = txtInCode.Text;
            n.CustomerName = txtInName.Text;
            n.TourName = txtInTour.Text;
            n.Quantity = (int)numQty.Value;
            n.PricePerOne = (double)numPrice.Value;

            _orders.AddLast(n);
            if (_currentNode == null) _currentNode = _orders.First;
            UpdateUI();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentNode != null && _currentNode.Next != null)
            {
                _currentNode = _currentNode.Next;
                UpdateUI();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentNode != null && _currentNode.Previous != null)
            {
                _currentNode = _currentNode.Previous;
                UpdateUI();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentNode != null)
            {
                var toDel = _currentNode;
                _currentNode = toDel.Next ?? toDel.Previous;
                _orders.Remove(toDel);
                UpdateUI();
            }
        }
    }
}