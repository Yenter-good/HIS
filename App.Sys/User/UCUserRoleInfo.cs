using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core.Entities;
using HIS.Service.Core;
using HIS.Core;
using HIS.Service.Core.Enums;
using DevComponents.AdvTree;

namespace App_Sys.User
{
    /// <summary>
    /// 创建人:Yenter
    /// 创建时间:2020-08-17 11:13:37
    /// 描述:
    /// </summary>
    internal partial class UCUserRoleInfo : UserControl, IUserRoleInfo
    {
        private IDeptService _deptService;

        private RoleAdditionalEntity _currentRoleAdditionEntity;
        private List<DeptEntity> _currentDeptEntities;
        private List<DeptEntity> _allDeptEntities;
        private List<DeptEntity> _cacheDeptEntities = new List<DeptEntity>();
        private HIS.ControlLib.Popups.PopupControlHost _host;

        public RoleEntity Role { get; private set; }

        public UCUserRoleInfo()
        {
            InitializeComponent();
            _deptService = ServiceLocator.GetService<IDeptService>();
            _host = new HIS.ControlLib.Popups.PopupControlHost(this.treeDept);
            _host.AutoClose = true;
            this.tbxDept.GotFocus += TbxDept_GotFocus;
        }


        /// <summary>
        /// 初始化角色附加信息
        /// </summary>
        /// <param name="depts">所有科室信息</param>
        /// <param name="teachers">所有用户信息</param>
        /// <param name="roleEntity">当前角色实体</param>
        /// <param name="userEntity">当前选择的用户</param>
        public void Init(List<DeptEntity> depts, List<UserEntity> teachers, RoleEntity roleEntity, UserEntity userEntity)
        {

            this.fcbTeacher.DisplayMember = nameof(UserEntity.Name);
            this.fcbTeacher.ValueMember = nameof(UserEntity.Id);
            this.fcbTeacher.DataSource = teachers.Where(p => p.Id != userEntity.Id).ToList();

            Role = roleEntity;
            _allDeptEntities = depts;

            _currentDeptEntities = _deptService.GetByUser(userEntity.Id, roleEntity.Id);
            foreach (var item in _currentDeptEntities)
                _cacheDeptEntities.Add(item);

            _currentRoleAdditionEntity = userEntity.RoleAdditions.Find(p => p.Role.Id == roleEntity.Id);

            this.dgvDept.Rows.Clear();
            foreach (var dept in _currentDeptEntities)
            {
                var newIndex = this.dgvDept.Rows.Add();
                var newRow = this.dgvDept.Rows[newIndex];
                newRow.Cells[colDeptName.Index].Value = dept.Name;
                newRow.Cells[colDeptCode.Index].Value = dept.Code;

                if (_currentRoleAdditionEntity != null && _currentRoleAdditionEntity.DefaultDept != null && dept.Id == _currentRoleAdditionEntity.DefaultDept.Id)
                    newRow.Cells[colDefault.Index].Value = true;

                newRow.Tag = dept;
            }

            if (_currentRoleAdditionEntity != null)
            {
                this.fcbTeacher.SelectedItem = _currentRoleAdditionEntity.Teacher;
                this.dtAllowStartTime.Value = _currentRoleAdditionEntity.AllowStartTime;
                this.dtAllowEndTime.Value = _currentRoleAdditionEntity.AllowEndTime;
            }

            BuildDeptTree(0, depts, this.treeDept.Nodes);
            this.treeDept.ExpandAll();
        }

        #region 方法

        /// <summary>
        /// 获取角色附加信息
        /// </summary>
        /// <param name="mandatoryGet">强制获取</param>
        /// <returns></returns>
        public RoleAdditionalEntity GetRoleAddition(bool mandatoryGet = false)
        {
            DeptEntity defaultDept = null;
            foreach (DataGridViewRow row in this.dgvDept.Rows)
            {
                if (row.Cells[colDefault.Index].Value.AsBoolean())
                {
                    defaultDept = row.Tag as DeptEntity;
                    break;
                }
            }
            UserEntity teacher = this.fcbTeacher.SelectedItem as UserEntity;
            var result = new RoleAdditionalEntity();

            if (!mandatoryGet)
            {
                if (_currentRoleAdditionEntity != null)
                {
                    bool isModify = _currentRoleAdditionEntity.AllowStartTime != this.dtAllowStartTime.Value;
                    isModify |= _currentRoleAdditionEntity.AllowEndTime != this.dtAllowEndTime.Value;
                    isModify |= _currentRoleAdditionEntity.Teacher?.Id != teacher?.Id;
                    isModify |= _currentRoleAdditionEntity.DefaultDept?.Id != defaultDept?.Id;
                    result.DataOperation = DataOperation.Modify;
                    if (!isModify)
                    {
                        result.Role = _currentRoleAdditionEntity.Role;
                        result.DataOperation = DataOperation.None;
                        return result;
                    }
                }
                else
                    result.DataOperation = DataOperation.New;
            }
            else
                result.DataOperation = DataOperation.New;

            result.AllowStartTime = this.dtAllowStartTime.Value;
            result.AllowEndTime = this.dtAllowEndTime.Value;
            result.Teacher = teacher;
            result.DefaultDept = defaultDept;
            result.Role = Role;

            return result;
        }
        /// <summary>
        /// 获取用户拥有的科室列表
        /// </summary>
        /// <returns></returns>
        public List<DeptEntity> GetDepts(bool mandatoryGet = false)
        {
            var result = new List<DeptEntity>();
            foreach (DataGridViewRow row in this.dgvDept.Rows)
                result.Add(row.Tag as DeptEntity);

            if (!mandatoryGet)
            {
                if (result.EqualList(_currentDeptEntities, (a, b) => a.Id == b.Id))
                    return null;
            }

            return result;
        }
        private void BuildDeptTree(long parentId, List<DeptEntity> deptEntities, NodeCollection parentNode)
        {
            var depts = deptEntities.Where(p => p.Parent.Id == parentId).ToList();
            foreach (var dept in depts)
            {
                Node node = new Node(dept.Name);
                node.Name = dept.Id.ToString();
                node.Tag = dept;
                node.CheckBoxVisible = true;
                parentNode.Add(node);

                if (_cacheDeptEntities.Exists(p => p.Id == dept.Id))
                    node.Checked = true;

                BuildDeptTree(dept.Id, deptEntities, node.Nodes);
            }
        }

