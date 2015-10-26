namespace SharpSynth.UserInterface.WindowsForms.Controls
{
    partial class ucPianoKeys
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ucPianoKeyOctave1 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.ucPianoKeyOctave2 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.ucPianoKeyOctave3 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.ucPianoKeyOctave1);
            this.pnlContainer.Controls.Add(this.ucPianoKeyOctave2);
            this.pnlContainer.Controls.Add(this.ucPianoKeyOctave3);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(820, 168);
            this.pnlContainer.TabIndex = 4;
            // 
            // ucPianoKeyOctave1
            // 
            this.ucPianoKeyOctave1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave1.Location = new System.Drawing.Point(0, 0);
            this.ucPianoKeyOctave1.Name = "ucPianoKeyOctave1";
            this.ucPianoKeyOctave1.Octave = ((byte)(0));
            this.ucPianoKeyOctave1.Size = new System.Drawing.Size(274, 167);
            this.ucPianoKeyOctave1.TabIndex = 0;
            // 
            // ucPianoKeyOctave2
            // 
            this.ucPianoKeyOctave2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave2.Location = new System.Drawing.Point(273, -1);
            this.ucPianoKeyOctave2.Name = "ucPianoKeyOctave2";
            this.ucPianoKeyOctave2.Octave = ((byte)(1));
            this.ucPianoKeyOctave2.Size = new System.Drawing.Size(274, 167);
            this.ucPianoKeyOctave2.TabIndex = 1;
            // 
            // ucPianoKeyOctave3
            // 
            this.ucPianoKeyOctave3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave3.Location = new System.Drawing.Point(546, 0);
            this.ucPianoKeyOctave3.Name = "ucPianoKeyOctave3";
            this.ucPianoKeyOctave3.Octave = ((byte)(2));
            this.ucPianoKeyOctave3.Size = new System.Drawing.Size(276, 167);
            this.ucPianoKeyOctave3.TabIndex = 2;
            // 
            // ucPianoKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "ucPianoKeys";
            this.Size = new System.Drawing.Size(820, 168);
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ucPianoKeyOctave ucPianoKeyOctave1;
        private ucPianoKeyOctave ucPianoKeyOctave2;
        private ucPianoKeyOctave ucPianoKeyOctave3;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
