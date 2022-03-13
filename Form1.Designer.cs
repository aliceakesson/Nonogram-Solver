
namespace Nonogram_Solver
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
            this.components = new System.ComponentModel.Container();
            this.programTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_pickDifficulty = new System.Windows.Forms.Panel();
            this.btn_easy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_medium = new System.Windows.Forms.Button();
            this.btn_expert = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.panel_Easy = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Medium = new System.Windows.Forms.Panel();
            this.tbox_Medium_20 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_19 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_18 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_17 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_16 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_15 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_14 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_13 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_12 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_11 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_10 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_9 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_8 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_7 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_6 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_5 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_4 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_3 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_2 = new System.Windows.Forms.TextBox();
            this.tbox_Medium_1 = new System.Windows.Forms.TextBox();
            this.panel_Medium_grid = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Medium_Solve = new System.Windows.Forms.Button();
            this.panel_pickDifficulty.SuspendLayout();
            this.panel_Easy.SuspendLayout();
            this.panel_Medium.SuspendLayout();
            this.SuspendLayout();
            // 
            // programTimer
            // 
            this.programTimer.Enabled = true;
            this.programTimer.Tick += new System.EventHandler(this.programTimer_Tick);
            // 
            // panel_pickDifficulty
            // 
            this.panel_pickDifficulty.Controls.Add(this.btn_easy);
            this.panel_pickDifficulty.Controls.Add(this.label1);
            this.panel_pickDifficulty.Controls.Add(this.btn_medium);
            this.panel_pickDifficulty.Controls.Add(this.btn_expert);
            this.panel_pickDifficulty.Controls.Add(this.btn_hard);
            this.panel_pickDifficulty.Location = new System.Drawing.Point(706, 672);
            this.panel_pickDifficulty.Name = "panel_pickDifficulty";
            this.panel_pickDifficulty.Size = new System.Drawing.Size(600, 600);
            this.panel_pickDifficulty.TabIndex = 1;
            // 
            // btn_easy
            // 
            this.btn_easy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(227)))));
            this.btn_easy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_easy.ForeColor = System.Drawing.Color.White;
            this.btn_easy.Location = new System.Drawing.Point(50, 243);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(215, 51);
            this.btn_easy.TabIndex = 1;
            this.btn_easy.Text = "Easy";
            this.btn_easy.UseVisualStyleBackColor = false;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick the Difficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_medium
            // 
            this.btn_medium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(227)))));
            this.btn_medium.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medium.ForeColor = System.Drawing.Color.White;
            this.btn_medium.Location = new System.Drawing.Point(329, 243);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(215, 51);
            this.btn_medium.TabIndex = 5;
            this.btn_medium.Text = "Medium";
            this.btn_medium.UseVisualStyleBackColor = false;
            this.btn_medium.Click += new System.EventHandler(this.btn_medium_Click);
            // 
            // btn_expert
            // 
            this.btn_expert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(227)))));
            this.btn_expert.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expert.ForeColor = System.Drawing.Color.White;
            this.btn_expert.Location = new System.Drawing.Point(329, 325);
            this.btn_expert.Name = "btn_expert";
            this.btn_expert.Size = new System.Drawing.Size(215, 51);
            this.btn_expert.TabIndex = 4;
            this.btn_expert.Text = "Expert";
            this.btn_expert.UseVisualStyleBackColor = false;
            this.btn_expert.Click += new System.EventHandler(this.btn_expert_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(227)))));
            this.btn_hard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hard.ForeColor = System.Drawing.Color.White;
            this.btn_hard.Location = new System.Drawing.Point(50, 325);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(215, 51);
            this.btn_hard.TabIndex = 3;
            this.btn_hard.Text = "Hard";
            this.btn_hard.UseVisualStyleBackColor = false;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // panel_Easy
            // 
            this.panel_Easy.Controls.Add(this.label2);
            this.panel_Easy.Location = new System.Drawing.Point(728, 31);
            this.panel_Easy.Name = "panel_Easy";
            this.panel_Easy.Size = new System.Drawing.Size(600, 600);
            this.panel_Easy.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(597, 100);
            this.label2.TabIndex = 7;
            this.label2.Text = "Easy";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel_Medium
            // 
            this.panel_Medium.Controls.Add(this.tbox_Medium_20);
            this.panel_Medium.Controls.Add(this.tbox_Medium_19);
            this.panel_Medium.Controls.Add(this.tbox_Medium_18);
            this.panel_Medium.Controls.Add(this.tbox_Medium_17);
            this.panel_Medium.Controls.Add(this.tbox_Medium_16);
            this.panel_Medium.Controls.Add(this.tbox_Medium_15);
            this.panel_Medium.Controls.Add(this.tbox_Medium_14);
            this.panel_Medium.Controls.Add(this.tbox_Medium_13);
            this.panel_Medium.Controls.Add(this.tbox_Medium_12);
            this.panel_Medium.Controls.Add(this.tbox_Medium_11);
            this.panel_Medium.Controls.Add(this.tbox_Medium_10);
            this.panel_Medium.Controls.Add(this.tbox_Medium_9);
            this.panel_Medium.Controls.Add(this.tbox_Medium_8);
            this.panel_Medium.Controls.Add(this.tbox_Medium_7);
            this.panel_Medium.Controls.Add(this.tbox_Medium_6);
            this.panel_Medium.Controls.Add(this.tbox_Medium_5);
            this.panel_Medium.Controls.Add(this.tbox_Medium_4);
            this.panel_Medium.Controls.Add(this.tbox_Medium_3);
            this.panel_Medium.Controls.Add(this.tbox_Medium_2);
            this.panel_Medium.Controls.Add(this.tbox_Medium_1);
            this.panel_Medium.Controls.Add(this.panel_Medium_grid);
            this.panel_Medium.Controls.Add(this.label3);
            this.panel_Medium.Location = new System.Drawing.Point(89, 69);
            this.panel_Medium.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Medium.Name = "panel_Medium";
            this.panel_Medium.Size = new System.Drawing.Size(600, 600);
            this.panel_Medium.TabIndex = 8;
            // 
            // tbox_Medium_20
            // 
            this.tbox_Medium_20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_20.Location = new System.Drawing.Point(26, 552);
            this.tbox_Medium_20.MaxLength = 100;
            this.tbox_Medium_20.Multiline = true;
            this.tbox_Medium_20.Name = "tbox_Medium_20";
            this.tbox_Medium_20.Size = new System.Drawing.Size(100, 37);
            this.tbox_Medium_20.TabIndex = 27;
            this.tbox_Medium_20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_19
            // 
            this.tbox_Medium_19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_19.Location = new System.Drawing.Point(25, 512);
            this.tbox_Medium_19.MaxLength = 100;
            this.tbox_Medium_19.Multiline = true;
            this.tbox_Medium_19.Name = "tbox_Medium_19";
            this.tbox_Medium_19.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_19.TabIndex = 26;
            this.tbox_Medium_19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_18
            // 
            this.tbox_Medium_18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_18.Location = new System.Drawing.Point(25, 472);
            this.tbox_Medium_18.MaxLength = 100;
            this.tbox_Medium_18.Multiline = true;
            this.tbox_Medium_18.Name = "tbox_Medium_18";
            this.tbox_Medium_18.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_18.TabIndex = 25;
            this.tbox_Medium_18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_17
            // 
            this.tbox_Medium_17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_17.Location = new System.Drawing.Point(26, 432);
            this.tbox_Medium_17.MaxLength = 100;
            this.tbox_Medium_17.Multiline = true;
            this.tbox_Medium_17.Name = "tbox_Medium_17";
            this.tbox_Medium_17.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_17.TabIndex = 24;
            this.tbox_Medium_17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_16
            // 
            this.tbox_Medium_16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_16.Location = new System.Drawing.Point(25, 392);
            this.tbox_Medium_16.MaxLength = 100;
            this.tbox_Medium_16.Multiline = true;
            this.tbox_Medium_16.Name = "tbox_Medium_16";
            this.tbox_Medium_16.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_16.TabIndex = 23;
            this.tbox_Medium_16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_15
            // 
            this.tbox_Medium_15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_15.Location = new System.Drawing.Point(25, 352);
            this.tbox_Medium_15.MaxLength = 100;
            this.tbox_Medium_15.Multiline = true;
            this.tbox_Medium_15.Name = "tbox_Medium_15";
            this.tbox_Medium_15.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_15.TabIndex = 22;
            this.tbox_Medium_15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_14
            // 
            this.tbox_Medium_14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_14.Location = new System.Drawing.Point(26, 312);
            this.tbox_Medium_14.MaxLength = 100;
            this.tbox_Medium_14.Multiline = true;
            this.tbox_Medium_14.Name = "tbox_Medium_14";
            this.tbox_Medium_14.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_14.TabIndex = 21;
            this.tbox_Medium_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_13
            // 
            this.tbox_Medium_13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_13.Location = new System.Drawing.Point(25, 272);
            this.tbox_Medium_13.MaxLength = 100;
            this.tbox_Medium_13.Multiline = true;
            this.tbox_Medium_13.Name = "tbox_Medium_13";
            this.tbox_Medium_13.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_13.TabIndex = 20;
            this.tbox_Medium_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_12
            // 
            this.tbox_Medium_12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_12.Location = new System.Drawing.Point(25, 232);
            this.tbox_Medium_12.MaxLength = 100;
            this.tbox_Medium_12.Multiline = true;
            this.tbox_Medium_12.Name = "tbox_Medium_12";
            this.tbox_Medium_12.Size = new System.Drawing.Size(100, 34);
            this.tbox_Medium_12.TabIndex = 19;
            this.tbox_Medium_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_Medium_12.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // tbox_Medium_11
            // 
            this.tbox_Medium_11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_11.Location = new System.Drawing.Point(26, 189);
            this.tbox_Medium_11.MaxLength = 100;
            this.tbox_Medium_11.Multiline = true;
            this.tbox_Medium_11.Name = "tbox_Medium_11";
            this.tbox_Medium_11.Size = new System.Drawing.Size(100, 37);
            this.tbox_Medium_11.TabIndex = 18;
            this.tbox_Medium_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Medium_10
            // 
            this.tbox_Medium_10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_10.Location = new System.Drawing.Point(495, 84);
            this.tbox_Medium_10.MaxLength = 100;
            this.tbox_Medium_10.Multiline = true;
            this.tbox_Medium_10.Name = "tbox_Medium_10";
            this.tbox_Medium_10.Size = new System.Drawing.Size(37, 100);
            this.tbox_Medium_10.TabIndex = 17;
            this.tbox_Medium_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_9
            // 
            this.tbox_Medium_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_9.Location = new System.Drawing.Point(455, 84);
            this.tbox_Medium_9.MaxLength = 100;
            this.tbox_Medium_9.Multiline = true;
            this.tbox_Medium_9.Name = "tbox_Medium_9";
            this.tbox_Medium_9.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_9.TabIndex = 16;
            this.tbox_Medium_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_8
            // 
            this.tbox_Medium_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_8.Location = new System.Drawing.Point(415, 83);
            this.tbox_Medium_8.MaxLength = 100;
            this.tbox_Medium_8.Multiline = true;
            this.tbox_Medium_8.Name = "tbox_Medium_8";
            this.tbox_Medium_8.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_8.TabIndex = 15;
            this.tbox_Medium_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_7
            // 
            this.tbox_Medium_7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_7.Location = new System.Drawing.Point(375, 84);
            this.tbox_Medium_7.MaxLength = 100;
            this.tbox_Medium_7.Multiline = true;
            this.tbox_Medium_7.Name = "tbox_Medium_7";
            this.tbox_Medium_7.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_7.TabIndex = 14;
            this.tbox_Medium_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_6
            // 
            this.tbox_Medium_6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_6.Location = new System.Drawing.Point(335, 83);
            this.tbox_Medium_6.MaxLength = 100;
            this.tbox_Medium_6.Multiline = true;
            this.tbox_Medium_6.Name = "tbox_Medium_6";
            this.tbox_Medium_6.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_6.TabIndex = 13;
            this.tbox_Medium_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_5
            // 
            this.tbox_Medium_5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_5.Location = new System.Drawing.Point(295, 83);
            this.tbox_Medium_5.MaxLength = 100;
            this.tbox_Medium_5.Multiline = true;
            this.tbox_Medium_5.Name = "tbox_Medium_5";
            this.tbox_Medium_5.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_5.TabIndex = 12;
            this.tbox_Medium_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_4
            // 
            this.tbox_Medium_4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_4.Location = new System.Drawing.Point(255, 84);
            this.tbox_Medium_4.MaxLength = 100;
            this.tbox_Medium_4.Multiline = true;
            this.tbox_Medium_4.Name = "tbox_Medium_4";
            this.tbox_Medium_4.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_4.TabIndex = 11;
            this.tbox_Medium_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_3
            // 
            this.tbox_Medium_3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_3.Location = new System.Drawing.Point(215, 83);
            this.tbox_Medium_3.MaxLength = 100;
            this.tbox_Medium_3.Multiline = true;
            this.tbox_Medium_3.Name = "tbox_Medium_3";
            this.tbox_Medium_3.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_3.TabIndex = 10;
            this.tbox_Medium_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_2
            // 
            this.tbox_Medium_2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_2.Location = new System.Drawing.Point(175, 83);
            this.tbox_Medium_2.MaxLength = 100;
            this.tbox_Medium_2.Multiline = true;
            this.tbox_Medium_2.Name = "tbox_Medium_2";
            this.tbox_Medium_2.Size = new System.Drawing.Size(34, 100);
            this.tbox_Medium_2.TabIndex = 9;
            this.tbox_Medium_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbox_Medium_1
            // 
            this.tbox_Medium_1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_Medium_1.Location = new System.Drawing.Point(132, 83);
            this.tbox_Medium_1.MaxLength = 100;
            this.tbox_Medium_1.Multiline = true;
            this.tbox_Medium_1.Name = "tbox_Medium_1";
            this.tbox_Medium_1.Size = new System.Drawing.Size(37, 100);
            this.tbox_Medium_1.TabIndex = 0;
            this.tbox_Medium_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Medium_1.TextChanged += new System.EventHandler(this.tbox_Medium_1_TextChanged);
            // 
            // panel_Medium_grid
            // 
            this.panel_Medium_grid.Location = new System.Drawing.Point(132, 189);
            this.panel_Medium_grid.Name = "panel_Medium_grid";
            this.panel_Medium_grid.Size = new System.Drawing.Size(400, 400);
            this.panel_Medium_grid.TabIndex = 8;
            this.panel_Medium_grid.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint_Medium_Grid);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, -20);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(597, 100);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medium";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Medium_Solve
            // 
            this.btn_Medium_Solve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(122)))), ((int)(((byte)(227)))));
            this.btn_Medium_Solve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Medium_Solve.ForeColor = System.Drawing.Color.White;
            this.btn_Medium_Solve.Location = new System.Drawing.Point(329, 672);
            this.btn_Medium_Solve.Name = "btn_Medium_Solve";
            this.btn_Medium_Solve.Size = new System.Drawing.Size(117, 51);
            this.btn_Medium_Solve.TabIndex = 2;
            this.btn_Medium_Solve.Text = "Solve";
            this.btn_Medium_Solve.UseVisualStyleBackColor = false;
            this.btn_Medium_Solve.Click += new System.EventHandler(this.solvePuzzle);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.btn_Medium_Solve);
            this.Controls.Add(this.panel_Medium);
            this.Controls.Add(this.panel_pickDifficulty);
            this.Controls.Add(this.panel_Easy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_pickDifficulty.ResumeLayout(false);
            this.panel_Easy.ResumeLayout(false);
            this.panel_Medium.ResumeLayout(false);
            this.panel_Medium.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer programTimer;
        private System.Windows.Forms.Panel panel_pickDifficulty;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_medium;
        private System.Windows.Forms.Button btn_expert;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Panel panel_Easy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Medium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_Medium_grid;
        private System.Windows.Forms.TextBox tbox_Medium_1;
        private System.Windows.Forms.TextBox tbox_Medium_2;
        private System.Windows.Forms.TextBox tbox_Medium_10;
        private System.Windows.Forms.TextBox tbox_Medium_9;
        private System.Windows.Forms.TextBox tbox_Medium_8;
        private System.Windows.Forms.TextBox tbox_Medium_7;
        private System.Windows.Forms.TextBox tbox_Medium_6;
        private System.Windows.Forms.TextBox tbox_Medium_5;
        private System.Windows.Forms.TextBox tbox_Medium_4;
        private System.Windows.Forms.TextBox tbox_Medium_3;
        private System.Windows.Forms.TextBox tbox_Medium_12;
        private System.Windows.Forms.TextBox tbox_Medium_11;
        private System.Windows.Forms.TextBox tbox_Medium_20;
        private System.Windows.Forms.TextBox tbox_Medium_19;
        private System.Windows.Forms.TextBox tbox_Medium_18;
        private System.Windows.Forms.TextBox tbox_Medium_17;
        private System.Windows.Forms.TextBox tbox_Medium_16;
        private System.Windows.Forms.TextBox tbox_Medium_15;
        private System.Windows.Forms.TextBox tbox_Medium_14;
        private System.Windows.Forms.TextBox tbox_Medium_13;
        private System.Windows.Forms.Button btn_Medium_Solve;
    }
}

