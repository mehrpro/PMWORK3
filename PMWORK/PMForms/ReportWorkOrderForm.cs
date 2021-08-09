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

namespace PMWORK.PMForms
{
    public partial class ReportWorkOrderForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private int machineryID;
        private string machineryName;
        private string code;
        //private ServicePeriode SelectedRow;

        public int MachineryID { get => machineryID; set => machineryID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }



        public ReportWorkOrderForm(ICodingRepository codingRepository)
        {
            _codingRepository = codingRepository;
            InitializeComponent();

       
        }

        private void ReportWorkOrderForm_Load(object sender, EventArgs e)
        {
            dgvTotal.GetRowByFieldName("MachineyTitle").Properties.Value = machineryName;
            dgvTotal.GetRowByFieldName("Code").Properties.Value = code;
        }
    }
}
