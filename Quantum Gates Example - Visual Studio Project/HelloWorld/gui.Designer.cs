namespace Quantum.Gates
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.RunGateSim = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.quantumDropDown = new System.Windows.Forms.ComboBox();
            this.quantumRadioButton = new System.Windows.Forms.RadioButton();
            this.classicalRadioButton = new System.Windows.Forms.RadioButton();
            this.classicalDropDown = new System.Windows.Forms.ComboBox();
            this.firstInputBitBtn = new System.Windows.Forms.Button();
            this.secondInputBitBtn = new System.Windows.Forms.Button();
            this.firstOutputBitBtn = new System.Windows.Forms.Button();
            this.gatePictureBox = new System.Windows.Forms.PictureBox();
            this.secondOutputBitBtn = new System.Windows.Forms.Button();
            this.numEvalsInput = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvalsInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunGateSim
            // 
            this.RunGateSim.Location = new System.Drawing.Point(708, 415);
            this.RunGateSim.Name = "RunGateSim";
            this.RunGateSim.Size = new System.Drawing.Size(75, 23);
            this.RunGateSim.TabIndex = 6;
            this.RunGateSim.Text = "Evaluate";
            this.RunGateSim.UseVisualStyleBackColor = true;
            this.RunGateSim.Click += new System.EventHandler(this.RunSimClick);
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(3, -3);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(614, 27);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // quantumDropDown
            // 
            this.quantumDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantumDropDown.FormattingEnabled = true;
            this.quantumDropDown.Items.AddRange(new object[] {
            "Hadamard",
            "NOT",
            "CNOT"});
            this.quantumDropDown.Location = new System.Drawing.Point(104, 14);
            this.quantumDropDown.Name = "quantumDropDown";
            this.quantumDropDown.Size = new System.Drawing.Size(121, 21);
            this.quantumDropDown.TabIndex = 2;
            this.quantumDropDown.SelectedIndexChanged += new System.EventHandler(this.QuantumDropDown_SelectedIndexChanged);
            // 
            // quantumRadioButton
            // 
            this.quantumRadioButton.AutoSize = true;
            this.quantumRadioButton.Checked = true;
            this.quantumRadioButton.Location = new System.Drawing.Point(30, 15);
            this.quantumRadioButton.Name = "quantumRadioButton";
            this.quantumRadioButton.Size = new System.Drawing.Size(68, 17);
            this.quantumRadioButton.TabIndex = 1;
            this.quantumRadioButton.TabStop = true;
            this.quantumRadioButton.Text = "Quantum";
            this.quantumRadioButton.UseVisualStyleBackColor = true;
            this.quantumRadioButton.CheckedChanged += new System.EventHandler(this.QuantumRadioButton_CheckedChanged);
            // 
            // classicalRadioButton
            // 
            this.classicalRadioButton.AutoSize = true;
            this.classicalRadioButton.Location = new System.Drawing.Point(30, 38);
            this.classicalRadioButton.Name = "classicalRadioButton";
            this.classicalRadioButton.Size = new System.Drawing.Size(66, 17);
            this.classicalRadioButton.TabIndex = 3;
            this.classicalRadioButton.Text = "Classical";
            this.classicalRadioButton.UseVisualStyleBackColor = true;
            this.classicalRadioButton.CheckedChanged += new System.EventHandler(this.ClassicalRadioButton_CheckedChanged);
            // 
            // classicalDropDown
            // 
            this.classicalDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classicalDropDown.FormattingEnabled = true;
            this.classicalDropDown.Items.AddRange(new object[] {
            "OR",
            "AND",
            "NOT"});
            this.classicalDropDown.Location = new System.Drawing.Point(104, 41);
            this.classicalDropDown.Name = "classicalDropDown";
            this.classicalDropDown.Size = new System.Drawing.Size(121, 21);
            this.classicalDropDown.TabIndex = 4;
            this.classicalDropDown.SelectedIndexChanged += new System.EventHandler(this.ClassicalDropDown_SelectedIndexChanged);
            // 
            // firstInputBitBtn
            // 
            this.firstInputBitBtn.ForeColor = System.Drawing.Color.White;
            this.firstInputBitBtn.Location = new System.Drawing.Point(30, 112);
            this.firstInputBitBtn.Name = "firstInputBitBtn";
            this.firstInputBitBtn.Size = new System.Drawing.Size(70, 70);
            this.firstInputBitBtn.TabIndex = 7;
            this.firstInputBitBtn.UseVisualStyleBackColor = true;
            this.firstInputBitBtn.Click += new System.EventHandler(this.FirstInputBit_Click);
            // 
            // secondInputBitBtn
            // 
            this.secondInputBitBtn.ForeColor = System.Drawing.Color.White;
            this.secondInputBitBtn.Location = new System.Drawing.Point(30, 201);
            this.secondInputBitBtn.Name = "secondInputBitBtn";
            this.secondInputBitBtn.Size = new System.Drawing.Size(70, 70);
            this.secondInputBitBtn.TabIndex = 8;
            this.secondInputBitBtn.UseVisualStyleBackColor = true;
            this.secondInputBitBtn.Click += new System.EventHandler(this.SecondInputBit_Click);
            // 
            // firstOutputBitBtn
            // 
            this.firstOutputBitBtn.ForeColor = System.Drawing.Color.White;
            this.firstOutputBitBtn.Location = new System.Drawing.Point(713, 112);
            this.firstOutputBitBtn.Name = "firstOutputBitBtn";
            this.firstOutputBitBtn.Size = new System.Drawing.Size(70, 70);
            this.firstOutputBitBtn.TabIndex = 0;
            this.firstOutputBitBtn.UseVisualStyleBackColor = true;
            // 
            // gatePictureBox
            // 
            this.gatePictureBox.Image = global::Quantum.Gates.Properties.Resources.QuantumHadamardGate;
            this.gatePictureBox.Location = new System.Drawing.Point(104, 64);
            this.gatePictureBox.Name = "gatePictureBox";
            this.gatePictureBox.Size = new System.Drawing.Size(603, 262);
            this.gatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gatePictureBox.TabIndex = 11;
            this.gatePictureBox.TabStop = false;
            // 
            // secondOutputBitBtn
            // 
            this.secondOutputBitBtn.ForeColor = System.Drawing.Color.White;
            this.secondOutputBitBtn.Location = new System.Drawing.Point(713, 201);
            this.secondOutputBitBtn.Name = "secondOutputBitBtn";
            this.secondOutputBitBtn.Size = new System.Drawing.Size(70, 70);
            this.secondOutputBitBtn.TabIndex = 0;
            this.secondOutputBitBtn.UseVisualStyleBackColor = true;
            // 
            // numEvalsInput
            // 
            this.numEvalsInput.Location = new System.Drawing.Point(638, 415);
            this.numEvalsInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numEvalsInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEvalsInput.Name = "numEvalsInput";
            this.numEvalsInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numEvalsInput.Size = new System.Drawing.Size(64, 20);
            this.numEvalsInput.TabIndex = 5;
            this.numEvalsInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Location = new System.Drawing.Point(12, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 27);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.descriptionLabel);
            this.panel2.Location = new System.Drawing.Point(104, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 76);
            this.panel2.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(0, -1);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.ReadOnly = true;
            this.descriptionLabel.Size = new System.Drawing.Size(603, 77);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "";
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numEvalsInput);
            this.Controls.Add(this.secondOutputBitBtn);
            this.Controls.Add(this.gatePictureBox);
            this.Controls.Add(this.firstOutputBitBtn);
            this.Controls.Add(this.secondInputBitBtn);
            this.Controls.Add(this.firstInputBitBtn);
            this.Controls.Add(this.classicalDropDown);
            this.Controls.Add(this.classicalRadioButton);
            this.Controls.Add(this.quantumRadioButton);
            this.Controls.Add(this.quantumDropDown);
            this.Controls.Add(this.RunGateSim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantum Gate Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.gatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvalsInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunGateSim;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox quantumDropDown;
        private System.Windows.Forms.RadioButton quantumRadioButton;
        private System.Windows.Forms.RadioButton classicalRadioButton;
        private System.Windows.Forms.ComboBox classicalDropDown;
        private System.Windows.Forms.Button firstInputBitBtn;
        private System.Windows.Forms.Button secondInputBitBtn;
        private System.Windows.Forms.Button firstOutputBitBtn;
        private System.Windows.Forms.PictureBox gatePictureBox;
        private System.Windows.Forms.Button secondOutputBitBtn;
        private System.Windows.Forms.NumericUpDown numEvalsInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox descriptionLabel;
    }
}