using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest
{
    public class DataModel
    {
        private Guid _id;

        public Guid ID
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        private string _machine_id;

        public string Machine_id
        {
            get => _machine_id;
            set
            {
                _machine_id = value;
            }
        }

        private string _timestamp;

        public string TimeStamp
        {
            get => _timestamp;
            set
            {
                _timestamp = value;
            }
        }

        private string _status;

        public string Status
        {
            get => _status;
            set
            {
                _status = value;
            }
        }
    }
}
