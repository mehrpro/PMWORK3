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
        private ComboBoxBaseClass _selectCompany;
        private ComboBoxBaseClass _selectGroup;
        private ComboBoxBaseClass _selectSubGroup;

        public IdentityDeviceForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;

            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";
            cbxGroup.Properties.DisplayMember = "Title";
            cbxGroup.Properties.ValueMember = "ID";
            cbxSubGroup.Properties.DisplayMember = "Title";
            cbxSubGroup.Properties.ValueMember = "ID";
            cbxCompany.Properties.DataSource = _codingRepository.GetAllCompanies()
                .Select(s => new ComboBoxBaseClass()
                { ID = s.ID, Title = s.CompanyTitle, Tag = s.CompnayIndex.ToString() }).ToList();
        
        }
        public void cbxSubGroupList( int gid)
        {
            cbxSubGroup.Properties.DataSource =_codingRepository.GetSubGroupsByGroupId(_selectGroup.ID)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.SubGroupTitle,
                    Tag = s.SubGroupIndex.ToString()
                }).ToList();
        }

        private void cbxGroup_EditValueChanged(object sender, EventArgs e)
        {
            _selectGroup = (ComboBoxBaseClass)cbxGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                cbxSubGroup.EditValue = null;
                cbxSubGroup.Properties.DataSource = null;
                return;
            }
            cbxSubGroupList( _selectGroup.ID); 
        }
        public void cbxGroupList(int id)
        {
            cbxGroup.Properties.DataSource =_codingRepository.GetGroupsByCompanyId(_selectCompany.ID)
                .Select(s => new ComboBoxBaseClass()
                {
                    ID = s.ID,
                    Title = s.GroupTitle,
                    Tag = s.GroupIndex.ToString()
                }).ToList();
        }
        private void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectCompany == null)
            {
                cbxGroup.EditValue = null;
                cbxGroup.Properties.DataSource = null;
                cbxSubGroup.EditValue = null;
                cbxSubGroup.Properties.DataSource = null;
                return;
            }
            cbxGroup.EditValue = null;
            cbxGroup.Properties.DataSource = null;
            cbxSubGroup.EditValue = null;
            cbxSubGroup.Properties.DataSource = null;
            cbxGroupList(_selectCompany.ID);

        }

        private void cbxSubGroup_EditValueChanged(object sender, EventArgs e)
        {
            _selectSubGroup = (ComboBoxBaseClass)cbxSubGroup.GetSelectedDataRow();
            if (_selectGroup == null)
            {
                return;
            }
        }
    }
}
