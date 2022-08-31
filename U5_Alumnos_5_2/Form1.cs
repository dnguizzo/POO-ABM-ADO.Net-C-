using System.Data;
using System.Data.SqlClient;




namespace U5_Alumnos_5_2
{
    public partial class FormAlumno : Form
    {

        private ConexionDB helper;
        private List<Alumno> lst;
        bool nuevo = false;
        public FormAlumno()
        {
            InitializeComponent();

            helper = new ConexionDB();// Relación de composición con la clase Conexion DB.
            lst = new List<Alumno>(); // Relación de Asociación por Agregacion con la clase alumno
        }

        private void FormAlumno_Load(object sender, EventArgs e)
        {

            CargarCombo("select * from Tipos_Documento", "tipo", "id_tipo_documento", cboTipoDocumento);
            CargarCombo("select * from carreras", "carrera", "id_carrera", cboCarrera);
            CargarLista("select * from alumnos");
            Habilitar(false);

        }

        public void Habilitar(bool x)
        {
            panelDatosAlumno.Enabled = x;
            btGrabar.Enabled = x;
            btCancelar.Enabled = x;
            btNuevo.Enabled = !x;
            btEditar.Enabled = !x;
            btBorrar.Enabled = !x;
            btSalir.Enabled = !x;
            lstAlumnos.Enabled = !x;

        }
        private void CargarCombo(string consulta, string displaymember, string valuemember, ComboBox cbo)
        {
            DataTable tabla = helper.ConsultarSQL(consulta);
            cbo.DataSource = tabla;
            cbo.DisplayMember = displaymember;
            cbo.ValueMember = valuemember;

            Habilitar(false);
            Limpiar();
            CargarLista("select * from alumnos");

        }


        private void Limpiar()

        {
         txtApellido.Text = "";
         txtNombre.Text = "";
         txtCalle.Text = "";
         txtNro.Text = "";
         txtCantidad.Text = "";
         txtDoc.Text = string.Empty;
         txtNro.Text= string.Empty;
         cboTipoDocumento.SelectedIndex= -1;
         cboCarrera.SelectedIndex = -1;
         chkActividad.Checked=false;
         chkCasado.Checked= false;
         chkHijos.Checked = false;
         rbtFemenino.Checked= false;
         rbtMasculino.Checked = false;
         dtpFecha.Value = DateTime.Now;



    }
        private void CargarLista(string consulta)
        {
            DataTable tabla = helper.ConsultarSQL(consulta);
            lstAlumnos.Items.Clear();
            lst.Clear();

        foreach (DataRow filas in tabla.Rows)

            {
                Alumno oAlumno = new Alumno();
                /*public Alumno(string apellido, string nombres, DateTime fechaNacimiento, int sexo, int tipoDocumento,
                int documento, string calle, int numero, bool actividad, bool casado, bool hijos, int cantidad, string carrera)*/

                oAlumno.pApellido = filas["apellido"].ToString();
                oAlumno.pNombres = filas["nombre"].ToString();
                oAlumno.pCalle = filas["calle"].ToString();
                oAlumno.pSexo = int.Parse(filas["sexo"].ToString());
                oAlumno.pTipoDocumento = int.Parse(filas["id_tipo_documento"].ToString());
                oAlumno.pDocumento = int.Parse(filas["documento"].ToString());
                oAlumno.pNumero = int.Parse(filas["nro"].ToString());
                oAlumno.pCarrera = int.Parse(filas["id_carrera"].ToString());
                oAlumno.pCasado = bool.Parse(filas["casado"].ToString());
                oAlumno.pActividad = bool.Parse(filas["actividad"].ToString());
                oAlumno.pHijos = bool.Parse(filas["hijos"].ToString());
                oAlumno.pFechaNacimiento = DateTime.Parse(filas["fecha_nacimiento"].ToString());
                lstAlumnos.Items.Add(oAlumno);
                lst.Add(oAlumno);

            }


        }

