namespace Morse
{
    partial class Form1
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rbnEncode = new System.Windows.Forms.RadioButton();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.rbnDecode = new System.Windows.Forms.RadioButton();
            this.grbTypes = new System.Windows.Forms.GroupBox();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            this.grbTypes.SuspendLayout();
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtInput);
            this.grbInput.Location = new System.Drawing.Point(12, 12);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(1053, 420);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(6, 25);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1040, 389);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // rbnEncode
            // 
            this.rbnEncode.AutoSize = true;
            this.rbnEncode.Checked = true;
            this.rbnEncode.Location = new System.Drawing.Point(6, 25);
            this.rbnEncode.Name = "rbnEncode";
            this.rbnEncode.Size = new System.Drawing.Size(169, 24);
            this.rbnEncode.TabIndex = 1;
            this.rbnEncode.TabStop = true;
            this.rbnEncode.Text = "Text to Morse code";
            this.rbnEncode.UseVisualStyleBackColor = true;
            this.rbnEncode.CheckedChanged += new System.EventHandler(this.rbnEncode_CheckedChanged_1);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.txtOutput);
            this.grbOutput.Location = new System.Drawing.Point(12, 438);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(1053, 404);
            this.grbOutput.TabIndex = 2;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(7, 25);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(1040, 373);
            this.txtOutput.TabIndex = 1;
            // 
            // rbnDecode
            // 
            this.rbnDecode.AutoSize = true;
            this.rbnDecode.Location = new System.Drawing.Point(6, 55);
            this.rbnDecode.Name = "rbnDecode";
            this.rbnDecode.Size = new System.Drawing.Size(172, 24);
            this.rbnDecode.TabIndex = 3;
            this.rbnDecode.TabStop = true;
            this.rbnDecode.Text = "Morse Code to Text";
            this.rbnDecode.UseVisualStyleBackColor = true;
            // 
            // grbTypes
            // 
            this.grbTypes.Controls.Add(this.rbnEncode);
            this.grbTypes.Controls.Add(this.rbnDecode);
            this.grbTypes.Location = new System.Drawing.Point(218, 25);
            this.grbTypes.Name = "grbTypes";
            this.grbTypes.Size = new System.Drawing.Size(188, 89);
            this.grbTypes.TabIndex = 4;
            this.grbTypes.TabStop = false;
            this.grbTypes.Text = "Encode or Decode";
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnCopy);
            this.grbOptions.Controls.Add(this.btnPlay);
            this.grbOptions.Controls.Add(this.grbTypes);
            this.grbOptions.Location = new System.Drawing.Point(1071, 12);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(414, 830);
            this.grbOptions.TabIndex = 5;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 36);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(206, 78);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play Morse Code Audio";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(6, 120);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(206, 78);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy Output to Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1501, 853);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Name = "Form1";
            this.Text = "Morse Code Translator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.grbTypes.ResumeLayout(false);
            this.grbTypes.PerformLayout();
            this.grbOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rbnEncode;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.RadioButton rbnDecode;
        private System.Windows.Forms.GroupBox grbTypes;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnCopy;
    }
}

