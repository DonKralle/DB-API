using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DbAPI
{
	internal class API
	{



		public static RestResponse sendGetRequest(string requestUrl)
		{
			string clientId = "7b9caa1503662d08ae26bb0bc9bc31cb";
			string clientSecret = "12192711b9033edc1c70f6014594f14d";

			var client = new RestClient(requestUrl);
			var request = new RestRequest("", Method.Get);
			request.AddHeader("DB-Client-Id", clientId);
			request.AddHeader("DB-Api-Key", clientSecret);
			request.AddHeader("Accept", "application/xml");
			return client.Execute(request);
		}

		public static List<string> GetFarhPlan(string timeType, string dt, string time, string eva)
		{
			string apiPlanUrl = "https://apis.deutschebahn.com/db-api-marketplace/apis/timetables/v1/plan/" + eva + "/" + dt + "/" + time;
			var response = sendGetRequest(apiPlanUrl);

			XmlDocument xmlTimetable = new XmlDocument();
			xmlTimetable.LoadXml(response.Content);

			if (timeType == "d")
			{
				XmlNodeList sElements = xmlTimetable.GetElementsByTagName("dp");
				List<string> Zug = new List<string>();
				foreach (XmlNode sElement in sElements)
				{
					DateTime dateTime = DateTime.ParseExact(sElement.Attributes["pt"].InnerText, "yyMMddHHmm", null);
					Zug.Add(dateTime + " - " + sElement.Attributes["ppth"].InnerText);
				}
				return Zug;
			}
			else if (timeType == "a")
			{
				XmlNodeList sElements = xmlTimetable.GetElementsByTagName("ar");

				foreach (XmlNode sElement in sElements)
				{
					List<string> Zug = new List<string>();
					DateTime dateTime = DateTime.ParseExact(sElement.Attributes["pt"].InnerText, "yyMMddHHmm", null);
					Zug.Add(dateTime + " - " + sElement.Attributes["ppth"].InnerText);
					Console.WriteLine();
					return Zug;
				}
			}
			return null;
		}

		public static IDictionary<string, string> GetAllStation()
		{
			string apiUrl = "https://apis.deutschebahn.com/db-api-marketplace/apis/timetables/v1/station/*";
			var response = sendGetRequest(apiUrl);

			IDictionary<string, string> stationList = new Dictionary<string, string>();

			XmlDocument xmlTimetable = new XmlDocument();
			xmlTimetable.LoadXml(response.Content);
			XmlNodeList sElements = xmlTimetable.GetElementsByTagName("station");

			foreach (XmlNode sElement in sElements)
			{
				XmlAttribute idAttrName = sElement.Attributes["name"];
				XmlAttribute idAttrEVA = sElement.Attributes["eva"];
				if (idAttrName != null && idAttrEVA != null)
				{
					try
					{
						stationList.Add(new KeyValuePair<string, string>(idAttrName.Value, idAttrEVA.Value));
					}
					catch (Exception e)
					{

					}

				}
			}
			return stationList;
		}
	}
}
