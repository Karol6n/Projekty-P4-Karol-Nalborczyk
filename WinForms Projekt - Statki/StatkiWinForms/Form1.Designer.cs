﻿
namespace StatkiWinForms
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
            this.txtGracz = new System.Windows.Forms.Label();
            this.txtPrzeciwnik = new System.Windows.Forms.Label();
            this.txtRundy = new System.Windows.Forms.Label();
            this.RuchPrzeciwnika = new System.Windows.Forms.Label();
            this.txtPomoc = new System.Windows.Forms.Label();
            this.PolaLokalizacjiWroga = new System.Windows.Forms.ComboBox();
            this.btnAtak = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.LicznikCzasuGryPrzeciwnika = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtGracz
            // 
            this.txtGracz.AutoSize = true;
            this.txtGracz.BackColor = System.Drawing.Color.Transparent;
            this.txtGracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtGracz.ForeColor = System.Drawing.Color.White;
            this.txtGracz.Location = new System.Drawing.Point(342, 110);
            this.txtGracz.Name = "txtGracz";
            this.txtGracz.Size = new System.Drawing.Size(38, 25);
            this.txtGracz.TabIndex = 0;
            this.txtGracz.Text = "00";
            // 
            // txtPrzeciwnik
            // 
            this.txtPrzeciwnik.AutoSize = true;
            this.txtPrzeciwnik.BackColor = System.Drawing.Color.Transparent;
            this.txtPrzeciwnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrzeciwnik.ForeColor = System.Drawing.Color.White;
            this.txtPrzeciwnik.Location = new System.Drawing.Point(997, 110);
            this.txtPrzeciwnik.Name = "txtPrzeciwnik";
            this.txtPrzeciwnik.Size = new System.Drawing.Size(38, 25);
            this.txtPrzeciwnik.TabIndex = 0;
            this.txtPrzeciwnik.Text = "00";
            // 
            // txtRundy
            // 
            this.txtRundy.AutoSize = true;
            this.txtRundy.BackColor = System.Drawing.Color.Transparent;
            this.txtRundy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRundy.ForeColor = System.Drawing.Color.White;
            this.txtRundy.Location = new System.Drawing.Point(474, 172);
            this.txtRundy.Name = "txtRundy";
            this.txtRundy.Size = new System.Drawing.Size(120, 25);
            this.txtRundy.TabIndex = 0;
            this.txtRundy.Text = "Runda: 10";
            // 
            // RuchPrzeciwnika
            // 
            this.RuchPrzeciwnika.AutoSize = true;
            this.RuchPrzeciwnika.BackColor = System.Drawing.Color.Transparent;
            this.RuchPrzeciwnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RuchPrzeciwnika.ForeColor = System.Drawing.Color.White;
            this.RuchPrzeciwnika.Location = new System.Drawing.Point(898, 34);
            this.RuchPrzeciwnika.Name = "RuchPrzeciwnika";
            this.RuchPrzeciwnika.Size = new System.Drawing.Size(43, 29);
            this.RuchPrzeciwnika.TabIndex = 0;
            this.RuchPrzeciwnika.Text = "A1";
            // 
            // txtPomoc
            // 
            this.txtPomoc.AutoSize = true;
            this.txtPomoc.BackColor = System.Drawing.Color.Transparent;
            this.txtPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPomoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPomoc.Location = new System.Drawing.Point(95, 545);
            this.txtPomoc.Name = "txtPomoc";
            this.txtPomoc.Size = new System.Drawing.Size(324, 20);
            this.txtPomoc.TabIndex = 0;
            this.txtPomoc.Text = "1) Naciśnij na 3 różne pola żeby zacząć";
            // 
            // PolaLokalizacjiWroga
            // 
            this.PolaLokalizacjiWroga.BackColor = System.Drawing.Color.PaleGreen;
            this.PolaLokalizacjiWroga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PolaLokalizacjiWroga.DropDownWidth = 95;
            this.PolaLokalizacjiWroga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PolaLokalizacjiWroga.FormattingEnabled = true;
            this.PolaLokalizacjiWroga.Location = new System.Drawing.Point(177, 30);
            this.PolaLokalizacjiWroga.Name = "PolaLokalizacjiWroga";
            this.PolaLokalizacjiWroga.Size = new System.Drawing.Size(104, 33);
            this.PolaLokalizacjiWroga.TabIndex = 1;
            this.PolaLokalizacjiWroga.SelectedIndexChanged += new System.EventHandler(this.PolaLokalizacjiWroga_SelectedIndexChanged);
            // 
            // btnAtak
            // 
            this.btnAtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAtak.Location = new System.Drawing.Point(296, 23);
            this.btnAtak.Name = "btnAtak";
            this.btnAtak.Size = new System.Drawing.Size(74, 42);
            this.btnAtak.TabIndex = 2;
            this.btnAtak.Text = "Atakuj";
            this.btnAtak.UseVisualStyleBackColor = true;
            this.btnAtak.Click += new System.EventHandler(this.PrzyciskAtakujEvent);
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.White;
            this.a2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a2.Location = new System.Drawing.Point(691, 224);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(86, 70);
            this.a2.TabIndex = 2;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = false;
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.White;
            this.a3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a3.Location = new System.Drawing.Point(784, 224);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(86, 70);
            this.a3.TabIndex = 2;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = false;
            // 
            // a4
            // 
            this.a4.BackColor = System.Drawing.Color.White;
            this.a4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a4.Location = new System.Drawing.Point(876, 224);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(86, 70);
            this.a4.TabIndex = 2;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(599, 301);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(86, 70);
            this.b1.TabIndex = 2;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = false;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(691, 301);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(86, 70);
            this.b2.TabIndex = 2;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = false;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(784, 301);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(86, 70);
            this.b3.TabIndex = 2;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = false;
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(876, 301);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(86, 70);
            this.b4.TabIndex = 2;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = false;
            // 
            // c1
            // 
            this.c1.BackColor = System.Drawing.Color.White;
            this.c1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c1.Location = new System.Drawing.Point(599, 378);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(86, 70);
            this.c1.TabIndex = 2;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = false;
            // 
            // c2
            // 
            this.c2.BackColor = System.Drawing.Color.White;
            this.c2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c2.Location = new System.Drawing.Point(691, 378);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(86, 70);
            this.c2.TabIndex = 2;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = false;
            // 
            // c3
            // 
            this.c3.BackColor = System.Drawing.Color.White;
            this.c3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c3.Location = new System.Drawing.Point(784, 378);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(86, 70);
            this.c3.TabIndex = 2;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = false;
            // 
            // c4
            // 
            this.c4.BackColor = System.Drawing.Color.White;
            this.c4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.c4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.c4.Location = new System.Drawing.Point(876, 378);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(86, 70);
            this.c4.TabIndex = 2;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = false;
            // 
            // d1
            // 
            this.d1.BackColor = System.Drawing.Color.White;
            this.d1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d1.Location = new System.Drawing.Point(599, 455);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(86, 70);
            this.d1.TabIndex = 2;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = false;
            // 
            // d2
            // 
            this.d2.BackColor = System.Drawing.Color.White;
            this.d2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d2.Location = new System.Drawing.Point(691, 455);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(86, 70);
            this.d2.TabIndex = 2;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = false;
            // 
            // d3
            // 
            this.d3.BackColor = System.Drawing.Color.White;
            this.d3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d3.Location = new System.Drawing.Point(784, 455);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(86, 70);
            this.d3.TabIndex = 2;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = false;
            // 
            // d4
            // 
            this.d4.BackColor = System.Drawing.Color.White;
            this.d4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.d4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.d4.Location = new System.Drawing.Point(876, 455);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(86, 70);
            this.d4.TabIndex = 2;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = false;
            // 
            // w1
            // 
            this.w1.BackColor = System.Drawing.Color.White;
            this.w1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.w1.Location = new System.Drawing.Point(99, 224);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(86, 70);
            this.w1.TabIndex = 2;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = false;
            this.w1.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.Color.White;
            this.x1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x1.Location = new System.Drawing.Point(99, 301);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(86, 70);
            this.x1.TabIndex = 2;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = false;
            this.x1.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.Color.White;
            this.y1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.y1.Location = new System.Drawing.Point(99, 378);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(86, 70);
            this.y1.TabIndex = 2;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = false;
            this.y1.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.Color.White;
            this.z1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.z1.Location = new System.Drawing.Point(99, 455);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(86, 70);
            this.z1.TabIndex = 2;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = false;
            this.z1.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // w2
            // 
            this.w2.BackColor = System.Drawing.Color.White;
            this.w2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.w2.Location = new System.Drawing.Point(191, 224);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(86, 70);
            this.w2.TabIndex = 2;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = false;
            this.w2.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.Color.White;
            this.x2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x2.Location = new System.Drawing.Point(191, 301);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(86, 70);
            this.x2.TabIndex = 2;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = false;
            this.x2.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.Color.White;
            this.y2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.y2.Location = new System.Drawing.Point(191, 378);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(86, 70);
            this.y2.TabIndex = 2;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = false;
            this.y2.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.Color.White;
            this.z2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.z2.Location = new System.Drawing.Point(191, 455);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(86, 70);
            this.z2.TabIndex = 2;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = false;
            this.z2.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // w3
            // 
            this.w3.BackColor = System.Drawing.Color.White;
            this.w3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.w3.Location = new System.Drawing.Point(284, 224);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(86, 70);
            this.w3.TabIndex = 2;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = false;
            this.w3.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.Color.White;
            this.x3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x3.Location = new System.Drawing.Point(284, 301);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(86, 70);
            this.x3.TabIndex = 2;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = false;
            this.x3.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.Color.White;
            this.y3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.y3.Location = new System.Drawing.Point(284, 378);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(86, 70);
            this.y3.TabIndex = 2;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = false;
            this.y3.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.Color.White;
            this.z3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.z3.Location = new System.Drawing.Point(284, 455);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(86, 70);
            this.z3.TabIndex = 2;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = false;
            this.z3.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // w4
            // 
            this.w4.BackColor = System.Drawing.Color.White;
            this.w4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.w4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.w4.Location = new System.Drawing.Point(376, 224);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(86, 70);
            this.w4.TabIndex = 2;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = false;
            this.w4.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // x4
            // 
            this.x4.BackColor = System.Drawing.Color.White;
            this.x4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.x4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.x4.Location = new System.Drawing.Point(376, 301);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(86, 70);
            this.x4.TabIndex = 2;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = false;
            this.x4.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // y4
            // 
            this.y4.BackColor = System.Drawing.Color.White;
            this.y4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.y4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.y4.Location = new System.Drawing.Point(376, 378);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(86, 70);
            this.y4.TabIndex = 2;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = false;
            this.y4.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // z4
            // 
            this.z4.BackColor = System.Drawing.Color.White;
            this.z4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.z4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.z4.Location = new System.Drawing.Point(376, 455);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(86, 70);
            this.z4.TabIndex = 2;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = false;
            this.z4.Click += new System.EventHandler(this.PrzyciskiPolGraczaEvent);
            // 
            // a1
            // 
            this.a1.BackColor = System.Drawing.Color.White;
            this.a1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.a1.Location = new System.Drawing.Point(599, 225);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(86, 70);
            this.a1.TabIndex = 3;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = false;
            // 
            // LicznikCzasuGryPrzeciwnika
            // 
            this.LicznikCzasuGryPrzeciwnika.Interval = 1000;
            this.LicznikCzasuGryPrzeciwnika.Tick += new System.EventHandler(this.LicznikCzasuGryPrzeciwnikaEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StatkiWinForms.Properties.Resources.tło;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 586);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.btnAtak);
            this.Controls.Add(this.PolaLokalizacjiWroga);
            this.Controls.Add(this.txtPomoc);
            this.Controls.Add(this.txtRundy);
            this.Controls.Add(this.RuchPrzeciwnika);
            this.Controls.Add(this.txtPrzeciwnik);
            this.Controls.Add(this.txtGracz);
            this.Name = "Form1";
            this.Text = "Statki by KN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtGracz;
        private System.Windows.Forms.Label txtPrzeciwnik;
        private System.Windows.Forms.Label txtRundy;
        private System.Windows.Forms.Label RuchPrzeciwnika;
        private System.Windows.Forms.Label txtPomoc;
        private System.Windows.Forms.ComboBox PolaLokalizacjiWroga;
        private System.Windows.Forms.Button btnAtak;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Timer LicznikCzasuGryPrzeciwnika;
    }
}

