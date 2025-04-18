using AriaWebAPI.AriaAccessAPI.Core;
using AriaWebAPI.AriaAccessAPI.Enums;
using AriaWebAPI.Helpers;
using System;

namespace AriaWebAPI.AriaAccessAPI.Requests
{
    public class GetBillingInfoRequest : AriaAccessObject
    {
        public JsonDttm StartDate { get; set; }
        public JsonDttm EndDate { get; set; }
        public JsonString HospitalName { get; set; }
        public JsonBool ReturnAllCharges { get; set; }
        public JsonInt SortMode { get; set; } 

        /// <summary>
        /// This isn't working at the moment.
        /// </summary>
        /// <param name="start">Start Date to Search</param>
        /// <param name="end">End Date to Search</param>
        /// <param name="hospitalId">Hospital to Search</param>
        /// <param name="returncharges">This is the piece that isn't working. Should return all charges.</param>
        /// <param name="sortMode">Sort mode of results. See SortMode enum</param>
        public GetBillingInfoRequest(DateTime start, DateTime end, HospitalId hospitalId, bool returncharges, SortMode sortMode = Enums.SortMode.None ):
            base("GetBillingInfoRequest:http://services.varian.com/AriaWebConnect/Link")
        {
            throw new NotImplementedException();

            //StartDate = new JsonDttm(start);
            //EndDate = new JsonDttm(end);
            //HospitalName = new JsonString(DeptAndHospitalEnumParser.HospitalfromEnum[hospitalId]);
            //ReturnAllCharges = new JsonBool(returncharges);
            //SortMode = new JsonInt((int)sortMode);
        }

    }
}
