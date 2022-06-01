using HIS.Service.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HIS.Service.Core;
using HIS.Service.Core.Entities;
using HIS.Service.Core.Enums;
using HIS.Core;
using DevComponents.DotNetBar;

namespace App_OP.Prescription
{
    internal partial class UCEditPrescription : OPStationUserControl, IOPStationData
    {
        private IDeptService _deptService;
        private IOPPrescriptionService _prescriptionService;

        private DeptEntity _dept;
        private OutpatientEntity _patient;

        private List<IPrescriptionInit> _prescriptionControls;

        public UCEditPrescription()
        {
            InitializeComponent();
            this.FunctionAreaHeight = 250;
        }

        #region 接口实现

        public event EventHandler<OPStationDataModifyEventArgs> Modify;

        public void ChoosePatient(OutpatientEntity outpatient)
        {
            _patient = outpatient;
            var diagnosis = this.GetData<List<PatientDiagnosisEntity>>(RegisterDataType.GetAllDiagnosis);

            PatientDiagnosisEntity mainDiagnosis = null;

            if (diagnosis != null && diagnosis.Count > 0)
                mainDiagnosis = diagnosis.Find(p => p.MainFlag);

            _prescriptionControls.ForEach(p =>
            {
                p.Outpatient = _patient;
                p.DiagnosisChanged(diagnosis);
                p.MainDiagnosis = mainDiagnosis;
            });

            //this.ucwmPrescription1.Outpatient = _patient;


            //if (diagnosis != null && diagnosis.Count > 0)
            //{

            //    if (mainDiagnosis != null)
            //    {
            //        this.ucwmPrescription1.MainDiagnosis = mainDiagnosis;
            //    }

            //    this.ucwmPrescription1.EnableNewPrescription(true);

            //    if (diagnosis.Count(p => p.Diagnosis.Type == DiagnosisType.ICD) > 0)
            //    {
            //        this.ucwmPrescription1.InitNormalPresciption();
            //    }
            //    if (diagnosis.Count(p => p.Diagnosis.Type == DiagnosisType.CMDiagnosis) > 0)
            //    {

            //        if (App.Instance.GlobalSet.OPHMGranulesMode == 1)
            //        {
            //            this.uchmPrescription1.EnableNewPrescription(true);
            //            this.uchmPrescriptionGranules.EnableNewPrescription(true);

            //            this.uchmPrescription1.InitNormalPresciption();
            //            this.uchmPrescriptionGranules.InitNormalPresciption();
            //        }
            //        else
            //        {
            //            this.uchmPrescription1.EnableNewPrescription(true);
            //            this.uchmPrescription1.InitNormalPresciption();
            //        }
            //    }
            //    else
            //    {
            //        this.uchmPrescription1.EnableNewPrescription(false);
            //        this.uchmPrescriptionGranules.EnableNewPrescription(false);
            //        this.uchmPrescription1.ClearAll();
            //        this.uchmPrescriptionGranules.ClearAll();
            //    }
            //}
            //else
            //{
            //    this.ucwmPrescription1.ClearAll();
            //    this.ucwmPrescription1.EnableButton(false);
            //    this.ucwmPrescription1.EnableNewPrescription(false);

            //    this.uchmPrescription1.ClearAll();
            //    this.uchmPrescription1.EnableButton(false);
            //    this.uchmPrescription1.EnableNewPrescription(false);

            //    this.uchmPrescriptionGranules.ClearAll();
            //    this.uchmPrescriptionGranules.EnableButton(false);
            //    this.uchmPrescriptionGranules.EnableNewPrescription(false);
            //}
        }

        public bool DeptChanged(DeptEntity dept)
        {
            _dept = dept;


            _deptService = ServiceLocator.GetService<IDeptService>();
            var pharmacy = _deptService.GetPharmacy(_dept.Id);

            _prescriptionControls.ForEach(p =>
            {
                p.Dept = _dept;
                p.InitPharmacy(pharmacy);
            });

            return true;
        }

