using System;
using System.Windows.Forms;

namespace analizador_lexico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(69, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 170);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(432, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 170);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(69, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 170);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(432, 268);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 170);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(474, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expresiones regulares mamalonas";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.CausesValidation = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(162, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Seleccionar archivo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Correr";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Draw);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Coral;
            this.button3.Location = new System.Drawing.Point(349, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "siguiente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Stop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Analizador lexico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button button2;
        private Button button3;
        //variables
        private String dataFile;
        private Boolean stopBucle = false;
        private void button_Stop(object sender, EventArgs e)
        {
            this.stopBucle = false;
        }
        //input para seleccionar un archivo :3 
        private void button_Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((openFileDialog1.OpenFile()) != null)
                    {
                        string path = openFileDialog1.FileName;
                        string[] lines = System.IO.File.ReadAllLines(path);
                        foreach (string line in lines)
                        {
                            // Use a tab to indent each line of the file.
                            this.dataFile += line;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        //Validaciones para procesar la data del archivo
        //CREAR (1,circulo)
        //CREAR(2, triangulo)
        //CREAR(3, circulo))
        //CREAR(4, cuadrado)
        //CRECER(1,50)
        //DECRECER(2, 20)
        //ELIMINAR(3)
        //CREAR(numero de panel, figura)
        //CRECER(numero de panel, tamaño de figura)
        //DECRECER(numero de panel, tamaño de figura)
        //ELIMINAR(numero de panel)
        //figuras: circulo, triangulo, cuadrado
        //tamaño de figura: 1-100
        //numero de panel: 1-4
        //acciones: CREAR, CRECER, DECRECER, ELIMINAR

        //funciones para crear las figuras en los paneles
        private void crearCirculo(int panel, int size)
        {
            System.Drawing.Graphics g = this.Controls["panel" + panel].CreateGraphics();
            g.FillEllipse(System.Drawing.Brushes.Red, 0, 0, size, size);
            // guardamos el nombre de la figura en el panel para poder eliminarla o cambiarla
            this.Controls["panel" + panel].Tag = "circulo";
            
        }

        private void crearTriangulo(int panel, int size)
        {
            System.Drawing.Graphics g = this.Controls["panel" + panel].CreateGraphics();
            System.Drawing.Point[] points = { new System.Drawing.Point(0, 0), new System.Drawing.Point(size, 0), new System.Drawing.Point(size / 2, size) };
            g.FillPolygon(System.Drawing.Brushes.Red, points);
            // guardamos el nombre de la figura en el panel para poder eliminarla o cambiarla
            this.Controls["panel" + panel].Tag = "triangulo";
        }

        private void crearCuadrado(int panel, int size)
        {
            System.Drawing.Graphics g = this.Controls["panel" + panel].CreateGraphics();
            g.FillRectangle(System.Drawing.Brushes.Red, 0, 0, size, size);
            // guardamos el nombre de la figura en el panel para poder eliminarla o cambiarla
            this.Controls["panel" + panel].Tag = "cuadrado";
        }

        //Validaciones para procesar la data del archivo en la variable dataFile
        private void button_Draw(object sender, EventArgs e)
        {
            //Dibujar los paneles segun la info del dataFile
            String[] lines = this.dataFile.Split(';');
            foreach (string line in lines)
            {
                this.stopBucle = true;
                if (line.Contains("CREAR"))
                {
                    //CREAR(1,circulo)
                    //CREAR(2,triangulo)
                    //CREAR(3, circulo))
                    //CREAR(4, cuadrado)
                    String[] data = line.Split(',');
                    String[] data1 = data[0].Split('(');
                    String[] data2 = data[1].Split(')');
                    String[] data3 = data2[0].Split(')');
                    int numPanel = Int32.Parse(data1[1]);
                    int size = 50;
                    if (data3.Length > 1)
                    {
                        size = Int32.Parse(data3[1]);
                    }
                    switch (data3[0])
                    {
                        case "circulo":
                            this.crearCirculo(numPanel, size);
                            break;
                        case "triangulo":
                            this.crearTriangulo(numPanel, size);
                            break;
                        case "cuadrado":
                            this.crearCuadrado(numPanel, size);
                            break;
                        default:
                            break;
                    }
                }
                else if (line.Contains("CRECER"))
                {
                    //CRECER(1,50)
                    String[] data = line.Split(',');
                    String[] data1 = data[0].Split('(');
                    String[] data2 = data[1].Split(')');
                    int numPanel = Int32.Parse(data1[1]);
                    int size = Int32.Parse(data2[0]);
                    //consolear
                    Console.WriteLine("CRECER: " + numPanel + " " + size);
                    //obtener el nombre de la figura
                    String figura = this.Controls["panel" + numPanel].Tag.ToString();
                    //eliminar la figura
                    this.Controls["panel" + numPanel].Refresh();
                    //crear la figura con el nuevo tamaño
                    switch (figura)
                    {
                        case "circulo":
                            this.crearCirculo(numPanel, size);
                            break;
                        case "triangulo":
                            this.crearTriangulo(numPanel, size);
                            break;
                        case "cuadrado":
                            this.crearCuadrado(numPanel, size);
                            break;
                        default:
                            break;
                    }

                }
                else if (line.Contains("DECRECER"))
                {
                    //DECRECER(2, 20)
                    String[] data = line.Split(',');
                    String[] data1 = data[0].Split('(');
                    String[] data2 = data[1].Split(')');
                    int numPanel = Int32.Parse(data1[1]);
                    int size = Int32.Parse(data2[0]);
                    //consolear
                    Console.WriteLine("DECRECER: " + numPanel + " " + size);
                    //obtener el nombre de la figura
                    String figura = this.Controls["panel" + numPanel].Tag.ToString();
                    //limpiar el panel
                    this.Controls["panel" + numPanel].Refresh();
                    //crear la figura con el tamaño nuevo
                    switch (figura)
                    {
                        case "circulo":
                            this.crearCirculo(numPanel, size);
                            break;
                        case "triangulo":
                            this.crearTriangulo(numPanel, size);
                            break;
                        case "cuadrado":
                            this.crearCuadrado(numPanel, size);
                            break;
                        default:
                            break;
                    }
                }
                else if (line.Contains("ELIMINAR"))
                {
                    //ELIMINAR(3)
                    String[] data = line.Split('(');
                    String[] data2 = data[1].Split(')');
                    int numPanel = Int32.Parse(data2[0]);
                    //consolear
                    Console.WriteLine("ELIMINAR: " + numPanel);
                    //limpiar el panel
                    this.Controls["panel" + numPanel].Refresh();
                }
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}




