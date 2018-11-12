using AgenciesManagement;
using System.Data;

namespace AgenciesManagement
{
	public class AgencyManagementDataService
	{
		public DataTable Ranges;

		public DataTable Agencies;

		private AgencyManagementRepository agencyRepository;

		public string GetRanges()
		{
			return null;
		}

		public string AddRange(int warehouseId, int agencyId, int rangeFrom, int rangeTo)
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

		public string GetAgencies()
		{
			return null;
		}

		public void AddAgency(string agencyName)
		{

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

