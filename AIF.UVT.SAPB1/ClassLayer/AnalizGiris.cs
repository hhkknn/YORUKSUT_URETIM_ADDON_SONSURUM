using AIF.ObjectsDLL;
using AIF.ObjectsDLL.Abstarct;
using AIF.ObjectsDLL.Events;
using AIF.ObjectsDLL.Lib;
using AIF.UVT.SAPB1.Models;
using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AIF.UVT.SAPB1.ClassLayer
{
    public class AnalizGiris : IUserForm, IMenuEvents, IRightEvents
    {
        [ItemAtt(AIFConn.AnalizGirisUID)]
        public SAPbouiCOM.Form frmAnaliz;

        [ItemAtt("Item_3")]
        public SAPbouiCOM.Folder oFolderSonUrunKimyasal;

        [ItemAtt("Item_6")]
        public SAPbouiCOM.Matrix oMatrixSonUrunKimyasal;

        [ItemAtt("Item_8")]
        public SAPbouiCOM.Matrix oMatrixDuyusalFonskiyonel;

        [ItemAtt("Item_9")]
        public SAPbouiCOM.Matrix oMatrixMikrobiyolojik;

        [ItemAtt("Item_14")]
        public SAPbouiCOM.EditText oEditUrunKodu;

        [ItemAtt("Item_1")]
        public SAPbouiCOM.EditText oEditUrunAdi;

        private List<AnalizPartiler> analizPartilers = new List<AnalizPartiler>();


        public void LoadForms()
        {
            ConstVariables.oFnc.LoadSAPXML(AIFConn.AnalizGirisUID, Assembly.GetExecutingAssembly().GetManifestResourceStream(AIFConn.AnalizGirisFrmXML));
            Functions.CreateUserOrSystemFormComponent<AnalizGiris>(AIFConn.AnalizGiris);

            InitForms();
        }

        public void InitForms()
        {
            try
            {
                frmAnaliz.EnableMenu("1283", false);
                frmAnaliz.EnableMenu("1284", false);
                frmAnaliz.EnableMenu("1286", false);

                oFolderSonUrunKimyasal.Select();

                //frmAnaliz.DataSources.DBDataSources.Item(0).Clear();
                //frmAnaliz.DataSources.DBDataSources.Item(1).Clear();
                //frmAnaliz.DataSources.DBDataSources.Item(2).Clear();
                //frmAnaliz.DataSources.DBDataSources.Item(3).Clear();

                oMatrixSonUrunKimyasal.AddRow();
                oMatrixDuyusalFonskiyonel.AddRow();
                oMatrixMikrobiyolojik.AddRow();

                oMatrixSonUrunKimyasal.AutoResizeColumns();
                oMatrixDuyusalFonskiyonel.AutoResizeColumns();
                oMatrixMikrobiyolojik.AutoResizeColumns();
            }
            catch (Exception)
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
                    if (BusinessObjectInfo.BeforeAction)
                    {
                        string sonsatir1 = frmAnaliz.DataSources.DBDataSources.Item(1).GetValue("U_PartiNo", frmAnaliz.DataSources.DBDataSources.Item(1).Size - 1);
                        string sonsatir2 = frmAnaliz.DataSources.DBDataSources.Item(2).GetValue("U_PartiNo", frmAnaliz.DataSources.DBDataSources.Item(2).Size - 1);
                        string sonsatir3 = frmAnaliz.DataSources.DBDataSources.Item(3).GetValue("U_PartiNo", frmAnaliz.DataSources.DBDataSources.Item(3).Size - 1);

                        if (sonsatir1 == "")
                        {
                            frmAnaliz.DataSources.DBDataSources.Item(1).RemoveRecord(frmAnaliz.DataSources.DBDataSources.Item(1).Size - 1);
                        }

                        if (sonsatir2 == "")
                        {
                            frmAnaliz.DataSources.DBDataSources.Item(2).RemoveRecord(frmAnaliz.DataSources.DBDataSources.Item(2).Size - 1);
                        }

                        if (sonsatir3 == "")
                        {
                            frmAnaliz.DataSources.DBDataSources.Item(3).RemoveRecord(frmAnaliz.DataSources.DBDataSources.Item(3).Size - 1);
                        }
                    }
                    break;
                case BoEventTypes.et_FORM_DATA_UPDATE:
                    if (BusinessObjectInfo.BeforeAction)
                    {
                        string sonsatir1 = frmAnaliz.DataSources.DBDataSources.Item(1).GetValue("U_PartiNo", frmAnaliz.DataSources.DBDataSources.Item(1).Size - 1);
                        string sonsatir2 = frmAnaliz.DataSources.DBDataSources.Item(2).GetValue("U_PartiNo", frmAnaliz.DataSources.DBDataSources.Item(2).Size - 1);
                        string sonsatir3 = frmAnaliz.DataSources.DBDataSources.Item(3).GetValue("U_PartiNo", frmAnaliz.DataSources.DBDataSources.Item(3).Size - 1);

                        if (sonsatir1 == "")
                        {
                            frmAnaliz.DataSources.DBDataSources.Item(1).RemoveRecord(frmAnaliz.DataSources.DBDataSources.Item(1).Size - 1);
                        }

                        if (sonsatir2 == "")
                        {
                            frmAnaliz.DataSources.DBDataSources.Item(2).RemoveRecord(frmAnaliz.DataSources.DBDataSources.Item(2).Size - 1);
                        }

                        if (sonsatir3 == "")
                        {
                            frmAnaliz.DataSources.DBDataSources.Item(3).RemoveRecord(frmAnaliz.DataSources.DBDataSources.Item(3).Size - 1);
                        }
                    }
                    break;
                case BoEventTypes.et_FORM_DATA_DELETE:
                    break;
                case BoEventTypes.et_FORM_DATA_LOAD:
                    if (!BusinessObjectInfo.BeforeAction)
                    {
                        frmAnaliz.DataSources.DBDataSources.Item(1).Clear();
                        frmAnaliz.DataSources.DBDataSources.Item(2).Clear();
                        frmAnaliz.DataSources.DBDataSources.Item(3).Clear();

                        oMatrixSonUrunKimyasal.AddRow();
                        oMatrixDuyusalFonskiyonel.AddRow();
                        oMatrixMikrobiyolojik.AddRow();

                        oMatrixSonUrunKimyasal.AutoResizeColumns();
                        oMatrixDuyusalFonskiyonel.AutoResizeColumns();
                        oMatrixMikrobiyolojik.AutoResizeColumns();
                    }
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

        public bool SAP_ItemEvent(string FormUID, ref ItemEvent pVal, ref bool BubbleEvent)
        {
            BubbleEvent = true;

            switch (pVal.EventType)
            {
                case BoEventTypes.et_ALL_EVENTS:
                    break;
                case BoEventTypes.et_ITEM_PRESSED:
                    if (pVal.ItemUID == "1" && !pVal.BeforeAction)
                    {
                        frmAnaliz.DataSources.DBDataSources.Item(1).Clear();
                        frmAnaliz.DataSources.DBDataSources.Item(2).Clear();
                        frmAnaliz.DataSources.DBDataSources.Item(3).Clear();

                        oMatrixSonUrunKimyasal.AddRow();
                        oMatrixDuyusalFonskiyonel.AddRow();
                        oMatrixMikrobiyolojik.AddRow();

                        oMatrixSonUrunKimyasal.AutoResizeColumns();
                        oMatrixDuyusalFonskiyonel.AutoResizeColumns();
                        oMatrixMikrobiyolojik.AutoResizeColumns();
                    }
                    //if (pVal.ItemUID == "1" && !pVal.BeforeAction)
                    //{
                    //    if (itemUID == "Item" && pVal.ColUID == "")
                    //    {
                    //        if (silinecekler.Count > 0)
                    //        {
                    //            foreach (var item in silinecekler)
                    //            {
                    //                if (item != "")
                    //                {
                    //                    ConstVariables.oRecordset.DoQuery("Delete from \"@AIF_ANALIZGIRIS1\" where \"DocEntry\" = '" + item + "'");
                    //                }
                    //            }
                    //        }

                    //        silinecekler = new List<string>(); 
                    //    }
                    //}
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
                    if (pVal.ItemUID == "Item_6" && pVal.ColUID == "Col_0" && !pVal.BeforeAction)
                    {

                        if (oEditUrunKodu.Value.ToString() == "")
                        {
                            Handler.SAPApplication.MessageBox("Lütfen Ürün Kodu seçimi yapınız.");
                            return false;
                        }

                        if (oEditUrunKodu.Value.ToString() != "")
                        {
                            AIFConn.AnlzGrsSec.LoadForms(oEditUrunKodu.Value.ToString(), "KimyasalAnaliz", analizPartilers);
                        }
                    }
                    else if (pVal.ItemUID == "Item_8" && pVal.ColUID == "Col_0" && !pVal.BeforeAction)
                    {
                        if (oEditUrunKodu.Value.ToString() == "")
                        {
                            Handler.SAPApplication.MessageBox("Lütfen Ürün Kodu seçimi yapınız.");
                            return false;
                        }

                        if (oEditUrunKodu.Value.ToString() != "")
                        {
                            AIFConn.AnlzGrsSec.LoadForms(oEditUrunKodu.Value.ToString(), "DuyusalAnaliz", analizPartilers);
                        }
                    }
                    else if (pVal.ItemUID == "Item_9" && pVal.ColUID == "Col_14" && !pVal.BeforeAction)
                    {
                        if (oEditUrunKodu.Value.ToString() == "")
                        {
                            Handler.SAPApplication.MessageBox("Lütfen Ürün Kodu seçimi yapınız.");
                            return false;
                        }
                        if (oEditUrunKodu.Value.ToString() != "")
                        {
                            AIFConn.AnlzGrsSec.LoadForms(oEditUrunKodu.Value.ToString(), "MikrobiyolojikAnaliz", analizPartilers);
                        }
                    }
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
                    if (pVal.ItemUID == "Item_14" && pVal.BeforeAction)
                    {
                        try
                        {
                            SAPbouiCOM.IChooseFromListEvent oCFLEvento = default(SAPbouiCOM.IChooseFromListEvent);
                            oCFLEvento = (SAPbouiCOM.IChooseFromListEvent)pVal;

                            SAPbouiCOM.ChooseFromList oCFL = default(SAPbouiCOM.ChooseFromList);
                            oCFL = frmAnaliz.ChooseFromLists.Item(oCFLEvento.ChooseFromListUID);

                            SAPbouiCOM.Conditions oCons = default(SAPbouiCOM.Conditions);
                            SAPbouiCOM.Condition oCon = default(SAPbouiCOM.Condition);
                            SAPbouiCOM.Conditions oEmptyConts = new SAPbouiCOM.Conditions();

                            oCFL.SetConditions(oEmptyConts);
                            oCons = oCFL.GetConditions();

                            oCon = oCons.Add();
                            oCon.Alias = "validFor";
                            oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                            oCon.CondVal = "Y";

                            oCFL.SetConditions(oCons);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else if (pVal.ItemUID == "Item_14" && !pVal.BeforeAction)
                    {
                        SAPbouiCOM.DataTable oDataTable = ((SAPbouiCOM.ChooseFromListEvent)pVal).SelectedObjects;
                        if (oDataTable == null)
                        {
                            break;
                        }
                        string val = "";
                        try
                        {
                            val = oDataTable.GetValue("ItemCode", 0).ToString();
                        }
                        catch (Exception)
                        {
                        }

                        try
                        {
                            oEditUrunKodu.Value = val;
                            //((SAPbouiCOM.EditText)oMatrixDetay.Columns.Item("Col_0").Cells.Item(pVal.Row).Specific).Value = val;
                        }
                        catch (Exception)
                        {
                        }

                        try
                        {
                            val = oDataTable.GetValue("ItemName", 0).ToString();
                        }
                        catch (Exception)
                        {
                        }

                        try
                        {
                            oEditUrunAdi.Value = val;
                            //((SAPbouiCOM.EditText)oMatrixDetay.Columns.Item("Col_1").Cells.Item(pVal.Row).Specific).Value = val;
                        }
                        catch (Exception)
                        {
                        }

                    }
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
        List<string> silinecekler = new List<string>();
        string itemUID = "";
        public void MenuEvent(ref MenuEvent pVal, ref bool BubbleEvent)
        {
            BubbleEvent = true;

            if (pVal.MenuUID == "1282" && !pVal.BeforeAction)
            {
                try
                {
                    oMatrixSonUrunKimyasal.AddRow();
                    oMatrixDuyusalFonskiyonel.AddRow();
                    oMatrixMikrobiyolojik.AddRow();

                    //oMatrixSonUrunKimyasal.AutoResizeColumns();
                    //oMatrixDuyusalFonskiyonel.AutoResizeColumns();
                    //oMatrixMikrobiyolojik.AutoResizeColumns();
                }
                catch (Exception)
                {
                }
            }

            try
            {
                if (pVal.MenuUID == "AIFRGHTCLK_DeleteRow" && pVal.BeforeAction)
                {

                    if (itemUID == "Item_6")
                    {
                        int row = oMatrixSonUrunKimyasal.GetNextSelectedRow();
                        if (row != -1)
                        {
                            //if (((SAPbouiCOM.EditText)oMatrixSonUrunKimyasal.Columns.Item("Col_0").Cells.Item(row).Specific).Value != "")
                            //{
                            //    silinecekler.Add(((SAPbouiCOM.EditText)oMatrixSonUrunKimyasal.Columns.Item("Col_0").Cells.Item(row).Specific).Value);
                            //}

                            oMatrixSonUrunKimyasal.DeleteRow(row);

                            if (frmAnaliz.Mode == BoFormMode.fm_OK_MODE)
                            {
                                frmAnaliz.Mode = BoFormMode.fm_UPDATE_MODE;
                            }
                        }
                    }
                    else if (itemUID == "Item_8")
                    {
                        int row = oMatrixDuyusalFonskiyonel.GetNextSelectedRow();
                        if (row != -1)
                        {
                            //if (((SAPbouiCOM.EditText)oMatrixDuyusalFonskiyonel.Columns.Item("Col_0").Cells.Item(row).Specific).Value != "")
                            //{
                            //    silinecekler.Add(((SAPbouiCOM.EditText)oMatrixDuyusalFonskiyonel.Columns.Item("Col_0").Cells.Item(row).Specific).Value);
                            //}

                            oMatrixDuyusalFonskiyonel.DeleteRow(row);

                            if (frmAnaliz.Mode == BoFormMode.fm_OK_MODE)
                            {
                                frmAnaliz.Mode = BoFormMode.fm_UPDATE_MODE;
                            }
                        }
                    }
                    else if (itemUID == "Item_9")
                    {
                        int row = oMatrixMikrobiyolojik.GetNextSelectedRow();
                        if (row != -1)
                        {
                            //if (((SAPbouiCOM.EditText)oMatrixMikrobiyolojik.Columns.Item("Col_14").Cells.Item(row).Specific).Value != "")
                            //{
                            //    silinecekler.Add(((SAPbouiCOM.EditText)oMatrixMikrobiyolojik.Columns.Item("Col_14").Cells.Item(row).Specific).Value);
                            //}

                            oMatrixMikrobiyolojik.DeleteRow(row);

                            if (frmAnaliz.Mode == BoFormMode.fm_OK_MODE)
                            {
                                frmAnaliz.Mode = BoFormMode.fm_UPDATE_MODE;
                            }
                        }
                    }
                }
                //else if (pVal.MenuUID == "AIFRGHTCLK_AddRow" && pVal.BeforeAction)
                //{
                //    frmBankaEslestirme.DataSources.DBDataSources.Item("@AIF_BNKESLESTIRME").Clear();
                //    oMatrix.AddRow();

                //}
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
                        itemUID = eventInfo.ItemUID;
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
                    //Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_AddRow");
                    return;
                }


                if (oForm.Mode == SAPbouiCOM.BoFormMode.fm_FIND_MODE)
                {
                    Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_DeleteRow");
                    //Handler.SAPApplication.Menus.RemoveEx("AIFRGHTCLK_AddRow");
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

                    //try
                    //{

                    //    oCreationPackage.UniqueID = "AIFRGHTCLK_AddRow";

                    //    oCreationPackage.String = "Satır Ekle";

                    //    oCreationPackage.Enabled = true;

                    //    oMenuItem = Handler.SAPApplication.Menus.Item("1280");

                    //    oMenus = oMenuItem.SubMenus;

                    //    oMenus.AddEx(oCreationPackage);
                    //}
                    //catch (Exception)
                    //{
                    //}
                }
                catch (Exception ex)
                {
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void partileriGetir(List<AnalizPartiler> analizPartilers)
        {
            try
            {
                frmAnaliz.Freeze(true);

                if (analizPartilers != null)
                {

                    if (analizPartilers[0].AnalizAdi == "KimyasalAnaliz")
                    {
                        foreach (var item in analizPartilers)
                        {
                            ((SAPbouiCOM.EditText)oMatrixSonUrunKimyasal.Columns.Item("Col_0").Cells.Item(oMatrixSonUrunKimyasal.RowCount).Specific).Value = item.PartiNumarasi;
                            oMatrixSonUrunKimyasal.AddRow();
                        }

                        oMatrixSonUrunKimyasal.AutoResizeColumns();
                    }

                    if (analizPartilers[0].AnalizAdi == "DuyusalAnaliz")
                    {
                        foreach (var item in analizPartilers)
                        {
                            ((SAPbouiCOM.EditText)oMatrixDuyusalFonskiyonel.Columns.Item("Col_0").Cells.Item(oMatrixDuyusalFonskiyonel.RowCount).Specific).Value = item.PartiNumarasi;
                            oMatrixDuyusalFonskiyonel.AddRow();
                        }

                        oMatrixDuyusalFonskiyonel.AutoResizeColumns();
                    }

                    if (analizPartilers[0].AnalizAdi == "MikrobiyolojikAnaliz")
                    {
                        foreach (var item in analizPartilers)
                        {
                            ((SAPbouiCOM.EditText)oMatrixMikrobiyolojik.Columns.Item("Col_14").Cells.Item(oMatrixMikrobiyolojik.RowCount).Specific).Value = item.PartiNumarasi;
                            oMatrixMikrobiyolojik.AddRow();
                        }

                        oMatrixMikrobiyolojik.AutoResizeColumns();
                    }

                    if (frmAnaliz.Mode == BoFormMode.fm_OK_MODE)
                    {
                        frmAnaliz.Mode = BoFormMode.fm_UPDATE_MODE;
                    }
                }


            }
            catch (Exception ex)
            {
                Handler.SAPApplication.MessageBox("Hata oluştu." + ex.Message);
            }
            finally
            {
                frmAnaliz.Freeze(false);
            }
        }
    }
}
