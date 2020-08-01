namespace LangtonsAnt
{
    partial class FormAnt
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
            this.components = new System.ComponentModel.Container();
            this.panelAntCanvas = new System.Windows.Forms.Panel();
            this.labIterationCount = new System.Windows.Forms.Label();
            this.btnStartStopAnt = new System.Windows.Forms.Button();
            this.timerAnt = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panelAntCanvas
            // 
            this.panelAntCanvas.Location = new System.Drawing.Point(12, 144);
            this.panelAntCanvas.Name = "panelAntCanvas";
            this.panelAntCanvas.Size = new System.Drawing.Size(1595, 826);
            this.panelAntCanvas.TabIndex = 0;
            this.panelAntCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAntCanvas_Paint);
            // 
            // labIterationCount
            // 
            this.labIterationCount.AutoSize = true;
            this.labIterationCount.Location = new System.Drawing.Point(12, 54);
            this.labIterationCount.Name = "labIterationCount";
            this.labIterationCount.Size = new System.Drawing.Size(163, 32);
            this.labIterationCount.TabIndex = 1;
            this.labIterationCount.Text = "Iterations: 0";
            // 
            // btnStartStopAnt
            // 
            this.btnStartStopAnt.Location = new System.Drawing.Point(1360, 35);
            this.btnStartStopAnt.Name = "btnStartStopAnt";
            this.btnStartStopAnt.Size = new System.Drawing.Size(238, 69);
            this.btnStartStopAnt.TabIndex = 2;
            this.btnStartStopAnt.Text = "Start Ant";
            this.btnStartStopAnt.UseVisualStyleBackColor = true;
            this.btnStartStopAnt.Click += new System.EventHandler(this.btnStartStopAnt_Click);
            // 
            // timerAnt
            // 
            this.timerAnt.Interval = 250;
            this.timerAnt.Tick += new System.EventHandler(this.timerAnt_Tick);
            // 
            // FormAnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 982);
            this.Controls.Add(this.btnStartStopAnt);
            this.Controls.Add(this.labIterationCount);
            this.Controls.Add(this.panelAntCanvas);
            this.Name = "FormAnt";
            this.Text = "Langtons Ant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAntCanvas;
        private System.Windows.Forms.Label labIterationCount;
        private System.Windows.Forms.Button btnStartStopAnt;
        private System.Windows.Forms.Timer timerAnt;
    }
}

