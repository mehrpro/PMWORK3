using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PMWORK.Entities;

namespace PMWORK.MachineryForms
{
    public partial class RequestRepairForm : XtraForm
    {
        private AppDbContext _db;
        private readonly int _typeofRequest;
        private ComboBoxBaseClass _selectCompany;
        private Applicant _selectApplicant;

        public RequestRepairForm(int typeofRequest)
        {
            InitializeComponent();
            _db = new AppDbContext();
            _typeofRequest = typeofRequest;
            dateRegistered.DateTime = DateTime.Now;


            cbxMachinery.Properties.DisplayMember = "Coding.Code";
            cbxMachinery.Properties.ValueMember = "ID";

            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxApplicant.Properties.DisplayMember = "ApplicantTitle";
            cbxApplicant.Properties.ValueMember = "ID";


            var str = _db.PublicTypes.Find(typeofRequest).Title;
            txtRequestTitle.Text += @" " + str;
            ClearForm();
            Task task = UpdateCompany();

        }

        private async Task UpdateApplicant(int companyId)
        {
            cbxApplicant.Properties.DataSource = await _db.Applicants.Where(x => x.CompanyID_FK == companyId).ToListAsync();

        }

        private async Task UpdateCompany()
        {
            cbxCompany.Properties.DataSource = await _db.Companies.Select(x => new ComboBoxBaseClass() { ID = x.ID, Title = x.CompanyTiltle, Tag = x.Description }).ToListAsync();
            //return true;
        }


        private void ClearForm()
        {
            dateRegistered.DateTime = DateTime.Now;
            radioGroupEMPM.SelectedIndex = 0;
            txtRequest.Text = "";

        }
        private async Task UpdateMachinery(int applicantIdFk)
        {
            cbxMachinery.Properties.DataSource = await _db.Machineries
                .Include(c => c.Coding)
                .Where(x => x.ApplicantID_FK == applicantIdFk)
                .ToListAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            var obj = new RequestRepair()
            {
                IsActive = true,
                MachineryID_FK = Convert.ToInt32(cbxMachinery.EditValue),
                CompanyID_FK = Convert.ToInt32(cbxCompany.EditValue),
                ApplicantID_FK = Convert.ToInt32(cbxApplicant.EditValue),
                UserID_FK = PublicClass.UserID,
                PublicTypeID_FK = _typeofRequest,
                EM = Convert.ToBoolean(radioGroupEMPM.EditValue),
                RequestDataTime = DateTime.Now,
                RequestTitle = txtRequest.Text.Trim()
            };
            _db.RequestRepairs.Add(obj);
            await _db.SaveChangesAsync();
            Close();


        }



        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                txtMachinery.Text = "";
                cbxApplicant.Properties.DataSource = null;
                return;
            }
            // txtMachinery.Text = SelectCompany.MachineryTitle;
            await UpdateApplicant(_selectCompany.ID);

        }

        private async void cbxMachinery_EditValueChanged_1(object sender, EventArgs e)
        {
            var SelectedMachinery = (Machinery)cbxMachinery.GetSelectedDataRow();
            if (SelectedMachinery == null)
            {
                txtMachinery.Text = "";
                cbxApplicant.Properties.DataSource = null;
                return;
            }
            txtMachinery.Text = SelectedMachinery.MachineryTitle;
            //await UpdateApplicant(SelectedMachinery.ID);
        }

        private async void cbxApplicant_EditValueChanged(object sender, EventArgs e)
        {
            _selectApplicant = (Applicant)cbxApplicant.GetSelectedDataRow();
            if (_selectApplicant == null)
            {
                cbxMachinery.EditValue = null;
                return;
            }
            await UpdateMachinery(_selectApplicant.ID);
        }
    }
}
