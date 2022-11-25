using Suncor_LdtConduitesLibrary.Models;
using System.Collections.Generic;


namespace Suncor_LdtConduitesLibrary.DataAccess
{
    public interface IDataConnection
    {
        List<ConduiteModel> GetConduites_All(string whereClause);
        List<DgvColumnsDefinitionModel> GetDgvConduitesDataDefinitions_All();
        bool UpdateSingleField(int lid, string champ, object value, object oldValue, string userName);


    }
}
