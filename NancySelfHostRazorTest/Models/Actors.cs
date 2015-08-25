using System;
using System.Data;

namespace NancyTest
{
	public static class Actors
	{
		public static DataTable Retrieve()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("Name");
			dt.Columns.Add("BirthDate");
			dt.Columns.Add("Country");
			dt.Columns.Add("ImdbLink");

			dt.Rows.Add(new object[] { "Elijah Wood", "1981-01-28", "USA","http://www.imdb.com/name/nm0000704/?ref_=tt_ov_st"});
			dt.Rows.Add(new object[] { "Ian McKellen", "1939-05-25", "USA","http://www.imdb.com/name/nm0005212/?ref_=tt_ov_st"});
			dt.Rows.Add(new object[] { "Orlando Bloom", "1977-01-13", "USA","http://www.imdb.com/name/nm0089217/?ref_=nv_sr_1"});
			dt.Rows.Add(new object[] { "Viggo Mortensen", "1958-10-20", "USA","http://www.imdb.com/name/nm0001557/?ref_=tt_ov_st"});
			dt.Rows.Add(new object[] { "Johnny Depp", "1963-06-09", "USA","http://www.imdb.com/name/nm0000136/?ref_=tt_ov_st"});
			dt.Rows.Add(new object[] { "Keira Knightley", "1985-03-26", "UK","http://www.imdb.com/name/nm0461136/?ref_=ttfc_fc_cl_t4"});

			return dt;
		}
	}
}

