namespace MicroNations
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSqCasa = new TextBox();
            txtSqOspiti = new TextBox();
            txtGoalCasa = new TextBox();
            txtGoalOspiti = new TextBox();
            btnSalva = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 95);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Squadra di casa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 172);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Squadra ospite";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(517, 95);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "goal squadra di casa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(517, 172);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "goal squadra ospite";
            // 
            // txtSqCasa
            // 
            txtSqCasa.Location = new Point(235, 127);
            txtSqCasa.Name = "txtSqCasa";
            txtSqCasa.Size = new Size(100, 23);
            txtSqCasa.TabIndex = 4;
            // 
            // txtSqOspiti
            // 
            txtSqOspiti.Location = new Point(235, 214);
            txtSqOspiti.Name = "txtSqOspiti";
            txtSqOspiti.Size = new Size(100, 23);
            txtSqOspiti.TabIndex = 5;
            // 
            // txtGoalCasa
            // 
            txtGoalCasa.Location = new Point(517, 127);
            txtGoalCasa.Name = "txtGoalCasa";
            txtGoalCasa.Size = new Size(100, 23);
            txtGoalCasa.TabIndex = 6;
            // 
            // txtGoalOspiti
            // 
            txtGoalOspiti.Location = new Point(517, 214);
            txtGoalOspiti.Name = "txtGoalOspiti";
            txtGoalOspiti.Size = new Size(100, 23);
            txtGoalOspiti.TabIndex = 7;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(296, 303);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(321, 169);
            btnSalva.TabIndex = 8;
            btnSalva.Text = "Salva i dati";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 527);
            Controls.Add(btnSalva);
            Controls.Add(txtGoalOspiti);
            Controls.Add(txtGoalCasa);
            Controls.Add(txtSqOspiti);
            Controls.Add(txtSqCasa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSqCasa;
        private TextBox txtSqOspiti;
        private TextBox txtGoalCasa;
        private TextBox txtGoalOspiti;
        private Button btnSalva;
    }
}
