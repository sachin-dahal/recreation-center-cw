using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    class GlobalData
    {
        public static bool isAdmin = true;
        public static String ticketPricesFilePath = "";
        public static String customersListFilePath = "";
        public static String[] ticketCategories;
        public static String[] ticketPrices;
        public static int[] minimumPeopleAllowedList;
        public static int[] maximumPeopleAllowedList;

        public static void loadTicketData()
        {
            try
            {
                String filePath = GlobalData.ticketPricesFilePath;
                string[] lines = File.ReadAllLines(filePath);
                String headers = lines[0];
                GlobalData.ticketCategories = new String[lines.Length - 1];
                GlobalData.ticketPrices = new String[lines.Length - 1];
                GlobalData.minimumPeopleAllowedList = new int[lines.Length - 1];
                GlobalData.maximumPeopleAllowedList = new int[lines.Length - 1];
                for (int i = 1; i < lines.Length; i++)
                {
                    String[] ticketType = lines[i].Split(',');
                    GlobalData.ticketCategories[i - 1] = ticketType[0];
                    GlobalData.ticketPrices[i - 1] = lines[i];
                    GlobalData.minimumPeopleAllowedList[i - 1] = int.Parse(ticketType[7]);
                    GlobalData.maximumPeopleAllowedList[i - 1] = int.Parse(ticketType[8]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "ERROR");
            }
        }
    }
}
