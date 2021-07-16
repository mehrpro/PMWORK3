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

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
    }
}
