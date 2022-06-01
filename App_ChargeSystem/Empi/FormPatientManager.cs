using HIS.Core;
using HIS.Core.UI;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ChargeSystem.Empi
{
    public partial class FormPatientManager : BaseForm
    {
        private readonly IEmpiPatientService _patientService;
        private readonly IEmpiAddressService _addressService;
        private readonly ISysDictQueryService _dicService;


        private PatientEntity _currEntity = null;

        public FormPatientManager(IEmpiPatientService patientService, IEmpiAddressService addressService, ISysDictQueryService dicService)
        {
            InitializeComponent();
            this._patientService = patientService;
            this._addressService = addressService;
            this._dicService = dicService;

            SetEnter();//设置回车键
            //获取 省 市 县 并绑定身份证校验
            var empi = ServiceLocator.GetService<IEmpiAddressService>();
            IDCardHelper.Instance.Configuration(empi.GetProvinceSimple(), empi.GetCitySimple(), empi.GetCountySimple());

        }

        private void FormPatientManager_Load(object sender, EventArgs e)
        {
            dgvMain.AutoGenerateColumns = false; //去除自动绑定列
            dgvMain.AllowUserToAddRows = false;  //去除空白行

            cbxSex.DataSource = new BindingSource(this.GetEnumDictEx<SexType>(), null);//性别
            cbxSex.ValueMember = "Key";
            cbxSex.DisplayMember = "Value";
            cbxSex.SelectedValue = 0;


            List<AdministrativeDivisionEntity> adminisList = _addressService.GetAll();//行政区划
            AdministrativeDivisionEntity nullEntity = new AdministrativeDivisionEntity();
            adminisList.Insert(0, nullEntity);
            //设置 省
            cbxProvince.DataSource = adminisList;
            cbxProvince.ValueMember = nameof(AdministrativeDivisionEntity.Code);
            cbxProvince.DisplayMember = nameof(AdministrativeDivisionEntity.Name);
            cbxProvince.FilterFields = new string[] { nameof(AdministrativeDivisionEntity.SearchCode), nameof(AdministrativeDivisionEntity.Name) };

            //设置 市
            cbxCity.DataSource = adminisList;
            cbxCity.ValueMember = nameof(AdministrativeDivisionEntity.Code);
            cbxCity.DisplayMember = nameof(AdministrativeDivisionEntity.Name);
            cbxCity.FilterFields = new string[] { nameof(AdministrativeDivisionEntity.SearchCode), nameof(AdministrativeDivisionEntity.Name) };

            //设置 区县
            cbxCounty.DataSource = adminisList;
            cbxCounty.ValueMember = nameof(AdministrativeDivisionEntity.Code);
            cbxCounty.DisplayMember = nameof(AdministrativeDivisionEntity.Name);
            cbxCounty.FilterFields = new string[] { nameof(AdministrativeDivisionEntity.SearchCode), nameof(AdministrativeDivisionEntity.Name) };


            List<LongItem> educationList = _dicService.GetEducation();//教育水平
            cbxEducationId.DataSource = educationList;
            LongItem itemEntity = new LongItem();
            itemEntity.Key = -1;
            itemEntity.Value = "--请选择--";
            educationList.Insert(0, itemEntity);

            cbxEducationId.DataSource = educationList;
            cbxEducationId.ValueMember = nameof(SysDicDetailEntity.Id);
            cbxEducationId.DisplayMember = nameof(SysDicDetailEntity.Value);
            cbxEducationId.FilterFields = new string[] { nameof(SysDicDetailEntity.Value) };

            List<LongItem> professionaList = _dicService.GetProfessionalType();//职业
            professionaList.Insert(0, new LongItem(-1, "--请选择--"));

            cbxProfessiona.DataSource = professionaList;
            cbxProfessiona.ValueMember = nameof(SysDicDetailEntity.Id);
            cbxProfessiona.DisplayMember = nameof(SysDicDetailEntity.Value);
            cbxProfessiona.FilterFields = new string[] { nameof(SysDicDetailEntity.Value) };



        }

        private void SetEnter() 
        {
            //设置回车键
            this.AddTabOrderContainer(this.tbxId);
            this.AddTabOrderContainer(this.tbxName);
            this.AddTabOrderContainer(this.cbxSex);
            this.AddTabOrderContainer(this.tbxIdNo);
            this.AddTabOrderContainer(this.tbxPhoneNo);
            this.AddTabOrderContainer(this.tbxAddress);
            this.AddTabOrderContainer(this.tbxBirthday);
            this.AddTabOrderContainer(this.cbxProvince);
            this.AddTabOrderContainer(this.cbxCity);
            this.AddTabOrderContainer(this.cbxCounty);
            this.AddTabOrderContainer(this.cbxEducationId);
            this.AddTabOrderContainer(this.cbxProfessiona);
            this.AddTabOrderContainer(this.tbxHeight);
            this.AddTabOrderContainer(this.tbxWeigth);
            this.AddTabOrderContainer(this.tbxUnit);
            this.AddTabOrderContainer(this.tbxUnitAddr);

            this.EnabledEnterNext = true;
        }

        private void tbxIdNo_Leave(object sender, EventArgs e)
        {
            if (tbxIdNo.Text.Trim().Length == 15 || tbxIdNo.Text.Trim().Length == 18)
            {
                var idCard = IDCardHelper.Instance.GetProperties(tbxIdNo.Text);
                cbxProvince.SelectedValue = cbxProvince.SelectedValue == null? idCard.Sheng.Code: cbxProvince.SelectedValue;
                cbxCity.SelectedValue = cbxCity.SelectedValue == null ? idCard.Shi?.Code : cbxCity.SelectedValue;
                cbxCounty.SelectedValue = cbxCounty.SelectedValue == null ? idCard.Xian?.Code : cbxCounty.SelectedValue;
                cbxSex.SelectedValue = idCard.Gender;
                tbxBirthday.Value = idCard.BirthDay;
            }

        }


        private void SetValue()
        {
            //主要信息
            tbxId.Text = _currEntity.Id > 0 ? _currEntity.Id.ToString() : "";
            tbxName.Text = _currEntity.Name;
            tbxBirthday.Value = _currEntity.Birthday;
            cbxSex.SelectedValue = _currEntity.SexCode;
            tbxIdNo.Text = _currEntity.IdCard;
            tbxPhoneNo.Text = _currEntity.PhoneNo;
            tbxAddress.Text = _currEntity.Address;
            cbxProvince.SelectedValue = _currEntity.AddrProvinceCode;
            cbxCity.SelectedValue = _currEntity.AddrCityCode;
            cbxCounty.SelectedValue = _currEntity.AddrCountyCode;
     
            //附属信息
            cbxEducationId.SelectedValue = _currEntity.EducationId;
            cbxProfessiona.SelectedValue = _currEntity.ProfessionalId;
            tbxHeight.Value = _currEntity.Height;
            tbxWeigth.Value = _currEntity.Weight;
            tbxUnit.Text = _currEntity.WorkUnit;
            tbxUnitAddr.Text = _currEntity.WorkUnitAddress;

        }

        private void GetValue()
        {
            if (_currEntity == null) _currEntity = new PatientEntity();
            _currEntity.Name = tbxName.Text;
            _currEntity.SexCode = (int)cbxSex.SelectedValue;
            _currEntity.Birthday = tbxBirthday.Value;
            _currEntity.IdCard = tbxIdNo.Text;
            _currEntity.PhoneNo = tbxPhoneNo.Text;
            _currEntity.Address = tbxAddress.Text;
            _currEntity.AddrProvinceCode = cbxProvince.SelectedValue == null? null:cbxProvince.SelectedValue.ToString();
            _currEntity.AddrCityCode = cbxCity.SelectedValue == null ? null : cbxCity.SelectedValue.ToString();
            _currEntity.AddrCountyCode = cbxCounty.SelectedValue == null ? null: cbxCounty.SelectedValue.ToString();
            _currEntity.SearchCode = SpellHelper.GetSpells(_currEntity.Name);

            _currEntity.EducationId = cbxEducationId.SelectedValue == null ? -1 : long.Parse(cbxEducationId.SelectedValue.ToString());
            _currEntity.ProfessionalId = cbxProfessiona.SelectedValue == null ? -1 : long.Parse(cbxProfessiona.SelectedValue.ToString());
            _currEntity.Height = tbxHeight.Value;
            _currEntity.Weight = tbxWeigth.Value;
            _currEntity.WorkUnit = tbxUnit.Text;
            _currEntity.WorkUnitAddress = tbxUnitAddr.Text;
        }

        private void Clear()
        {
            this._currEntity = null;
            this.SetValue();
        }

        private void LoadPatient()
        {
            string str = tbxSearch.Text.Trim();
            List<PatientEntity> list = _patientService.GetBySearchStr(str);
            this.dgvMain.DataSource = list;
        }


        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbxSearch.Text.Trim().Length > 0)
            {
                LoadPatient();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.GetValue();
            _currEntity.Kinship = 0; //亲属关系  0、本人 1、子女 2、父母 3、朋友 4、其他   如果父母持本人身份证给子女注册则必须传1 否则身份证重复不许注册 且性别出生日期可能与实际情况不同
            _currEntity.RegisteredChannels = 1;//1、门诊窗口 2、住院窗口 3、门诊服务台 4、自助机 5、微信小程序

            DataResult<PatientEntity> result = _patientService.AddPatient(this._currEntity);
            if (result.Success)
            {
                AlertBox.Info("注册成功");
            }
            else
            {
                AlertBox.Error(result.Message);
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                PatientEntity entity = dgvMain.CurrentRow.DataBoundItem as PatientEntity;
                this._currEntity = entity;
                this.SetValue();
            }
        }

        private void tbxBirthday_ValueChanged(object sender, EventArgs e)
        {
            if (tbxBirthday.Value == null)
            {
                tbxAge.Text = "";
            }
            else
            {
                tbxAge.Text = Extensions.GetBetweenFormatDays(tbxBirthday.Value,DateTime.Today); 
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadPatient();
        }

       
    }
}
