using DevExpress.XtraEditors;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.MachineryForms
{
    public partial class MachineryForm : XtraForm
    {

        private AppDbContext _db;
        private List<ComboBoxCoding> _codingListForComboBox;
        private ComboBoxCoding _selectedCoding;
        private ComboBoxBaseClass _selectedCompany;
        private Machinery _selectedRow;
        private ComboBoxBaseClass _selectedApplicant;

        public MachineryForm()
        {
            InitializeComponent();
            _db = new AppDbContext();
            cbxCompany.Properties.DisplayMember = "Title";
            cbxCompany.Properties.ValueMember = "ID";

            cbxApplicantList.Properties.DisplayMember = "Title";
            cbxApplicantList.Properties.ValueMember = "ID";

            cbxCoding.Properties.DisplayMember = "Cod";
            cbxCoding.Properties.ValueMember = "ID";

            cbxCompany.Properties.DataSource = _db.Companies.Select(x => new ComboBoxBaseClass()
            {
                ID = x.ID,
                Title = x.CompanyTitle,
                Tag = x.CompnayIndex.ToString()
            }).ToList();

            if (PublicClass.LimitedCompany)
            {
                cbxCompany.EditValue = PublicClass.CompanyID;
                cbxCompany.ReadOnly = true;
            }

        }


        private async Task UpdateCodingList(int cid, int aid)
        {
            await UpdateCbxCoding(cid);
            var qryMasterMachineryList = await _db.Machineries
                .Include(a => a.Applicant)
                .Include(x => x.Coding)
                .ToListAsync();
            var qryMachineryList = qryMasterMachineryList
                .Where(x => x.CompanyID == cid && x.IsActive && !x.IsDelete && x.ApplicantID_FK == aid).ToList();
            foreach (var item in qryMasterMachineryList)
            {
                var result = _codingListForComboBox.SingleOrDefault(x => x.Cod == item.Coding.Code);
                if (result != null)
                {

                    _codingListForComboBox.Remove(result);
                }
            }
            cbxCoding.Properties.DataSource = _codingListForComboBox;
            dgvMachineryList.DataSource = qryMachineryList;
        }


        public async Task UpdateCbxCoding(int cid)
        {

            var qry = await _db.Codings.Include(a => a.Group).Include(a => a.SubGroup).Where(x => x.CompanyID_FK == cid).ToListAsync();
            _codingListForComboBox = new List<ComboBoxCoding>();
            foreach (var x in qry)
            {
                var item = new ComboBoxCoding
                {
                    ID = x.ID,
                    Cod = x.Code,
                    Title = x.CodeTitle,
                    Des = $"{x.Group.GroupTitle}---{x.SubGroup.SubGroupTitle}"
                };
                _codingListForComboBox.Add(item);
            }

        }


        private async Task UpdateApplicant(int companyId)
        {
            cbxApplicantList.Properties.DataSource = await _db.Applicants.Where(x => x.CompanyID_FK == companyId).Select(x => new ComboBoxBaseClass
            {
                ID = x.ID,
                Title = x.ApplicantTitle,
                Tag = x.Description
            }).ToListAsync();
        }

        private async void cbxCompany_EditValueChanged(object sender, EventArgs e)
        {
            _selectedCompany = (ComboBoxBaseClass)cbxCompany.GetSelectedDataRow();
            if (_selectedCompany == null)
            {
                cbxCoding.EditValue = null;
                cbxCoding.Properties.DataSource = null;
                dgvMachineryList.DataSource = null;
                cbxApplicantList.Properties.DataSource = null;
                return;
            }
            await UpdateApplicant(_selectedCompany.ID);

        }

        private void cbxCoding_EditValueChanged(object sender, EventArgs e)
        {
            _selectedCoding = (ComboBoxCoding)cbxCoding.GetSelectedDataRow();
            if (_selectedCoding == null)
            {
                chkActive.Checked = chkDelete.Checked = false;
                txtDescription.ResetText(); txtTitle.ResetText(); return;

            }
            txtTitle.Text = _selectedCoding.Title;


        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                if (Convert.ToBoolean(btnAdd.Tag))
                {
                    var selected = await _db.Machineries.FindAsync(_selectedRow.ID);
                    selected.IsActive = Convert.ToBoolean(chkActive.CheckState);
                    selected.IsDelete = Convert.ToBoolean(chkDelete.CheckState);
                    selected.ApplicantID_FK = Convert.ToInt32(cbxApplicantList.EditValue);
                    selected.Description = txtDescription.Text.Trim();
                }
                else
                {
                    var newObj = new Machinery()
                    {
                        IsActive = true,
                        IsDelete = false,
                        MachineryTitle = _selectedCoding.Title,
                        CodeID_FK = _selectedCoding.ID,
                        Description = txtDescription.Text.Trim(),
                        CompanyID = _selectedCompany.ID,
                        ApplicantID_FK = _selectedApplicant.ID

                    };
                    _db.Machineries.Add(newObj);
                }

                await _db.SaveChangesAsync();
                await UpdateCodingList(_selectedCompany.ID, _selectedApplicant.ID);
                ClearForm();
            }
            else
            {
                PublicClass.ErrorValidationMessage(Text);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "انصراف")
            {
                //_selectedCoding = null;
                //cbxCoding.EditValue = 0;
                ClearForm();
            }
            else
            {
                Close();

            }
        }

        private void ClearForm()
        {
            cbxCompany.ReadOnly = cbxCoding.ReadOnly = false;
            txtTitle.ResetText(); txtDescription.ResetText();
            chkActive.Checked = chkDelete.Checked = false;
            cbxCoding.EditValue = null;
            // _selectedCoding = null;
            btnAdd.Text = "افزودن";
            btnClose.Text = PublicClass.CloseStr;

        }

        private void btnSelect_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvMachineryList.GetFocusedRowCellValue("ID") != null)
            {
                var row = gvMachineryList.GetFocusedRow();
                _selectedRow = (Machinery)row;
                txtTitle.EditValue = _selectedRow.MachineryTitle;
                txtDescription.EditValue = _selectedRow.Coding.Code + _selectedRow.Description;
                chkActive.EditValue = _selectedRow.IsActive;
                chkDelete.EditValue = _selectedRow.IsDelete;

                cbxCompany.ReadOnly = cbxCoding.ReadOnly = true;
                btnAdd.Tag = true;
                btnAdd.Text = @"ذخیره";
                btnClose.Text = PublicClass.CancelStr;
            }
        }

        private void chkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(chkDelete.CheckState))
            {
                chkActive.Enabled = false;
            }
            else
            {
                chkActive.Enabled = true;
            }

        }

        private async void cbxApplicantList_EditValueChanged(object sender, EventArgs e)
        {
            _selectedApplicant = (ComboBoxBaseClass)cbxApplicantList.GetSelectedDataRow();
            if (_selectedApplicant == null)
            {
                return;
            }

            cbxCoding.EditValue = null;
            await UpdateCodingList(_selectedCompany.ID, _selectedApplicant.ID);


        }
    }



}
