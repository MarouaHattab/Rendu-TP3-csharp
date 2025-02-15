namespace RenduTP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelAire.Visible = false;
            labelPerimetre.Visible = false;
            textBoxDimension1.Visible = false;
            textBoxDimension2.Visible = false;
            labelDimension1.Visible = false;
            labelDimension2.Visible = false;
        }

        private void comboBoxFormes_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDimension1.Visible = false;
            textBoxDimension2.Visible = false;
            labelDimension1.Visible = false;
            labelDimension2.Visible = false;
            labelAire.Visible = false;
            labelPerimetre.Visible = false;

            if (comboBoxFormes.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une forme.");
                return;
            }

            switch (comboBoxFormes.SelectedItem.ToString())
            {
                case "Carré":
                    labelDimension1.Text = "Côté :";
                    textBoxDimension1.Visible = true;
                    labelDimension1.Visible = true;
                    pictureBoxForme.Image = Properties.Resources.carre;
                    break;

                case "Rectangle":
                    labelDimension1.Text = "Longueur :";
                    labelDimension2.Text = "Largeur :";
                    textBoxDimension1.Visible = true;
                    textBoxDimension2.Visible = true;
                    labelDimension1.Visible = true;
                    labelDimension2.Visible = true;
                    pictureBoxForme.Image = Properties.Resources.rectangle;
                    break;

                case "Cercle":
                    labelDimension1.Text = "Rayon :";
                    textBoxDimension1.Visible = true;
                    labelDimension1.Visible = true;
                    pictureBoxForme.Image = Properties.Resources.cercle;
                    break;

                case "Triangle Équilatéral":
                    labelDimension1.Text = "Côté :";
                    textBoxDimension1.Visible = true;
                    labelDimension1.Visible = true;
                    pictureBoxForme.Image = Properties.Resources.triangle;
                    break;

                default:
                    MessageBox.Show("Forme non reconnue.");
                    break;
            }
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            FormeGeometrique forme = null;

            try
            {
                if (comboBoxFormes.SelectedItem == null)
                {
                    MessageBox.Show("Veuillez sélectionner une forme.");
                    return;
                }

                switch (comboBoxFormes.SelectedItem.ToString())
                {
                    case "Carré":
                        double cote = double.Parse(textBoxDimension1.Text);
                        if (cote <= 0) throw new ArgumentException("Le côté doit être positif.");
                        forme = new Carre(cote);
                        break;

                    case "Rectangle":
                        double longueur = double.Parse(textBoxDimension1.Text);
                        double largeur = double.Parse(textBoxDimension2.Text);
                        if (longueur <= 0 || largeur <= 0) throw new ArgumentException("La longueur et la largeur doivent être positives.");
                        forme = new Rectangle(longueur, largeur);
                        break;

                    case "Cercle":
                        double rayon = double.Parse(textBoxDimension1.Text);
                        if (rayon <= 0) throw new ArgumentException("Le rayon doit être positif.");
                        forme = new Cercle(rayon);
                        break;

                    case "Triangle Équilatéral":
                        double coteTriangle = double.Parse(textBoxDimension1.Text);
                        if (coteTriangle <= 0) throw new ArgumentException("Le côté doit être positif.");
                        forme = new TriangleEquilateral(coteTriangle);
                        break;

                    default:
                        MessageBox.Show("Forme non reconnue.");
                        return;
                }

                if (forme != null)
                {
                    labelAire.Text = $"Aire : {forme.CalculerAire().ToString("N2")} m²";
                    labelPerimetre.Text = $"Périmètre : {forme.CalculerPerimetre().ToString("N2")} m";
                    labelAire.Visible = true;
                    labelPerimetre.Visible = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Erreur : Veuillez entrer des valeurs numériques valides pour les dimensions.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}