using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace ApiTest
{
    public class WSService
    {
        private WebSocket _webSocket;

        public void Init()
        {
            if (_webSocket != null) return;

            _webSocket = new WebSocket("ws://machinestream.herokuapp.com/ws");
            _webSocket.OnMessage += OnMessage;
            _webSocket.OnError += OnError;
            _webSocket.OnClose += OnClose;

        }

        private void OnClose(object sender, CloseEventArgs e)
        {

        }

        private void OnMessage(object sender, MessageEventArgs e)
        {
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(e.Data);
            string status = jsonData["status"].ToString();

            DataModel dataModel = new DataModel();
            dataModel.ID = new Guid(jsonData["Id"].ToString());
            dataModel.Machine_id = jsonData["Machine_id"].ToString();
            dataModel.Status = jsonData["status"].ToString();

            DataService.Add(dataModel);

            if (status == "errored")
            {
                //_webSocket.Send()
            }
        }

        private void OnError(object sender, ErrorEventArgs e)
        {

        }

    }
}
