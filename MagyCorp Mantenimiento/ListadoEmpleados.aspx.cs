
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//AGREGAMOS ESTAS DOS LIBRERIAS PARA PODER EJECUTAR LOS COMANDOS DE SQL
using System.Data;
using System.Data.SqlClient;

//EL NOMBRE DE LA EMPRESA A LA QUE LE HAREMOS EL MANTENIMIENTO
namespace MagyCorp_Mantenimiento
{


    public partial class ListadoEmpleados : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            listado();  
                    
        }

//FUNCION DEL BOTON EDITAR

        protected void ibtnEditar_Click(object sender, ImageClickEventArgs e)
        {
        }

//FUNCION DEL BOTON AGREGAR

        protected void ibtnAdd_Click(object sender, EventArgs e)
        {
//CONEXION CON LA BASE DE DATOS
            int idempleado = 0;
            try { 
                idempleado = int.Parse(txbID.Text);
            } catch(Exception){}

            if (idempleado > 0)
            {
                actualizar(idempleado);
            }
            else {
                agregar();
            }
            listado();                       
        }

        protected void agregar() {
            string listado = "Data Source=.;Initial Catalog=MagyCorp_bd;Integrated Security=True";
            SqlConnection conectar = new SqlConnection(listado);

            string consulta = "INSERT INTO Empleados values (@Nombre, @Apellido, @Puesto, @Sueldo, @Telefono)";
            SqlCommand ejec = new SqlCommand(consulta, conectar);


            //APERTURA DE LA CONEXION
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            string puesto = txbPuesto.Text;
            double sueldo = double.Parse(txbSueldo.Text);
            string tel = txbTelefono.Text;

            conectar.Open();
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Nombre", nombre);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Apellido", apellido);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Puesto", puesto);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Sueldo", sueldo);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Telefono", tel);


            ejec.ExecuteReader();
            //CIERRE DE LA CONEXION

            conectar.Close();

            txbNombre.Text = "";
            txbApellido.Text = "";
            txbPuesto.Text = "";
            txbTelefono.Text = "";
            txbSueldo.Text = "";
        }

        protected void actualizar(int idempleado) {
            string listado = "Data Source=.;Initial Catalog=MagyCorp_bd;Integrated Security=True";
            SqlConnection conectar = new SqlConnection(listado);

            string consulta = "UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido, Puesto = @Puesto, Sueldo = @Sueldo, Telefono = @Telefono WHERE ID_empleado = @ID_empleado";
            SqlCommand ejec = new SqlCommand(consulta, conectar);


            //APERTURA DE LA CONEXION
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            string puesto = txbPuesto.Text;
            double sueldo = double.Parse(txbSueldo.Text);
            string tel = txbTelefono.Text;

            conectar.Open();
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@ID_empleado", idempleado);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Nombre", nombre);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Apellido", apellido);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Puesto", puesto);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Sueldo", sueldo);
            ejec.CommandType = CommandType.Text;
            ejec.Parameters.Add("@Telefono", tel);


            ejec.ExecuteReader();
            //CIERRE DE LA CONEXION

            conectar.Close();

            txbID.Text = "";
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbPuesto.Text = "";
            txbTelefono.Text = "";
            txbSueldo.Text = "";
        }

//FUNCION DEL BOTON AGREGAR O DESPLEGAR

        protected void listado()
        {
            string mostrar = "Data Source=.;Initial Catalog=MagyCorp_bd;Integrated Security=True";
            SqlConnection conex = new SqlConnection(mostrar);
            conex.Open();

            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM Empleados", conex);
            DataSet dts = new DataSet();

            
//LLENADO DEL GRIDVIEW CON LOS DATOS DE LA BASE DE DATOS

            adp.Fill(dts, "Empleados");

            GV.DataSource = dts;
            GV.DataBind();
            conex.Close();


        }

//FUNCION DEL BOTON ELIMINAR

        protected void ibtnEliminar_Click(object sender, EventArgs e)
        {


//CONEXION CON LA BASE DE DATOS
            string eliminar = "Data Source=.;Initial Catalog=MagyCorp_bd;Integrated Security=True";
            SqlConnection conex = new SqlConnection(eliminar);

            string nm = "DELETE FROM  Empleados WHERE ID_empleado = @ID_empleado";
            SqlCommand comd = new SqlCommand(nm, conex);

            conex.Open();
            comd.CommandType = CommandType.Text;
            comd.Parameters.Add("@ID_empleado", SqlDbType.NVarChar, 50).Value = txbID.Text;
            comd.ExecuteReader();
            conex.Close();

            txbID.Text = "";
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbPuesto.Text = "";
            txbTelefono.Text = "";
            txbSueldo.Text = "";
            listado();
        }

        protected void GV_SelectedIndexChanged(object sender, EventArgs e){
            string idempleado;
            GridViewRow row = GV.SelectedRow;
            idempleado = row.Cells[1].Text;
            txbID.Text = idempleado;
            txbNombre.Text = row.Cells[2].Text;
            txbApellido.Text = row.Cells[3].Text;
            txbPuesto.Text = row.Cells[4].Text;
            txbSueldo.Text = row.Cells[5].Text;
            txbTelefono.Text = row.Cells[6].Text;
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbNombre.Text = "";
            txbApellido.Text = "";
            txbPuesto.Text = "";
            txbTelefono.Text = "";
            txbSueldo.Text = "";
            listado();
        }         
                        
    }
}