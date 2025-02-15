namespace RenduTP3
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
            comboBoxFormes = new ComboBox();
            panelSaisie = new Panel();
            label1 = new Label();
            labelDimension1 = new Label();
            labelDimension2 = new Label();
            textBoxDimension1 = new TextBox();
            textBoxDimension2 = new TextBox();
            buttonCalculer = new Button();
            labelAire = new Label();
            labelPerimetre = new Label();
            pictureBoxForme = new PictureBox();
            panelSaisie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForme).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFormes
            // 
            comboBoxFormes.FormattingEnabled = true;
            comboBoxFormes.Items.AddRange(new object[] { "Carré", "Rectangle", "Cercle", "Triangle Équilatéral" });
            comboBoxFormes.Location = new Point(230, 39);
            comboBoxFormes.Name = "comboBoxFormes";
            comboBoxFormes.Size = new Size(155, 28);
            comboBoxFormes.TabIndex = 0;
            comboBoxFormes.SelectedIndexChanged += comboBoxFormes_SelectedIndexChanged;
            // 
            // panelSaisie
            // 
            panelSaisie.Controls.Add(textBoxDimension2);
            panelSaisie.Controls.Add(textBoxDimension1);
            panelSaisie.Controls.Add(labelDimension2);
            panelSaisie.Controls.Add(labelDimension1);
            panelSaisie.Location = new Point(82, 102);
            panelSaisie.Name = "panelSaisie";
            panelSaisie.Size = new Size(407, 176);
            panelSaisie.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 39);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 2;
            label1.Text = "Forme :";
            // 
            // labelDimension1
            // 
            labelDimension1.AutoSize = true;
            labelDimension1.Location = new Point(41, 38);
            labelDimension1.Name = "labelDimension1";
            labelDimension1.Size = new Size(50, 20);
            labelDimension1.TabIndex = 0;
            labelDimension1.Text = "label1";
            // 
            // labelDimension2
            // 
            labelDimension2.AutoSize = true;
            labelDimension2.Location = new Point(41, 114);
            labelDimension2.Name = "labelDimension2";
            labelDimension2.Size = new Size(50, 20);
            labelDimension2.TabIndex = 1;
            labelDimension2.Text = "label2";
            // 
            // textBoxDimension1
            // 
            textBoxDimension1.Location = new Point(148, 38);
            textBoxDimension1.Name = "textBoxDimension1";
            textBoxDimension1.Size = new Size(155, 27);
            textBoxDimension1.TabIndex = 2;
            // 
            // textBoxDimension2
            // 
            textBoxDimension2.Location = new Point(148, 114);
            textBoxDimension2.Name = "textBoxDimension2";
            textBoxDimension2.Size = new Size(155, 27);
            textBoxDimension2.TabIndex = 3;
            // 
            // buttonCalculer
            // 
            buttonCalculer.BackColor = SystemColors.Highlight;
            buttonCalculer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCalculer.ForeColor = SystemColors.HighlightText;
            buttonCalculer.Location = new Point(383, 297);
            buttonCalculer.Name = "buttonCalculer";
            buttonCalculer.Size = new Size(106, 48);
            buttonCalculer.TabIndex = 3;
            buttonCalculer.Text = "Calculer";
            buttonCalculer.UseVisualStyleBackColor = false;
            buttonCalculer.Click += buttonCalculer_Click;
            // 
            // labelAire
            // 
            labelAire.AutoSize = true;
            labelAire.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAire.Location = new Point(97, 367);
            labelAire.Name = "labelAire";
            labelAire.Size = new Size(65, 28);
            labelAire.TabIndex = 4;
            labelAire.Text = "label2";
            // 
            // labelPerimetre
            // 
            labelPerimetre.AutoSize = true;
            labelPerimetre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPerimetre.Location = new Point(97, 439);
            labelPerimetre.Name = "labelPerimetre";
            labelPerimetre.Size = new Size(65, 28);
            labelPerimetre.TabIndex = 5;
            labelPerimetre.Text = "label2";
            // 
            // pictureBoxForme
            // 
            pictureBoxForme.Location = new Point(542, 54);
            pictureBoxForme.Name = "pictureBoxForme";
            pictureBoxForme.Size = new Size(400, 400);
            pictureBoxForme.TabIndex = 6;
            pictureBoxForme.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 534);
            Controls.Add(pictureBoxForme);
            Controls.Add(labelPerimetre);
            Controls.Add(labelAire);
            Controls.Add(buttonCalculer);
            Controls.Add(label1);
            Controls.Add(panelSaisie);
            Controls.Add(comboBoxFormes);
            Name = "Form1";
            Text = "Application de Gestion de Formes Géométriques";
            panelSaisie.ResumeLayout(false);
            panelSaisie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFormes;
        private Panel panelSaisie;
        private Label label1;
        private Label labelDimension2;
        private Label labelDimension1;
        private TextBox textBoxDimension2;
        private TextBox textBoxDimension1;
        private Button buttonCalculer;
        private Label labelAire;
        private Label labelPerimetre;
        private PictureBox pictureBoxForme;
    }
}