        public void FinishTreatment(OutpatientEntity outpatient)
        {
            _prescriptionControls.ForEach(p =>
            {
                p.ClearAll();
                p.EnableButton(false);
                p.EnableNewPrescription(false);
            });
        }

        public void Init()
        {
            _prescriptionService = ServiceLocator.GetService<IOPPrescriptionService>();

            var prescriptionTypes = _prescriptionService.GetPrescriptionType();

            _prescriptionControls = new List<IPrescriptionInit>();
            foreach (SuperTabItem tab in this.tabMain.Tabs)
            {
                if (tab.AttachedControl.Controls.Count > 0 && tab.AttachedControl.Controls[0] is IPrescriptionInit init)
                    _prescriptionControls.Add(init);
            }

            if (App.Instance.GlobalSet.OPHMGranulesMode == 0)
            {
                this.tabHMGranules.Visible = false;
                this.uchmPrescription1.GranulesEditor = HMPrescriptionEditor.全部;
            }
            else
            {
                this.uchmPrescription1.GranulesEditor = HMPrescriptionEditor.饮片;
                this.uchmPrescriptionGranules.GranulesEditor = HMPrescriptionEditor.颗粒剂;
            }

            _prescriptionControls.ForEach(p =>
            {
                p.InitData();
                p.InitUI(prescriptionTypes);
                p.Submit += UcwmPrescription1_Submit;
            });
        }

        public void Notify(DataModifyType actionId, object data)
        {
            if (actionId == DataModifyType.DiagnosisChanged)
            {
                _prescriptionControls.ForEach(p => p.DiagnosisChanged(data as List<PatientDiagnosisEntity>));
            }
            else if (actionId == DataModifyType.MainDiagnosisChanged)
            {
                var diagnosis = data as PatientDiagnosisEntity;

                _prescriptionControls.ForEach(p => p.MainDiagnosis = diagnosis);
            }
            else if (actionId == DataModifyType.SelectPrescription)
            {
                var args = data as PrescriptionSubmitEventArgs;

                if (args.Prescription.PrescriptionType.Type == PrscriptionType.西药中成药)
                {
                    this.ucwmPrescription1.InitPrescription(args.Prescription, args.PrescriptionDetails);
                    this.tabMain.SelectedTab = this.tabWM;
                    this.ShowMe();
                }
                else if (args.Prescription.PrescriptionType.Type == PrscriptionType.草药 || args.Prescription.PrescriptionType.Type == PrscriptionType.颗粒剂)
                {
                    if (App.Instance.GlobalSet.OPHMGranulesMode == 0)
                    {
                        this.uchmPrescription1.InitPrescription(args.Prescription, args.PrescriptionDetails);
                        this.tabMain.SelectedTab = this.tabHM;
                    }
                    else
                    {
                        if (args.Prescription.PrescriptionType.Type == PrscriptionType.草药)
                        {
                            this.uchmPrescription1.InitPrescription(args.Prescription, args.PrescriptionDetails);
                            this.tabMain.SelectedTab = this.tabHM;
                        }
                        else
                        {
                            this.uchmPrescriptionGranules.InitPrescription(args.Prescription, args.PrescriptionDetails);
                            this.tabMain.SelectedTab = this.tabHMGranules;
                        }
                    }
                    this.ShowMe();
                }
                else if (args.Prescription.PrescriptionType.Type == PrscriptionType.治疗和材料)
                {
                    this.ucItemPrescription1.InitPrescription(args.Prescription, args.PrescriptionDetails);
                    this.tabMain.SelectedTab = this.tabItem;
                    this.ShowMe();
                }
            }
            else if (actionId == DataModifyType.UndoPrescription)
            {
                _prescriptionControls.ForEach(p => p.ClearAll());
            }
        }

        #endregion

        private void UcwmPrescription1_Submit(object sender, PrescriptionSubmitEventArgs e)
        {
            this.Modify?.Invoke(this, new OPStationDataModifyEventArgs() { ActionId = DataModifyType.SavePrescription, Data = e });
        }
    }
}
