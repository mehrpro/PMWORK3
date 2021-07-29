﻿using DevExpress.XtraEditors;
using PMWORK.Repository;
using PMWORK.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMWORK.Admin
{
    public partial class UserAccessForm : XtraForm
    {
        private readonly ICodingRepository _codingRepository;
        private ApplicationUser SelectedUser;

        public UserAccessForm(PMWORK.Repository.ICodingRepository codingRepository)
        {
            InitializeComponent();
            _codingRepository = codingRepository;
            cbxUserList.Properties.DisplayMember = "UserName";
            cbxUserList.Properties.ValueMember = "UserId";
            cbxUserList.Properties.DataSource = _codingRepository.GetAllUsers();
            UpdateRadioGroup();

        }


        private void UpdateRadioGroup()
        {
            foreach (var item in _codingRepository.GetMenuGroups())
            {
                radioGroupRibbonPage.Properties.Items.Add(new DevExpress.XtraEditors.Controls.RadioGroupItem(item.GroupID, item.Description));
            }
        }

        private void radioGroupRibbonPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = Convert.ToInt32(radioGroupRibbonPage.EditValue);
            if (selected > 0)
            {

                var access = _codingRepository.GetCleamsListByUserId(SelectedUser.UserId);
                chkListPageGroup.Items.Clear();
                foreach (var item in _codingRepository.GetMenuItemsByGroupId(selected))
                {

                    var bo = access.Any(x => x.MenuItemID_FK == item.ItemID && !x.IsDelete);
                    if (bo)
                    {
                        chkListPageGroup.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(item.ItemID, item.Description, CheckState.Checked));
                    }
                    else
                        chkListPageGroup.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(item.ItemID, item.Description, CheckState.Unchecked));
                }

                var list = chkListPageGroup.Items.ToList();

            }

        }

        private void cbxUserList_EditValueChanged(object sender, EventArgs e)
        {
            SelectedUser = (ApplicationUser)cbxUserList.GetSelectedDataRow();
            if (SelectedUser == null)
            {
                return;
            }

        }
    }
}
