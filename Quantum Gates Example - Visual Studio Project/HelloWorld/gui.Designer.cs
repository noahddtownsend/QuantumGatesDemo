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
            this.RunGateSim = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.quantumDropDown = new System.Windows.Forms.ComboBox();
            this.quantumRadioButton = new System.Windows.Forms.RadioButton();
            this.classicalRadioButton = new System.Windows.Forms.RadioButton();
            this.classicalDropDown = new System.Windows.Forms.ComboBox();
            this.firstBit = new System.Windows.Forms.Button();
            this.secondBit = new System.Windows.Forms.Button();
            this.outputBit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunGateSim
            // 
            this.RunGateSim.Location = new System.Drawing.Point(713, 415);
            this.RunGateSim.Name = "RunGateSim";
            this.RunGateSim.Size = new System.Drawing.Size(75, 23);
            this.RunGateSim.TabIndex = 0;
            this.RunGateSim.Text = "Evaluate";
            this.RunGateSim.UseVisualStyleBackColor = true;
            this.RunGateSim.Click += new System.EventHandler(this.runSimClick);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(381, 415);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "Result";
            // 
            // quantumDropDown
            // 
            this.quantumDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quantumDropDown.FormattingEnabled = true;
            this.quantumDropDown.Items.AddRange(new object[] {
            "Hadamard",
            "Quantum NOT",
            "CNOT"});
            this.quantumDropDown.Location = new System.Drawing.Point(104, 14);
            this.quantumDropDown.Name = "quantumDropDown";
            this.quantumDropDown.Size = new System.Drawing.Size(121, 21);
            this.quantumDropDown.TabIndex = 2;
            this.quantumDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // quantumRadioButton
            // 
            this.quantumRadioButton.AutoSize = true;
            this.quantumRadioButton.Checked = true;
            this.quantumRadioButton.Location = new System.Drawing.Point(30, 15);
            this.quantumRadioButton.Name = "quantumRadioButton";
            this.quantumRadioButton.Size = new System.Drawing.Size(68, 17);
            this.quantumRadioButton.TabIndex = 3;
            this.quantumRadioButton.TabStop = true;
            this.quantumRadioButton.Text = "Quantum";
            this.quantumRadioButton.UseVisualStyleBackColor = true;
            this.quantumRadioButton.CheckedChanged += new System.EventHandler(this.quantumRadioButton_CheckedChanged);
            // 
            // classicalRadioButton
            // 
            this.classicalRadioButton.AutoSize = true;
            this.classicalRadioButton.Location = new System.Drawing.Point(30, 38);
            this.classicalRadioButton.Name = "classicalRadioButton";
            this.classicalRadioButton.Size = new System.Drawing.Size(66, 17);
            this.classicalRadioButton.TabIndex = 4;
            this.classicalRadioButton.Text = "Classical";
            this.classicalRadioButton.UseVisualStyleBackColor = true;
            this.classicalRadioButton.CheckedChanged += new System.EventHandler(this.classicalRadioButton_CheckedChanged);
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
            this.classicalDropDown.TabIndex = 5;
            // 
            // firstBit
            // 
            this.firstBit.ForeColor = System.Drawing.Color.White;
            this.firstBit.Location = new System.Drawing.Point(30, 112);
            this.firstBit.Name = "firstBit";
            this.firstBit.Size = new System.Drawing.Size(70, 70);
            this.firstBit.TabIndex = 8;
            this.firstBit.UseVisualStyleBackColor = true;
            this.firstBit.Click += new System.EventHandler(this.firstBit_Click);
            // 
            // secondBit
            // 
            this.secondBit.ForeColor = System.Drawing.Color.White;
            this.secondBit.Location = new System.Drawing.Point(30, 201);
            this.secondBit.Name = "secondBit";
            this.secondBit.Size = new System.Drawing.Size(70, 70);
            this.secondBit.TabIndex = 9;
            this.secondBit.UseVisualStyleBackColor = true;
            this.secondBit.Click += new System.EventHandler(this.secondBit_Click);
            // 
            // outputBit
            // 
            this.outputBit.ForeColor = System.Drawing.Color.White;
            this.outputBit.Location = new System.Drawing.Point(713, 160);
            this.outputBit.Name = "outputBit";
            this.outputBit.Size = new System.Drawing.Size(70, 70);
            this.outputBit.TabIndex = 10;
            this.outputBit.UseVisualStyleBackColor = true;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputBit);
            this.Controls.Add(this.secondBit);
            this.Controls.Add(this.firstBit);
            this.Controls.Add(this.classicalDropDown);
            this.Controls.Add(this.classicalRadioButton);
            this.Controls.Add(this.quantumRadioButton);
            this.Controls.Add(this.quantumDropDown);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.RunGateSim);
            this.Name = "Gui";
            this.Text = "Main";
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
        private System.Windows.Forms.Button firstBit;
        private System.Windows.Forms.Button secondBit;
        private System.Windows.Forms.Button outputBit;
    }
}