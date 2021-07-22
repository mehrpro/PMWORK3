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
        private List<ConsumViewModel> _consumTemp;
        private List<ConsumablePart> _consumablePartsTemp;

        private RepairMan _selectedRepairMan;
        private ConsumViewModel _selectedConsum;



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
            _consumablePartsTemp = new List<ConsumablePart>();
            _consumTemp = new List<ConsumViewModel>();





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
            if (dxValidationProviderAddRepairMan.Validate(txtConsumablePartName)
            && dxValidationProviderAddRepairMan.Validate(numConsumablePart)
            && dxValidationProviderAddRepairMan.Validate(cbxUnit))
            {
                var obj = new ConsumViewModel()
                {

                    ConsumablePartTitel = txtConsumablePartName.Text.Trim(),
                    Number = Convert.ToInt32(numConsumablePart.EditValue),
                    UnitID_FK = Convert.ToInt32(cbxUnit.EditValue),
                    RequestID_FK = Convert.ToInt64(txtRequestNumber.Text),
                    UnitOfMeasurement = cbxUnit.Text,

                };
                _consumTemp.Add(obj);
                dgvYadaki.DataSource = _consumTemp;
                txtConsumablePartName.ResetText();
                numConsumablePart.EditValue = 0;
                cbxUnit.EditValue = null;
                dgvYadaki.RefreshDataSource();
                //gvYadaki.RefreshData();
            }
            else
            {
                XtraMessageBox.Show(PublicClass.ErrorValidation, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectConsum_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvYadaki.GetFocusedRowCellValue("ID") == null) return;
            _selectedConsum = (ConsumViewModel)gvYadaki.GetFocusedRow();

            txtConsumablePartName.Text = _selectedConsum.ConsumablePartTitel;
            numConsumablePart.EditValue = _selectedConsum.Number;
            cbxUnit.EditValue = _selectedConsum.UnitID_FK;
            btnSaveConsum.Enabled = btnCancelConsum.Enabled = true;
            btnConsumablePartAdd.Enabled = false;

        }

        private void btnSaveConsum_Click(object sender, EventArgs e)
        {
            _selectedConsum.ConsumablePartTitel = txtConsumablePartName.Text;
            _selectedConsum.Number = Convert.ToInt32(numConsumablePart.EditValue);
            _selectedConsum.UnitID_FK = Convert.ToInt32(cbxUnit.EditValue);
            _selectedConsum.UnitOfMeasurement = cbxUnit.Text;
            _selectedConsum = null;
            txtConsumablePartName.ResetText();
            numConsumablePart.EditValue = 0;
            cbxUnit.EditValue = null;
            btnSaveConsum.Enabled = btnCancelConsum.Enabled = false;
            btnConsumablePartAdd.Enabled = true;
            dgvYadaki.RefreshDataSource();
            gvYadaki.RefreshData();

        }

        private void cbxRepairMan_EditValueChanged(object sender, EventArgs e)
        {
            _selectedRepairMan = (RepairMan)cbxRepairMan.GetSelectedDataRow();
            if (_selectedRepairMan == null)
            {
                return;
            }
        }


        private void btnCancelConsum_Click(object sender, EventArgs e)
        {
            _selectedConsum = null;
            txtConsumablePartName.ResetText();
            numConsumablePart.EditValue = 0;
            cbxUnit.EditValue = null;
            btnSaveConsum.Enabled = btnCancelConsum.Enabled = false;
            btnConsumablePartAdd.Enabled = true;
            dgvYadaki.RefreshDataSource();
            gvYadaki.RefreshData();
        }
    }
}
