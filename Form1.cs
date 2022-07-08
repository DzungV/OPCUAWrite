using Opc.UaFx.Client;

namespace OPCUAWrite
{
    public partial class Form1 : Form
    {
        OpcClient client = new OpcClient("opc.tcp://localhost:4840/");
        //OpcClient client = new OpcClient("opc.tcp://laptop-it96r3ej:62563/Quickstarts/SimpleEventsServer");

        bool ret;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            double sensorValue;

            sensorValue = ReadSensorData();
            OpcWrite(sensorValue);
        }

       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null)
                client.Disconnect();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            client.Connect();
            timer1.Start();
            lblStatusMessage.Text = "Logging Started and Connected to OPC Server";

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (client != null)
                client.Disconnect();
            lblStatusMessage.Text = "Logging Stopped and Disconnected from OPC Server";
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            sbyte position;
            position = ReadPosition();
                    
        }
       

        private void btnMode_Click(object sender, EventArgs e)
        {
            byte mode;
            mode = ReadMode();
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            bool status;
            status = ReadOperStt();

        }


        sbyte ReadPosition()
        {
            
            string pos = txtPos.Text;            
            sbyte position = Convert.ToSByte(pos);
            string tagName = "ns=2;s=Position";
            client.WriteNode(tagName, position);
            return position;
        }

        void OpcWrite(double sensorValue)
        {
            string tagName = "ns=2;s=Temperature";
            client.WriteNode(tagName, sensorValue);

            tagName = "ns=2;s=Name";
            client.WriteNode(tagName, "Machine 1");


        }

        double ReadSensorData()
        {
            var rand = new Random();
            int minValue = 20, maxValue = 30;
            double sensorValue;

            //Generate SensorValue
            sensorValue = rand.NextDouble() * (maxValue - minValue) + minValue;
            txtSensorValue.Text = sensorValue.ToString("#.##");
            DateTime sensorDateTime = DateTime.Now;
            txtTimeStamp.Text = sensorDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            return sensorValue;
        }

        byte ReadMode()
        {            
            string Mode = txtMode.Text;
            byte mode = Convert.ToByte(Mode);
            string tagName = "ns=2;s=Status";
            client.WriteNode(tagName, mode);
            return mode;

        }

        bool ReadOperStt()
        {
            

            if (ret)
            {
                txtOperStt.Text = "false";
            }
            else
            {
                txtOperStt.Text = "true";
            }
            ret = !ret;
            string tagName = "ns=2;s=IsActive";
            client.WriteNode(tagName, ret);
            return ret;
        }

      
    }

}