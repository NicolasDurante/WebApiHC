using HC.WebApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HC.WebApi.Controllers;
using Newtonsoft.Json;

namespace Fronend.Prueba
{

    //Esto es una prueba para resivir (serializar y deserializar) los datos traidos de la web api

    /*El projecto HC.WebApi se conecta con la base de datos central de manera local en Web.Config
     en la seccion conection string.
     En la carpeta Controllers Estan los controles en entityFramework donde ya estan programados
     todos los verbos (Get,Put,Post,Delete) estan programados usando los modelos de la BDCentral
     que estan en Model.edmx/model.tt

     al ejecutar el programa la api ya se ejecuta y esta en funcionamiento
     Para usarla en el form teniendo los using( using System.Net.Http; y using Newtonsoft.Json;)
     Se crea una variable que tiene la url de la api y llamando a client(la url) y .GetAsync o PutAsync . result se trae una lista de el modelo de la web api en la url 
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Ejemplo traer datos  para un objeto persona
        private void Get(string dato)
        {
            //client es el la direcion Http +/api+ dato que es Personas
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53382/api");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(client.BaseAddress + dato).Result;
            //response usa GetAsync para traer los valores de la url en responce en una lista



            if (response.IsSuccessStatusCode)
            {
                //data es una string de responce 
                var data = response.Content.ReadAsStringAsync().Result;
                
                //persona es una instancia de una lista de personas
                var personas = new List<persona>();

                //este codigo deserializa data y puebla el objeto persona automaticamente
                Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), personas);

                //ejemplo para mostrar en datagridview
                dataGridView1.DataSource = personas;
                
            }
            
        }

        private void Post(string dato)
        {
            //ejemplo instancia de persona
            persona nuevaPersona = new persona();

            nuevaPersona.Persona_id = Convert.ToInt32(txtbPersona_id.Text);
            nuevaPersona.DNI = Convert.ToInt32(txtbDNI.Text);
            nuevaPersona.Nombre = txtbNombre.Text;
            nuevaPersona.Apellido = textBoxapelido.Text;
            nuevaPersona.Edad = Convert.ToInt32(textBEdad.Text);
            nuevaPersona.Sexo = textBSexo.Text;
            nuevaPersona.Estado_Civil = textBEstadoCivil.Text;
            nuevaPersona.E_Mail = txtbDNI.Text;
            nuevaPersona.Celular = textBCelular.Text;
            nuevaPersona.TelFijo = textBTelFijo.Text;
            nuevaPersona.Fecha_Nacimiento = Convert.ToDateTime(textBFechaNac.Text);
            nuevaPersona.Nacionalidad = textBNacionalidad.Text;
            nuevaPersona.Prov_Nacimiento = textBProv_na.Text;
            //nueva persona ya es un objeto con datos cargados con textbox

            

            //Client es Url Http
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53382/api");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //response hace un post a client+base+data con el objeto nueva persona (objeto ya serializado automaticamente)
            var response = client.PostAsJsonAsync(client.BaseAddress + dato, nuevaPersona).Result;
            //response ya es un post exitoso
        }

        private void Put(string dato)
        {
            //instancia de persona con datos cargados en txtbox
            persona nuevaPersona = new persona();

            nuevaPersona.Persona_id = Convert.ToInt32(txtbPersona_id.Text);
            nuevaPersona.DNI = Convert.ToInt32(txtbDNI.Text);
            nuevaPersona.Nombre = txtbNombre.Text;
            nuevaPersona.Apellido = textBoxapelido.Text;
            nuevaPersona.Edad = Convert.ToInt32(textBEdad.Text);
            nuevaPersona.Sexo = textBSexo.Text;
            nuevaPersona.Estado_Civil = textBEstadoCivil.Text;
            nuevaPersona.E_Mail = textBEmail.Text;
            nuevaPersona.Celular = textBCelular.Text;
            nuevaPersona.TelFijo = textBTelFijo.Text;
            nuevaPersona.Fecha_Nacimiento = Convert.ToDateTime(textBFechaNac.Text);
            nuevaPersona.Nacionalidad = textBNacionalidad.Text;
            nuevaPersona.Prov_Nacimiento = textBProv_na.Text;


            //url
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53382/api");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //Put en json con url mas la instacia nueva persona serializado
            var response = client.PutAsJsonAsync(client.BaseAddress + dato +"/"+ Convert.ToString( nuevaPersona.Persona_id), nuevaPersona).Result;

            //responese ya es un put exitoso
        }

        private void Delete(string dato)
        {
           //url
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:53382/api");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //delete client y el nombre de el control Personas en txtbox
            var response = client.DeleteAsync(txtboxDelete.Text).Result;

        }

        //el resto son las acciones en botones

        private void btTraerDatos_Click(object sender, EventArgs e)
        {
            string datos=$"/{textboxDatos.Text}";

            Get(datos);
        }

        private void btPost_Click(object sender, EventArgs e)
        {
            string datos = $"/{textboxDatos.Text}";
            Post(datos);
        }

        private void btput_Click(object sender, EventArgs e)
        {
            string datos = $"/{textboxDatos.Text}";
            Put(datos);
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            string datos = $"/{textboxDatos.Text}";
            Delete(datos);
        }
    }
}
