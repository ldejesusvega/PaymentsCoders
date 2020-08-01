using Newtonsoft.Json;
using Payment.Domain;
using Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaymentsUI
{
    public partial class frmPayments : Form
    {
        public frmPayments()
        {
            InitializeComponent();
            BindDgPayments();
            numAmount.Minimum = 0;
            numAmount.Maximum = 10000000000;
            numAmount.DecimalPlaces = 2;
            numAmount.Increment = 0.01m;
        }

        private async void BindDgPayments()
        {
            dgPayments.DataSource = null;
            if (dgPayments.ColumnCount > 0)
            {
                dgPayments.Columns.Remove("Edit");
                dgPayments.Columns.Remove("Del");
            }

            var prt = await RestClient.GetAllPayments();
            ResultT r = JsonConvert.DeserializeObject<ResultT>(prt);
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Concept", typeof(string));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("Date", typeof(DateTime));
            if (r.PaymentResourceList.Any())
            {
                foreach (var x in r.PaymentResourceList)
                {
                    dt.Rows.Add(x.Id, x.Concept, x.Amount, x.Date.ToShortDateString());
                }
            }
            else if (r.PaymentResource != null)
            {
                dt.Rows.Add(r.PaymentResource.Id, r.PaymentResource.Concept, r.PaymentResource.Amount, r.PaymentResource.Date.ToShortDateString());
            }
            dgPayments.DataSource = dt;

            Image img = Image.FromFile(Application.StartupPath + "\\edit.png");
            DataGridViewImageColumn editCol = new DataGridViewImageColumn
            {
                Image = img,
                HeaderText = "Editar",
                Name = "Edit",
                ToolTipText = "Editar",
                Width = 50
            };
            dgPayments.Columns.Insert(4, editCol);

            Image imgDel = Image.FromFile(Application.StartupPath + "\\erase.png");
            DataGridViewImageColumn imgDelCol = new DataGridViewImageColumn
            {
                Image = imgDel,
                HeaderText = "Borrar",
                Name = "Del",
                ToolTipText = "Borrar",
                Width = 50
            };
            dgPayments.Columns.Insert(5, imgDelCol);

            dgPayments.Columns["Amount"].Width = 70;
            dgPayments.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgPayments.Columns["Amount"].DefaultCellStyle.Format = "c";

        }

        private async void dgPayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                DataGridViewRow row = dgPayments.Rows[e.RowIndex];
                var x = await RestClient.Delete(row.Cells["Id"].Value.ToString());
                ResultT r = JsonConvert.DeserializeObject<ResultT>(x);
                if (r.IsSuccess)
                {
                    MessageBox.Show("Pago " + row.Cells["Concept"].Value + " Eliminado", "Pago - Mensaje!");
                }
                else
                {
                    MessageBox.Show("Hubo un error al borrar : " + row.Cells["Concept"].Value + ". ", "Pago - Mensaje!");
                }
                dgPayments.EndEdit();
                pnlsSwtich(1);
                CleanAddPayment();
                ValidationOff();
                BindDgPayments();
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgPayments.Rows[e.RowIndex];
                pnlsSwtich(2);
                CleanAddPayment();
                ValidationOn();
                lblPaymentId.Text = row.Cells["Id"].Value.ToString();
                var x = await RestClient.GetPaymentById(row.Cells["Id"].Value.ToString());
                ResultT r = JsonConvert.DeserializeObject<ResultT>(x);
                txtConcepto.Text = r.PaymentResource.Concept;
                numAmount.Value = r.PaymentResource.Amount;
                dtDate.Value = r.PaymentResource.Date;
                lblTituloPaymentOpciones.Text = "Editar Pago";
                dgPayments.EndEdit();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CleanAddPayment();
            pnlsSwtich(2);
            ValidationOn();
            lblPaymentId.Text = "0";
            lblPaymentAction.Text = "Agregar Pago";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CleanAddPayment()
        {
            txtConcepto.Text = string.Empty;
            numAmount.Value = 0;
            dtDate.Value = this.dtDate.MinDate;
        }

        private void pnlsSwtich(int step)
        {
            switch (step)
            {
                case 1:
                    gpoOpciones.Visible = true;
                    gpoAddPayments.Visible = false;
                    break;
                case 2:
                    gpoOpciones.Visible = false;
                    gpoAddPayments.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void ValidationOff()
        {
            txtConcepto.CausesValidation = false;
            numAmount.CausesValidation = false;
            dtDate.CausesValidation = false;
            btnGuardar.CausesValidation = false;
        }

        private void ValidationOn()
        {
            txtConcepto.CausesValidation = true;
            numAmount.CausesValidation = true;
            dtDate.CausesValidation = true;
            btnGuardar.CausesValidation = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CleanAddPayment();
            pnlsSwtich(1);
            ValidationOff();
            lblPaymentId.Text = string.Empty;
            lblPaymentAction.Text = string.Empty;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool tpi = false;
            int id = 0;
            string message = string.Empty;
            string response = string.Empty;
            SavePaymentResource pr = new SavePaymentResource()
            {
                Concept = txtConcepto.Text.Trim(),
                Amount = numAmount.Value,
                Date = dtDate.Value
            };

            tpi = int.TryParse(lblPaymentId.Text, out id);
            if (tpi)
            {
                if (id == 0)
                {
                    response = await RestClient.Post(pr);
                    message = "Result : \r " + "Pago : " + txtConcepto.Text.Trim() + " creado.";
                }
                else if (id > 0)
                {
                    response = await RestClient.Put(lblPaymentId.Text.Trim(), pr);
                    message = "Result : \r " + "Pago : " + txtConcepto.Text.Trim() + " actualizado.";
                }

                ResultT r = JsonConvert.DeserializeObject<ResultT>(response);
                if (r.IsSuccess == true)
                {
                    MessageBox.Show(message + ",  " + r.Status, "Pago - Mensaje!");
                    pnlsSwtich(1);
                    CleanAddPayment();
                    ValidationOff();
                    BindDgPayments();
                    lblPaymentId.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error, revise su información", "Pago - Mensaje!");
            }
        }
    }
}
