namespace Game_Of_Life
{
    partial class MainWindow
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.largestLB = new System.Windows.Forms.Label();
            this.stepsLB = new System.Windows.Forms.Label();
            this.aliveLB = new System.Windows.Forms.Label();
            this.authorBT = new System.Windows.Forms.Button();
            this.instruciotnBT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.randomBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.startBT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.defaulBT = new System.Windows.Forms.Button();
            this.toPopulateNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.toAlive_2NUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.toAlive_1NUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.upperDepopulationNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lowerDepopulationNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.delayNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.stepControler = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toPopulateNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toAlive_2NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toAlive_1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepopulationNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerDepopulationNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuPanel.Controls.Add(this.groupBox3);
            this.menuPanel.Controls.Add(this.authorBT);
            this.menuPanel.Controls.Add(this.instruciotnBT);
            this.menuPanel.Controls.Add(this.groupBox1);
            this.menuPanel.Controls.Add(this.groupBox2);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuPanel.Location = new System.Drawing.Point(584, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 599);
            this.menuPanel.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.largestLB);
            this.groupBox3.Controls.Add(this.stepsLB);
            this.groupBox3.Controls.Add(this.aliveLB);
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(3, 467);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // largestLB
            // 
            this.largestLB.AutoSize = true;
            this.largestLB.Location = new System.Drawing.Point(6, 50);
            this.largestLB.Name = "largestLB";
            this.largestLB.Size = new System.Drawing.Size(106, 13);
            this.largestLB.TabIndex = 18;
            this.largestLB.Text = "Largest population: 0";
            // 
            // stepsLB
            // 
            this.stepsLB.AutoSize = true;
            this.stepsLB.Location = new System.Drawing.Point(6, 74);
            this.stepsLB.Name = "stepsLB";
            this.stepsLB.Size = new System.Drawing.Size(71, 13);
            this.stepsLB.TabIndex = 17;
            this.stepsLB.Text = "Total steps: 0";
            // 
            // aliveLB
            // 
            this.aliveLB.AutoSize = true;
            this.aliveLB.Location = new System.Drawing.Point(6, 26);
            this.aliveLB.Name = "aliveLB";
            this.aliveLB.Size = new System.Drawing.Size(74, 13);
            this.aliveLB.TabIndex = 16;
            this.aliveLB.Text = "Alive nodes: 0";
            // 
            // authorBT
            // 
            this.authorBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorBT.ForeColor = System.Drawing.Color.Teal;
            this.authorBT.Location = new System.Drawing.Point(103, 573);
            this.authorBT.Name = "authorBT";
            this.authorBT.Size = new System.Drawing.Size(94, 23);
            this.authorBT.TabIndex = 3;
            this.authorBT.Text = "Author";
            this.authorBT.UseVisualStyleBackColor = true;
            this.authorBT.Click += new System.EventHandler(this.authorBT_Click);
            // 
            // instruciotnBT
            // 
            this.instruciotnBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruciotnBT.ForeColor = System.Drawing.Color.Teal;
            this.instruciotnBT.Location = new System.Drawing.Point(3, 573);
            this.instruciotnBT.Name = "instruciotnBT";
            this.instruciotnBT.Size = new System.Drawing.Size(94, 23);
            this.instruciotnBT.TabIndex = 2;
            this.instruciotnBT.Text = "Instruction";
            this.instruciotnBT.UseVisualStyleBackColor = true;
            this.instruciotnBT.Click += new System.EventHandler(this.instruciotnBT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.randomBT);
            this.groupBox1.Controls.Add(this.resetBT);
            this.groupBox1.Controls.Add(this.stopBT);
            this.groupBox1.Controls.Add(this.startBT);
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(3, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulation control";
            // 
            // randomBT
            // 
            this.randomBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomBT.ForeColor = System.Drawing.Color.Teal;
            this.randomBT.Location = new System.Drawing.Point(18, 112);
            this.randomBT.Name = "randomBT";
            this.randomBT.Size = new System.Drawing.Size(157, 25);
            this.randomBT.TabIndex = 17;
            this.randomBT.Tag = "control";
            this.randomBT.Text = "Random";
            this.randomBT.UseVisualStyleBackColor = true;
            this.randomBT.Click += new System.EventHandler(this.randomBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBT.ForeColor = System.Drawing.Color.Teal;
            this.resetBT.Location = new System.Drawing.Point(18, 81);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(157, 25);
            this.resetBT.TabIndex = 16;
            this.resetBT.Tag = "control";
            this.resetBT.Text = "Reset ";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBT.ForeColor = System.Drawing.Color.Teal;
            this.stopBT.Location = new System.Drawing.Point(18, 50);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(157, 25);
            this.stopBT.TabIndex = 5;
            this.stopBT.Tag = "";
            this.stopBT.Text = "Stop";
            this.stopBT.UseVisualStyleBackColor = true;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // startBT
            // 
            this.startBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBT.ForeColor = System.Drawing.Color.Teal;
            this.startBT.Location = new System.Drawing.Point(18, 19);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(157, 25);
            this.startBT.TabIndex = 4;
            this.startBT.Tag = "control";
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.defaulBT);
            this.groupBox2.Controls.Add(this.toPopulateNUD);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.toAlive_2NUD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.toAlive_1NUD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.upperDepopulationNUD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lowerDepopulationNUD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.delayNUD);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulation settings";
            // 
            // defaulBT
            // 
            this.defaulBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defaulBT.ForeColor = System.Drawing.Color.Teal;
            this.defaulBT.Location = new System.Drawing.Point(21, 267);
            this.defaulBT.Name = "defaulBT";
            this.defaulBT.Size = new System.Drawing.Size(154, 29);
            this.defaulBT.TabIndex = 6;
            this.defaulBT.Tag = "settings";
            this.defaulBT.Text = "Reset default";
            this.defaulBT.UseVisualStyleBackColor = true;
            this.defaulBT.Click += new System.EventHandler(this.defaulBT_Click);
            // 
            // toPopulateNUD
            // 
            this.toPopulateNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toPopulateNUD.ForeColor = System.Drawing.Color.Teal;
            this.toPopulateNUD.Location = new System.Drawing.Point(21, 241);
            this.toPopulateNUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.toPopulateNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toPopulateNUD.Name = "toPopulateNUD";
            this.toPopulateNUD.Size = new System.Drawing.Size(154, 20);
            this.toPopulateNUD.TabIndex = 15;
            this.toPopulateNUD.Tag = "settings";
            this.toPopulateNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Requirement to populate";
            // 
            // toAlive_2NUD
            // 
            this.toAlive_2NUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toAlive_2NUD.ForeColor = System.Drawing.Color.Teal;
            this.toAlive_2NUD.Location = new System.Drawing.Point(21, 202);
            this.toAlive_2NUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.toAlive_2NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toAlive_2NUD.Name = "toAlive_2NUD";
            this.toAlive_2NUD.Size = new System.Drawing.Size(154, 20);
            this.toAlive_2NUD.TabIndex = 13;
            this.toAlive_2NUD.Tag = "settings";
            this.toAlive_2NUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Requirement to stay alive #2";
            // 
            // toAlive_1NUD
            // 
            this.toAlive_1NUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toAlive_1NUD.ForeColor = System.Drawing.Color.Teal;
            this.toAlive_1NUD.Location = new System.Drawing.Point(21, 163);
            this.toAlive_1NUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.toAlive_1NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toAlive_1NUD.Name = "toAlive_1NUD";
            this.toAlive_1NUD.Size = new System.Drawing.Size(154, 20);
            this.toAlive_1NUD.TabIndex = 11;
            this.toAlive_1NUD.Tag = "settings";
            this.toAlive_1NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Requirement to stay alive #1";
            // 
            // upperDepopulationNUD
            // 
            this.upperDepopulationNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.upperDepopulationNUD.ForeColor = System.Drawing.Color.Teal;
            this.upperDepopulationNUD.Location = new System.Drawing.Point(21, 124);
            this.upperDepopulationNUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.upperDepopulationNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upperDepopulationNUD.Name = "upperDepopulationNUD";
            this.upperDepopulationNUD.Size = new System.Drawing.Size(154, 20);
            this.upperDepopulationNUD.TabIndex = 5;
            this.upperDepopulationNUD.Tag = "settings";
            this.upperDepopulationNUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upper requirement for depopulation";
            // 
            // lowerDepopulationNUD
            // 
            this.lowerDepopulationNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lowerDepopulationNUD.ForeColor = System.Drawing.Color.Teal;
            this.lowerDepopulationNUD.Location = new System.Drawing.Point(21, 85);
            this.lowerDepopulationNUD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.lowerDepopulationNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowerDepopulationNUD.Name = "lowerDepopulationNUD";
            this.lowerDepopulationNUD.Size = new System.Drawing.Size(154, 20);
            this.lowerDepopulationNUD.TabIndex = 3;
            this.lowerDepopulationNUD.Tag = "settings";
            this.lowerDepopulationNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lower requirement for depopulation";
            // 
            // delayNUD
            // 
            this.delayNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delayNUD.ForeColor = System.Drawing.Color.Teal;
            this.delayNUD.Location = new System.Drawing.Point(21, 46);
            this.delayNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.delayNUD.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.delayNUD.Name = "delayNUD";
            this.delayNUD.Size = new System.Drawing.Size(154, 20);
            this.delayNUD.TabIndex = 1;
            this.delayNUD.Tag = "settings";
            this.delayNUD.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delay every step";
            // 
            // stepControler
            // 
            this.stepControler.Interval = 1000;
            this.stepControler.Tick += new System.EventHandler(this.stepControler_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(784, 599);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Game Of Life";
            this.menuPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toPopulateNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toAlive_2NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toAlive_1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperDepopulationNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerDepopulationNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button authorBT;
        private System.Windows.Forms.Button instruciotnBT;
        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label largestLB;
        private System.Windows.Forms.Label stepsLB;
        private System.Windows.Forms.Label aliveLB;
        private System.Windows.Forms.NumericUpDown toPopulateNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown toAlive_2NUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown toAlive_1NUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown upperDepopulationNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lowerDepopulationNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown delayNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button defaulBT;
        private System.Windows.Forms.Button stopBT;
        private System.Windows.Forms.Button resetBT;
        private System.Windows.Forms.Timer stepControler;
        private System.Windows.Forms.Button randomBT;
    }
}

