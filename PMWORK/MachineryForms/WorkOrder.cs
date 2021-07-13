using DevExpress.XtraEditors;
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
    public partial class WorkOrder : XtraForm
    {
        private readonly IRequestRepairRepository request;

        public WorkOrder(IRequestRepairRepository request)
        {
            InitializeComponent();
            this.request = request;
        }



        
    }
}
