namespace Proyecto_Herencia3
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            error1 = new ErrorProvider(components);
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(81, 222);
            button1.Name = "button1";
            button1.Size = new Size(103, 21);
            button1.TabIndex = 0;
            button1.Text = "Guardar Datos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 115);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(190, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(538, 193);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 26);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre Miembro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 73);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 7;
            label2.Text = "Año De Publicación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 123);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de Salida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 176);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 9;
            label4.Text = "Titulo Del Libro";
            // 
            // button2
            // 
            button2.Location = new Point(483, 222);
            button2.Name = "button2";
            button2.Size = new Size(209, 23);
            button2.TabIndex = 10;
            button2.Text = "Generar Fecha de Entrega";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 168);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 11;
            label5.Text = "Fecha De Entrega";
            // 
            // button3
            // 
            button3.Location = new Point(288, 296);
            button3.Name = "button3";
            button3.Size = new Size(209, 23);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(538, 133);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 115);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Día De Entrega";
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // button4
            // 
            button4.Location = new Point(190, 222);
            button4.Name = "button4";
            button4.Size = new Size(100, 23);
            button4.TabIndex = 15;
            button4.Text = "Nuevo Libro";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Label label5;
        private Button button3;
        private TextBox textBox6;
        private Label label6;
        private ErrorProvider error1;
        private Button button4;
    }
}
