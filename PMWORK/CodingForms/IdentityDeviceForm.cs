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
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class IdentityDeviceForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private ComboBoxBaseClass _selectedCompany;
        private ComboBoxBaseClass _selectedApplicant;

        public IdentityDeviceForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies().Select(x => new ComboBoxBaseClass
            {
                ID = x.ID,
                Title = x.CompanyTitle,
                Tag = x.Description
            }).ToList(); ;
            cbxApplicantList.Properties.DisplayMember = "Title";
            cbxApplicantList.Properties.ValueMember = "ID";





        }

        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectedCompany == null)
            {
                cbxApplicantList.Properties.DataSource = null;
                return;
            }
            cbxApplicantList.Properties.DataSource =
                _codingRepository.GetApplicantsByCompanyId(_selectedCompany.ID)
            .Select(x => new ComboBoxBaseClass
            {
                ID = x.ID,
                Title = x.ApplicantTitle,
                Tag = x.Description
            }).ToList();
        }


        private void cbxApplicantList_EditValueChanged(object sender, EventArgs e)
        {
            _selectedApplicant = (ComboBoxBaseClass)cbxApplicantList.GetSelectedDataRow();
            if (_selectedApplicant == null)
            {
                return;
            }
            dgvMachineryList.DataSource = _codingRepository.GetMachineriesListByApplicantId(_selectedApplicant.ID);
        }
    }
}
