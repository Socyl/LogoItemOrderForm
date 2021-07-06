
namespace LogoItemOrderForm
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
            this.orderNumberLabel = new System.Windows.Forms.Label();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.mugRadioButton = new System.Windows.Forms.RadioButton();
            this.usbRadioButton = new System.Windows.Forms.RadioButton();
            this.textToEngraveLabel = new System.Windows.Forms.Label();
            this.numberOfColorsLabel = new System.Windows.Forms.Label();
            this.numberOfColorsTextBox = new System.Windows.Forms.TextBox();
            this.textToEngraveTextBox = new System.Windows.Forms.TextBox();
            this.logoCheckBox = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNumberLabel
            // 
            this.orderNumberLabel.AutoSize = true;
            this.orderNumberLabel.Location = new System.Drawing.Point(65, 31);
            this.orderNumberLabel.Name = "orderNumberLabel";
            this.orderNumberLabel.Size = new System.Drawing.Size(128, 25);
            this.orderNumberLabel.TabIndex = 0;
            this.orderNumberLabel.Text = "Order Number";
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.AutoSize = true;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(65, 68);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(147, 25);
            this.numberOfItemsLabel.TabIndex = 1;
            this.numberOfItemsLabel.Text = "Number of items";
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.Location = new System.Drawing.Point(220, 28);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(150, 31);
            this.orderNumberTextBox.TabIndex = 2;
            // 
            // numberOfItemsTextBox
            // 
            this.numberOfItemsTextBox.Location = new System.Drawing.Point(220, 65);
            this.numberOfItemsTextBox.Name = "numberOfItemsTextBox";
            this.numberOfItemsTextBox.Size = new System.Drawing.Size(150, 31);
            this.numberOfItemsTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.penRadioButton);
            this.groupBox1.Controls.Add(this.mugRadioButton);
            this.groupBox1.Controls.Add(this.usbRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(220, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Type";
            // 
            // penRadioButton
            // 
            this.penRadioButton.AutoSize = true;
            this.penRadioButton.Location = new System.Drawing.Point(7, 102);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(65, 29);
            this.penRadioButton.TabIndex = 2;
            this.penRadioButton.Text = "Pen";
            this.penRadioButton.UseVisualStyleBackColor = true;
            // 
            // mugRadioButton
            // 
            this.mugRadioButton.AutoSize = true;
            this.mugRadioButton.Checked = true;
            this.mugRadioButton.Location = new System.Drawing.Point(7, 66);
            this.mugRadioButton.Name = "mugRadioButton";
            this.mugRadioButton.Size = new System.Drawing.Size(74, 29);
            this.mugRadioButton.TabIndex = 1;
            this.mugRadioButton.TabStop = true;
            this.mugRadioButton.Text = "Mug";
            this.mugRadioButton.UseVisualStyleBackColor = true;
            // 
            // usbRadioButton
            // 
            this.usbRadioButton.AutoSize = true;
            this.usbRadioButton.Location = new System.Drawing.Point(7, 31);
            this.usbRadioButton.Name = "usbRadioButton";
            this.usbRadioButton.Size = new System.Drawing.Size(69, 29);
            this.usbRadioButton.TabIndex = 0;
            this.usbRadioButton.Text = "USB";
            this.usbRadioButton.UseVisualStyleBackColor = true;
            // 
            // textToEngraveLabel
            // 
            this.textToEngraveLabel.AutoSize = true;
            this.textToEngraveLabel.Location = new System.Drawing.Point(65, 255);
            this.textToEngraveLabel.Name = "textToEngraveLabel";
            this.textToEngraveLabel.Size = new System.Drawing.Size(180, 25);
            this.textToEngraveLabel.TabIndex = 5;
            this.textToEngraveLabel.Text = "Text to engrave/print:";
            // 
            // numberOfColorsLabel
            // 
            this.numberOfColorsLabel.AutoSize = true;
            this.numberOfColorsLabel.Location = new System.Drawing.Point(65, 374);
            this.numberOfColorsLabel.Name = "numberOfColorsLabel";
            this.numberOfColorsLabel.Size = new System.Drawing.Size(152, 25);
            this.numberOfColorsLabel.TabIndex = 6;
            this.numberOfColorsLabel.Text = "Number of colors";
            this.numberOfColorsLabel.Visible = false;
            // 
            // numberOfColorsTextBox
            // 
            this.numberOfColorsTextBox.Location = new System.Drawing.Point(223, 371);
            this.numberOfColorsTextBox.Name = "numberOfColorsTextBox";
            this.numberOfColorsTextBox.Size = new System.Drawing.Size(143, 31);
            this.numberOfColorsTextBox.TabIndex = 7;
            this.numberOfColorsTextBox.Visible = false;
            // 
            // textToEngraveTextBox
            // 
            this.textToEngraveTextBox.Location = new System.Drawing.Point(65, 284);
            this.textToEngraveTextBox.Multiline = true;
            this.textToEngraveTextBox.Name = "textToEngraveTextBox";
            this.textToEngraveTextBox.Size = new System.Drawing.Size(305, 46);
            this.textToEngraveTextBox.TabIndex = 8;
            // 
            // logoCheckBox
            // 
            this.logoCheckBox.AutoSize = true;
            this.logoCheckBox.Location = new System.Drawing.Point(227, 337);
            this.logoCheckBox.Name = "logoCheckBox";
            this.logoCheckBox.Size = new System.Drawing.Size(92, 29);
            this.logoCheckBox.TabIndex = 9;
            this.logoCheckBox.Text = "Logo ?";
            this.logoCheckBox.UseVisualStyleBackColor = true;
            this.logoCheckBox.CheckedChanged += new System.EventHandler(this.logoCheckBox_CheckedChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 448);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(112, 34);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(227, 448);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 34);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(65, 527);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(305, 142);
            this.resultTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 730);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.logoCheckBox);
            this.Controls.Add(this.textToEngraveTextBox);
            this.Controls.Add(this.numberOfColorsTextBox);
            this.Controls.Add(this.numberOfColorsLabel);
            this.Controls.Add(this.textToEngraveLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberOfItemsTextBox);
            this.Controls.Add(this.orderNumberTextBox);
            this.Controls.Add(this.numberOfItemsLabel);
            this.Controls.Add(this.orderNumberLabel);
            this.Name = "Form1";
            this.Text = "Logo Item Order Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderNumberLabel;
        private System.Windows.Forms.Label numberOfItemsLabel;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.TextBox numberOfItemsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.RadioButton mugRadioButton;
        private System.Windows.Forms.RadioButton usbRadioButton;
        private System.Windows.Forms.Label textToEngraveLabel;
        private System.Windows.Forms.Label numberOfColorsLabel;
        private System.Windows.Forms.TextBox numberOfColorsTextBox;
        private System.Windows.Forms.TextBox textToEngraveTextBox;
        private System.Windows.Forms.CheckBox logoCheckBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

