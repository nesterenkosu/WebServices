using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CookComputing.XmlRpc;


namespace XmlRpcClient2023
{    

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            IDemoServiceProxy proxy = XmlRpcProxyGen.Create<IDemoServiceProxy>();
            proxy.HelloUser("Vasya", 19);
        }
    }

    [XmlRpcUrl("https://localhost:44302/Server.ashx")]
    public interface IDemoServiceProxy : IXmlRpcProxy
    {
        [XmlRpcMethod("demoservice::hellouser")]
        string HelloUser(string name, int age);
    }
}
