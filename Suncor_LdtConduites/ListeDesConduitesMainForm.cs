using PlanificateurUI;
using Suncor_LdtConduitesLibrary;
using Suncor_LdtConduitesLibrary.DataAccess;
using Suncor_LdtConduitesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Suncor_LdtConduitesUI
{
    public partial class ListeDesConduitesMainForm : Form
    {
        IDataConnection db = GlobalConfig.Connection;
        object oldValue = null;

        public ListeDesConduitesMainForm()
        {
            InitializeComponent();
            toolStripStatusLabelNombreConduitesAffichees.Text = string.Empty;
            WireUpForm();

            // Events            
            uniteText.KeyPress += UniteText_KeyPress;
            serviceText.KeyPress += ServiceText_KeyPress;
            sequentielText.KeyPress += sequentielText_KeyPress;

            dgvConduites.CellBeginEdit += DgvConduites_CellBeginEdit;
            dgvConduites.CellEndEdit += DgvConduites_CellEndEdit;
        }        

        private void UniteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RechercheConduites();
        }

        private void sequentielText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RechercheConduites();
        }

        private void ServiceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                RechercheConduites();
        }

        private void DgvConduites_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var lid = (int)dgvConduites.Rows[e.RowIndex].Cells["LID"].Value;
            var champ = dgvConduites.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name;
            var val = dgvConduites.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (val != oldValue)
            {
                if (dgvConduites.Rows[e.RowIndex].Cells[e.ColumnIndex].GetType() != typeof(System.Windows.Forms.DataGridViewCheckBoxCell))
                {
                    if (val != null)
                    {
                        val = $"'{val.ToString().Replace("'", "''")}'";
                    }
                    else
                    {
                        val = $"'{val}'";
                    }
                }

                // Mettre a jour la db avec la nouvelle valeur
                var updateSuccessful = db.UpdateSingleField(lid, champ, val, oldValue, System.Environment.UserName);
                if (!updateSuccessful)
                    MessageBox.Show("Could not update, something went wrong");
            }
        }

        private void DgvConduites_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Conserver la valeur de la cellule avant qu'on la modifie
            oldValue = dgvConduites.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private string BuildSqlQuery()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(" where ");

            // Unite
            if (uniteText.Text != string.Empty)
                sb.Append($" (Unite = '{ uniteText.Text }') and ");

            // Service
            if (serviceText.Text != string.Empty)
                sb.Append($" (Service='{ serviceText.Text }') and ");

            // Sequentiel ou conduite
            if (sequentielText.Text != string.Empty)
            {
                // Si - c'est un numero de conduite, sinon un numero sequentiel seulement
                if (!sequentielText.Text.Contains("-"))
                {
                    sb.Append($" (Sequentiel='{ sequentielText.Text }') and ");
                }
                else
                {
                    sb.Append($" (Conduite like '%{ sequentielText.Text }%') and ");
                }
            }

            // Champ Texte 1
            if ((champ1ComboBox.SelectedIndex != -1) && (champ1Text.Text != string.Empty))
            {
                string s = champ1Text.Text;
                DgvColumnsDefinitionModel cdm = (DgvColumnsDefinitionModel)champ1ComboBox.SelectedItem;

                if (s.Contains("*"))
                {
                    sb.Append($"{cdm.CName} like '{s.Replace('*', '%')}' and ");
                }
                else
                {
                    sb.Append($"{cdm.CName} = '{s}' and ");
                }
            }

            // Champ Texte 2
            if ((champ2ComboBox.SelectedIndex != -1) && (champ2Text.Text != string.Empty))
            {
                string s = champ2Text.Text;
                DgvColumnsDefinitionModel cdm = (DgvColumnsDefinitionModel)champ2ComboBox.SelectedItem;

                if (s.Contains("*"))
                {
                    sb.Append($"{cdm.CName} like '{s.Replace('*', '%')}' and ");
                }
                else
                {
                    sb.Append($"{cdm.CName} = '{s}' and ");
                }
            }

            // Return the where clause
            if (sb.ToString().Equals(" where "))
                return string.Empty;
            else
                return sb.ToString().Substring(0, sb.Length - 4);
        }

        private void WireUpForm()
        {

            // Liste des conduites DataGridView
            List<DgvColumnsDefinitionModel> lstDgvMandatsColumnsDefinitions = db.GetDgvConduitesDataDefinitions_All();
            DatagridViewDefineColumns.Define(dgvConduites, lstDgvMandatsColumnsDefinitions);

            // ComboBoxes
            List<DgvColumnsDefinitionModel> lstForCombo1 = lstDgvMandatsColumnsDefinitions.Where(x => x.Field_Is_Visible = true).OrderBy(x => x.Header_Text).ToList();
            List<DgvColumnsDefinitionModel> lstForCombo2 = new List<DgvColumnsDefinitionModel>(lstForCombo1);

            champ1ComboBox.DataSource = lstForCombo1;
            champ1ComboBox.DisplayMember = "Header_Text";
            champ1ComboBox.SelectedIndex = -1;

            champ2ComboBox.DataSource = lstForCombo2;
            champ2ComboBox.DisplayMember = "Header_Text";
            champ2ComboBox.SelectedIndex = -1;
        }

        private void rechercheConduiteButton_Click(object sender, System.EventArgs e)
        {
            RechercheConduites();
        }

        private void RechercheConduites()
        {
            string whereClause = BuildSqlQuery();
            SortableBindingList<ConduiteModel> conduites = new SortableBindingList<ConduiteModel>(db.GetConduites_All(whereClause));
            dgvConduites.DataSource = conduites;

            toolStripStatusLabelNombreConduitesAffichees.Text = $"{ conduites.Count } conduites affichées";
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            // Reinitialiser le form
            uniteText.Clear();
            serviceText.Clear();
            sequentielText.Clear();
            champ1ComboBox.SelectedIndex = -1;
            champ1Text.Clear();
            champ2ComboBox.SelectedIndex = -1;
            champ2Text.Clear();
        }

        private void uniteText_KeyPress(object sender, KeyPressEventArgs e)
        {
            // On veut juste des valeurs numeriques pour le numero d'unite
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void serviceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ModifierLaSelectionButton_Click(object sender, EventArgs e)
        {
            if (!ordreText.Text.Equals(string.Empty) &&
                (!ingenieurText.Text.Equals(string.Empty) &&
                (!dateMiseaJourText.Text.Equals(string.Empty))))
            {
                string ordre = ordreText.Text;
                string ingenieur = ingenieurText.Text;
                string date = dateMiseaJourText.Text;

                foreach (DataGridViewRow row in dgvConduites.SelectedRows)
                {
                    var lid = (int)row.Cells["LID"].Value;

                    row.Cells["Commentaires"].Value = ordre;
                    row.Cells["VerifiePar"].Value = ingenieur;
                    row.Cells["DateVerification"].Value = date;

                    db.UpdateSingleField(lid, "Commentaires", $"'{ordre}'", oldValue, System.Environment.UserName);
                    db.UpdateSingleField(lid, "VerifiePar", $"'{ingenieur}'", oldValue, System.Environment.UserName);
                    db.UpdateSingleField(lid, "DateVerification", $"'{date}'", oldValue, System.Environment.UserName);

                }
            }
        }
    }
}
