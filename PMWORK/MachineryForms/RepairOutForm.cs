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
       
        private int machineryID;
        private string machineryName;
        private string code;

        public int MachineryID { get => machineryID; set => machineryID = value; }
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

            }
        }
    }
