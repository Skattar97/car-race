namespace carrace
{
    partial class maingame
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
            this.label10 = new System.Windows.Forms.Label();
            this.rbJack = new System.Windows.Forms.RadioButton();
            this.rbSam = new System.Windows.Forms.RadioButton();
            this.rbJess = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betbtn = new System.Windows.Forms.Button();
            this.betplaceud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Racerud = new System.Windows.Forms.NumericUpDown();
            this.Gobtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.JackLabel = new System.Windows.Forms.Label();
            this.SamLabel = new System.Windows.Forms.Label();
            this.JessLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car4 = new System.Windows.Forms.PictureBox();
            this.car3 = new System.Windows.Forms.PictureBox();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.racePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.betplaceud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racerud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePB)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 403);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 47);
            this.label10.TabIndex = 5;
            this.label10.Text = "Place Your Bets";
            // 
            // rbJack
            // 
            this.rbJack.AutoSize = true;
            this.rbJack.Checked = true;
            this.rbJack.Location = new System.Drawing.Point(9, 476);
            this.rbJack.Name = "rbJack";
            this.rbJack.Size = new System.Drawing.Size(51, 17);
            this.rbJack.TabIndex = 6;
            this.rbJack.TabStop = true;
            this.rbJack.Text = "JACK";
            this.rbJack.UseVisualStyleBackColor = true;
            // 
            // rbSam
            // 
            this.rbSam.AutoSize = true;
            this.rbSam.Location = new System.Drawing.Point(9, 503);
            this.rbSam.Name = "rbSam";
            this.rbSam.Size = new System.Drawing.Size(48, 17);
            this.rbSam.TabIndex = 7;
            this.rbSam.TabStop = true;
            this.rbSam.Text = "SAM";
            this.rbSam.UseVisualStyleBackColor = true;
            this.rbSam.CheckedChanged += new System.EventHandler(this.rbSam_CheckedChanged);
            // 
            // rbJess
            // 
            this.rbJess.AutoSize = true;
            this.rbJess.Location = new System.Drawing.Point(9, 527);
            this.rbJess.Name = "rbJess";
            this.rbJess.Size = new System.Drawing.Size(51, 17);
            this.rbJess.TabIndex = 8;
            this.rbJess.TabStop = true;
            this.rbJess.Text = "JESS";
            this.rbJess.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Location = new System.Drawing.Point(12, 453);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(91, 13);
            this.minimumBetLabel.TabIndex = 9;
            this.minimumBetLabel.Text = "Minimum bet is 1$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "name";
            // 
            // betbtn
            // 
            this.betbtn.Location = new System.Drawing.Point(74, 579);
            this.betbtn.Name = "betbtn";
            this.betbtn.Size = new System.Drawing.Size(46, 20);
            this.betbtn.TabIndex = 11;
            this.betbtn.Text = "Bets";
            this.betbtn.UseVisualStyleBackColor = true;
            this.betbtn.Click += new System.EventHandler(this.beterbtn_Click);
            // 
            // betplaceud
            // 
            this.betplaceud.Location = new System.Drawing.Point(137, 580);
            this.betplaceud.Name = "betplaceud";
            this.betplaceud.Size = new System.Drawing.Size(43, 20);
            this.betplaceud.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 570);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "$ on car no";
            // 
            // Racerud
            // 
            this.Racerud.Location = new System.Drawing.Point(333, 577);
            this.Racerud.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Racerud.Name = "Racerud";
            this.Racerud.Size = new System.Drawing.Size(41, 20);
            this.Racerud.TabIndex = 14;
            this.Racerud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Gobtn
            // 
            this.Gobtn.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gobtn.Location = new System.Drawing.Point(798, 495);
            this.Gobtn.Name = "Gobtn";
            this.Gobtn.Size = new System.Drawing.Size(153, 95);
            this.Gobtn.TabIndex = 15;
            this.Gobtn.Text = "Go";
            this.Gobtn.UseVisualStyleBackColor = true;
            this.Gobtn.Click += new System.EventHandler(this.Racerbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(306, 409);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Bets That are Places";
            // 
            // JackLabel
            // 
            this.JackLabel.AutoSize = true;
            this.JackLabel.Location = new System.Drawing.Point(309, 466);
            this.JackLabel.Name = "JackLabel";
            this.JackLabel.Size = new System.Drawing.Size(33, 13);
            this.JackLabel.TabIndex = 17;
            this.JackLabel.Text = "JACK";
            // 
            // SamLabel
            // 
            this.SamLabel.AutoSize = true;
            this.SamLabel.Location = new System.Drawing.Point(517, 466);
            this.SamLabel.Name = "SamLabel";
            this.SamLabel.Size = new System.Drawing.Size(30, 13);
            this.SamLabel.TabIndex = 18;
            this.SamLabel.Text = "SAM";
            // 
            // JessLabel
            // 
            this.JessLabel.AutoSize = true;
            this.JessLabel.Location = new System.Drawing.Point(309, 527);
            this.JessLabel.Name = "JessLabel";
            this.JessLabel.Size = new System.Drawing.Size(33, 13);
            this.JessLabel.TabIndex = 19;
            this.JessLabel.Text = "JESS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car4
            // 
            this.car4.Image = global::CarRace.Properties.Resources._104_1048996_2d_race_cars_formula_one_car_png;
            this.car4.Location = new System.Drawing.Point(15, 320);
            this.car4.Name = "car4";
            this.car4.Size = new System.Drawing.Size(87, 54);
            this.car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car4.TabIndex = 4;
            this.car4.TabStop = false;
            // 
            // car3
            // 
            this.car3.Image = global::CarRace.Properties.Resources._104_1048996_2d_race_cars_formula_one_car_png;
            this.car3.Location = new System.Drawing.Point(15, 213);
            this.car3.Name = "car3";
            this.car3.Size = new System.Drawing.Size(87, 54);
            this.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car3.TabIndex = 3;
            this.car3.TabStop = false;
            // 
            // car2
            // 
            this.car2.Image = global::CarRace.Properties.Resources._104_1048996_2d_race_cars_formula_one_car_png;
            this.car2.Location = new System.Drawing.Point(15, 119);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(87, 54);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car2.TabIndex = 2;
            this.car2.TabStop = false;
            // 
            // car1
            // 
            this.car1.Image = global::CarRace.Properties.Resources._104_1048996_2d_race_cars_formula_one_car_png;
            this.car1.Location = new System.Drawing.Point(15, 22);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(87, 54);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car1.TabIndex = 1;
            this.car1.TabStop = false;
            // 
            // racePB
            // 
            this.racePB.Image = global::CarRace.Properties.Resources.road;
            this.racePB.Location = new System.Drawing.Point(9, 12);
            this.racePB.Name = "racePB";
            this.racePB.Size = new System.Drawing.Size(968, 384);
            this.racePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racePB.TabIndex = 0;
            this.racePB.TabStop = false;
            // 
            // maingame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(989, 618);
            this.Controls.Add(this.JessLabel);
            this.Controls.Add(this.SamLabel);
            this.Controls.Add(this.JackLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Gobtn);
            this.Controls.Add(this.Racerud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.betplaceud);
            this.Controls.Add(this.betbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.rbJess);
            this.Controls.Add(this.rbSam);
            this.Controls.Add(this.rbJack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.car4);
            this.Controls.Add(this.car3);
            this.Controls.Add(this.car2);
            this.Controls.Add(this.car1);
            this.Controls.Add(this.racePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "maingame";
            this.Text = "Car Race";
            ((System.ComponentModel.ISupportInitialize)(this.betplaceud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racerud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racePB;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.PictureBox car2;
        private System.Windows.Forms.PictureBox car3;
        private System.Windows.Forms.PictureBox car4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbJack;
        private System.Windows.Forms.RadioButton rbSam;
        private System.Windows.Forms.RadioButton rbJess;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button betbtn;
        private System.Windows.Forms.NumericUpDown betplaceud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Racerud;
        private System.Windows.Forms.Button Gobtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label JackLabel;
        private System.Windows.Forms.Label SamLabel;
        private System.Windows.Forms.Label JessLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

