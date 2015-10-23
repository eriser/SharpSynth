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
            this.ucPianoKeyOctave1 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.ucPianoKeyOctave2 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.ucPianoKeyOctave3 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.ucPianoKeyOctave4 = new SharpSynth.UserInterface.WindowsForms.Controls.ucPianoKeyOctave();
            this.SuspendLayout();
            // 
            // ucPianoKeyOctave1
            // 
            this.ucPianoKeyOctave1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave1.Location = new System.Drawing.Point(0, -1);
            this.ucPianoKeyOctave1.Name = "ucPianoKeyOctave1";
            this.ucPianoKeyOctave1.Octave = ((byte)(0));
            this.ucPianoKeyOctave1.Size = new System.Drawing.Size(260, 167);
            this.ucPianoKeyOctave1.TabIndex = 0;
            // 
            // ucPianoKeyOctave2
            // 
            this.ucPianoKeyOctave2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave2.Location = new System.Drawing.Point(258, -1);
            this.ucPianoKeyOctave2.Name = "ucPianoKeyOctave2";
            this.ucPianoKeyOctave2.Octave = ((byte)(1));
            this.ucPianoKeyOctave2.Size = new System.Drawing.Size(260, 167);
            this.ucPianoKeyOctave2.TabIndex = 1;
            // 
            // ucPianoKeyOctave3
            // 
            this.ucPianoKeyOctave3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave3.Location = new System.Drawing.Point(516, -1);
            this.ucPianoKeyOctave3.Name = "ucPianoKeyOctave3";
            this.ucPianoKeyOctave3.Octave = ((byte)(2));
            this.ucPianoKeyOctave3.Size = new System.Drawing.Size(260, 167);
            this.ucPianoKeyOctave3.TabIndex = 2;
            // 
            // ucPianoKeyOctave4
            // 
            this.ucPianoKeyOctave4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPianoKeyOctave4.Location = new System.Drawing.Point(774, -1);
            this.ucPianoKeyOctave4.Name = "ucPianoKeyOctave4";
            this.ucPianoKeyOctave4.Octave = ((byte)(3));
            this.ucPianoKeyOctave4.Size = new System.Drawing.Size(260, 167);
            this.ucPianoKeyOctave4.TabIndex = 3;
            // 
            // ucPianoKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPianoKeyOctave4);
            this.Controls.Add(this.ucPianoKeyOctave3);
            this.Controls.Add(this.ucPianoKeyOctave2);
            this.Controls.Add(this.ucPianoKeyOctave1);
            this.Name = "ucPianoKeys";
            this.Size = new System.Drawing.Size(1036, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private ucPianoKeyOctave ucPianoKeyOctave1;
        private ucPianoKeyOctave ucPianoKeyOctave2;
        private ucPianoKeyOctave ucPianoKeyOctave3;
        private ucPianoKeyOctave ucPianoKeyOctave4;
    }
}
