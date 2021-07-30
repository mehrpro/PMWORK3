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
            //CreateTreeList(treeListAccess);

        }


        private void CreateColumnsTreeList(TreeList tl)
        {
            tl.BeginUpdate();
            TreeListColumn col = tl.Columns.Add();
            col.Caption = "منوهای نرم افزار";
            col.VisibleIndex = 0;
            tl.EndUpdate();
        }

        private void CreateTreeList(TreeList tl, int userId)
        {
            tl.BeginUnboundLoad();
            tl.ClearNodes();
            TreeListNode treeListNodeParent = null;
            var cleamList = _codingRepository.GetCleams(userId);

            foreach (var item in _codingRepository.GetMenuGroups())
            {
                var app = tl.AppendNode(new object[] { item.Description }, treeListNodeParent, CheckState.Unchecked, NodeCheckBoxStyle.Check, item.GroupID);
                foreach (var menuItem in _codingRepository.GetMenuItemsByGroupId(item.GroupID))
                {
                    var child = tl.AppendNode(new object[] { menuItem.Description }, app.Id, menuItem.ItemID);
                    child.Checked = cleamList.Any(x => x.MenuItemID_FK == menuItem.ItemID);
                }
            }
            tl.EndUnboundLoad();
            tl.ExpandAll();


        }

        private void CreateTreeList(TreeList tl)
        {
            tl.BeginUnboundLoad();
            TreeListNode treeListNodeParent = null;


            foreach (var item in _codingRepository.GetMenuGroups())
            {
                var app = tl.AppendNode(new object[] { item.Description }, treeListNodeParent, CheckState.Unchecked, NodeCheckBoxStyle.Check, item.GroupID);
                foreach (var menuItem in _codingRepository.GetMenuItemsByGroupId(item.GroupID))
                {
                    tl.AppendNode(new object[] { menuItem.Description }, app.Id, menuItem.ItemID);
                }
            }
            tl.EndUnboundLoad();
            tl.ExpandAll();
            tl.Enabled = false;
        }


        private void cbxUserList_EditValueChanged(object sender, EventArgs e)
        {
            SelectedUser = (ApplicationUser)cbxUserList.GetSelectedDataRow();
            if (SelectedUser == null)
            {
                return;
            }
            CreateTreeList(treeListAccess, SelectedUser.UserId);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var accessList = treeListAccess.Selection;
            var newList = new List<Cleam>();
            var li = treeListAccess.Nodes.ToList();
            foreach (var item in li)
            {
                var sel = item.Nodes.ToList();
                var selTag = item.Tag;
                foreach (var subItem in sel)
                {
                    var sub = subItem.Tag;
                }
            }
        }
    }
}