        private void CheckAllChild(Node parentNode, bool checkState, ref List<Node> addNodes, ref List<Node> deleteNodes)
        {
            if (parentNode.Checked != checkState)
            {
                parentNode.Checked = checkState;
                if (!checkState)
                    deleteNodes.Add(parentNode);
                else
                    addNodes.Add(parentNode);
            }
            if (parentNode.Nodes.Count > 0)
            {
                foreach (Node node in parentNode.Nodes)
                    CheckAllChild(node, checkState, ref addNodes, ref deleteNodes);
            }
        }
        private void ClearNodeStyle(NodeCollection nodes)
        {
            foreach (Node node in nodes)
            {
                node.Text = node.Tag.As<DeptEntity>().Name;
                ClearNodeStyle(node.Nodes);
            }
        }
        private void SetNodeStyle(List<long> names)
        {
            foreach (var name in names)
            {
                var node = this.treeDept.FindNodeByName(name.ToString());
                node.Text = $@"<b><font color=""#ED1C24"">{node.Tag.As<DeptEntity>().Name}</font></b>";
            }
        }
        #endregion

        #region 窗体事件
        private void tbxDept_TextChanged(object sender, EventArgs e)
        {
            _host.AttachInputRect = new Rectangle(this.PointToScreen(this.tbxDept.Location), this.tbxDept.Size);
            this.treeDept.Width = this.tbxDept.Width;
            ClearNodeStyle(this.treeDept.Nodes);
            if (this.tbxDept.Text != "")
            {
                var filter = _allDeptEntities.Where(p => p.SearchCode.Contains(this.tbxDept.Text.ToUpper()) || p.Name.Contains(this.tbxDept.Text)).ToList();
                SetNodeStyle(filter.Select(p => p.Id).ToList());
            }

            _host.Show(this.tbxDept);
        }
        private void TbxDept_GotFocus(object sender, EventArgs e)
        {
            _host.AttachInputRect = new Rectangle(this.PointToScreen(this.tbxDept.Location), this.tbxDept.Size);
            this.treeDept.Width = this.tbxDept.Width;
            _host.Show(this.tbxDept);
        }

        private void dgvDept_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == this.colDefault.Index)
            {
                foreach (DataGridViewRow row in this.dgvDept.Rows)
                {
                    if (row.Index == e.RowIndex)
                        row.Cells[colDefault.Index].Value = true;
                    else
                        row.Cells[colDefault.Index].Value = false;
                }
            }
        }
        #endregion

        private void treeDept_BeforeCheck(object sender, AdvTreeCellBeforeCheckEventArgs e)
        {
            if (e.Action != eTreeAction.Mouse)
                return;

            List<Node> addNodes = new List<Node>();
            List<Node> deleteNodes = new List<Node>();
            CheckAllChild(e.Cell.Parent, !e.Cell.Parent.Checked, ref addNodes, ref deleteNodes);

            foreach (var addNode in addNodes)
            {
                var dept = addNode.Tag as DeptEntity;
                var newIndex = this.dgvDept.Rows.Add();
                var newRow = this.dgvDept.Rows[newIndex];
                newRow.Cells[colDeptName.Index].Value = dept.Name;
                newRow.Cells[colDeptCode.Index].Value = dept.Code;

                newRow.Tag = dept;
                _cacheDeptEntities.Add(dept);
            }
            foreach (var deleteNode in deleteNodes)
            {
                var id = deleteNode.Name.AsLong(0);
                foreach (DataGridViewRow row in this.dgvDept.Rows)
                {
                    if (row.Tag.As<DeptEntity>().Id == id)
                    {
                        this.dgvDept.Rows.Remove(row);
                        break;
                    }
                }
                _cacheDeptEntities.RemoveAll(p => p.Id == id);
            }

            e.Cancel = true;
        }

    
    }
}
