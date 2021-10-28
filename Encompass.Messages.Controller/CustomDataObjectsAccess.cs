using EllieMae.Encompass.BusinessObjects;
using EllieMae.Encompass.BusinessObjects.Loans;
using EllieMae.Encompass.BusinessObjects.Users;
using EllieMae.Encompass.Client;
using Encompass.Messages.Parsers;
using System.Text;

namespace Encompass.Messages.Controller
{
    static class CustomDataObjectsAccess
    {
        public static T GetJsonData<T>(string cdoName, DataExchange exchange)
        {
            string data = GetDataString(exchange.GetCustomDataObject(cdoName).Data);
            return JsonParser.GetObjectFromJson<T>(data);
        }
        public static T GetJsonData<T>(string cdoName, Loan loan)
        {
            string data = GetDataString(loan.GetCustomDataObject(cdoName).Data);
            return JsonParser.GetObjectFromJson<T>(data);
        }
        public static T GetJsonData<T>(string cdoName, User user)
        {
            string data = GetDataString(user.GetCustomDataObject(cdoName).Data);
            return JsonParser.GetObjectFromJson<T>(data);
        }

        public static void PutJsonData<T>(string cdoName, DataExchange exchange, T data)
        {
            string jsonData = JsonParser.GetJsonFromObject<T>(data);
            PutStringData(cdoName, exchange, jsonData);
        }
        public static void PutJsonData<T>(string cdoName, Loan loan, T data)
        {
            string jsonData = JsonParser.GetJsonFromObject<T>(data);
            PutStringData(cdoName, loan, jsonData);
        }
        public static void PutJsonData<T>(string cdoName, User user, T data)
        {
            string jsonData = JsonParser.GetJsonFromObject<T>(data);
            PutStringData(cdoName, user, jsonData);
        }

        public static string GetStringData(string cdoName, DataExchange exchange)
            => GetDataString(exchange.GetCustomDataObject(cdoName).Data);
        public static string GetStringData(string cdoName, Loan loan)
            => GetDataString(loan.GetCustomDataObject(cdoName).Data);
        public static string GetStringData(string cdoName, User user)
            => GetDataString(user.GetCustomDataObject(cdoName).Data);

        public static void PutStringData(string cdoName, DataExchange exchange, string data)
            => exchange.SaveCustomDataObject(cdoName, GetDataObject(data));
        public static void PutStringData(string cdoName, Loan loan, string data)
            => loan.SaveCustomDataObject(cdoName, GetDataObject(data));
        public static void PutStringData(string cdoName, User user, string data)
            => user.SaveCustomDataObject(cdoName, GetDataObject(data));

        private static string GetDataString(byte[] rawData)
           => Encoding.ASCII.GetString(rawData);
        private static DataObject GetDataObject(string data)
            => new DataObject(Encoding.ASCII.GetBytes(data));
    }
}
