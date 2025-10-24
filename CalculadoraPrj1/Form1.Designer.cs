namespace CalculadoraPrj1
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculo = new TextBox();
            ClearEntry = new Button();
            Clear = new Button();
            cuadrado = new Button();
            raiz = new Button();
            division = new Button();
            multiplicacion = new Button();
            resta = new Button();
            suma = new Button();
            igual = new Button();
            siete = new Button();
            cuatro = new Button();
            uno = new Button();
            masmenos = new Button();
            ocho = new Button();
            cinco = new Button();
            dos = new Button();
            cero = new Button();
            nueve = new Button();
            seis = new Button();
            tres = new Button();
            punto = new Button();
            SuspendLayout();
            // 
            // calculo
            // 
            calculo.Font = new Font("Segoe UI Black", 22F, FontStyle.Bold);
            calculo.Location = new Point(-1, -1);
            calculo.Multiline = true;
            calculo.Name = "calculo";
            calculo.Size = new Size(491, 93);
            calculo.TabIndex = 0;
            calculo.TextAlign = HorizontalAlignment.Right;
            calculo.TextChanged += calculo_TextChanged;
            // 
            // ClearEntry
            // 
            ClearEntry.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearEntry.Location = new Point(-1, 91);
            ClearEntry.Name = "ClearEntry";
            ClearEntry.Size = new Size(128, 114);
            ClearEntry.TabIndex = 1;
            ClearEntry.Text = "CE";
            ClearEntry.UseVisualStyleBackColor = true;
            ClearEntry.Click += ClearEntry_Click;
            // 
            // Clear
            // 
            Clear.AutoEllipsis = true;
            Clear.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.Location = new Point(124, 91);
            Clear.Name = "Clear";
            Clear.Size = new Size(128, 114);
            Clear.TabIndex = 2;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // cuadrado
            // 
            cuadrado.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuadrado.Location = new Point(245, 91);
            cuadrado.Name = "cuadrado";
            cuadrado.Size = new Size(128, 114);
            cuadrado.TabIndex = 3;
            cuadrado.Text = "x²";
            cuadrado.UseVisualStyleBackColor = true;
            cuadrado.Click += cuadrado_Click;
            // 
            // raiz
            // 
            raiz.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            raiz.Location = new Point(362, 91);
            raiz.Name = "raiz";
            raiz.Size = new Size(128, 114);
            raiz.TabIndex = 4;
            raiz.Text = "√";
            raiz.UseVisualStyleBackColor = true;
            raiz.Click += raiz_Click;
            // 
            // division
            // 
            division.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            division.Location = new Point(362, 200);
            division.Name = "division";
            division.Size = new Size(128, 114);
            division.TabIndex = 4;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // multiplicacion
            // 
            multiplicacion.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplicacion.Location = new Point(362, 310);
            multiplicacion.Name = "multiplicacion";
            multiplicacion.Size = new Size(128, 114);
            multiplicacion.TabIndex = 4;
            multiplicacion.Text = "*";
            multiplicacion.UseVisualStyleBackColor = true;
            multiplicacion.Click += multiplicacion_Click;
            // 
            // resta
            // 
            resta.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resta.Location = new Point(362, 418);
            resta.Name = "resta";
            resta.Size = new Size(128, 114);
            resta.TabIndex = 4;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = true;
            resta.Click += resta_Click;
            // 
            // suma
            // 
            suma.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            suma.Location = new Point(362, 529);
            suma.Name = "suma";
            suma.Size = new Size(128, 114);
            suma.TabIndex = 4;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = true;
            suma.Click += suma_Click;
            // 
            // igual
            // 
            igual.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            igual.Location = new Point(-1, 634);
            igual.Name = "igual";
            igual.Size = new Size(491, 114);
            igual.TabIndex = 4;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = true;
            igual.Click += igual_Click;
            // 
            // siete
            // 
            siete.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siete.Location = new Point(-1, 200);
            siete.Name = "siete";
            siete.Size = new Size(128, 114);
            siete.TabIndex = 1;
            siete.Text = "7";
            siete.UseVisualStyleBackColor = true;
            siete.Click += siete_Click;
            // 
            // cuatro
            // 
            cuatro.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuatro.Location = new Point(-1, 310);
            cuatro.Name = "cuatro";
            cuatro.Size = new Size(128, 114);
            cuatro.TabIndex = 1;
            cuatro.Text = "4";
            cuatro.UseVisualStyleBackColor = true;
            cuatro.Click += cuatro_Click;
            // 
            // uno
            // 
            uno.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uno.Location = new Point(-1, 418);
            uno.Name = "uno";
            uno.Size = new Size(128, 114);
            uno.TabIndex = 1;
            uno.Text = "1";
            uno.UseVisualStyleBackColor = true;
            uno.Click += uno_Click;
            // 
            // masmenos
            // 
            masmenos.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            masmenos.Location = new Point(-1, 529);
            masmenos.Name = "masmenos";
            masmenos.Size = new Size(128, 114);
            masmenos.TabIndex = 1;
            masmenos.Text = "+/-";
            masmenos.UseVisualStyleBackColor = true;
            masmenos.Click += masmenos_Click;
            // 
            // ocho
            // 
            ocho.AutoEllipsis = true;
            ocho.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ocho.Location = new Point(124, 200);
            ocho.Name = "ocho";
            ocho.Size = new Size(128, 114);
            ocho.TabIndex = 2;
            ocho.Text = "8";
            ocho.UseVisualStyleBackColor = true;
            ocho.Click += ocho_Click;
            // 
            // cinco
            // 
            cinco.AutoEllipsis = true;
            cinco.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cinco.Location = new Point(124, 310);
            cinco.Name = "cinco";
            cinco.Size = new Size(128, 114);
            cinco.TabIndex = 2;
            cinco.Text = "5";
            cinco.UseVisualStyleBackColor = true;
            cinco.Click += cinco_Click;
            // 
            // dos
            // 
            dos.AutoEllipsis = true;
            dos.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dos.Location = new Point(124, 418);
            dos.Name = "dos";
            dos.Size = new Size(128, 114);
            dos.TabIndex = 2;
            dos.Text = "2";
            dos.UseVisualStyleBackColor = true;
            dos.Click += dos_Click;
            // 
            // cero
            // 
            cero.AutoEllipsis = true;
            cero.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cero.Location = new Point(124, 529);
            cero.Name = "cero";
            cero.Size = new Size(128, 114);
            cero.TabIndex = 2;
            cero.Text = "0";
            cero.UseVisualStyleBackColor = true;
            cero.Click += cero_Click;
            // 
            // nueve
            // 
            nueve.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nueve.Location = new Point(245, 200);
            nueve.Name = "nueve";
            nueve.Size = new Size(128, 114);
            nueve.TabIndex = 3;
            nueve.Text = "9";
            nueve.UseVisualStyleBackColor = true;
            nueve.Click += nueve_Click;
            // 
            // seis
            // 
            seis.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seis.Location = new Point(245, 310);
            seis.Name = "seis";
            seis.Size = new Size(128, 114);
            seis.TabIndex = 3;
            seis.Text = "6";
            seis.UseVisualStyleBackColor = true;
            seis.Click += seis_Click;
            // 
            // tres
            // 
            tres.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tres.Location = new Point(245, 418);
            tres.Name = "tres";
            tres.Size = new Size(128, 114);
            tres.TabIndex = 3;
            tres.Text = "3";
            tres.UseVisualStyleBackColor = true;
            tres.Click += tres_Click;
            // 
            // punto
            // 
            punto.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            punto.Location = new Point(245, 529);
            punto.Name = "punto";
            punto.Size = new Size(128, 114);
            punto.TabIndex = 3;
            punto.Text = ".";
            punto.UseVisualStyleBackColor = true;
            punto.Click += punto_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 741);
            Controls.Add(igual);
            Controls.Add(suma);
            Controls.Add(resta);
            Controls.Add(multiplicacion);
            Controls.Add(division);
            Controls.Add(raiz);
            Controls.Add(punto);
            Controls.Add(tres);
            Controls.Add(seis);
            Controls.Add(nueve);
            Controls.Add(cuadrado);
            Controls.Add(cero);
            Controls.Add(dos);
            Controls.Add(cinco);
            Controls.Add(ocho);
            Controls.Add(Clear);
            Controls.Add(masmenos);
            Controls.Add(uno);
            Controls.Add(cuatro);
            Controls.Add(siete);
            Controls.Add(ClearEntry);
            Controls.Add(calculo);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox calculo;
        private Button ClearEntry;
        private Button Clear;
        private Button cuadrado;
        private Button raiz;
        private Button division;
        private Button multiplicacion;
        private Button resta;
        private Button suma;
        private Button igual;
        private Button siete;
        private Button cuatro;
        private Button uno;
        private Button masmenos;
        private Button ocho;
        private Button cinco;
        private Button dos;
        private Button cero;
        private Button nueve;
        private Button seis;
        private Button tres;
        private Button punto;
    }
}
