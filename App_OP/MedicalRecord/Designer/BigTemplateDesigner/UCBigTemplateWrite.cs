using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DCSoft.Writer;
using HIS.Service.Core.Entities;
using DCSoft.Writer.Dom;
using HIS.Utility.Extensions;

namespace App_OP.MedicalRecord
{
    public partial class UCBigTemplateWrite : UCBaseTemplateWrite
    {
        public UCBigTemplateWrite()
        {
            InitializeComponent();
            this.Enabled = false;
            this.cWriter.SetZoomRate(1.25f);
            this.cWriter.EventInsertObject += CWriter_EventInsertObject;
            this.cWriter.DocumentContentChanged += (x, y) => { this.btnSave.Enabled = true; };
        }
        private void CWriter_EventInsertObject(object eventSender, InsertObjectEventArgs args)
        {
            if (args.DataObject.GetDataPresent(nameof(DataElementEntity)))
            {
                DataElementEntity dataElement = args.DataObject.GetData(nameof(DataElementEntity)) as DataElementEntity;
                if (dataElement == null)
                    return;
                InputFieldEditStyle inputFieldEditStyle = InputFieldEditStyle.Text;
                XTextInputFieldElement fieldElement = new XTextInputFieldElement();
                fieldElement.ID = dataElement.Code;
                fieldElement.Name = dataElement.Name;
                fieldElement.BackgroundText = dataElement.Name;
                fieldElement.UserEditable = false;
                fieldElement.Deleteable = false;
                fieldElement.FieldSettings = new InputFieldSettings();
                fieldElement.FieldSettings.EditStyle = inputFieldEditStyle;
                this.cWriter.ExecuteCommand(StandardCommandNames.InsertInputField, false, fieldElement);
                args.Result = true;
            }
        }
    }
}
