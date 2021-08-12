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
    public partial class RepairOutForm3 : XtraForm
        {
        private readonly IRequestRepairRepository _requestRepairRepository;

        //private long requestID;
        //private string machineryName;
        //private string code;
        //private string requestRepairTitle;
        private Repairout repairout;

        public Repairout Repairout { get => repairout; set => repairout = value; }
        //public string RequestRepairTitle { get => requestRepairTitle; set => requestRepairTitle = value; }
        //public long RequestID { get => requestID; set => requestID = value; }
        //public string MachineryName { get => machineryName; set => machineryName = value; }
        //public string Code { get => code; set => code = value; }
        public RepairOutForm3(IRequestRepairRepository requestRepairRepository)
            {
            InitializeComponent();
            _requestRepairRepository = requestRepairRepository;
            }

        private void RepairOutForm_Load(object sender, EventArgs e)
            {

            txtMachineryName.EditValue = repairout.RequestRepair.Machinery.Coding.CodeTitle;
            txtCode.EditValue = repairout.RequestRepair.Machinery.Coding.Code;
            txtRegistred.Text = repairout.Regidtered.ToString();
            txtUser.EditValue = repairout.ApplicationUser.FullName;
            txtRequestTitle.EditValue = repairout.RequestRepair.RequestTitle;
            txtRequest.EditValue = repairout.RequestRepairOut;
            txtRepairmanOutFullName.EditValue = repairout.RepairOutFullName;

            

            }

        private void btnClose_Click(object sender, EventArgs e)
            {
            Close();
            }

        private void btnSave_Click(object sender, EventArgs e)
            {
            if (dx.Validate())
                {

                repairout.IsActive = false;
                repairout.IsClosed = true;
                repairout.IsDelete = false;
                repairout.RepairOutFullName = txtRepairmanOutFullName.Text.Trim();
                repairout.RequestRepairOut = txtRequest.Text.Trim();
                repairout.RepairReportOut = txtRepair.Text.Trim();
                repairout.BackendRequest = DateTime.Now;
                

                var result = _requestRepairRepository.AddEditRepairOut(repairout);
                if (result)
                    {
                    PublicClass.SuccessMessage(Text);
                    Close();
                    }
                else                    
                    PublicClass.ErrorSave(Text);
                    
                }
            else
                
                PublicClass.ErrorValidationMessage(Text);
                
            }
        }
    }
