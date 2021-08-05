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

namespace PMWORK.PMForms
{
    public partial class IdentityMachineryForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private int machineryID;
        private string machineryName;
        private string code;

        public int MachineryID { get => machineryID; set => machineryID = value; }
        public string MachineryName { get => machineryName; set => machineryName = value; }
        public string Code { get => code; set => code = value; }
        public IdentityMachineryForm(ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
        }

        private void IdentityMachineryForm_Load(object sender, EventArgs e)
            {

            }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
            {

            }
        }
}
