﻿using AIF.ObjectsDLL;
using AIF.ObjectsDLL.Abstarct;
using AIF.ObjectsDLL.Events;
using AIF.ObjectsDLL.Lib;
using AIF.ObjectsDLL.Utils;
using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Handler = AIF.ObjectsDLL.Events.Handler;


namespace AIF.UVT.SAPB1.ClassLayer
{
    public class SutBrixCeza
    {
        [ItemAtt(AIFConn.SutBrixCezaUID)]
        public SAPbouiCOM.Form frmSutBrixCeza;

        [ItemAtt("Item_14")]
        public SAPbouiCOM.Matrix oMatrix;
        [ItemAtt("Item_0")]
        public SAPbouiCOM.ComboBox oComboNitelik;
        public void LoadForms()
        {
            ConstVariables.oFnc.LoadSAPXML(AIFConn.SutBrixCezaXML, Assembly.GetExecutingAssembly().GetManifestResourceStream(AIFConn.SutBrixCezaXML));
            Functions.CreateUserOrSystemFormComponent<SutBrixCeza>(AIFConn.BrixCeza);

            InitForms();
        }
        public void InitForms()
        {
            try
            {
                frmSutBrixCeza.EnableMenu("1283", false);
                frmSutBrixCeza.EnableMenu("1284", false);
                frmSutBrixCeza.EnableMenu("1286", false);

                oMatrix.AutoResizeColumns();

                oComboNitelik.ValidValues.Add("", "");

                ConstVariables.oRecordset.DoQuery("Select FldValue,Descr from UFD1 where FieldID =(select FieldID from CUFD where TableID = '@AIF_SUTKABUL2'and AliasID = 'Nitelik')");

                while (!ConstVariables.oRecordset.EoF)
                {
                    oComboNitelik.ValidValues.Add(ConstVariables.oRecordset.Fields.Item(0).Value.ToString(), ConstVariables.oRecordset.Fields.Item(1).Value.ToString());
                    ConstVariables.oRecordset.MoveNext();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public bool SAP_FormDataEvent(ref BusinessObjectInfo BusinessObjectInfo, ref bool BubbleEvent)
        {
            BubbleEvent = true;

            switch (BusinessObjectInfo.EventType)
            {
                case BoEventTypes.et_ALL_EVENTS:
                    break;
                case BoEventTypes.et_ITEM_PRESSED:
                    break;
                case BoEventTypes.et_KEY_DOWN:
                    break;
                case BoEventTypes.et_GOT_FOCUS:
                    break;
                case BoEventTypes.et_LOST_FOCUS:
                    break;
                case BoEventTypes.et_COMBO_SELECT:
                    break;
                case BoEventTypes.et_CLICK:
                    break;
                case BoEventTypes.et_DOUBLE_CLICK:
                    break;
                case BoEventTypes.et_MATRIX_LINK_PRESSED:
                    break;
                case BoEventTypes.et_MATRIX_COLLAPSE_PRESSED:
                    break;
                case BoEventTypes.et_VALIDATE:
                    break;
                case BoEventTypes.et_MATRIX_LOAD:
                    break;
                case BoEventTypes.et_DATASOURCE_LOAD:
                    break;
                case BoEventTypes.et_FORM_LOAD:
                    break;
                case BoEventTypes.et_FORM_UNLOAD:
                    break;
                case BoEventTypes.et_FORM_ACTIVATE:
                    break;
                case BoEventTypes.et_FORM_DEACTIVATE:
                    break;
                case BoEventTypes.et_FORM_CLOSE:
                    break;
                case BoEventTypes.et_FORM_RESIZE:
                    break;
                case BoEventTypes.et_FORM_KEY_DOWN:
                    break;
                case BoEventTypes.et_FORM_MENU_HILIGHT:
                    break;
                case BoEventTypes.et_PRINT:
                    break;
                case BoEventTypes.et_PRINT_DATA:
                    break;
                case BoEventTypes.et_EDIT_REPORT:
                    break;
                case BoEventTypes.et_CHOOSE_FROM_LIST:
                    break;
                case BoEventTypes.et_RIGHT_CLICK:
                    break;
                case BoEventTypes.et_MENU_CLICK:
                    break;
                case BoEventTypes.et_FORM_DATA_ADD:
                    break;
                case BoEventTypes.et_FORM_DATA_UPDATE:
                    break;
                case BoEventTypes.et_FORM_DATA_DELETE:
                    break;
                case BoEventTypes.et_FORM_DATA_LOAD:
                    break;
                case BoEventTypes.et_PICKER_CLICKED:
                    break;
                case BoEventTypes.et_GRID_SORT:
                    break;
                case BoEventTypes.et_Drag:
                    break;
                case BoEventTypes.et_FORM_DRAW:
                    break;
                case BoEventTypes.et_UDO_FORM_BUILD:
                    break;
                case BoEventTypes.et_UDO_FORM_OPEN:
                    break;
                case BoEventTypes.et_B1I_SERVICE_COMPLETE:
                    break;
                case BoEventTypes.et_FORMAT_SEARCH_COMPLETED:
                    break;
                case BoEventTypes.et_PRINT_LAYOUT_KEY:
                    break;
                case BoEventTypes.et_FORM_VISIBLE:
                    break;
                case BoEventTypes.et_ITEM_WEBMESSAGE:
                    break;
                default:
                    break;
            }

            return BubbleEvent;
        }

        string val = "";
        public bool SAP_ItemEvent(string FormUID, ref ItemEvent pVal, ref bool BubbleEvent)
        {
            BubbleEvent = true;

            switch (pVal.EventType)
            {
                case BoEventTypes.et_ALL_EVENTS:
                    break;
                case BoEventTypes.et_ITEM_PRESSED:
                    break;
                case BoEventTypes.et_KEY_DOWN:
                    break;
                case BoEventTypes.et_GOT_FOCUS:
                    break;
                case BoEventTypes.et_LOST_FOCUS:
                    break;
                case BoEventTypes.et_COMBO_SELECT:
                    break;
                case BoEventTypes.et_CLICK:
                    break;
                case BoEventTypes.et_DOUBLE_CLICK:
                    break;
                case BoEventTypes.et_MATRIX_LINK_PRESSED:
                    break;
                case BoEventTypes.et_MATRIX_COLLAPSE_PRESSED:
                    break;
                case BoEventTypes.et_VALIDATE:
                    break;
                case BoEventTypes.et_MATRIX_LOAD:
                    break;
                case BoEventTypes.et_DATASOURCE_LOAD:
                    break;
                case BoEventTypes.et_FORM_LOAD:
                    break;
                case BoEventTypes.et_FORM_UNLOAD:
                    break;
                case BoEventTypes.et_FORM_ACTIVATE:
                    break;
                case BoEventTypes.et_FORM_DEACTIVATE:
                    break;
                case BoEventTypes.et_FORM_CLOSE:
                    break;
                case BoEventTypes.et_FORM_RESIZE:
                    break;
                case BoEventTypes.et_FORM_KEY_DOWN:
                    break;
                case BoEventTypes.et_FORM_MENU_HILIGHT:
                    break;
                case BoEventTypes.et_PRINT:
                    break;
                case BoEventTypes.et_PRINT_DATA:
                    break;
                case BoEventTypes.et_EDIT_REPORT:
                    break;
                case BoEventTypes.et_CHOOSE_FROM_LIST:
                    break;
                case BoEventTypes.et_RIGHT_CLICK:
                    break;
                case BoEventTypes.et_MENU_CLICK:
                    break;
                case BoEventTypes.et_FORM_DATA_ADD:
                    break;
                case BoEventTypes.et_FORM_DATA_UPDATE:
                    break;
                case BoEventTypes.et_FORM_DATA_DELETE:
                    break;
                case BoEventTypes.et_FORM_DATA_LOAD:
                    break;
                case BoEventTypes.et_PICKER_CLICKED:
                    break;
                case BoEventTypes.et_GRID_SORT:
                    break;
                case BoEventTypes.et_Drag:
                    break;
                case BoEventTypes.et_FORM_DRAW:
                    break;
                case BoEventTypes.et_UDO_FORM_BUILD:
                    break;
                case BoEventTypes.et_UDO_FORM_OPEN:
                    break;
                case BoEventTypes.et_B1I_SERVICE_COMPLETE:
                    break;
                case BoEventTypes.et_FORMAT_SEARCH_COMPLETED:
                    break;
                case BoEventTypes.et_PRINT_LAYOUT_KEY:
                    break;
                case BoEventTypes.et_FORM_VISIBLE:
                    break;
                case BoEventTypes.et_ITEM_WEBMESSAGE:
                    break;
                default:
                    break;
            }


            return BubbleEvent;

        }
        public void MenuEvent(ref MenuEvent pVal, ref bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                if (pVal.MenuUID == "AIFRGHTCLK_DeleteRow" && pVal.BeforeAction)
                {
                    int row = oMatrix.GetNextSelectedRow();
                    if (row != -1)
                    {
                        oMatrix.DeleteRow(row);
                        if (frmSutBrixCeza.Mode == BoFormMode.fm_OK_MODE)
                        {
                            frmSutBrixCeza.Mode = BoFormMode.fm_UPDATE_MODE;
                        }
                    }
                }
                else if (pVal.MenuUID == "AIFRGHTCLK_AddRow" && pVal.BeforeAction)
                {
                    frmSutBrixCeza.DataSources.DBDataSources.Item(1).Clear();
                    oMatrix.AddRow();
                    oMatrix.Columns.Item("Col_0").Cells.Item(oMatrix.RowCount).Click();
                }
            }
            catch (Exception)
            {
            }
        }

        public void RightClickEvent(ref ContextMenuInfo eventInfo, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                var oForm = Handler.SAPApplication.Forms.ActiveForm;

                if (eventInfo.ItemUID != "")
                {
                    try
                    {
                        SAPbouiCOM.Matrix item = (SAPbouiCOM.Matrix)oForm.Items.Item(eventInfo.ItemUID).Specific;
                    }
                    catch (Exception)
                    {
                        Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_DeleteRow");
                        return;
                    }


                }
                else
                {
                    Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_DeleteRow");
                    Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_AddRow");
                    return;
                }


                if (oForm.Mode == SAPbouiCOM.BoFormMode.fm_FIND_MODE)
                {
                    Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_DeleteRow");
                    Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_AddRow");
                    return;
                }
                SAPbouiCOM.MenuItem oMenuItem = default(SAPbouiCOM.MenuItem);

                SAPbouiCOM.Menus oMenus = default(SAPbouiCOM.Menus);

                try
                {

                    SAPbouiCOM.MenuCreationParams oCreationPackage = default(SAPbouiCOM.MenuCreationParams);

                    oCreationPackage = (SAPbouiCOM.MenuCreationParams)Handler.SAPApplication.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_MenuCreationParams);

                    oCreationPackage.Type = SAPbouiCOM.BoMenuType.mt_STRING;
                    try
                    {
                        oCreationPackage.UniqueID = "AIFRGHTCLK_DeleteRow";

                        oCreationPackage.String = "Satır Sil";

                        oCreationPackage.Enabled = true;

                        oMenuItem = Handler.SAPApplication.Menus.Item("1280");

                        oMenus = oMenuItem.SubMenus;

                        oMenus.AddEx(oCreationPackage);

                    }
                    catch
                    {
                    }

                    try
                    {

                        oCreationPackage.UniqueID = "AIFRGHTCLK_AddRow";

                        oCreationPackage.String = "Satır Ekle";

                        oCreationPackage.Enabled = true;

                        oMenuItem = Handler.SAPApplication.Menus.Item("1280");

                        oMenus = oMenuItem.SubMenus;

                        oMenus.AddEx(oCreationPackage);
                    }
                    catch (Exception)
                    {
                    }
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
            }


        }
    }
}
