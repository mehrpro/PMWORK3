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

        private void CreateTreeList(int userId)
        {
            treeListAccess.BeginUnboundLoad();
            treeListAccess.ClearNodes();
            TreeListNode treeListNodeParent = null;
            var cleamList = _codingRepository.GetCleams(userId);

            foreach (var item in _codingRepository.GetMenuGroups())
            {
                var app = treeListAccess.AppendNode(new object[] { item.Description },
                    treeListNodeParent, CheckState.Unchecked, NodeCheckBoxStyle.Check, item.GroupID);
                foreach (var menuItem in _codingRepository.GetMenuItemsByGroupId(item.GroupID))
                {
                    var child = treeListAccess.AppendNode(new object[] { menuItem.Description }, app.Id, menuItem.ItemID);
                    child.Checked = !cleamList.Single(x => x.MenuItemID_FK == menuItem.ItemID).IsDelete;
                }
            }
            treeListAccess.EndUnboundLoad();
            treeListAccess.ExpandAll();


        }


        private void cbxUserList_EditValueChanged(object sender, EventArgs e)
        {
            SelectedUser = (ApplicationUser)cbxUserList.GetSelectedDataRow();
            if (SelectedUser == null) return;
            CreateTreeList(SelectedUser.UserId);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var newList = new List<Cleam>();
            foreach (var groupItem in treeListAccess.Nodes.ToList())
            {
                foreach (var subItem in groupItem.Nodes.ToList())
                {
                    var item = new Cleam();
                    item.UserID_FK = Convert.ToInt32(cbxUserList.EditValue);
                    item.GroupID_FK = Convert.ToInt32(groupItem.Tag);
                    item.MenuItemID_FK = Convert.ToInt32(subItem.Tag);
                    item.IsDelete = !Convert.ToBoolean(subItem.CheckState);
                    newList.Add(item);
                }
            }
            var result = _codingRepository.CleamUser(newList);
            if (result)
            {
                PublicClass.SuccessMessage(Text);
                CreateTreeList(SelectedUser.UserId);
            }
            else
            {
                PublicClass.ErrorSave(Text);
            }

        }
    }
}
