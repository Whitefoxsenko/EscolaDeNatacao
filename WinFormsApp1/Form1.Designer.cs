namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtHorario = new TextBox();
            txtProfessor = new TextBox();
            txtAluno = new TextBox();
            groupBox1 = new GroupBox();
            lblContadorAluno = new Label();
            dtpDataAula = new DateTimePicker();
            button1 = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 165);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Professor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 222);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 109);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Aluno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 285);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Horario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Azure;
            label5.Font = new Font("Yu Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(173, 9);
            label5.Name = "label5";
            label5.Size = new Size(402, 38);
            label5.TabIndex = 4;
            label5.Text = "Seja bem vindo a King Water";
            // 
            // txtHorario
            // 
            txtHorario.Location = new Point(29, 308);
            txtHorario.Name = "txtHorario";
            txtHorario.Size = new Size(230, 23);
            txtHorario.TabIndex = 6;
            // 
            // txtProfessor
            // 
            txtProfessor.Location = new Point(29, 188);
            txtProfessor.Name = "txtProfessor";
            txtProfessor.Size = new Size(230, 23);
            txtProfessor.TabIndex = 8;
            // 
            // txtAluno
            // 
            txtAluno.Location = new Point(29, 132);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(230, 23);
            txtAluno.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblContadorAluno);
            groupBox1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(511, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(163, 88);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Quantidade Alunos";
            // 
            // lblContadorAluno
            // 
            lblContadorAluno.AutoSize = true;
            lblContadorAluno.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblContadorAluno.Location = new Point(69, 33);
            lblContadorAluno.Name = "lblContadorAluno";
            lblContadorAluno.Size = new Size(27, 31);
            lblContadorAluno.TabIndex = 0;
            lblContadorAluno.Text = "0";
            // 
            // dtpDataAula
            // 
            dtpDataAula.Location = new Point(29, 245);
            dtpDataAula.Name = "dtpDataAula";
            dtpDataAula.Size = new Size(230, 23);
            dtpDataAula.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(271, 397);
            button1.Name = "button1";
            button1.Size = new Size(221, 61);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 334);
            label6.Name = "label6";
            label6.Size = new Size(263, 14);
            label6.TabIndex = 13;
            label6.Text = "Aviso: horario de funcionamento das 06:00 as 19:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(728, 470);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(dtpDataAula);
            Controls.Add(groupBox1);
            Controls.Add(txtAluno);
            Controls.Add(txtProfessor);
            Controls.Add(txtHorario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Academia King Water";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtHorario;
        private TextBox txtProfessor;
        private TextBox txtAluno;
        private GroupBox groupBox1;
        private DateTimePicker dtpDataAula;
        private Button button1;
        private Label lblContadorAluno;
        private Label label6;
    }
}