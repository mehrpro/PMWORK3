﻿using DevExpress.XtraEditors;
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
        private RequestRepair requestReapqir;

        public RequestRepair RequestReapqirModel { get => requestReapqir; set => requestReapqir = value; }

        public WorkOrderForm(IRequestRepairRepository request, ICodingRepository codingRepository)
        {
            InitializeComponent();
            this.request = request;
            _codingRepository = codingRepository;
            cbxUnit.Properties.DisplayMember = "Unit";
            cbxUnit.Properties.ValueMember = "ID";
            cbxUnit.Properties.DataSource = _codingRepository.GetAllUnits();

        }

        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            txtRequestNumber.EditValue = requestReapqir.ID;
            dateFinish.EditValue = dateStart.EditValue = requestReapqir.RequestDataTime;
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

        private void cbxUnit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
