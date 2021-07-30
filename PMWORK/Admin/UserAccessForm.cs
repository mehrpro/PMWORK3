using DevExpress.XtraEditors;
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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;

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
            // UpdateRadioGroup();
            CreateColumnsTreeList(treeListAccess);
            CreateTreeList(treeListAccess);

        }


        private void CreateColumnsTreeList(TreeList tl)
        {
            tl.BeginUpdate();
            TreeListColumn col = tl.Columns.Add();
            col.Caption = "منوهای نرم افزار";
            col.VisibleIndex = 0;
            tl.EndUpdate();
        }


        private void CreateTreeList(TreeList tl)
        {
            tl.BeginUnboundLoad();
            TreeListNode treeListNodeParent = null;
            TreeListNode codingNode = tl.AppendNode(
                new object[] { "دارایی فیزیکی" }, treeListNodeParent, CheckState.Unchecked, NodeCheckBoxStyle.Check, true);
            tl.AppendNode(new object[] { "ماشین آلات" }, codingNode);
            tl.AppendNode(new object[] { "کدینگ موجودیت" }, codingNode);
            TreeListNode MaintanceNode = tl.AppendNode(new object[] { "نگهداری و تعمیرات" }, treeListNodeParent, CheckState.Unchecked, NodeCheckBoxStyle.Check, true);
            tl.AppendNode(new object[] { "درخواست تعمیرات" }, MaintanceNode);
            tl.EndUnboundLoad();
        }


        //this.treeListAccess.AppendNode(new object[] {
        //"دارای فیزیکی"}, -1, 0, 0, -1, System.Windows.Forms.CheckState.Unchecked, 
        //DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, true);
        //this.treeListAccess.AppendNode(new object[] {            "ماشین آلات"}, 0);
        //this.treeListAccess.AppendNode(new object[] { "کدینگ موجودیت" }, 0);

        //this.treeListAccess.AppendNode(new object[] { "نگهداری و تعمیرات" }, -1, 0, 0, -1,
        //    System.Windows.Forms.CheckState.Unchecked, DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
        //this.treeListAccess.AppendNode(new object[] { "تعمیرگاه" }, 3);

        //this.treeListAccess.AppendNode(new object[] { "گزارشات" }, -1, 0, 0, -1,
        //    System.Windows.Forms.CheckState.Unchecked, DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
        //this.treeListAccess.AppendNode(new object[] {
        //            "گزارش تعمیرات"}, 5);
        //this.treeListAccess.AppendNode(new object[] {
        //            "مدیریت نرم افزار"}, -1, 0, 0, -1, System.Windows.Forms.CheckState.Unchecked,
        //DevExpress.XtraTreeList.NodeCheckBoxStyle.Check, null);
        //this.treeListAccess.AppendNode(new object[] {
        //            "مدیریت کاربران"}, 7);

        //private void radioGroupRibbonPage_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var selected = Convert.ToInt32(radioGroupRibbonPage.EditValue);
        //    if (selected > 0)
        //    {

        //        var access = _codingRepository.GetCleamsListByUserId(SelectedUser.UserId);
        //        chkListPageGroup.Items.Clear();
        //        foreach (var item in _codingRepository.GetMenuItemsByGroupId(selected))
        //        {

        //            var bo = access.Any(x => x.MenuItemID_FK == item.ItemID && !x.IsDelete);
        //            if (bo)
        //            {
        //                chkListPageGroup.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(item.ItemID, item.Description, CheckState.Checked));
        //            }
        //            else
        //                chkListPageGroup.Items.Add(new DevExpress.XtraEditors.Controls.CheckedListBoxItem(item.ItemID, item.Description, CheckState.Unchecked));
        //        }

        //        //var list = chkListPageGroup.Items.ToList();

        //    }

        //}

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
