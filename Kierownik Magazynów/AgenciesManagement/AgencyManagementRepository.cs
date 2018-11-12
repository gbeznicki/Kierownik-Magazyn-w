using Kierownik_Magazynów.Database;
using System.Data;

namespace AgenciesManagement
{
	public class AgencyManagementRepository
	{
        private AgencyEntities agencyDataBase;

        public DataTable GetRanges()
		{
			return null;
		}

		public string AddRange(int warehouseId, int agencyId, int rangeFrom, int rangeTo, int totalRange)
		{
			return null;
		}

		public string EditRange(int rangeId, int rangeFrom, int rangeTo)
		{
			return null;
		}

		public string DeleteRange(int rangeId)
		{
			return null;
		}

		public DataTable GetAgencies()
		{
			return null;
		}

		public string AddAgency()
		{
			return null;
		}

		public string EditAgency(int agencyId, string agencyName)
		{
			return null;
		}

		public string DeleteAgency(int agencyId)
		{
			return null;
		}

	}

}

