using Kierownik_Magazynów.Database;
using System;
using System.Data;
using System.Data.Entity;

namespace AgenciesManagement
{
	public class AgencyManagementRepository
	{
        private WarehouseManagerEntitiesAgencies agencyDataBase;

        public AgencyManagementRepository()
        {
            this.agencyDataBase = new WarehouseManagerEntitiesAgencies();
        }

        public DbSet<Range> GetRanges()
		{
			return agencyDataBase.Range;
		}

		public string AddRange(int warehouseId, int agencyId, int rangeFrom, int rangeTo, int totalRange)
		{
            Range rangeToAdd = new Range();
            rangeToAdd.WarehouseId = warehouseId;
            rangeToAdd.AgencyId = agencyId;
            rangeToAdd.RangeFrom = rangeFrom;
            rangeToAdd.RangeTo = rangeTo;
            rangeToAdd.TotalRange = totalRange;
            agencyDataBase.Range.Add(rangeToAdd);
            agencyDataBase.SaveChanges();
			return "Dodano zakres";
		}

        internal DbSet<Warehouse> GetWarehouses()
        {
            return agencyDataBase.Warehouse;
        }

        public string EditRange(int rangeId, int rangeFrom, int rangeTo)
		{
			return null;
		}

		public string DeleteRange(int rangeId)
		{
			return null;
		}

		public DbSet<Agency> GetAgencies()
		{
			return agencyDataBase.Agency;
		}

		public string AddAgency(string agencyName)
		{
            Agency agencyToAdd = new Agency();
            agencyToAdd.AgencyName = agencyName;
            agencyDataBase.Agency.Add(agencyToAdd);
            agencyDataBase.SaveChanges();

			return "Dodano agencjê";
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

