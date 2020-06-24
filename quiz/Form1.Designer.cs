namespace quiz
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.pozostalyCzas = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeft = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.minusRight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.multiplyLeft = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.multiplyRight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.divide = new System.Windows.Forms.Label();
            this.divideLeft = new System.Windows.Forms.Label();
            this.divideRight = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.roznica = new System.Windows.Forms.NumericUpDown();
            this.pomnozone = new System.Windows.Forms.NumericUpDown();
            this.iloraz = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roznica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomnozone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(108, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // pozostalyCzas
            // 
            this.pozostalyCzas.AutoSize = true;
            this.pozostalyCzas.Location = new System.Drawing.Point(21, 17);
            this.pozostalyCzas.Name = "pozostalyCzas";
            this.pozostalyCzas.Size = new System.Drawing.Size(81, 13);
            this.pozostalyCzas.TabIndex = 1;
            this.pozostalyCzas.Text = "pozostały czas:";
            // 
            // plusLeft
            // 
            this.plusLeft.AutoSize = true;
            this.plusLeft.Location = new System.Drawing.Point(62, 44);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(13, 13);
            this.plusLeft.TabIndex = 2;
            this.plusLeft.Text = "?";
            // 
            // plusRight
            // 
            this.plusRight.AutoSize = true;
            this.plusRight.Location = new System.Drawing.Point(100, 44);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(13, 13);
            this.plusRight.TabIndex = 3;
            this.plusRight.Text = "?";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Location = new System.Drawing.Point(81, 44);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(13, 13);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(139, 42);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 20);
            this.sum.TabIndex = 6;
            // 
            // minusLeft
            // 
            this.minusLeft.AutoSize = true;
            this.minusLeft.Location = new System.Drawing.Point(62, 70);
            this.minusLeft.Name = "minusLeft";
            this.minusLeft.Size = new System.Drawing.Size(13, 13);
            this.minusLeft.TabIndex = 7;
            this.minusLeft.Text = "?";
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.Location = new System.Drawing.Point(84, 70);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(10, 13);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            // 
            // minusRight
            // 
            this.minusRight.AutoSize = true;
            this.minusRight.Location = new System.Drawing.Point(100, 70);
            this.minusRight.Name = "minusRight";
            this.minusRight.Size = new System.Drawing.Size(13, 13);
            this.minusRight.TabIndex = 9;
            this.minusRight.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            // 
            // multiplyLeft
            // 
            this.multiplyLeft.AutoSize = true;
            this.multiplyLeft.Location = new System.Drawing.Point(62, 97);
            this.multiplyLeft.Name = "multiplyLeft";
            this.multiplyLeft.Size = new System.Drawing.Size(13, 13);
            this.multiplyLeft.TabIndex = 11;
            this.multiplyLeft.Text = "?";
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Location = new System.Drawing.Point(84, 97);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(11, 13);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // multiplyRight
            // 
            this.multiplyRight.AutoSize = true;
            this.multiplyRight.Location = new System.Drawing.Point(101, 97);
            this.multiplyRight.Name = "multiplyRight";
            this.multiplyRight.Size = new System.Drawing.Size(13, 13);
            this.multiplyRight.TabIndex = 13;
            this.multiplyRight.Text = "?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "=";
            // 
            // divide
            // 
            this.divide.AutoSize = true;
            this.divide.Location = new System.Drawing.Point(83, 123);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(12, 13);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            // 
            // divideLeft
            // 
            this.divideLeft.AutoSize = true;
            this.divideLeft.Location = new System.Drawing.Point(62, 123);
            this.divideLeft.Name = "divideLeft";
            this.divideLeft.Size = new System.Drawing.Size(13, 13);
            this.divideLeft.TabIndex = 17;
            this.divideLeft.Text = "?";
            // 
            // divideRight
            // 
            this.divideRight.AutoSize = true;
            this.divideRight.Location = new System.Drawing.Point(101, 123);
            this.divideRight.Name = "divideRight";
            this.divideRight.Size = new System.Drawing.Size(13, 13);
            this.divideRight.TabIndex = 18;
            this.divideRight.Text = "?";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "=";
            // 
            // roznica
            // 
            this.roznica.Location = new System.Drawing.Point(139, 68);
            this.roznica.Name = "roznica";
            this.roznica.Size = new System.Drawing.Size(120, 20);
            this.roznica.TabIndex = 20;
            // 
            // pomnozone
            // 
            this.pomnozone.Location = new System.Drawing.Point(139, 95);
            this.pomnozone.Name = "pomnozone";
            this.pomnozone.Size = new System.Drawing.Size(120, 20);
            this.pomnozone.TabIndex = 21;
            // 
            // iloraz
            // 
            this.iloraz.Location = new System.Drawing.Point(139, 121);
            this.iloraz.Name = "iloraz";
            this.iloraz.Size = new System.Drawing.Size(120, 20);
            this.iloraz.TabIndex = 22;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(108, 147);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 23;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 224);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.iloraz);
            this.Controls.Add(this.pomnozone);
            this.Controls.Add(this.roznica);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.divideRight);
            this.Controls.Add(this.divideLeft);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.multiplyRight);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.multiplyLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusRight);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.minusLeft);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.pozostalyCzas);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roznica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pomnozone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label pozostalyCzas;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeft;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label minusRight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label multiplyLeft;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label multiplyRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label divide;
        private System.Windows.Forms.Label divideLeft;
        private System.Windows.Forms.Label divideRight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown roznica;
        private System.Windows.Forms.NumericUpDown pomnozone;
        private System.Windows.Forms.NumericUpDown iloraz;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