        private void lstAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validar que el índice seleccionado es correcto:
            if (lstAlumnos.SelectedIndex != -1)
            {
                //Tomar el objeto persona ligado con el ítem seleccionado y actualizar componentes de la clase Lista:
                
                Alumno oAlumno = lst[lstAlumnos.SelectedIndex];
                txtApellido.Text = oAlumno.pApellido.ToString();
                txtNombre.Text = oAlumno.pNombres.ToString();
                txtDoc.Text = Convert.ToString(oAlumno.pDocumento.ToString());
                txtCalle.Text = oAlumno.pCalle.ToString();
                txtNro.Text = oAlumno.pNumero.ToString();
                cboTipoDocumento.SelectedValue = oAlumno.pTipoDocumento;
                cboCarrera.SelectedValue = oAlumno.pCarrera; //"SelectValue->ValueMember"
                if (oAlumno.pSexo == 1)
                    rbtMasculino.Checked = true;
                else
                    rbtFemenino.Checked = true;

                chkActividad.Checked = oAlumno.pActividad;
                chkCasado.Checked = oAlumno.pCasado;
                chkHijos.Checked = oAlumno.pHijos;
                chkActividad.Checked = oAlumno.pActividad;
                txtCantidad.Text = oAlumno.pCantidad.ToString();
                dtpFecha.Value = oAlumno.pFechaNacimiento;

            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;//Aviso que vamos a insertar un registro
            Habilitar(true);
            Limpiar();
            txtApellido.Focus();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar(false);
            nuevo = false;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Dispose();
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text.ToString();
            string nombres = txtNombre.Text.ToString();
            string calle = txtCalle.Text.ToString();
            int numero = int.Parse(txtNro.Text.ToString());
            DateTime fecha = dtpFecha.Value;
            int tipoDocumento = int.Parse(cboTipoDocumento.SelectedValue.ToString());
            int carrera = int.Parse(cboCarrera.SelectedValue.ToString());
            int documento = int.Parse(txtDoc.Text);
            int sexo = 1;
            if (rbtMasculino.Checked)
                sexo = 2;
            bool actividad = chkActividad.Checked;
            bool casado = chkCasado.Checked;
            bool hijos = chkHijos.Checked;

            /* public Alumno(string apellido, string nombres, DateTime fechaNacimiento, int sexo, int tipoDocumento,
            int documento, string calle, int numero, bool actividad, bool casado, bool hijos, int cantidad, int carrera)*/
            Alumno oAlumno = new Alumno(apellido, nombres, fecha,sexo,tipoDocumento, documento,calle,numero,actividad,casado,hijos,cantidad,carrera);


            if (nuevo)
            {
                if (!Existe(documento) && Validar())
                {
                    string query = "INSERT INTO ALUMNOS Values(@apellido,@nombre,@fecha_nacimiento,@sexo, @id_tipo_documento," +
                        "@documento,@calle,@nro,@actividad,@casado,@hijos,@cantidad,@id_carrera)";

                    List<Parametro> lst = new List<Parametro>();
                    lst.Add(new Parametro("@apellido", oAlumno.pApellido));
                    lst.Add(new Parametro("@nombre", oAlumno.pNombres));
                    lst.Add(new Parametro("@fecha_nacimiento", oAlumno.pFechaNacimiento));
                    lst.Add(new Parametro("@sexo", oAlumno.pSexo));
                    lst.Add(new Parametro("@id_tipo_documento", oAlumno.pTipoDocumento));
                    lst.Add(new Parametro("@documento", oAlumno.pDocumento));
                    lst.Add(new Parametro("@calle", oAlumno.pCalle));
                    lst.Add(new Parametro("@nro", oAlumno.pNumero));
                    lst.Add(new Parametro("@actividad", oAlumno.pActividad));
                    lst.Add(new Parametro("@casado", oAlumno.pCasado));
                    lst.Add(new Parametro("@hijos", oAlumno.pHijos));
                    lst.Add(new Parametro("@cantidad", oAlumno.pCantidad));
                    lst.Add(new Parametro("@id_carrera", oAlumno.pCarrera));

                    int filasAfectadas = helper.EjecutarSQL(query, lst);
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Se inserto el producto!", "Confirmación");
                        Limpiar();
                        Habilitar(true);
                        CargarLista("select * from alumnos");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registro con éxito el producto!", "Error");
                    }




                }

                else
                    MessageBox.Show("INFO. El alumno ya existe!", "Validación");


            }
            else
            {

            }
        }


        private bool Existe(int documento)
        {
            bool encontrado = false;
            foreach (Alumno i in lst)
            {
                if (i.pDocumento == documento)
                {
                    encontrado = true;
                    break;
                }
                                
            }
            return encontrado;
        }

        private bool Validar()
        {
            bool result = false;

            //valide campos vacios txtCodigo.Text != String.Empty
            //valide campos numericos
            //cboMarca.SelectedIndex != -1
            //....


            if (String.IsNullOrEmpty(txtApellido.Text) ||
                String.IsNullOrEmpty(txtDoc.Text) ||
                cboTipoDocumento.SelectedIndex == -1)
            { result = false; }

            if (dtpFecha.Value > DateTime.Now)
            { result = false; }

            return result;

                           
            
            
            return true;

        }
        private void btEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            //txtDocumento.Enabled = false;  no esta disponible porque es la PK y no se puede editar.
            txtApellido.Focus();
            nuevo = false;
        }
    }
}