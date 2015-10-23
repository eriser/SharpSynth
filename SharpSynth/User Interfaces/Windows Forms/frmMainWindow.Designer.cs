namespace SharpSynth.UserInterface.WindowsForms
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbOscillatorOne = new System.Windows.Forms.GroupBox();
            this.lblOscOneWaveshape = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ucPianoKeys1 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeys();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbOscillatorOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(911, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 252);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbOscillatorOne);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbOscillatorOne
            // 
            this.gbOscillatorOne.Controls.Add(this.comboBox1);
            this.gbOscillatorOne.Controls.Add(this.lblOscOneWaveshape);
            this.gbOscillatorOne.Location = new System.Drawing.Point(6, 6);
            this.gbOscillatorOne.Name = "gbOscillatorOne";
            this.gbOscillatorOne.Size = new System.Drawing.Size(891, 146);
            this.gbOscillatorOne.TabIndex = 0;
            this.gbOscillatorOne.TabStop = false;
            this.gbOscillatorOne.Text = "Oscillator 1";
            // 
            // lblOscOneWaveshape
            // 
            this.lblOscOneWaveshape.AutoSize = true;
            this.lblOscOneWaveshape.Location = new System.Drawing.Point(6, 22);
            this.lblOscOneWaveshape.Name = "lblOscOneWaveshape";
            this.lblOscOneWaveshape.Size = new System.Drawing.Size(68, 13);
            this.lblOscOneWaveshape.TabIndex = 0;
            this.lblOscOneWaveshape.Text = "Waveshape:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sine",
            "Triangle",
            "Saw",
            "Square",
            "Pulse",
            "Noise"});
            this.comboBox1.Location = new System.Drawing.Point(97, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // ucPianoKeys1
            // 
            this.ucPianoKeys1.Location = new System.Drawing.Point(0, 366);
            this.ucPianoKeys1.Name = "ucPianoKeys1";
            this.ucPianoKeys1.Size = new System.Drawing.Size(911, 138);
            this.ucPianoKeys1.TabIndex = 2;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 529);
            this.Controls.Add(this.ucPianoKeys1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMainWindow";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbOscillatorOne.ResumeLayout(false);
            this.gbOscillatorOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbOscillatorOne;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblOscOneWaveshape;
        private Controls.ucPianoKeys ucPianoKeys1;

    }
}

