using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using DevComponents.Editors.DateTimeAdv;
using HIS.Core;
using HIS.Core.UI;
using HIS.DSkinControl;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App_OP.PatientJournal
{
    /// <summary>
    /// 门诊日志
    /// </summary>
    public partial class FormEditJournal : BaseDialogForm
    {
        /// <summary>
        /// 字典服务
        /// </summary>
        private readonly ISysDictQueryService _sysDictQueryService;
        /// <summary>
        /// 门诊日志服务
        /// </summary>
        private readonly IOPJournalService _oPJournalService;
        /// <summary>
        /// 待编辑的门诊日志实体
        /// </summary>
        public PatientJournalEntity ModifyPatientJournalEntity { get; set; }
        /// <summary>
        /// 必填字段
        /// </summary>
        private List<StringItem> _RequiredFields;
        /// <summary>
        /// 门诊号
        /// </summary>
        public string OutpatientNo;
        /// <summary>
        /// 当前科室
        /// </summary>
        public DeptEntity Dept;
        /// <summary>
        /// 当前界面中的所有控件
        /// </summary>
        private List<Control> _childControls;
        public FormEditJournal(ISysDictQueryService sysDictQueryService, IOPJournalService oPJournalService)
        {
            InitializeComponent();
            this._sysDictQueryService = sysDictQueryService;
            this._oPJournalService = oPJournalService;
            this._childControls = this.Controls.Cast<Control>().OrderBy(d => d.TabIndex).ToList();
        }

        #region 方法

        private void InitUI()
        {
            if (string.IsNullOrWhiteSpace(this.OutpatientNo))
                throw new ArgumentNullException("OutpatientNo is null or empty");

            //获取门诊日志
            this.ModifyPatientJournalEntity = this._oPJournalService.GetJournal(this.OutpatientNo);
            if (this.ModifyPatientJournalEntity == null)
            {
                MsgBox.OK("未获取到当前患者的门诊日志");
                base.OnOK();
                return;
            }

            //加载性别
            var gender = typeof(Gender).GetEnumDictEx<Gender>();
            BindingSource bs = new BindingSource();
            bs.DataSource = gender;
            this.cbxGender.DisplayMember = "Value";
            this.cbxGender.ValueMember = "Key";
            this.cbxGender.DataSource = bs;
            this.cbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxGender.SelectedIndex = -1;

            //加载婚姻状况
            var marrys = this._sysDictQueryService.GetMarry();
            this.cbxMarry.DisplayMember = nameof(LongItem.Value);
            this.cbxMarry.ValueMember = nameof(LongItem.Key);
            this.cbxMarry.DataSource = marrys;
            this.cbxMarry.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxMarry.SelectedIndex = -1;

            //加载血型
            var bloods = this._sysDictQueryService.GetBlood();
            this.cbxBlood.DisplayMember = nameof(LongItem.Value);
            this.cbxBlood.ValueMember = nameof(LongItem.Key);
            this.cbxBlood.DataSource = bloods;
            this.cbxBlood.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxBlood.SelectedIndex = -1;

            //加载民族
            var nationals = this._sysDictQueryService.GetNational();
            this.cbxNation.DisplayMember = nameof(LongItem.Value);
            this.cbxNation.ValueMember = nameof(LongItem.Key);
            this.cbxNation.DataSource = nationals;
            this.cbxNation.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxNation.SelectedIndex = -1;

            //加载国籍
            var nationalitys = this._sysDictQueryService.GetNationality();
            this.cbxNationality.DisplayMember = nameof(LongItem.Value);
            this.cbxNationality.ValueMember = nameof(LongItem.Key);
            this.cbxNationality.DataSource = nationalitys;
            this.cbxNationality.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxNationality.SelectedIndex = -1;

            //加载文化程度
            var knowlages = this._sysDictQueryService.GetEducation();
            this.cbxKnowlage.DisplayMember = nameof(LongItem.Value);
            this.cbxKnowlage.ValueMember = nameof(LongItem.Key);
            this.cbxKnowlage.DataSource = knowlages;
            this.cbxKnowlage.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxKnowlage.SelectedIndex = -1;

            //加载职业
            var jobs = this._sysDictQueryService.GetProfessionalType();
            this.cbxJob.DisplayMember = nameof(LongItem.Value);
            this.cbxJob.ValueMember = nameof(LongItem.Key);
            this.cbxJob.DataSource = jobs;
            this.cbxJob.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxJob.SelectedIndex = -1;

            //加载必填字段
            this._RequiredFields = App.Instance.GlobalSet.JournalRequiredField;

            //控件设置
            foreach (Control ctr in this._childControls)
            {
                //设置必填字段为红色
                if (this._RequiredFields.Exists(d => d.Code == ctr.Name))
                    ctr.ForeColor = Color.Red;
                //设置必填字段快捷键
                if (this._RequiredFields.Exists(d => d.Key == ctr.Name))
                    this.AddTabOrderContainer(ctr);
            }
            if (this._RequiredFields.Count > 0)
                this.EnabledEnterNext = true;

            //姓名
            this.tbxPatientName.Text = this.ModifyPatientJournalEntity.PatientName;

            //年龄
            this.tbxAge.Text = this.ModifyPatientJournalEntity.Age;

            //性别
            this.cbxGender.SelectedValue = (int)this.ModifyPatientJournalEntity.Gender;

            //出生日期
            if (this.ModifyPatientJournalEntity.Birthday.HasValue)
                this.dtpBirthday.Value = this.ModifyPatientJournalEntity.Birthday.Value;
            else
            {
                if (!string.IsNullOrWhiteSpace(this.ModifyPatientJournalEntity.IDCard))
                {
                    if (IDCardHelper.Instance.Validation(this.ModifyPatientJournalEntity.IDCard).Success)
                    {
                        IDCardProperties iDCardProperties = IDCardHelper.Instance.GetProperties(this.ModifyPatientJournalEntity.IDCard);
                        this.dtpBirthday.Value = iDCardProperties.BirthDay;
                    }
                }
            }

            //身高
            this.intStature.ValueObject = this.ModifyPatientJournalEntity.Stature;

            //婚姻状况
            this.cbxMarry.SelectedValue = this.ModifyPatientJournalEntity.Marry.Key;

            //血型
            this.cbxBlood.SelectedValue = this.ModifyPatientJournalEntity.Blood.Key;

            //体重
            this.intWight.ValueObject = this.ModifyPatientJournalEntity.Wight;

            //民族
            this.cbxNation.SelectedValue = this.ModifyPatientJournalEntity.Nation.Key;

            //国籍
            this.cbxNationality.SelectedValue = this.ModifyPatientJournalEntity.Nationality.Key;

            //籍贯
            this.tbxOrigin.Text = this.ModifyPatientJournalEntity.Origin;

            //身份证号
            this.tbxIDCard.Text = this.ModifyPatientJournalEntity.IDCard;

            //文化程度
            this.cbxKnowlage.SelectedValue = this.ModifyPatientJournalEntity.Knowlage.Key;

            //出生地
            this.tbxBirthPlace.Text = this.ModifyPatientJournalEntity.BirthPlace;

            //本人地址
            this.tbxAddress.Text = this.ModifyPatientJournalEntity.Address;

            //Email
            this.tbxEmail.Text = this.ModifyPatientJournalEntity.Email;

            //本人电话
            this.tbxPhone.Text = this.ModifyPatientJournalEntity.Phone;

            //联系人电话
            this.tbxContactsPhone.Text = this.ModifyPatientJournalEntity.ContactsPhone;

            //联系人姓名
            this.tbxContactsName.Text = this.ModifyPatientJournalEntity.ContactsName;

            //职业
            this.cbxJob.SelectedValue = this.ModifyPatientJournalEntity.Job.Key;

            //单位地址
            this.tbxJobAddress.Text = this.ModifyPatientJournalEntity.JobAddress;

            //单位电话
            this.tbxJobPhone.Text = this.ModifyPatientJournalEntity.JobPhone;

            //备注
            this.tbxRemark.Text = this.ModifyPatientJournalEntity.Remark;

            //传染病
            this.ckbInfectionFlag.Checked = this.ModifyPatientJournalEntity.InfectionFlag;

            //初复诊
            if (this.ModifyPatientJournalEntity.FirstOrSecond.HasValue)
            {
                if (this.ModifyPatientJournalEntity.FirstOrSecond.Value == 0)
                    this.ckbFirst.Checked = true;
                else
                    this.ckbSecond.Checked = true;
            }

            //发病日期
            if (this.ModifyPatientJournalEntity.OnsetDate.HasValue)
                this.dtpOnsetDate.ValueObject = this.ModifyPatientJournalEntity.OnsetDate;
            else
                this.dtpOnsetDate.Value = DateTime.Now;
            this.dtpOnsetDate.MaxDate = DateTime.Now;

            //收缩压
            if (this.ModifyPatientJournalEntity.BloodPressureHigh.HasValue)
                this.intBloodPressureHigh.ValueObject = this.ModifyPatientJournalEntity.BloodPressureHigh.Value;

            //舒张压
            if (this.ModifyPatientJournalEntity.BloodPressureLow.HasValue)
                this.intBloodPressureLow.ValueObject = this.ModifyPatientJournalEntity.BloodPressureLow.Value;
        }
        private bool CheckValidity()
        {
            foreach (Control ctr in this._childControls)
            {
                StringItem si = this._RequiredFields.Find(d => d.Key == ctr.Name);
                if (si == null) continue;
                if (ctr is TextBoxX tbx)
                {
                    if (tbx.Text.Trim() != "")
                        continue;
                }
                else if (ctr is ComboBoxEx cbx)
                {
                    if (cbx.SelectedValue.AsLong(0) > 0)
                        continue;
                }
                else if (ctr is DateTimeInput dtp)
                {
                    if ((dtp.ValueObject as DateTime?).HasValue)
                        continue;
                }
                else if (ctr is IntegerInput intInput)
                {
                    if ((intInput.ValueObject as int?).HasValue)
                        continue;
                }

                ctr.Focus();
                ctr.ShowTips($"{si.Value}不能为空");
                return false;
            }
            //判断初复诊是否为空
            if (!this.ckbFirst.Checked && !this.ckbSecond.Checked)
            {
                MsgBox.OK("请选择初复诊");
                return false;
            }

            return true;
        }
        #endregion

        #region 窗口事件
        private void FormEditJournal_Shown(object sender, EventArgs e)
        {
            this.ShowMask(() =>
            {
                this.InitUI();
            });
        }

        protected override void OnOK()
        {
            if (!this.CheckValidity())
                return;

            //患者姓名
            string name = this.tbxPatientName.Text.Trim();
            if (name == "")
                name = null;

            //年龄
            string age = this.tbxAge.Text.Trim();
            if (age == "")
                age = null;

            //性别
            Gender gender = (Gender)this.cbxGender.SelectedValue.AsInt(0);

            //出生日期
            DateTime? birthday = this.dtpBirthday.ValueObject as DateTime?;

            //身高
            int? stature = this.intStature.ValueObject as int?;

            //婚姻状况
            if (this.cbxMarry.SelectedItem != null)
                this.ModifyPatientJournalEntity.Marry = this.cbxMarry.SelectedItem as LongItem;

            //血型
            if (this.cbxBlood.SelectedItem != null)
                this.ModifyPatientJournalEntity.Blood = this.cbxBlood.SelectedItem as LongItem;

            //体重
            int? wight = this.intWight.ValueObject as int?;

            //民族
            if (this.cbxNation.SelectedItem != null)
                this.ModifyPatientJournalEntity.Nation = this.cbxNation.SelectedItem as LongItem;

            //国籍
            if (this.cbxNationality.SelectedItem != null)
                this.ModifyPatientJournalEntity.Nationality = this.cbxNationality.SelectedItem as LongItem;

            //籍贯
            string origin = this.tbxOrigin.Text.Trim();
            if (origin == "")
                origin = null;

            //身份证号
            string idCard = this.tbxIDCard.Text.Trim();
            if (idCard == "")
                idCard = null;

            //文化程度
            if (this.cbxKnowlage.SelectedItem != null)
                this.ModifyPatientJournalEntity.Knowlage = this.cbxKnowlage.SelectedItem as LongItem;

            //出生地
            string birthPlace = this.tbxBirthPlace.Text.Trim();
            if (birthPlace == "")
                birthPlace = null;

            //本人地址
            string address = this.tbxAddress.Text.Trim();
            if (address == "")
                address = null;

            //Email
            string email = this.tbxEmail.Text.Trim();
            if (email == "")
                email = null;

            //本人电话
            string phone = this.tbxPhone.Text.Trim();
            if (phone == "")
                phone = null;

            //联系人电话
            string contactsPhone = this.tbxContactsPhone.Text.Trim();
            if (contactsPhone == "")
                contactsPhone = null;

            //联系人姓名
            string contactsName = this.tbxContactsName.Text.Trim();
            if (contactsName == "")
                contactsName = null;

            //职业
            if (this.cbxJob.SelectedItem != null)
                this.ModifyPatientJournalEntity.Job = this.cbxJob.SelectedItem as LongItem;

            //单位地址
            string jobAddress = this.tbxJobAddress.Text.Trim();
            if (jobAddress == "")
                jobAddress = null;

            //单位电话
            string jobPhone = this.tbxJobPhone.Text.Trim();
            if (jobPhone == "")
                jobPhone = null;

            //备注
            string remark = this.tbxRemark.Text.Trim();
            if (remark == "")
                remark = null;

            //传染病
            bool infectionFlag = this.ckbInfectionFlag.Checked;

            //初诊或复诊
            int firstOrSecond = 0;
            if (this.ckbSecond.Checked)
                firstOrSecond = 1;

            //发病日期
            DateTime? onsetDate = this.dtpOnsetDate.ValueObject as DateTime?;

            //收缩压
            int? bloodPressureHigh = this.intBloodPressureHigh.ValueObject as int?;

            //舒张压
            int? bloodPressureLow = this.intBloodPressureLow.ValueObject as int?;

            //更新日志
            this.ModifyPatientJournalEntity.PatientName = name;
            this.ModifyPatientJournalEntity.Gender = gender;
            this.ModifyPatientJournalEntity.Birthday = birthday;
            this.ModifyPatientJournalEntity.Age = age;
            this.ModifyPatientJournalEntity.Dept.Id = Dept.Id;
            this.ModifyPatientJournalEntity.Dept.Code = Dept.Code;
            this.ModifyPatientJournalEntity.Dept.Name = Dept.Name;
            this.ModifyPatientJournalEntity.Doctor.Id = App.Instance.RuntimeSystemInfo.UserInfo.Id;
            this.ModifyPatientJournalEntity.Doctor.Code = App.Instance.RuntimeSystemInfo.UserInfo.Code;
            this.ModifyPatientJournalEntity.Doctor.Name = App.Instance.RuntimeSystemInfo.UserInfo.Name;
            this.ModifyPatientJournalEntity.IDCard = idCard;
            this.ModifyPatientJournalEntity.Address = address;
            this.ModifyPatientJournalEntity.Stature = stature;
            this.ModifyPatientJournalEntity.BirthPlace = birthPlace;
            this.ModifyPatientJournalEntity.Wight = wight;
            this.ModifyPatientJournalEntity.Origin = origin;
            this.ModifyPatientJournalEntity.Email = email;
            this.ModifyPatientJournalEntity.Phone = phone;
            this.ModifyPatientJournalEntity.ContactsPhone = contactsPhone;
            this.ModifyPatientJournalEntity.ContactsName = contactsName;
            this.ModifyPatientJournalEntity.JobAddress = jobAddress;
            this.ModifyPatientJournalEntity.JobPhone = jobPhone;
            this.ModifyPatientJournalEntity.Remark = remark;
            this.ModifyPatientJournalEntity.FirstOrSecond = firstOrSecond;
            this.ModifyPatientJournalEntity.InfectionFlag = infectionFlag;
            this.ModifyPatientJournalEntity.BloodPressureHigh = bloodPressureHigh;
            this.ModifyPatientJournalEntity.BloodPressureLow = bloodPressureLow;
            this.ModifyPatientJournalEntity.OnsetDate = onsetDate;
            this.ModifyPatientJournalEntity.EffectiveFlag = true;
            this.ModifyPatientJournalEntity.FirstAcceptDoctor.Id = App.Instance.RuntimeSystemInfo.UserInfo.Id;
            this.ModifyPatientJournalEntity.FirstAcceptDoctor.Code = App.Instance.RuntimeSystemInfo.UserInfo.Code;
            this.ModifyPatientJournalEntity.FirstAcceptDoctor.Name = App.Instance.RuntimeSystemInfo.UserInfo.Name;

            var result = this._oPJournalService.UpdateJournal(this.ModifyPatientJournalEntity);
            if (result.Success)
            {
                AlertBox.Info("操作成功");
                base.OnOK();
            }
            else
                MsgBox.OK($"门诊日志操作失败\r\n{result.Message}");
        }
        #endregion
    }
}
