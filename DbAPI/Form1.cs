using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbAPI
{
	public partial class Form1 : Form
	{
		public IDictionary<string, string> StationList = new Dictionary<string, string>();
		public Form1()
		{
			InitializeComponent();
		}

		private void Search_Click(object sender, EventArgs e)
		{
			anzeige.Items.Clear();
			string dt = dateTimePicker1.Value.ToString("yyMMdd");
			string eva = StationList[StationBox.SelectedItem.ToString()];

			if (abfahrtBox.Checked)
			{
				try
				{
					var FahrPlanList = API.GetFarhPlan("d", dt, (UhrzeitBox.Text.ToString().Replace(" Uhr", "")), eva);
					if (FahrPlanList != null)
					{
						foreach (var item in FahrPlanList)
						{
							anzeige.Items.Add(item);
						}
					}
				}
				catch (Exception b)
				{
					anzeige.Items.Add(b.Message);
				}

			}
			if (Ankunft.Checked)
			{
				try
				{
					var FahrPlanList = API.GetFarhPlan("a", dt, (UhrzeitBox.Text.ToString().Replace(" Uhr", "")), eva);
					if (FahrPlanList != null)
					{
						foreach (var item in FahrPlanList)
						{
							anzeige.Items.Add(item);
						}
					}
				}
				catch (Exception b)
				{
					anzeige.Items.Add(b.Message);
				}

			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//load all Stations
			StationList = API.GetAllStation();
			foreach (var item in StationList)
			{
				StationBox.Items.Add(item.Key);
			}

		}
	}
}
