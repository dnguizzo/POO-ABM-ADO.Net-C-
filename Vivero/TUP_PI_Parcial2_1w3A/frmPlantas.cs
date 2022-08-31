using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TUP_PI_Parcial2_13A;

//CURSO: – LEGAJO: – APELLIDO: – NOMBRE:
//Cadena de Conexión: "Data Source=138.99.7.66,1433;Initial Catalog=TUPI_Vivero;User ID=tup1_vivero;Password=@tup1_Vive"

namespace TUP_PI_Parcial2_1w3A
{
    public partial class frmPlantas : Form
    {
        private HelperDB helper;
        private Accion accion;

        public frmPlantas()
        {
            InitializeComponent();
            helper = new HelperDB();
            accion = Accion.NUEVO;
        }

        private void frmPlantas_Load(object sender, EventArgs e)
        {
            ListarPlantas();
            CargarCombo();

        }

        private void CargarCombo()
        {
            cboEspecie.DataSource = helper.EjecutarQuery("SELECT * FROM Especies");
            cboEspecie.DisplayMember = "nombreEspecie";
            cboEspecie.ValueMember = "idEspecie";

        }

        private void ListarPlantas()
        {
            lstPlantas.Items.Clear();
            dgvPlantas.Rows.Clear();
            DataTable dtPlantas = helper.EjecutarQuery("SELECT * FROM Plantas");
            foreach (DataRow row in dtPlantas.Rows)
            {
                Planta oPlanta = new Planta();
                oPlanta.pCodigo = Convert.ToInt32(row["codigo"].ToString());
                oPlanta.pNombre = row["nombre"].ToString();
                oPlanta.pEspecie = (int)row["especie"];
                oPlanta.pPrecio = (double)row["precio"];
                oPlanta.pFecha = (DateTime)row["fecha"];

                // lstPlantas.Items.Add(oPlanta);
                dgvPlantas.Rows.Add(new object[] { oPlanta.pCodigo, oPlanta.pNombre, oPlanta.pPrecio, oPlanta.pFecha, oPlanta.pEspecie });

            }
            
            


        }

        private void lstPlantas_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lstPlantas.SelectedIndex != -1)
            {
                Planta p = (Planta)lstPlantas.SelectedItem;
                txtCodigo.Text = p.pCodigo.ToString();
                txtNombre.Text = p.pNombre;
                cboEspecie.SelectedValue = p.pEspecie;
                txtPrecio.Text = p.pPrecio.ToString();
                dtpFecha.Value = p.pFecha;
                btnBorrar.Enabled = true;
                btnEditar.Enabled = true;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Planta oPlanta = new Planta();
                oPlanta.pCodigo = Convert.ToInt32(txtCodigo.Text);
                oPlanta.pNombre = txtNombre.Text;
                oPlanta.pEspecie = Convert.ToInt32(cboEspecie.SelectedValue.ToString());
                oPlanta.pPrecio = Convert.ToDouble(txtPrecio.Text);
                oPlanta.pFecha = dtpFecha.Value;

                string query = String.Empty;
                if (accion == Accion.NUEVO)
                {
                    query = "INSERT INTO PLANTAS Values(@codigo,@nombre,@especie,@precio,@fecha)";
                }
                else if(accion == Accion.EDITAR)
                {
                    query = "UPDATE PLANTAS SET nombre=@nombre,especie = @especie,precio = @precio,fecha = @fecha WHERE codigo = @codigo";
                }

                int filas = helper.EjecutarNonQuery(query, oPlanta);
                if(filas == 1)
                {
                    MessageBox.Show("Esto es un Éxito!", "Disney");
                    ListarPlantas();
                    Habilitar(false);
                    btnBorrar.Enabled = false;
                    btnEditar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error. No se pudo actualizar la BD!", "NPI");
                }


            }
            else
            {
                MessageBox.Show("Error de validación, revise los datos ingresados!", "Validaciones");
            }
        }

        private bool validar()
        {
            bool result = true;

            if (String.IsNullOrEmpty(txtCodigo.Text) || (Existe(txtCodigo.Text)&& accion == Accion.NUEVO))
                result = false;

            if(String.IsNullOrEmpty(txtNombre.Text))
                result = false;

            if (cboEspecie.SelectedIndex == -1)
                result = false;

            if(String.IsNullOrEmpty(txtPrecio.Text))
                result = false;

            if (dtpFecha.Value > DateTime.Now)
                result = false;

            return result;
        }

        private bool Existe(string codigo)
        {
           foreach(DataGridViewRow fila in dgvPlantas.Rows)
            {
                if (fila.Cells["colCodigo"].Value.ToString().Equals(codigo))
                    return true;
            }
            return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void dgvPlantas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlantas.CurrentRow.Index != -1)
            {
                txtCodigo.Text = dgvPlantas.CurrentRow.Cells["colCodigo"].Value.ToString();
                txtNombre.Text = dgvPlantas.CurrentRow.Cells["colNombre"].Value.ToString();
                cboEspecie.SelectedValue = Convert.ToInt32(dgvPlantas.CurrentRow.Cells["colEspecie"].Value.ToString());
                txtPrecio.Text = dgvPlantas.CurrentRow.Cells["colPrecio"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(dgvPlantas.CurrentRow.Cells["colFecha"].Value.ToString());
                btnBorrar.Enabled = true;
                btnEditar.Enabled = true;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            accion = Accion.EDITAR;
        }

        private void Habilitar(bool val)
        {
            gbFormulario.Enabled = val;
            btnCancelar.Enabled = val;
            btnGuardar.Enabled = val;
            dgvPlantas.Enabled = !val;
            btnSalir.Enabled = !val;
            btnNuevo.Enabled = !val;
            btnEditar.Enabled = !val;
            btnBorrar.Enabled = !val;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {   
            Habilitar(true);
            Limpiar();
            accion = Accion.NUEVO;
        }

        private void Limpiar()
        {
            txtCodigo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            dtpFecha.Value = DateTime.Now;
            cboEspecie.SelectedIndex = -1;
            txtCodigo.Enabled = true;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }

    enum Accion
    {
        NUEVO, 
        EDITAR, 
        BORRAR, 
        LEER
    }

}
