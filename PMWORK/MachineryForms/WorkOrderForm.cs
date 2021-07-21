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
            get { return _repairmanTemp; }
            set
            {
                if (value == null) new List<RepairMan>();
                value = _repairmanTemp;
            }
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
            cbxUnit.EditValue = 1;


            cbxRepairMan.Properties.DisplayMember = "Repairman_FullName";
            cbxRepairMan.Properties.ValueMember = "ID";
            cbxRepairMan.Properties.DataSource = _codingRepository.GetAllRepairMan();
            cbxRepairMan.EditValue = 1;



        }



        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            txtRequestNumber.EditValue = _requestReapqir.ID;
            dateFinish.EditValue = dateStart.EditValue = _requestReapqir.RequestDataTime;
            // timEnd.EditValue = timStart.EditValue = requestReapqir.RequestDataTime.TimeOfDay;



        }

        private void dateFinish_EditValueChanged(object sender, EventArgs e)
        {

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


        private void btnAddRepairMan_Click(object sender, EventArgs e)
        {
            _selectedRepairMan = (RepairMan)cbxRepairMan.GetSelectedDataRow();
            if (_selectedRepairMan == null)
            {
                return;
            }
            _repairmanTemp.Add(_selectedRepairMan);
        }
    }
}
