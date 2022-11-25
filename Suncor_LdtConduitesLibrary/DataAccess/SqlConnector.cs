using Dapper;
using Suncor_LdtConduitesLibrary.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Suncor_LdtConduitesLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //private const string db = "MtlListeConduitesPlanificateurMandatsV2";
        //private const string db = "MtlListeConduites";
        private const string db = "MtlListeConduitesSuncor";

        /// <summary>
        ///  Definition des colonnes du dgv des conduites
        /// </summary>
        /// <returns></returns>
        public List<DgvColumnsDefinitionModel> GetDgvConduitesDataDefinitions_All()
        {
            List<DgvColumnsDefinitionModel> output;

            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(GlobalConfig.conString(db)))
            {
                output = con.Query<DgvColumnsDefinitionModel>("dbo.spLdtConduitesColumnsDefinitions_GetAll").ToList();
            }

            return output;
        }


        /// <summary>
        /// Liste des conduites
        /// </summary>
        /// <returns></returns>
        List<ConduiteModel> IDataConnection.GetConduites_All(string whereClause)
        {
            List<ConduiteModel> output;

            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(GlobalConfig.conString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@whereClause", whereClause);

                output = con.Query<ConduiteModel>("dbo.spLdtConduites_GetAll", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;

        }

        /// <summary>
        /// Mise a jour d'un champ de la LDT Liste des Conduites
        /// </summary>
        /// <param name="lid">ID de la conduite</param>
        /// <param name="champ">Champ</param>
        /// <param name="value">Nouvelle valeur</param>
        /// <param name="oldValue">Ancienne valeur</param>
        /// <param name="userName">Nom d'utilisateur de la personne qui soumet le changement</param>
        /// <returns></returns>
        public bool UpdateSingleField(int lid, string champ, object value, object oldValue, string userName)
        {
            var isSuccess = 0;

            using (IDbConnection con = new System.Data.SqlClient.SqlConnection(GlobalConfig.conString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@lid", lid);
                p.Add("@champ", champ);
                p.Add("@value", value);
                p.Add("@oldValue", oldValue);
                p.Add("@userName", userName);

                isSuccess = con.Execute("dbo.spLdtConduitesUpdateSingleField", p, commandType: CommandType.StoredProcedure);
            }

            return isSuccess > 0;
        }
    }
}
