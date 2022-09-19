using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest
{
    public static class DataService
    {
        static List<DataModel> Models { get; }

        static DataService()
        {
            Models = new List<DataModel>();
        }

        public static List<DataModel> GetDataModels() => Models;

        public static DataModel Get(Guid id) => Models.FirstOrDefault(model => model.ID == id);

        public static void Add(DataModel dataModel) => Models.Add(dataModel);

        public static void Remove(DataModel dataModel) => Models.Remove(dataModel);

        public static void Update(DataModel dataModel)
        {
            Models.Remove(dataModel);
            Models.Add(dataModel);
        }
    }
}
