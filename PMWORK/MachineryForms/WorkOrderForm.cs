using DevExpress.XtraEditors;
using PMWORK.Entities;
using PMWORK.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PMWORK.MachineryForms
{
    public partial class WorkOrderForm : XtraForm
    {
        private readonly IRequestRepairRepository _requestRepairRepository;
        private ICodingRepository _codingRepository;
        private RequestRepair _requestReapqir;
        private bool _editable;
        private WorkOrder _workOrderID;
        private List<RepairMan> _repairmanTemp;
        private List<ConsumViewModel> _consumTemp;
        //private List<ConsumablePart> _consumablePartsTemp;

        private RepairMan _selectedRepairMan;
        private ConsumViewModel _selectedConsum;



        public bool Editable { get => _editable; set => _editable = value; }
        public RequestRepair RequestReapqirModel { get => _requestReapqir; set => _requestReapqir = value; }
        public WorkOrderForm(IRequestRepairRepository request, ICodingRepository codingRepository)
        {
            InitializeComponent();
            _requestRepairRepository = request;
            _codingRepository = codingRepository;

            cbxUnit.Properties.DisplayMember = "Unit";
            cbxUnit.Properties.ValueMember = "ID";
            cbxUnit.Properties.DataSource = _codingRepository.GetAllUnits();


            cbxRepairMan.Properties.DisplayMember = "Repairman_FullName";
            cbxRepairMan.Properties.ValueMember = "ID";
            cbxRepairMan.Properties.DataSource = _codingRepository.GetAllRepairMan();

            _repairmanTemp = new List<RepairMan>();
            // _consumablePartsTemp = new List<ConsumablePart>();
            _consumTemp = new List<ConsumViewModel>();
        }

        void SetWorkOrder()
        {
            _workOrderID = _requestRepairRepository.FindWorkOrderByRequestId(_requestReapqir.ID);
            _repairmanTemp = _requestRepairRepository.GetRepairManByWorkOrderID(_workOrderID.ID);
            _consumTemp = _requestRepairRepository.GetConsumViewModelsByRequestId(_requestReapqir.ID);
            dgvYadaki.DataSource = _consumTemp;
            UpdateRepairManList();
            dateStart.DateTime = _workOrderID.StartWorking;
            dateFinish.DateTime = _workOrderID.EndWorking;
            //_requestReapqir.ID = _workOrderID.RequestID_FK;
            dateStart.DateTime = _workOrderID.StartWorking;
            dateFinish.DateTime = _workOrderID.EndWorking;
            chkCause_Exhaustion.Checked = _workOrderID.Cause_Exhaustion;
            chkCause_OperatorNegligence.Checked = _workOrderID.Cause_OperatorNegligence;
            chkCause_QualityofSpareParts.Checked = _workOrderID.Cause_QualityofSpareParts;
            chkPersonHours.Checked = _workOrderID.PersonHours;
            numPersonHoursTime.EditValue = _workOrderID.PersonHoursTime;
            txtPersonHoursDescription.Text = _workOrderID.PersonHoursDescription;
            chkNoSpareParts.Checked = _workOrderID.NoSpareParts;
            numNoSparePartsTime.EditValue = _workOrderID.NoSparePartsTime;
            txtNoSparePartsDescription.Text = _workOrderID.NoSparePartsDescription;
            chkProductionPlanning.Checked = _workOrderID.ProductionPlanning;
            numProductionPlanningTime.EditValue = _workOrderID.ProductionPlanningTime;
            txtProductionPlanningDescription.Text = _workOrderID.ProductionPlanningDescription;
            chkOther.Checked = _workOrderID.Other;
            numOtherTime.EditValue = _workOrderID.OtherTime;
            txtOtherDescription.Text = _workOrderID.OtherDescription;
            numStopTotalMin.EditValue = _workOrderID.StopTotalMin;
            numWorkingTotalMin.EditValue = _workOrderID.WorkingTotalMin;
            chkOtherError.Checked = _workOrderID.OtherError;
            txtOtherDescription.Text = _workOrderID.OtherErrorDescription;
            txtReportRepair.Text = _workOrderID.ReportRepair;

        }

        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            txtRequestNumber.EditValue = _requestReapqir.ID;
            dateFinish.Properties.MinValue = dateStart.Properties.MinValue = _requestReapqir.RequestDataTime;
            dateFinish.EditValue = dateStart.EditValue = _requestReapqir.RequestDataTime;
            if (_editable)
            {
                SetWorkOrder();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxSave.Validate())
            {
                var newWork = new WorkOrder();
                newWork.RequestID_FK = _requestReapqir.ID;
                newWork.StartWorking = dateStart.DateTime;
                newWork.EndWorking = dateFinish.DateTime;
                newWork.Cause_Exhaustion = Convert.ToBoolean(chkCause_Exhaustion.CheckState);
                newWork.Cause_OperatorNegligence = Convert.ToBoolean(chkCause_OperatorNegligence.CheckState);
                newWork.Cause_QualityofSpareParts = Convert.ToBoolean(chkCause_QualityofSpareParts.CheckState);
                newWork.DateTimeClosing = DateTime.Now;
                newWork.IsDelete = false;
                newWork.RepairOutside = false;
                newWork.PersonHours = Convert.ToBoolean(chkPersonHours.CheckState);
                newWork.PersonHoursTime = Convert.ToInt16(numPersonHoursTime.EditValue);
                newWork.PersonHoursDescription = txtPersonHoursDescription.Text.Trim();
                newWork.NoSpareParts = Convert.ToBoolean(chkNoSpareParts.CheckState);
                newWork.NoSparePartsTime = Convert.ToInt16(numNoSparePartsTime.EditValue);
                newWork.NoSparePartsDescription = txtNoSparePartsDescription.Text.Trim();
                newWork.ProductionPlanning = Convert.ToBoolean(chkProductionPlanning.CheckState);
                newWork.ProductionPlanningTime = Convert.ToInt16(numProductionPlanningTime.EditValue);
                newWork.ProductionPlanningDescription = txtProductionPlanningDescription.Text.Trim();
                newWork.Other = Convert.ToBoolean(chkOther.CheckState);
                newWork.OtherTime = Convert.ToInt16(numOtherTime.EditValue);
                newWork.OtherDescription = txtOtherDescription.Text.Trim();
                newWork.RepairOutSideReportID_FK = null;
                newWork.CloseRequest = true;
                newWork.StopTotalMin = Convert.ToInt32(numStopTotalMin.EditValue);
                newWork.WorkingTotalMin = Convert.ToInt32(numWorkingTotalMin.EditValue);
                newWork.OtherError = Convert.ToBoolean(chkOtherError.CheckState);
                newWork.OtherErrorDescription = txtOtherDescription.Text.Trim();
                newWork.ReportRepair = txtReportRepair.Text.Trim();
                if (_editable)
                {
                    newWork.ID = _workOrderID.ID;
                    var result = _requestRepairRepository.UpdateWorkOrder(newWork, _repairmanTemp, _consumTemp);
                    if (result)
                    {
                       PublicClass.SuccessMessage( Text);
                        Close();
                    }
                    else
                        PublicClass.ErrorSave(Text);
                }
                else
                {
                    var result = _requestRepairRepository.AddNewWorkOrder(newWork, _repairmanTemp, _consumTemp);
                    if (result)
                    {
                        PublicClass.SuccessMessage(Text);

                        Close();
                    }
                    else
                        PublicClass.ErrorSave( Text);
                }


            }
            else
                PublicClass.ErrorValidationMessage( Text);
        }

        private void UpdateRepairManList()
        {
            dgvRepairMan.DataSource = _repairmanTemp;
            gvRepairMan.RefreshData();
        }

        private void btnAddRepairMan_Click(object sender, EventArgs e)
        {
            if (dxRepairMan.Validate(cbxRepairMan))
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
                PublicClass.ErrorValidationMessage(Text);
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
            if (dxRepairMan.Validate(txtConsumablePartName)
            && dxRepairMan.Validate(numConsumablePart)
            && dxRepairMan.Validate(cbxUnit))
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
                PublicClass.ErrorValidationMessage(Text);
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

        private void dateFinish_EditValueChanged(object sender, EventArgs e)
        {
            numStopTotalMin.EditValue = numWorkingTotalMin.EditValue = dateFinish.DateTime.Subtract(dateStart.DateTime).TotalMinutes;
        }

        private void chkPersonHours_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkPersonHours.Checked)
            {
                txtPersonHoursDescription.ResetText();
                numPersonHoursTime.EditValue = 0;
                txtPersonHoursDescription.Enabled = numPersonHoursTime.Enabled = false;
            }
            else
            {
                txtPersonHoursDescription.Enabled = numPersonHoursTime.Enabled = true;
            }
        }

        private void chkProductionPlanning_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkProductionPlanning.Checked)
            {
                txtProductionPlanningDescription.ResetText();
                numProductionPlanningTime.EditValue = 0;
                txtProductionPlanningDescription.Enabled = numProductionPlanningTime.Enabled = false;
            }
            else
            {
                txtProductionPlanningDescription.Enabled = numProductionPlanningTime.Enabled = true;
            }
        }

        private void chkNoSpareParts_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkNoSpareParts.Checked)
            {
                txtNoSparePartsDescription.ResetText();
                numNoSparePartsTime.EditValue = 0;
                txtNoSparePartsDescription.Enabled = numNoSparePartsTime.Enabled = false;
            }
            else
            {
                txtNoSparePartsDescription.Enabled = numNoSparePartsTime.Enabled = true;

            }
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkOther.Checked)
            {
                txtOtherDescription.ResetText();
                numOtherTime.EditValue = 0;
                txtOtherDescription.Enabled = numOtherTime.Enabled = false;
            }
            else
            {
                txtOtherDescription.Enabled = numOtherTime.Enabled = true;

            }
        }

        private void chkOtherError_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkOtherError.Checked)
            {
                txtOtherError.ResetText();
                txtOtherError.Enabled = false;
            }
            else
            {
                txtOtherError.Enabled = true;
            }
        }

        private void btnRepairOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
