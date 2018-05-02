using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace PostQueueAzure
{
    public partial class Form1 : Form
    {
        String token;
        public Form1()
        {
            InitializeComponent();
        }

        //metodo para crear una cola si no existe o recuperarla
        public CloudQueue GetColaMensajes(String programador)
        {
            CloudStorageAccount cuenta = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnectionString"));
            //creamos un cliente para la cola
            CloudQueueClient cliente = cuenta.CreateCloudQueueClient();
            //recuperamos en contenedor de la cola de cada programador
            CloudQueue cola = cliente.GetQueueReference(programador);
            //creamos la cola si no existe
            cola.CreateIfNotExists();
            //devolvemos la cola creada o recuperada
            return cola;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncrearmensaje_Click(object sender, EventArgs e)
        {
            String nombrequeue = this.cmbusuarios.SelectedItem.ToString();
            CloudQueue cola = this.GetColaMensajes(nombrequeue);
            String contenido = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - " + txtmensaje.Text;
            CloudQueueMessage mensaje = new CloudQueueMessage(contenido);
            cola.AddMessage(mensaje);
            this.lblpintar.Text = "mensaje creado";

        }

        private void btnultimomensaje_Click(object sender, EventArgs e)
        {
            this.lsvmensajes.Items.Clear();
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            CloudQueueMessage mensaje = cola.PeekMessage();

            if (mensaje == null)
            {
                this.lblpintar.Text = "no hay mensajes";
            }
            else
            {
                this.lsvmensajes.Items.Add(mensaje.AsString);
            }
        }

        private void btntodosmensajes_Click(object sender, EventArgs e)
        {
            this.lsvmensajes.Items.Clear();
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            foreach (CloudQueueMessage mensaje in cola.GetMessages(32))
            {
                this.lsvmensajes.Items.Add(mensaje.AsString);
            }

        }

        private void btnmodificarmensaje_Click(object sender, EventArgs e)
        {
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            CloudQueueMessage mensaje = cola.GetMessage();
            mensaje.SetMessageContent(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - " + this.txtmensaje.Text);
            cola.UpdateMessage(mensaje, TimeSpan.FromMinutes(5), MessageUpdateFields.Content | MessageUpdateFields.Visibility);
            this.lblpintar.Text = "Mensaje modificado";
        }
        private void btnborrarmensaje_Click(object sender, EventArgs e)
        {
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            CloudQueueMessage mensaje = cola.GetMessage();
            cola.DeleteMessage(mensaje);
            this.lblpintar.Text = "Mensaje eliminado";
        }
        private void btnborrartarea_Click(object sender, EventArgs e)
        {
            CloudQueue cola = this.GetColaMensajes(this.cmbusuarios.SelectedItem.ToString());
            IEnumerable<CloudQueueMessage> mensajes = cola.GetMessages(32);
            foreach (CloudQueueMessage msj in mensajes)
            {
                cola.DeleteMessage(msj);
            }
            this.lblpintar.Text = "cola de mensajes vacia";
        }

        public CloudQueueClient RecuperarCliente()
        {
            String claves = CloudConfigurationManager.GetSetting("cuentastorage");
            CloudStorageAccount cuenta = CloudStorageAccount.Parse(claves);
            CloudQueueClient cliente = cuenta.CreateCloudQueueClient();
            return cliente;

        }        
    }
}
