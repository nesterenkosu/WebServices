using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloSoapClient
{
    public partial class Form1 : Form
    {
        //Переменная прокси-класса SOAP-сервиса
        MyServiceReference.MyServicePortTypeClient myservice;
        public Form1()
        {
            InitializeComponent();
            //Создание экземпляра прокси-класса SOAP-сервиса
            myservice = new MyServiceReference.MyServicePortTypeClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Вызов SOAP-метода HelloWorld
            lb_Result1.Text=myservice.HelloWorld();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Вызов SOAP-метода GreetUser
            try
            {
                lb_Result2.Text = myservice.GreetUser(tb_Name.Text, Convert.ToInt32(tb_Age.Text));
            }
            catch(System.ServiceModel.FaultException ex)
            {
                //В случае SoapFault вывод сообщения об ошибке
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Вызов SOAP-метода GetCityInfo
            try
            {
                cityinfoBindingSource.DataSource = myservice.GetCityInfo(tb_City.Text);
            }
            catch (System.ServiceModel.FaultException ex)
            {
                //В случае SoapFault вывод сообщения об ошибке
                MessageBox.Show(ex.Message);
            }
        }
    }
}
