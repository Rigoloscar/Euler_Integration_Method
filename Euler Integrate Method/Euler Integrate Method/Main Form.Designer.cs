namespace Euler_Integrate_Method
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FunctionTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComputeBtn = new System.Windows.Forms.Button();
            this.trackBarH = new System.Windows.Forms.TrackBar();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.trackBarP = new System.Windows.Forms.TrackBar();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.panelP = new System.Windows.Forms.Panel();
            this.panelC = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 41);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(520, 397);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // FunctionTxb
            // 
            this.FunctionTxb.Location = new System.Drawing.Point(551, 74);
            this.FunctionTxb.Multiline = true;
            this.FunctionTxb.Name = "FunctionTxb";
            this.FunctionTxb.Size = new System.Drawing.Size(237, 97);
            this.FunctionTxb.TabIndex = 2;
            this.FunctionTxb.Text = "Ex: 1/X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Function to be integrated";
            // 
            // ComputeBtn
            // 
            this.ComputeBtn.Location = new System.Drawing.Point(652, 389);
            this.ComputeBtn.Name = "ComputeBtn";
            this.ComputeBtn.Size = new System.Drawing.Size(136, 49);
            this.ComputeBtn.TabIndex = 4;
            this.ComputeBtn.Text = "Compute";
            this.ComputeBtn.UseVisualStyleBackColor = true;
            this.ComputeBtn.Click += new System.EventHandler(this.ComputeBtn_Click);
            // 
            // trackBarH
            // 
            this.trackBarH.Location = new System.Drawing.Point(551, 208);
            this.trackBarH.Maximum = 100;
            this.trackBarH.Minimum = 1;
            this.trackBarH.Name = "trackBarH";
            this.trackBarH.Size = new System.Drawing.Size(183, 45);
            this.trackBarH.TabIndex = 5;
            this.trackBarH.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarH.Value = 50;
            this.trackBarH.Scroll += new System.EventHandler(this.trackBarH_Scroll);
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(740, 208);
            this.textBoxH.Multiline = true;
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(48, 20);
            this.textBoxH.TabIndex = 6;
            // 
            // trackBarP
            // 
            this.trackBarP.Location = new System.Drawing.Point(551, 272);
            this.trackBarP.Maximum = 1000;
            this.trackBarP.Minimum = 1;
            this.trackBarP.Name = "trackBarP";
            this.trackBarP.Size = new System.Drawing.Size(183, 45);
            this.trackBarP.TabIndex = 7;
            this.trackBarP.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarP.Value = 500;
            this.trackBarP.Scroll += new System.EventHandler(this.trackBarP_Scroll);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(740, 272);
            this.textBoxP.Multiline = true;
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(48, 20);
            this.textBoxP.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precision";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of points";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Location = new System.Drawing.Point(551, 316);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(182, 17);
            this.checkBoxE.TabIndex = 12;
            this.checkBoxE.Text = "Aproximated points of the integral";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(551, 355);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(181, 17);
            this.checkBoxC.TabIndex = 13;
            this.checkBoxC.Text = "Aproximated curve of the integral";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // panelP
            // 
            this.panelP.Location = new System.Drawing.Point(771, 316);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(17, 17);
            this.panelP.TabIndex = 14;
            this.panelP.Click += new System.EventHandler(this.panelP_Click);
            // 
            // panelC
            // 
            this.panelC.Location = new System.Drawing.Point(771, 355);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(17, 17);
            this.panelC.TabIndex = 16;
            this.panelC.Click += new System.EventHandler(this.panelC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "X start";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(551, 418);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(32, 20);
            this.textBoxX.TabIndex = 19;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(592, 418);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(32, 20);
            this.textBoxY.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Col:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Col:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelC);
            this.Controls.Add(this.panelP);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.trackBarP);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.trackBarH);
            this.Controls.Add(this.ComputeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FunctionTxb);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarP)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox FunctionTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ComputeBtn;
        private System.Windows.Forms.TrackBar trackBarH;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TrackBar trackBarP;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.Panel panelC;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

