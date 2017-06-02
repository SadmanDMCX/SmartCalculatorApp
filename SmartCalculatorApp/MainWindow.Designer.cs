namespace SmartCalculatorApp
{
    partial class MainWindow
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
            this.showLastCalculation = new MetroFramework.Controls.MetroLabel();
            this.btnOne = new MetroFramework.Controls.MetroButton();
            this.calculationTextBox = new System.Windows.Forms.TextBox();
            this.btnTwo = new MetroFramework.Controls.MetroButton();
            this.btnThree = new MetroFramework.Controls.MetroButton();
            this.btnFour = new MetroFramework.Controls.MetroButton();
            this.btnFive = new MetroFramework.Controls.MetroButton();
            this.btnSix = new MetroFramework.Controls.MetroButton();
            this.btnSeven = new MetroFramework.Controls.MetroButton();
            this.btnEight = new MetroFramework.Controls.MetroButton();
            this.btnNine = new MetroFramework.Controls.MetroButton();
            this.btnZero = new MetroFramework.Controls.MetroButton();
            this.btnMunus = new MetroFramework.Controls.MetroButton();
            this.btnDivide = new MetroFramework.Controls.MetroButton();
            this.btnPlus = new MetroFramework.Controls.MetroButton();
            this.btnMul = new MetroFramework.Controls.MetroButton();
            this.btnDot = new MetroFramework.Controls.MetroButton();
            this.btnPM = new MetroFramework.Controls.MetroButton();
            this.showCalculatedValue = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOne = new MetroFramework.Controls.MetroButton();
            this.clearAll = new MetroFramework.Controls.MetroButton();
            this.colorChangePanel = new System.Windows.Forms.Panel();
            this.btnEqual = new MetroFramework.Controls.MetroButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showLastCalculation
            // 
            this.showLastCalculation.Location = new System.Drawing.Point(22, 106);
            this.showLastCalculation.Name = "showLastCalculation";
            this.showLastCalculation.Size = new System.Drawing.Size(186, 148);
            this.showLastCalculation.TabIndex = 0;
            this.showLastCalculation.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.White;
            this.btnOne.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnOne.Location = new System.Drawing.Point(20, 322);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(65, 55);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseSelectable = true;
            this.btnOne.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // calculationTextBox
            // 
            this.calculationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationTextBox.Location = new System.Drawing.Point(20, 257);
            this.calculationTextBox.Multiline = true;
            this.calculationTextBox.Name = "calculationTextBox";
            this.calculationTextBox.Size = new System.Drawing.Size(351, 59);
            this.calculationTextBox.TabIndex = 1;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.White;
            this.btnTwo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTwo.Location = new System.Drawing.Point(91, 322);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(65, 55);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseSelectable = true;
            this.btnTwo.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.White;
            this.btnThree.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnThree.Location = new System.Drawing.Point(162, 322);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(65, 55);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseSelectable = true;
            this.btnThree.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.White;
            this.btnFour.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFour.Location = new System.Drawing.Point(20, 383);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(65, 55);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseSelectable = true;
            this.btnFour.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.White;
            this.btnFive.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFive.Location = new System.Drawing.Point(91, 383);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(64, 55);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseSelectable = true;
            this.btnFive.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.White;
            this.btnSix.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSix.Location = new System.Drawing.Point(162, 383);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(65, 55);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseSelectable = true;
            this.btnSix.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.White;
            this.btnSeven.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSeven.Location = new System.Drawing.Point(19, 444);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(65, 55);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseSelectable = true;
            this.btnSeven.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.White;
            this.btnEight.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEight.Location = new System.Drawing.Point(90, 444);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(65, 55);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseSelectable = true;
            this.btnEight.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.White;
            this.btnNine.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnNine.Location = new System.Drawing.Point(161, 444);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(65, 55);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseSelectable = true;
            this.btnNine.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.White;
            this.btnZero.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnZero.Location = new System.Drawing.Point(90, 505);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(65, 55);
            this.btnZero.TabIndex = 12;
            this.btnZero.Text = "0";
            this.btnZero.UseSelectable = true;
            this.btnZero.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnMunus
            // 
            this.btnMunus.BackColor = System.Drawing.Color.White;
            this.btnMunus.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMunus.Location = new System.Drawing.Point(306, 383);
            this.btnMunus.Name = "btnMunus";
            this.btnMunus.Size = new System.Drawing.Size(65, 55);
            this.btnMunus.TabIndex = 17;
            this.btnMunus.Text = "-";
            this.btnMunus.UseSelectable = true;
            this.btnMunus.Click += new System.EventHandler(this.ArithmeticOparation_PlusMinusDivideMultiply);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.White;
            this.btnDivide.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDivide.Location = new System.Drawing.Point(306, 444);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(65, 55);
            this.btnDivide.TabIndex = 19;
            this.btnDivide.Text = "/";
            this.btnDivide.UseSelectable = true;
            this.btnDivide.Click += new System.EventHandler(this.ArithmeticOparation_PlusMinusDivideMultiply);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.White;
            this.btnPlus.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPlus.Location = new System.Drawing.Point(235, 383);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(65, 55);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseSelectable = true;
            this.btnPlus.Click += new System.EventHandler(this.ArithmeticOparation_PlusMinusDivideMultiply);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.White;
            this.btnMul.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMul.Location = new System.Drawing.Point(235, 444);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(65, 55);
            this.btnMul.TabIndex = 18;
            this.btnMul.Text = "*";
            this.btnMul.UseSelectable = true;
            this.btnMul.Click += new System.EventHandler(this.ArithmeticOparation_PlusMinusDivideMultiply);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.White;
            this.btnDot.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDot.Location = new System.Drawing.Point(161, 505);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(65, 55);
            this.btnDot.TabIndex = 13;
            this.btnDot.Text = ".";
            this.btnDot.UseSelectable = true;
            this.btnDot.Click += new System.EventHandler(this.OnClick_Number);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.White;
            this.btnPM.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPM.Location = new System.Drawing.Point(20, 505);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(65, 55);
            this.btnPM.TabIndex = 11;
            this.btnPM.Text = "+/-";
            this.btnPM.UseSelectable = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // showCalculatedValue
            // 
            this.showCalculatedValue.Location = new System.Drawing.Point(214, 106);
            this.showCalculatedValue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.showCalculatedValue.Name = "showCalculatedValue";
            this.showCalculatedValue.Size = new System.Drawing.Size(157, 148);
            this.showCalculatedValue.TabIndex = 0;
            this.showCalculatedValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(354, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.scientificToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // clearOne
            // 
            this.clearOne.BackColor = System.Drawing.Color.White;
            this.clearOne.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearOne.Location = new System.Drawing.Point(235, 322);
            this.clearOne.Name = "clearOne";
            this.clearOne.Size = new System.Drawing.Size(65, 55);
            this.clearOne.TabIndex = 14;
            this.clearOne.Text = "CO";
            this.clearOne.UseSelectable = true;
            this.clearOne.Click += new System.EventHandler(this.clearOne_Click);
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.White;
            this.clearAll.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearAll.Location = new System.Drawing.Point(306, 322);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(65, 55);
            this.clearAll.TabIndex = 15;
            this.clearAll.Text = "CA";
            this.clearAll.UseSelectable = true;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // colorChangePanel
            // 
            this.colorChangePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.colorChangePanel.Location = new System.Drawing.Point(19, 566);
            this.colorChangePanel.Name = "colorChangePanel";
            this.colorChangePanel.Size = new System.Drawing.Size(352, 28);
            this.colorChangePanel.TabIndex = 21;
            this.colorChangePanel.Click += new System.EventHandler(this.OnClickColorChangePanel_OnClick);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.White;
            this.btnEqual.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnEqual.Location = new System.Drawing.Point(235, 505);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(136, 55);
            this.btnEqual.TabIndex = 20;
            this.btnEqual.Text = "=";
            this.btnEqual.UseSelectable = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 617);
            this.Controls.Add(this.colorChangePanel);
            this.Controls.Add(this.calculationTextBox);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.clearOne);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMunus);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.showCalculatedValue);
            this.Controls.Add(this.showLastCalculation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Resizable = false;
            this.Text = "Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel showLastCalculation;
        private MetroFramework.Controls.MetroButton btnOne;
        private System.Windows.Forms.TextBox calculationTextBox;
        private MetroFramework.Controls.MetroButton btnTwo;
        private MetroFramework.Controls.MetroButton btnThree;
        private MetroFramework.Controls.MetroButton btnFour;
        private MetroFramework.Controls.MetroButton btnFive;
        private MetroFramework.Controls.MetroButton btnSix;
        private MetroFramework.Controls.MetroButton btnSeven;
        private MetroFramework.Controls.MetroButton btnEight;
        private MetroFramework.Controls.MetroButton btnNine;
        private MetroFramework.Controls.MetroButton btnZero;
        private MetroFramework.Controls.MetroButton btnMunus;
        private MetroFramework.Controls.MetroButton btnDivide;
        private MetroFramework.Controls.MetroButton btnPlus;
        private MetroFramework.Controls.MetroButton btnMul;
        private MetroFramework.Controls.MetroButton btnDot;
        private MetroFramework.Controls.MetroButton btnPM;
        private MetroFramework.Controls.MetroLabel showCalculatedValue;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private MetroFramework.Controls.MetroButton clearOne;
        private MetroFramework.Controls.MetroButton clearAll;
        private System.Windows.Forms.Panel colorChangePanel;
        private MetroFramework.Controls.MetroButton btnEqual;
    }
}

