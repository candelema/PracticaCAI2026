namespace PracticaCAI2026.Enunciado_5_ElectroPlus
{
    partial class RegistroReclamo
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            label7 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 10F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 19);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestión de Reclamos - ElectroPlus";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(503, 111);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 29);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre Completo:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 64);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "DNI:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 23);
            textBox1.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(134, 61);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(132, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(503, 143);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 102);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 0;
            label4.Text = "¿En Garantía?:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 70);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 1;
            label5.Text = "Modelo/Serie:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 38);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 2;
            label6.Text = "Tipo de Producto:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(134, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 23);
            textBox2.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(546, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 274);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Falla";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 29);
            label7.Name = "label7";
            label7.Size = new Size(232, 15);
            label7.TabIndex = 0;
            label7.Text = "Descripción del Problema según el Cliente:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(29, 56);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 195);
            textBox3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 337);
            button1.Name = "button1";
            button1.Size = new Size(172, 23);
            button1.TabIndex = 4;
            button1.Text = "Ver Factura de Compra";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(812, 377);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(670, 377);
            button3.Name = "button3";
            button3.Size = new Size(122, 23);
            button3.TabIndex = 6;
            button3.Text = "Registrar Reclamo";
            button3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(136, 100);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Si";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(176, 100);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // _1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 410);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "_1";
            Text = "ElectroPlus - Registro de Reclamo Postventa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}