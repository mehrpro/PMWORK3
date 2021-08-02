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

namespace PMWORK.PMForms
{
    public partial class ServicePerideForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;

        public ServicePerideForm(Repository.ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
        }
    }
}
