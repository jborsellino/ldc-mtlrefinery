namespace Suncor_LdtConduitesLibrary.Models
{

    public class DgvColumnsDefinitionModel
    {
        public int EID { get; set; }
        public string DGV_NAME { get; set; }
        public int COL_ID { get; set; }
        public bool IS_VISIBLE { get; set; }
        public int USER_CWIDTH { get; set; }
        public int COL_ORDER { get; set; }
        public decimal Column_Order { get; set; }
        public string CType { get; set; }
        public string CName { get; set; }
        public string Header_Text { get; set; }
        public bool Field_Is_Visible { get; set; }
        public bool Is_Read_Only { get; set; }
        public int CWidth { get; set; }
        public string Header_Align { get; set; }
        public string Content_Align { get; set; }
        public string TypeAffichage { get; set; }
        public string TypeAffichageOrdreTri { get; set; }
        public string Is_User_Customizable { get; set; }

    }
}
