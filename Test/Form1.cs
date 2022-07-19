using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Form1 : Form
    {
        //Inicializar Comando para Iniciar la Conexion
        //Nota: en C# se debe escribir la contraseña en texto tal cual, taparlo luego
        public static String Contra = Environment.GetEnvironmentVariable("PassSQL", EnvironmentVariableTarget.User);
        public string cs = "Data Source=localhost;Initial Catalog=Tupperware;User ID=root;Password="+Contra+"";
        //Inicializar la Variable de la Conexion
        public MySqlConnection conn = null;
        public int n;
        public Form1()
        {
            
            InitializeComponent();
            //Se Declara la conexion con el comando antes inizializado
            conn = new MySqlConnection(cs);
            //Se abre un try-catch debido a que SQL es su propia cosa con los errores, asi que
            //se abre uno para todo lo relacionado con SQL
            try
            {
                //Se abre la conexion con el servidor
                conn.Open();
                String[] datos;

                //Logica de una Peticion
                //1.- Hacer la Peticion [Linea 44]
                //2.- Designar una variable para que reciba lo que mandó el servidor [Reader, Inicializado 42, Ejecutado 46]
                //3.- Manejar la Respuesta dependiendo del Resultado [el While de Linea 48]

                //inizializar el lector, el Reader es para recibir una respuesta del servidor
                MySqlDataReader Reader = null;
                //Crear un Comando para el servidor
                MySqlCommand cmd = new MySqlCommand("select * from Clientes", conn);
                //Ejecutar el Reader con el comando.
                Reader = cmd.ExecuteReader();
                //Consecuencia de lo que ocurrió.
                while (Reader.Read())
                {
                    //En caso de que haya lineas, registrará lo recibido
                    if (Reader.HasRows)
                    {
                        //Registra los campos de la base de datos a variables del programa
                        String id = Reader.GetValue(Reader.GetOrdinal("id")).ToString();
                        String NumCliente = Reader.GetValue(Reader.GetOrdinal("NumCliente")).ToString();
                        String Nombre = Reader.GetValue(Reader.GetOrdinal("Nombre")).ToString();
                        String Direccion = Reader.GetValue(Reader.GetOrdinal("Direccion")).ToString();
                        String Telefono = Reader.GetValue(Reader.GetOrdinal("Telefono")).ToString();
                        String UltimoPedido = Reader.GetValue(Reader.GetOrdinal("UltimoPedido")).ToString();
                        //Se agrega lo recibido a un array, y este se agrega a la Tabla.
                        datos = new string[]{id,NumCliente, Nombre, Direccion, Telefono, UltimoPedido};
                        GridViewTabla.Rows.Add(datos);
                    }
                    else {}
                //Siempre que se abra un reader hay que cerrarlo.
                }Reader.Close();
            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Van a haber muchas request para enviar al SQL, asi que decidí hacer una funcion que haga eso
        private void ComandoSql(string com)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(com, conn);
                MySqlDataReader Reader = cmd.ExecuteReader();
                Reader.Close();
            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //El mismo checker del programa pasado, ahora adaptado a las funciones de la base de datos
        private void Checker()
        {
            //Cada vez que se inicie resetear n a 0 por motivos de seguridad
            n = 0;
            n = textBoxNumCliente.TextLength != 0 ? n + 1 : n + 0;
            n = textBoxNombre.TextLength != 0 ? n + 2 : n + 0;
            n = textBoxDireccion.TextLength != 0 ? n + 3 : n + 0;
            n = textBoxTelefono.TextLength != 0 ? n + 4 : n + 0;
            n = textBoxUltimoPedido.TextLength != 0 ? n + 5 : n + 0;
        }
        //En Modificar y en Consultar uso el mismo procedimiento de sacar un string, el texto del campo
        //y el indice de la columna que corresponde, asi que hice una funcion para no hacerlo dos veces
        private string[] Prefix()
        {
            //array para devolver 3 valores
            string[] prefix = new string[3];
            Checker();
            if (n <= 5)
            {
                switch (n)
                {
                    case 1:
                        prefix[0] = "NumCliente";
                        prefix[1] = textBoxNumCliente.Text;
                        prefix[2] = "1";

                        break;
                    case 2:
                        prefix[0] = "Nombre";
                        prefix[1] = textBoxNombre.Text;
                        prefix[2] = "2";
                        break;
                    case 3:
                        prefix[0] = "Direccion";
                        prefix[1] = textBoxDireccion.Text;
                        prefix[2] = "3";
                        break;
                    case 4:
                        prefix[0] = "Telefono";
                        prefix[1] = textBoxTelefono.Text;
                        prefix[2] = "4";
                        break;
                    case 5:
                        prefix[0] = "UltimoPedido";
                        prefix[1] = textBoxUltimoPedido.Text;
                        prefix[2] = "5";
                        break;
                    default:
                        MessageBox.Show("Tiene que seleccionar un solo campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un solo campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return prefix;
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            //Contar la cantidad de n
            Checker();

            
            if (n == 15)
            {
                //Lo mismo que el programa pasado
                String GridNumCliente = textBoxNumCliente.Text;
                String GridNombre = textBoxNombre.Text;
                String GridDireccion = textBoxDireccion.Text;
                String GridTelefono = textBoxTelefono.Text;
                String GridUltimoPedido = textBoxUltimoPedido.Text;
                //el Id en el GridView y en el SQL funcionan distinto, asi que se saca el Rows.Count
                String GridId = GridViewTabla.Rows.Count.ToString();
                
                String[] GridDatos = { GridId, GridNumCliente, GridNombre, GridDireccion, GridTelefono, GridUltimoPedido };
                GridViewTabla.Rows.Add(GridDatos);
                //C gran comando SQL
                String InsertTabla = 
                "insert into Clientes (Id, NumCliente, Nombre, Direccion, Telefono, UltimoPedido) " +
                "values ("+GridId+"," + GridNumCliente + ",'" + GridNombre + "','" + GridDireccion + "'," + GridTelefono + ",'" + GridUltimoPedido + "')";
                ComandoSql(InsertTabla);
                
                textBoxNumCliente.Text = "";
                textBoxNombre.Text = "";
                textBoxDireccion.Text = "";
                textBoxTelefono.Text = "";
                textBoxUltimoPedido.Text = "";
            }
            else
            {
                //Ahora le puse una ventana de Error para indicar lo que se debe hacer
                MessageBox.Show("Se tiene que Llenar todos los Campos.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //Recibir el array con el Checker
            string[] prefix = Prefix();
            if (GridViewTabla.CurrentCell != null)
            {
                /* Que se va a hacer ?
                 * buscar con dos foreach los index de la fila y la columna de la celda que va a ser modificada
                 * para esto se usaran dos foreach, uno para las filas y otro para las columnas, con unos filtros
                 * que permiten saltarse el proceso hasta que sea exactamente el campo que se busca y asi reemplazarlo.
                 */
                //Variables
                int index = GridViewTabla.CurrentCell.RowIndex;
                int fila = -1; int col = -1;
                //Para el comando de SQL necesito guardar el valor que se va a eliminar, por eso esta variable
                string antiguo ="";
                foreach (DataGridViewRow rows in GridViewTabla.Rows)
                {
                    fila++;
                    foreach(DataGridViewCell c in rows.Cells)
                    {  
                        //Primer filtro que no deja avanzar hasta que las rows sean las del index seleccionado
                        if (c.RowIndex != index) { continue; }
                        col++;
                        //Segundo filtro que no deja avanzar hasta que los index de las columnas coincidan.
                        if (c.ColumnIndex != int.Parse(prefix[2])) { continue;}
                        //Guardar el valor antes de reemplazarlo
                        antiguo = GridViewTabla.Rows[fila].Cells[col].Value.ToString();
                        GridViewTabla.Rows[fila].Cells[col].Value = prefix[1];                      
                    }
                }
                //Comando de MySql
                string mod = "update Clientes set "+prefix[0]+"= '"+prefix[1]+"' where "+prefix[0]+"= '"+antiguo+"' ";
                ComandoSql(mod);
                textBoxNumCliente.Text = "";
                textBoxNombre.Text = "";
                textBoxDireccion.Text = "";
                textBoxTelefono.Text = "";
                textBoxUltimoPedido.Text = "";
            }
            
        }

        //Este tiene una logica similar al de Modificar, mas este necesita filtros distintos ya que tiene un fin distinto
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            string[] prefix = Prefix();

            int fila = -1; int col = -1;
            foreach (DataGridViewRow rows in GridViewTabla.Rows)
            {
                fila++;
                foreach (DataGridViewCell c in rows.Cells)
                {
                    //El primer filtro no permite que avance hasta que el valor de la celda sea el mismo al valor de lo escrito
                    if (c.Value?.ToString() != prefix[1]) { continue; }
                    col++;
                    //Segundo filtro que no permite que avance hasta que el valor los index de las columnas sean iguales
                    if (c.ColumnIndex.ToString() != prefix[2]) { continue; }
                    //Aqui solamente se va a resaltar la casilla que se busca
                    GridViewTabla.CurrentCell = GridViewTabla.Rows[fila].Cells[col];
                   
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (GridViewTabla.CurrentCell != null)
            {
                //C Viene el Absoluto Conchesumadre
                /* La idea para Eliminar es pues eliminar registros tanto de la GridView como de la 
                 * tabla en SQL, el problema es que esto hace que se desactualize el Id, osease si elimino el
                 * registro con el id 2, habrá un hueco en el registro 1 y 3, la idea es que tambien se actualize
                 * el registro 3 y se vuelva el registro 2.
                 * Decidí inventarme un ciclo for de comandos para SQL
                 * MySQL no tiene variables ni ciclos, asi que aplicaré esas dos cosas aqui para ver si funciona
                 */

                //Iniciar Variables antes de eliminar
                int IdEliminar = (GridViewTabla.CurrentCell.RowIndex + 1);
                int TotalFilas = (GridViewTabla.Rows.Count);
                string Actualizar="";

                //Eliminar las filas tanto en el GridView como en el SQL
                GridViewTabla.Rows.RemoveAt(GridViewTabla.CurrentCell.RowIndex);
                string eliminar = "delete from Clientes where Id = "+IdEliminar.ToString();
                ComandoSql(eliminar);
                //C viene este pedo, i va a pasar hasta el total de filas que habia antes de eliminar todo
                for (int i = 0; i < TotalFilas; i++)
                {   //lo que hace esto es establecer el valor eliminado mas i al valor que este por arriba
                    //en un inicio empieza con 0, asi que si el valor de arriba es 3 pasa a ser 2, si es 4 pasa a 3 y asi
                    Actualizar = "update Clientes set Id=" + (IdEliminar + i) + " where Id=" + (IdEliminar + i + 1);
                    ComandoSql(Actualizar);
                    //Resetear esta variable porque cosas
                    Actualizar = "";
                }
               
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
