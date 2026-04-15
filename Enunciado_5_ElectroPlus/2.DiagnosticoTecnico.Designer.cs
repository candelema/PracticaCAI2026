namespace PracticaCAI2026.Enunciado_5_ElectroPlus
{
    partial class DiagnosticoTecnico
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label7 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 33);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Orden de Servicio N°:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 73);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Equipo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 30);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 70);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(26, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 261);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informe del Técnico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 32);
            label3.Name = "label3";
            label3.Size = new Size(178, 15);
            label3.TabIndex = 0;
            label3.Text = "Diagnóstico detallado de la falla:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 50);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(704, 153);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 223);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 2;
            label4.Text = "Tipo de Reparación:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(137, 220);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 23);
            comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 407);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 4;
            label5.Text = "¿Requiere Repuestos?:";
            label5.Click += label5_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(222, 405);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(34, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Si";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(262, 405);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 444);
            label6.Name = "label6";
            label6.Size = new Size(190, 15);
            label6.TabIndex = 7;
            label6.Text = "Horas de mano de obra estimadas:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(222, 442);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 486);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 9;
            label7.Text = "Nivel de prioridad:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(222, 483);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 23);
            comboBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(713, 522);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(504, 522);
            button2.Name = "button2";
            button2.Size = new Size(190, 23);
            button2.TabIndex = 11;
            button2.Text = "Enviar Informe al Supervisor";
            button2.UseVisualStyleBackColor = true;
            // 
            // DiagnosticoTecnico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 557);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DiagnosticoTecnico";
            Text = "ElectroPlus - Área Técnica - Diagnóstico";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label3;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label7;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
    }
}