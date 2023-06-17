using System;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Calc
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
            this.numBox = new System.Windows.Forms.TextBox();
            this.digit7 = new System.Windows.Forms.Button();
            this.digit8 = new System.Windows.Forms.Button();
            this.digit9 = new System.Windows.Forms.Button();
            this.opDiv = new System.Windows.Forms.Button();
            this.ctrlCE = new System.Windows.Forms.Button();
            this.digit4 = new System.Windows.Forms.Button();
            this.digit5 = new System.Windows.Forms.Button();
            this.digit6 = new System.Windows.Forms.Button();
            this.opMult = new System.Windows.Forms.Button();
            this.ctrlClear = new System.Windows.Forms.Button();
            this.digit1 = new System.Windows.Forms.Button();
            this.digit2 = new System.Windows.Forms.Button();
            this.digit3 = new System.Windows.Forms.Button();
            this.opSub = new System.Windows.Forms.Button();
            this.digit0 = new System.Windows.Forms.Button();
            this.charPoint = new System.Windows.Forms.Button();
            this.opAdd = new System.Windows.Forms.Button();
            this.ctrlEquals = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(12, 25);
            this.numBox.MaxLength = 16;
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(224, 20);
            this.numBox.TabIndex = 0;
            this.numBox.Text = "0";
            this.numBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBox.SelectionLength = 0;
            this.numBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numBoxKeyDown);
            this.numBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numBoxKeyPress);
            // 
            // digit7
            // 
            this.digit7.Location = new System.Drawing.Point(12, 51);
            this.digit7.Name = "digit7";
            this.digit7.Size = new System.Drawing.Size(40, 40);
            this.digit7.TabIndex = 1;
            this.digit7.Text = "7";
            this.digit7.UseVisualStyleBackColor = true;
            this.digit7.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // digit8
            // 
            this.digit8.Location = new System.Drawing.Point(58, 51);
            this.digit8.Name = "digit8";
            this.digit8.Size = new System.Drawing.Size(40, 40);
            this.digit8.TabIndex = 2;
            this.digit8.Text = "8";
            this.digit8.UseVisualStyleBackColor = true;
            this.digit8.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // digit9
            // 
            this.digit9.Location = new System.Drawing.Point(104, 51);
            this.digit9.Name = "digit9";
            this.digit9.Size = new System.Drawing.Size(40, 40);
            this.digit9.TabIndex = 3;
            this.digit9.Text = "9";
            this.digit9.UseVisualStyleBackColor = true;
            this.digit9.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // opDiv
            // 
            this.opDiv.Location = new System.Drawing.Point(150, 51);
            this.opDiv.Name = "opDiv";
            this.opDiv.Size = new System.Drawing.Size(40, 40);
            this.opDiv.TabIndex = 4;
            this.opDiv.Text = "/";
            this.opDiv.UseVisualStyleBackColor = true;
            this.opDiv.Click += new System.EventHandler(this.buttonOpClick);
            // 
            // ctrlCE
            // 
            this.ctrlCE.Location = new System.Drawing.Point(196, 51);
            this.ctrlCE.Name = "ctrlCE";
            this.ctrlCE.Size = new System.Drawing.Size(40, 40);
            this.ctrlCE.TabIndex = 5;
            this.ctrlCE.Text = "CE";
            this.ctrlCE.UseVisualStyleBackColor = true;
            this.ctrlCE.Click += new System.EventHandler(this.buttonCEClick);
            // 
            // digit4
            // 
            this.digit4.Location = new System.Drawing.Point(12, 97);
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(40, 40);
            this.digit4.TabIndex = 6;
            this.digit4.Text = "4";
            this.digit4.UseVisualStyleBackColor = true;
            this.digit4.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // digit5
            // 
            this.digit5.Location = new System.Drawing.Point(58, 97);
            this.digit5.Name = "digit5";
            this.digit5.Size = new System.Drawing.Size(40, 40);
            this.digit5.TabIndex = 7;
            this.digit5.Text = "5";
            this.digit5.UseVisualStyleBackColor = true;
            this.digit5.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // digit6
            // 
            this.digit6.Location = new System.Drawing.Point(104, 97);
            this.digit6.Name = "digit6";
            this.digit6.Size = new System.Drawing.Size(40, 40);
            this.digit6.TabIndex = 8;
            this.digit6.Text = "6";
            this.digit6.UseVisualStyleBackColor = true;
            this.digit6.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // opMult
            // 
            this.opMult.Location = new System.Drawing.Point(150, 97);
            this.opMult.Name = "opMult";
            this.opMult.Size = new System.Drawing.Size(40, 40);
            this.opMult.TabIndex = 9;
            this.opMult.Text = "*";
            this.opMult.UseVisualStyleBackColor = true;
            this.opMult.Click += new System.EventHandler(this.buttonOpClick);
            // 
            // ctrlClear
            // 
            this.ctrlClear.Location = new System.Drawing.Point(196, 97);
            this.ctrlClear.Name = "ctrlClear";
            this.ctrlClear.Size = new System.Drawing.Size(40, 40);
            this.ctrlClear.TabIndex = 10;
            this.ctrlClear.Text = "C";
            this.ctrlClear.UseVisualStyleBackColor = true;
            this.ctrlClear.Click += new EventHandler(this.buttonClearClick);
            // 
            // digit1
            // 
            this.digit1.Location = new System.Drawing.Point(12, 143);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(40, 40);
            this.digit1.TabIndex = 11;
            this.digit1.Text = "1";
            this.digit1.UseVisualStyleBackColor = true;
            this.digit1.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // digit2
            // 
            this.digit2.Location = new System.Drawing.Point(58, 143);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(40, 40);
            this.digit2.TabIndex = 12;
            this.digit2.Text = "2";
            this.digit2.UseVisualStyleBackColor = true;
            this.digit2.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // digit3
            // 
            this.digit3.Location = new System.Drawing.Point(104, 143);
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(40, 40);
            this.digit3.TabIndex = 13;
            this.digit3.Text = "3";
            this.digit3.UseVisualStyleBackColor = true;
            this.digit3.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // opSub
            // 
            this.opSub.Location = new System.Drawing.Point(150, 143);
            this.opSub.Name = "opSub";
            this.opSub.Size = new System.Drawing.Size(40, 40);
            this.opSub.TabIndex = 14;
            this.opSub.Text = "-";
            this.opSub.UseVisualStyleBackColor = true;
            this.opSub.Click += new System.EventHandler(this.buttonOpClick);
            // 
            // digit0
            // 
            this.digit0.Location = new System.Drawing.Point(12, 189);
            this.digit0.Name = "digit0";
            this.digit0.Size = new System.Drawing.Size(86, 40);
            this.digit0.TabIndex = 15;
            this.digit0.Text = "0";
            this.digit0.UseVisualStyleBackColor = true;
            this.digit0.Click += new System.EventHandler(this.buttonDigitClick);
            // 
            // charPoint
            // 
            this.charPoint.Location = new System.Drawing.Point(104, 189);
            this.charPoint.Name = "charPoint";
            this.charPoint.Size = new System.Drawing.Size(40, 40);
            this.charPoint.TabIndex = 16;
            this.charPoint.Text = ".";
            this.charPoint.UseVisualStyleBackColor = true;
            this.charPoint.Click += new System.EventHandler(this.buttonPointClick);
            // 
            // opAdd
            // 
            this.opAdd.Location = new System.Drawing.Point(150, 189);
            this.opAdd.Name = "opAdd";
            this.opAdd.Size = new System.Drawing.Size(40, 40);
            this.opAdd.TabIndex = 17;
            this.opAdd.Text = "+";
            this.opAdd.UseVisualStyleBackColor = true;
            this.opAdd.Click += new System.EventHandler(this.buttonOpClick);
            // 
            // ctrlEquals
            // 
            this.ctrlEquals.Location = new System.Drawing.Point(196, 143);
            this.ctrlEquals.Name = "ctrlEquals";
            this.ctrlEquals.Size = new System.Drawing.Size(40, 86);
            this.ctrlEquals.TabIndex = 18;
            this.ctrlEquals.Text = "=";
            this.ctrlEquals.UseVisualStyleBackColor = true;
            this.ctrlEquals.Click += new EventHandler(this.buttonEqualsClick);
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(224, 13);
            this.label.TabIndex = 19;
            this.label.Text = "";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 242);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ctrlEquals);
            this.Controls.Add(this.opAdd);
            this.Controls.Add(this.charPoint);
            this.Controls.Add(this.digit0);
            this.Controls.Add(this.opSub);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.ctrlClear);
            this.Controls.Add(this.opMult);
            this.Controls.Add(this.digit6);
            this.Controls.Add(this.digit5);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.ctrlCE);
            this.Controls.Add(this.opDiv);
            this.Controls.Add(this.digit9);
            this.Controls.Add(this.digit8);
            this.Controls.Add(this.digit7);
            this.Controls.Add(this.numBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void numBoxKeyPress(object sender, KeyPressEventArgs e) {            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.') { //&& !char.IsControl(e.KeyChar) 
                e.Handled = true;
            }
            else {
                (sender as TextBox).SelectionStart = (sender as TextBox).TextLength;
                if ((sender as TextBox).Text == "0" && e.KeyChar != '.' || isLabeling) {
                    (sender as TextBox).Clear();
                }
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) {
                e.Handled = true;
            }
            if (e.KeyChar == '0' && (sender as TextBox).Text == "0") {
                e.Handled = true;
            }
            isLabeling = false;
        }

        private void numBoxKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Delete) {
                (sender as TextBox).Text = "0";
                (sender as TextBox).SelectionStart = 1;
                if (label.Text.IndexOf('=') > -1) {
                    label.Text = "";
                }
            }
            if (e.KeyCode == Keys.Back) {
                (sender as TextBox).Text = (sender as TextBox).Text.Remove((sender as TextBox).Text.Length - 1);               
                if ((sender as TextBox).Text.Length == 0) {
                    (sender as TextBox).Text = "0";
                } 
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
            isLabeling = false;
        }

        private void buttonDigitClick(object sender, EventArgs e) {
            if (numBox.Text == "0" || isLabeling || label.Text.IndexOf('=') > -1) {
                numBox.Clear();
                //label.Text = "";
            }
            if (numBox.Text.Length != 16) {
                numBox.Text += (sender as Button).Text;
            }
            isLabeling = false;
        }

        private void buttonPointClick(object sender, EventArgs e) {
            if (isLabeling) {
                numBox.Text = "0";
            }
            if (numBox.Text.IndexOf('.') == -1 && numBox.Text.Length != 16) {
                numBox.Text += '.';
            }
            isLabeling = false;
        }

        private void buttonCEClick(object sender, EventArgs e) {
            numBox.Text = "0";
            if (label.Text.IndexOf('=') > -1) {
                label.Text = "";
            }
            isLabeling = false;
        }

        private void buttonClearClick(object sender, EventArgs e) {
            numBox.Text = "0";
            label.Text = "";
            isLabeling = false;
        }

        private void buttonOpClick(object sender, EventArgs e) {
            if (label.Text.Length == 0 || isLabeling || label.Text.IndexOf('=') > -1) {
                label.Text = numBox.Text + " " + (sender as Button).Text;
                isLabeling = true;
            }
            if (!isLabeling && label.Text.IndexOf('=') == -1) {
                NumberFormatInfo format = new NumberFormatInfo();
                format.NumberGroupSeparator = ",";
                format.NumberDecimalSeparator = ".";
                label.Text = ((Convert.ToDouble((new DataTable().Compute(label.Text + numBox.Text, null)), format)).ToString(format)) + " " + (sender as Button).Text;
                numBox.Text = "0";
            }
        }

        private void buttonEqualsClick(object sender, EventArgs e) {
            if (label.Text.IndexOf('=') == -1) {
                label.Text += " " + numBox.Text;
                NumberFormatInfo format = new NumberFormatInfo();
                format.NumberGroupSeparator = ",";
                format.NumberDecimalSeparator = ".";
                numBox.Text = ((Convert.ToDouble((new DataTable().Compute(label.Text, null)), format)).ToString(format));
                if (numBox.Text == "Infinity" || numBox.Text == "NaN") {
                    numBox.Text = "DIVISION BY ZERO";
                    isLabeling = false;
                }
                label.Text += " =";
            }
            else { 

            }
	    }
            
        private bool isLabeling = false;

        private System.Windows.Forms.TextBox numBox;
        private Button digit7;
        private Button digit8;
        private Button digit9;
        private Button opDiv;
        private Button ctrlCE;
        private Button digit4;
        private Button digit5;
        private Button digit6;
        private Button opMult;
        private Button ctrlClear;
        private Button digit1;
        private Button digit2;
        private Button digit3;
        private Button opSub;
        private Button digit0;
        private Button charPoint;
        private Button opAdd;
        private Button ctrlEquals;
        private Label label;
    }
}

