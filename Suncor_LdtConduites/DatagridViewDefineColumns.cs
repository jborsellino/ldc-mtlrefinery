using Suncor_LdtConduitesLibrary.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlanificateurUI
{
    public class DatagridViewDefineColumns
    {

        /// <summary>
        ///  Definition des colonnes du datagridview specifie
        /// </summary>
        /// <param name="dataGridView">Source DataGridView</param>
        /// <param name="columnsDefinitions">Columns Definitions List</param>
        public static void Define(DataGridView dataGridView, List<DgvColumnsDefinitionModel> columnsDefinitions)
        {
            dataGridView.Rows.Clear();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.Columns.Clear();
            dataGridView.AutoGenerateColumns = false;

            foreach (DgvColumnsDefinitionModel cdm in columnsDefinitions)
            {
                DataGridViewColumn col = InitializeColumn(cdm.CType);
                col.Name = cdm.CName;
                col.DataPropertyName = cdm.CName;
                col.HeaderText = cdm.Header_Text;
                dataGridView.Columns.Add(col);
                dataGridView.Columns[cdm.CName].Width = cdm.CWidth;

                // Header Alignment
                switch (cdm.Header_Align)
                {
                    case "MiddleCenter":
                        dataGridView.Columns[cdm.CName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;

                    case "MiddleLeftt":
                        dataGridView.Columns[cdm.CName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;

                    case "MiddleRIght":
                        dataGridView.Columns[cdm.CName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;

                    default:
                        dataGridView.Columns[cdm.CName].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                }

                // Content Alignment
                switch (cdm.Content_Align)
                {
                    case "MiddleCenter":
                        dataGridView.Columns[cdm.CName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        break;

                    case "MiddleLeftt":
                        dataGridView.Columns[cdm.CName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;

                    case "MiddleRIght":
                        dataGridView.Columns[cdm.CName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        break;

                    default:
                        dataGridView.Columns[cdm.CName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                }

                // Is the field visible or not ?
                if (cdm.Field_Is_Visible)
                {
                    dataGridView.Columns[cdm.CName].Visible = true;
                }
                else
                {
                    dataGridView.Columns[cdm.CName].Visible = false;
                }

            }

        }

        /// <summary>
        /// Initialisation des colonnes selon leur type
        /// </summary>
        /// <param name="colunmType"></param>
        /// <returns></returns>
        private static DataGridViewColumn InitializeColumn(string colunmType)
        {
            // Initialize a datagridViewColumn according to its type

            // DataGridViewTextBoxColumn
            if (colunmType.Equals("DataGridViewTextBoxColumn"))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                return col;
            }

            // DataGridViewImageColumn
            if (colunmType.Equals("DataGridViewImageColumn"))
            {
                DataGridViewImageColumn col = new DataGridViewImageColumn();
                return col;
            }

            // DataGridViewCheckBoxColumn
            if (colunmType.Equals("DataGridViewCheckBoxColumn"))
            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                return col;
            }

            // DataGridViewButtonColumn
            if (colunmType.Equals("DataGridViewButtonColumn"))
            {
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                return col;
            }

            // DataGridViewComboBoxColumn
            if (colunmType.Equals("DataGridViewComboBoxColumn"))
            {
                DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                col.FlatStyle = FlatStyle.Flat;
                return col;
            }

            // DataGridViewLinkColumn
            if (colunmType.Equals("DataGridViewLinkColumn"))
            {
                DataGridViewLinkColumn col = new DataGridViewLinkColumn();
                return col;
            }

            // CalendarColumn
            //if (colunmType.Equals("CalendarColumn"))
            //{
            //    CalendarColumn col = new CalendarColumn();
            //    return col;
            //}

            return null;
        }
    }
}
