using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.MachineryForms
{
    public partial class WorkOrderForm : XtraForm
    {
        private readonly IRequestRepairRepository request;
        private ICodingRepository _codingRepository;
        private RequestRepair _requestReapqir;

        private List<RepairMan> _repairmanTemp;



        private RepairMan _selectedRepairMan;

        public List<RepairMan> RepairManTemp
        {
            get => _repairmanTemp;
            set => _repairmanTemp = value;
        }

        public RequestRepair RequestReapqirModel { get => _requestReapqir; set => _requestReapqir = value; }

        public WorkOrderForm(IRequestRepairRepository request, ICodingRepository codingRepository)
        {
            InitializeComponent();
            this.request = request;
            _codingRepository = codingRepository;

            cbxUnit.Properties.DisplayMember = "Unit";
            cbxUnit.Properties.ValueMember = "ID";
            cbxUnit.Properties.DataSource = _codingRepository.GetAllUnits();


            cbxRepairMan.Properties.DisplayMember = "Repairman_FullName";
            cbxRepairMan.Properties.ValueMember = "ID";
            cbxRepairMan.Properties.DataSource = _codingRepository.GetAllRepairMan();

            _repairmanTemp = new List<RepairMan>();



        }



        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            txtRequestNumber.EditValue = _requestReapqir.ID;
            dateFinish.EditValue = dateStart.EditValue = _requestReapqir.RequestDataTime;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newWork = new WorkOrder()
            {
                RequestID_FK = Convert.ToInt64(txtRequestNumber.EditValue),
                StartWorking = dateStart.DateTime.Date

            };
        }

        private void UpdateRepairManList()
        {
            dgvRepairMan.DataSource = _repairmanTemp.ToList();
        }

        private void btnAddRepairMan_Click(object sender, EventArgs e)
        {
            if (dxValidationProviderAddRepairMan.Validate(cbxRepairMan))
            {
                if (_repairmanTemp.Any(x => x.ID == _selectedRepairMan.ID))
                {
                    XtraMessageBox.Show("تعمیرکار در لیست اضافه شده است!", Text, MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                _repairmanTemp.Add(_selectedRepairMan);
                cbxRepairMan.EditValue = null;
                UpdateRepairManList();
            }
            else
            {
                XtraMessageBox.Show(PublicClass.ErrorValidation, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveRepairMan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvRepairMan.GetFocusedRowCellValue("ID") != null)
            {
                _selectedRepairMan = (RepairMan)gvRepairMan.GetFocusedRow();
                _repairmanTemp.Remove(_selectedRepairMan);
                cbxRepairMan.EditValue = null;
                UpdateRepairManList();

            }
        }

        private void btnConsumablePartAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
