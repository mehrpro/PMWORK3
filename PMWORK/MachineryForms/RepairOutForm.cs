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
using PMWORK.Entities;
using PMWORK.Repository;

namespace PMWORK.MachineryForms
    {
    public partial class RepairOutForm : XtraForm
        {
        private readonly IRequestRepairRepository _requestRepairRepository;

        private long requestID;
        private string machineryName;
        private string code;
        private string requestRepairTitle;

        public string RequestRepairTitle { get => requestRepairTitle; set => requestRepairTitle = value; }
        public long RequestID { get => requestID; set => requestID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }
        public RepairOutForm(IRequestRepairRepository requestRepairRepository)
            {
            InitializeComponent();
            _requestRepairRepository = requestRepairRepository;
            }

        private void RepairOutForm_Load(object sender, EventArgs e)
            {

            txtMachineryName.EditValue = machineryName;
            txtCode.EditValue = code;
            txtRegistred.Text = PublicClass.TodayPersian();
            txtUser.Text = PublicClass.FullNameTask;
            txtRequestTitle.Text = requestRepairTitle;

            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            Close();
            }

        private void btnSave_Click(object sender, EventArgs e)
            {
            if (dx.Validate())
                {
                var obj = new Repairout()
                    {
                    IsActive = true,
                    IsClosed = false,
                    IsDelete = false,
                    Regidtered = DateTime.Now,
                    RepairOutFullName = txtRepairmanOutFullName.Text.Trim(),
                    CompanyID_FK = PublicClass.CompanyID,
                    RequestID_FK = requestID,
                    RequestRepairOut = txtRequest.Text.Trim(),
                    RepairReportOut = "در انتظار بازگشت",
                    BackendRequest = DateTime.Now,
                    UserID_FK = PublicClass.UserID,

                    };

                var result = _requestRepairRepository.AddEditRepairOut(obj);
                if (result)
                    {
                    PublicClass.SuccessMessage(Text);
                    Close();
                    }
                else
                    {
                    PublicClass.ErrorSave(Text);
                    }
                }
            else
                {
                PublicClass.ErrorValidationMessage(Text);
                }
            }
        }
    }
