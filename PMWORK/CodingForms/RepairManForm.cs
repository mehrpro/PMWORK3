using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.CodingForms
{
    public partial class RepairManForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;


        public RepairManForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();
        }

        public void UpdateRepairManList()
        {
            dgvRepaiemanList.DataSource = _codingRepository.GetAllRepairMan();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate())
            {
                var newobj = new RepairMan()
                {
                    IsActive = Convert.ToBoolean(chkActive.CheckState),
                    RepairMan_Status = txtJob.Text.Trim(),
                    Repairman_FullName = txtFullName.Text.Trim()
                };
                var result = _codingRepository.AddRepairMan(newobj);
                if (result)
                {
                    XtraMessageBox.Show(PublicClass.SuccessSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateRepairManList();

                }
                else
                {
                    XtraMessageBox.Show(PublicClass.ErrorSave, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                XtraMessageBox.Show(PublicClass.ErrorValidation, Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
