namespace WindowsFormsApp1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtInCode;
        private System.Windows.Forms.TextBox txtInName;
        private System.Windows.Forms.TextBox txtInTour;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numDiscount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtInCode = new System.Windows.Forms.TextBox();
            this.txtInName = new System.Windows.Forms.TextBox();
            this.txtInTour = new System.Windows.Forms.TextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(220, 160);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(12, 180);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = " < ";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(182, 180);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = " > ";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Додати замовлення";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Видалити поточне";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtInCode
            // 
            this.txtInCode.Location = new System.Drawing.Point(360, 12);
            this.txtInCode.Name = "txtInCode";
            this.txtInCode.Size = new System.Drawing.Size(120, 20);
            this.txtInCode.TabIndex = 5;
            this.txtInCode.Text = "212";
            // 
            // txtInName
            // 
            this.txtInName.Location = new System.Drawing.Point(360, 38);
            this.txtInName.Name = "txtInName";
            this.txtInName.Size = new System.Drawing.Size(120, 20);
            this.txtInName.TabIndex = 6;
            // 
            // txtInTour
            // 
            this.txtInTour.Location = new System.Drawing.Point(360, 64);
            this.txtInTour.Name = "txtInTour";
            this.txtInTour.Size = new System.Drawing.Size(120, 20);
            this.txtInTour.TabIndex = 7;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(360, 90);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 20);
            this.numQty.TabIndex = 8;
            this.numQty.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(360, 116);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrice.TabIndex = 9;
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(360, 142);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(120, 20);
            this.numDiscount.TabIndex = 10;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(250, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(94, 13);
            this.lblCode.TabIndex = 11;
            this.lblCode.Text = "Код замовлення:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(250, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "ПІБ клієнта:";
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(250, 67);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(66, 13);
            this.lblTour.TabIndex = 13;
            this.lblTour.Text = "Назва туру:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(250, 93);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(56, 13);
            this.lblQty.TabIndex = 14;
            this.lblQty.Text = "Кількість:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(250, 119);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Ціна за 1:";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(250, 145);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(60, 13);
            this.lblDisc.TabIndex = 16;
            this.lblDisc.Text = "Знижка %:";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtInCode);
            this.Controls.Add(this.txtInName);
            this.Controls.Add(this.txtInTour);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDisc);
            this.Name = "MainForm";
            this.Text = "Менеджер Турів";
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDisc;
    }
}