using AgenciesManagement;
using Kierownik_Magazyn�w.Database;
using System.Data;
using System.Data.Entity;

namespace AgenciesManagement
{
	public class AgencyManagementDataService
	{
		public DataTable Ranges;

		public DataTable Agencies;

        public DataTable Warehouses;

		private AgencyManagementRepository agencyRepository;

        public AgencyManagementDataService()
        {
            this.agencyRepository = new AgencyManagementRepository();
        }

        public void GetWarehouses()
        {
            try
            {
                this.Warehouses = agencyRepository.GetWarehouses().ToListAsync().Result.ToDataTable();
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("B��d przy pobieraniu listy magazyn�w");
            }
        }

		public string GetRanges()
		{
            string message;
            try
            {
                Ranges = agencyRepository.GetRanges().ToListAsync().Result.ToDataTable();
                message = "Pobrano list� zakres�w";
            }
            catch
            {
                message = "Nieudana pr�ba pobrania zakres�w";
            }
            return message;
		}

		public string AddRange(int warehouseId, int agencyId, int rangeFrom, int rangeTo)
		{
            string message;
            if (warehouseId != 0 && agencyId != 0 && rangeFrom > 0 && rangeTo > rangeFrom)
            {
                return agencyRepository.AddRange(warehouseId, agencyId, rangeFrom, rangeTo, rangeTo-rangeFrom);
            }
            else
            {
                message = "Nale�y wprowadzi� wszystkie dane!";
            }
            return message;

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
            string message;
            try
            {
                Agencies = agencyRepository.GetAgencies().ToListAsync().Result.ToDataTable();
                message = "Pobrano list� agencji";
            }
            catch
            {
                message = "Nieudana pr�ba pobrania agencji";
            }
            return message;
        }

        public string AddAgency(string agencyName)
		{
            string message;
            if (agencyName.Length >= 1)
            {
                return agencyRepository.AddAgency(agencyName);
            }
            else
            {
                message = "Minimalna d�ugo�� nazwy agencji wynosi 1 znak.";
            }
            return message;
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

