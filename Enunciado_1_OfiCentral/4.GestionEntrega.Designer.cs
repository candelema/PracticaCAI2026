namespace PracticaCAI2026
{
    partial class GestionEntrega
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
            Materiales = new CheckedListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 28);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Insumos a Entregar:";
            // 
            // Materiales
            // 
            Materiales.FormattingEnabled = true;
            Materiales.Location = new Point(18, 46);
            Materiales.Name = "Materiales";
            Materiales.Size = new Size(340, 166);
            Materiales.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(180, 269);
            button1.Name = "button1";
            button1.Size = new Size(178, 23);
            button1.TabIndex = 2;
            button1.Text = "Registrar Salida de Depósito";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Materiales);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 308);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Depósito";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 326);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(379, 188);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 221);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 3;
            label2.Text = "Ubicación en estante:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 218);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 100);
            label3.Name = "label3";
            label3.Size = new Size(128, 15);
            label3.TabIndex = 0;
            label3.Text = "Firma de conformidad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 23);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 42);
            label4.Name = "label4";
            label4.Size = new Size(156, 15);
            label4.TabIndex = 2;
            label4.Text = "Estado del material recibido:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 23);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(221, 148);
            button2.Name = "button2";
            button2.Size = new Size(137, 23);
            button2.TabIndex = 4;
            button2.Text = "Confirmar Recepción";
            button2.UseVisualStyleBackColor = true;
            // 
            // GestionEntrega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 536);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "GestionEntrega";
            Text = "OfiCentral S.A. - Entrega y Recepción de Materiales";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private CheckedListBox Materiales;
        private Button button1;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Button button2;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
    }
}