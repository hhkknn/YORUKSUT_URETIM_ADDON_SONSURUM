using AIF.ObjectsDLL;
using AIF.ObjectsDLL.Abstarct;
using AIF.ObjectsDLL.Events;
using AIF.ObjectsDLL.Lib;
using AIF.ObjectsDLL.Utils;
using AIF.UVT.SAPB1.Models;
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
    public class UrunIadeSecim
    {
        [ItemAtt(AIFConn.UrunIadeSecimUID)]
        public SAPbouiCOM.Form frmUrunIadeSecim;

        [ItemAtt("Item_17")]
        public SAPbouiCOM.Matrix oMatrix;

        [ItemAtt("Item_11")]
        public SAPbouiCOM.EditText oEditIadeBelgeNo;

        [ItemAtt("Item_2")]
        public SAPbouiCOM.EditText oEditDocEntry;

        [ItemAtt("1")]
        public SAPbouiCOM.Button oBtn;

        [ItemAtt("Item_18")]
        public SAPbouiCOM.EditText oEditTarih;

        public static SAPbouiCOM.DataTable oDataTable = null;
        public static SAPbouiCOM.DBDataSource oDBDSHeader = null;
        private List<UrunIadeParametre> urunIadeParametres = new List<UrunIadeParametre>();

        public void LoadForms(List<UrunIadeParametre> _urunIadeParametres)
        {
            ConstVariables.oFnc.LoadSAPXML(AIFConn.UrunIadeSecimXML, Assembly.GetExecutingAssembly().GetManifestResourceStream(AIFConn.UrunIadeSecimXML));
            Functions.CreateUserOrSystemFormComponent<UrunIadeSecim>(AIFConn.UrnIadeScm);

            urunIadeParametres = _urunIadeParametres;

            InitForms();
        }

        public void InitForms()
        {
            try
            {
                ConstVariables.oRecordset = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                frmUrunIadeSecim.EnableMenu("1283", false);
                frmUrunIadeSecim.EnableMenu("1284", false);
                frmUrunIadeSecim.EnableMenu("1286", false);

                oDataTable = frmUrunIadeSecim.DataSources.DataTables.Add("DATA");

                try
                {
                    frmUrunIadeSecim.Freeze(true);

                    oMatrix.AddRow();

                    if (urunIadeParametres != null)
                    {
                        oEditIadeBelgeNo.Value = urunIadeParametres[0].IadeBelgeNo.ToString();

                        ConstVariables.oRecordset.DoQuery("Select \"DocEntry\" from \"@AIF_URUNIADE\" where \"U_IadeBelgeNo\" = '" + oEditIadeBelgeNo.Value + "'");

                        if (ConstVariables.oRecordset.RecordCount > 0)
                        {
                            oEditDocEntry.Item.Enabled = true;
                            frmUrunIadeSecim.Mode = BoFormMode.fm_FIND_MODE;
                            oEditDocEntry.Value = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();
                            oBtn.Item.Click();
                            oEditTarih.Item.Click();
                            oEditDocEntry.Item.Enabled = false;
                        }
                        else
                        {
                            //((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].IadeTarih.ToString("yyyyMMdd");
                            //((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_1").Cells.Item(oMatrix.RowCount).Specific).String = urunIadeParametres[0].IadeTarih.ToString("yyyyMMdd");
                            ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].IadeTarih.ToString();
                            ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_1").Cells.Item(oMatrix.RowCount).Specific).String = urunIadeParametres[0].IadeTarih.ToString();
                            ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_16").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].CariKodu.ToString();
                            ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_2").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].CariAdi.ToString();
                            ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_3").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].CariDetay.ToString();
                        }
                    }

                    //oMatrix.SetCellFocus(1, 1);
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    frmUrunIadeSecim.Freeze(false);
                }

                oMatrix.AutoResizeColumns();


            }
            catch (Exception ex)
            {
            }
        }
        public static void CFLFilter(string FormUID, SAPbouiCOM.ItemEvent pVal, string Item_Code, string Cflid, string AliasName, string ikinciFiltre, string ucuncuFiltre, string sql, ref bool calledBefore)
        {
            try
            {
                //if (calledBefore) return;
                SAPbouiCOM.Form oForm = null;
                oForm = Handler.SAPApplication.Forms.Item(FormUID);
                SAPbouiCOM.IChooseFromListEvent oCFLEvento = null;
                oCFLEvento = (SAPbouiCOM.IChooseFromListEvent)pVal;
                oDataTable = oCFLEvento.SelectedObjects;
                //oDBDSHeader = oForm.DataSources.DBDataSources.Item(Datasource);
                if (pVal.BeforeAction)
                {
                    if (pVal.ItemUID == Item_Code || pVal.ColUID == Item_Code)
                    {
                        //SAPbouiCOM.Form oForm = default(SAPbouiCOM.Form);
                        oForm = Handler.SAPApplication.Forms.ActiveForm;
                        SAPbouiCOM.ChooseFromList oCFL = oForm.ChooseFromLists.Item(Cflid);
                        SAPbouiCOM.Conditions oConds = default(SAPbouiCOM.Conditions);
                        SAPbouiCOM.Condition oCond = default(SAPbouiCOM.Condition);
                        SAPbouiCOM.Conditions oEmptyConds = new SAPbouiCOM.Conditions();

                        var rsetCFL = ConstVariables.oRecordset;
                        oCFL.SetConditions(oEmptyConds);
                        oConds = oCFL.GetConditions();


                        rsetCFL.DoQuery(sql);
                        rsetCFL.MoveFirst();
                        bool ikinciFiltreVerildi = false;

                        for (int i = 1; i <= rsetCFL.RecordCount; i++)
                        {
                            ikinciFiltreVerildi = false;
                            if (i == (rsetCFL.RecordCount))
                            {
                                if (i > 1)
                                {
                                    oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                                }
                                oCond = oConds.Add();
                                oCond.Alias = AliasName;
                                oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                                oCond.CondVal = (rsetCFL.Fields.Item(0).Value).ToString().Trim();

                                if (ikinciFiltre != "")
                                {
                                    if (i > 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                                    }
                                    if (i == 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                                    }
                                    oCond = oConds.Add();
                                    oCond.Alias = ikinciFiltre;
                                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                                    oCond.CondVal = (rsetCFL.Fields.Item(1).Value).ToString().Trim();

                                    ikinciFiltreVerildi = true;
                                }

                                if (ucuncuFiltre != "")
                                {
                                    if (i > 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                                    }

                                    if (i == 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                                    }
                                    oCond = oConds.Add();
                                    oCond.Alias = ucuncuFiltre;
                                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                                    oCond.CondVal = (rsetCFL.Fields.Item(2).Value).ToString().Trim();
                                }

                            }
                            else
                            {
                                if (i > 1)
                                {
                                    oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                                }
                                //else
                                //{
                                //    oCond.BracketOpenNum = 1;
                                //} 

                                oCond = oConds.Add();
                                oCond.Alias = AliasName;
                                oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                                oCond.CondVal = (rsetCFL.Fields.Item(0).Value).ToString().Trim();

                                if (ikinciFiltre != "")
                                {
                                    if (i > 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                                    }

                                    if (i == 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                                    }

                                    oCond = oConds.Add();
                                    oCond.Alias = ikinciFiltre;
                                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                                    oCond.CondVal = (rsetCFL.Fields.Item(1).Value).ToString().Trim();

                                    ikinciFiltreVerildi = true;
                                }

                                if (ucuncuFiltre != "")
                                {
                                    if (i > 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                                    }

                                    if (i == 1)
                                    {
                                        oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                                    }

                                    oCond = oConds.Add();
                                    oCond.Alias = ucuncuFiltre;
                                    oCond.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                                    oCond.CondVal = (rsetCFL.Fields.Item(2).Value).ToString().Trim();
                                }

                                //oCond.BracketCloseNum = 1;
                            }
                            rsetCFL.MoveNext();
                        }

                        if (rsetCFL.RecordCount == 0)
                        {
                            oCond = oConds.Add();
                            oCond.Alias = AliasName;
                            oCond.Relationship = SAPbouiCOM.BoConditionRelationship.cr_OR;
                            oCond.CondVal = "-1";
                        }
                        oCFL.SetConditions(oConds);

                    }
                }

                if (pVal.BeforeAction == false)
                {
                    if (pVal.ItemUID == Item_Code || pVal.ColUID == Item_Code)
                    {
                        ((SAPbouiCOM.EditText)oForm.Items.Item(Item_Code).Specific).Value = oDataTable.GetValue(AliasName, 0).ToString();
                    }
                }
                calledBefore = true;
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
                    if (BusinessObjectInfo.BeforeAction)
                    {
                        string sonsatir1 = frmUrunIadeSecim.DataSources.DBDataSources.Item(1).GetValue("U_UrunKodu", frmUrunIadeSecim.DataSources.DBDataSources.Item(1).Size - 1);

                        if (sonsatir1 == "")
                        {
                            frmUrunIadeSecim.DataSources.DBDataSources.Item(1).RemoveRecord(frmUrunIadeSecim.DataSources.DBDataSources.Item(1).Size - 1);
                        }
                    }
                    break;

                case BoEventTypes.et_FORM_DATA_UPDATE:
                    if (BusinessObjectInfo.BeforeAction)
                    {
                        string sonsatir1 = frmUrunIadeSecim.DataSources.DBDataSources.Item(1).GetValue("U_UrunKodu", frmUrunIadeSecim.DataSources.DBDataSources.Item(1).Size - 1);

                        if (sonsatir1 == "")
                        {
                            frmUrunIadeSecim.DataSources.DBDataSources.Item(1).RemoveRecord(frmUrunIadeSecim.DataSources.DBDataSources.Item(1).Size - 1);
                        }
                    }
                    break;

                case BoEventTypes.et_FORM_DATA_DELETE:
                    break;

                case BoEventTypes.et_FORM_DATA_LOAD:
                    //if (!BusinessObjectInfo.BeforeAction)
                    //{
                    //    frmUrunIadeSecim.DataSources.DBDataSources.Item(1).Clear(); 

                    //    oMatrix.AddRow();
                    //    //oMatrixEkler.AddRow();

                    //    oMatrix.AutoResizeColumns(); 
                    //}
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
                    //if (pVal.ItemUID == "1" && !pVal.BeforeAction)
                    //{

                    //    frmUrunIadeSecim.DataSources.DBDataSources.Item(1).Clear(); 

                    //    oMatrix.AddRow();
                    //    //oMatrixEkler.AddRow();

                    //    oMatrix.AutoResizeColumns(); 
                    //}
                    break;

                case BoEventTypes.et_KEY_DOWN:
                    break;

                case BoEventTypes.et_GOT_FOCUS:
                    break;

                case BoEventTypes.et_LOST_FOCUS:
                    //if (pVal.ItemUID == "Item_17" && pVal.ColUID == "Col_0" && !pVal.BeforeAction)
                    //{
                    //    int row = oMatrix.GetNextSelectedRow();
                    //    if (row != -1)
                    //    {
                    //        if (((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(row).Specific).Value != "")
                    //        {
                    //            //if (((SAPbouiCOM.EditText)oMatrixDetay.Columns.Item("Col_0").Cells.Item(oMatrixDetay.RowCount - 1).Specific).Value == "")
                    //            //{
                    //            frmUrunIadeSecim.DataSources.DBDataSources.Item("@AIF_URUNIADE1").Clear();
                    //            oMatrix.AddRow();
                    //            //}
                    //        }
                    //    }
                    //}
                    break;

                case BoEventTypes.et_COMBO_SELECT:
                    break;

                case BoEventTypes.et_CLICK:
                    if (pVal.ItemUID == "Item_2" && !pVal.BeforeAction)
                    {
                        try
                        {

                            try
                            {
                                frmUrunIadeSecim.Close();
                            }
                            catch (Exception)
                            {

                            }
                            //string xml = oMatrix.SerializeAsXML(BoMatrixXmlSelect.mxs_All);

                            //analizPartilers = (from x in XDocument.Parse(xml).Descendants("Row")
                            //                   where (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_0" select new XElement(y.Element("Value"))).First().Value == "Y"
                            //                   select new AnalizPartiler()
                            //                   {
                            //                       PartiNumarasi = (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_1" select new XElement(y.Element("Value"))).First().Value,
                            //                       KabulTarihi = (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_2" select new XElement(y.Element("Value"))).First().Value,
                            //                       GecerlilikSonu = (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_3" select new XElement(y.Element("Value"))).First().Value,
                            //                       AnalizAdi = analizAdi
                            //                   }).ToList();


                            //frmPartiliUretimRaporuSecim.Close();
                            //AIFConn.AnalizGiris.partileriGetir(analizPartilers);
                        }
                        catch (Exception)
                        {

                        }
                    }
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
                    if (pVal.ItemUID == "Item_17" && pVal.BeforeAction)
                    {
                        //if (pVal.ColUID == "Col_0")
                        //{
                        //    try
                        //    {
                        //        bool cflCalled = false;

                        //        string sqlQuery = "select \"ItemCode\",\"Dscription\" from PDN1 where \"DocEntry\"='" + urunIadeParametres[0].IadeBelgeNo + "' ";

                        //        CFLFilter(frmUrunIadeSecim.UniqueID, pVal, "Item_4", "CFL_0", "ItemCode", "", sqlQuery, ref cflCalled);
                        //    }
                        //    catch (Exception)
                        //    {
                        //    }
                        //}

                        if (pVal.ColUID == "Col_5")
                        {
                            try
                            {
                                bool cflCalled = false;

                                //string sqlQuery = "select \"ItemCode\",\"ItemName\" from PDN1 where \"DocEntry\"='" + girdiKontrolFormus[0].SatinalmaSipNo + "' ";

                                //string itemCode = ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(pVal.Row).Specific).Value;



                                string sql = "SELECT T1.\"ItemCode\" as \"KalemNumarası\",T1.\"ItemName\" as \"KalemTanımı\",T0.\"BatchNum\" as \"PartiNumarası\", T0.\"WhsCode\" as \"DepoKodu\", T2.\"InDate\" as \"ÜretimTarihi\",T2.\"ExpDate\" as \"SonKullanmaTarihi\",T0.\"Quantity\" as \"Miktar\",100/case when ISNULL(T1.\"IWeight1\",0) = 0 then 1 else T1.\"IWeight1\" end as 'İade Birim',T0.\"Quantity\" * (100/case when ISNULL(T1.\"IWeight1\",0) = 0 then 1 else T1.\"IWeight1\" end) as 'İade KG' FROM IBT1 T0 INNER JOIN OITM T1 ON T0.\"ItemCode\" = T1.\"ItemCode\" INNER JOIN OBTN T2 ON T2.\"DistNumber\" = T0.\"BatchNum\" and T2.\"ItemCode\" = T0.\"ItemCode\"  WHERE T0.\"BaseType\" = '16' ";
                                sql += " AND T0.\"BaseEntry\" = '" + oEditIadeBelgeNo.Value.ToString() + "' ";
                                //sql += " AND T0.\"ItemCode\" = '" + itemCode + "'";
                                CFLFilter(frmUrunIadeSecim.UniqueID, pVal, "Item_17", "CFL_0", "ItemCode", "", "", sql, ref cflCalled);
                            }
                            catch (Exception)
                            {
                            }
                        }
                        else if (pVal.ColUID == "Col_7")
                        {
                            try
                            {
                                bool cflCalled = false;

                                //string sqlQuery = "select \"ItemCode\",\"ItemName\" from PDN1 where \"DocEntry\"='" + girdiKontrolFormus[0].SatinalmaSipNo + "' ";

                                string itemCode = ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(pVal.Row).Specific).Value;



                                string sql = "SELECT T0.\"BatchNum\" as \"PartiNumarası\", T1.\"ItemCode\" as \"KalemNumarası\",T0.\"WhsCode\" as \"DepoKodu\", T1.\"ItemName\" as \"KalemTanımı\", T2.\"InDate\" as \"ÜretimTarihi\",T2.\"ExpDate\" as \"SonKullanmaTarihi\",T0.\"Quantity\" as \"Miktar\",100/case when ISNULL(T1.\"IWeight1\",0) = 0 then 1 else T1.\"IWeight1\" end as 'İade Birim',T0.\"Quantity\" * (100/case when ISNULL(T1.\"IWeight1\",0) = 0 then 1 else T1.\"IWeight1\" end) as 'İade KG' FROM IBT1 T0 INNER JOIN OITM T1 ON T0.\"ItemCode\" = T1.\"ItemCode\" INNER JOIN OBTN T2 ON T2.\"DistNumber\" = T0.\"BatchNum\" and T2.\"ItemCode\" = T0.\"ItemCode\"  WHERE T0.\"BaseType\" = '16' ";
                                sql += " AND T0.\"BaseEntry\" = '" + oEditIadeBelgeNo.Value.ToString() + "' ";
                                sql += " AND T0.\"ItemCode\" = '" + itemCode + "'";
                                CFLFilter(frmUrunIadeSecim.UniqueID, pVal, "Item_17", "CFL_1", "BatchNum", "ItemCode", "WhsCode", sql, ref cflCalled);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    else if (pVal.ItemUID == "Item_17" && !pVal.BeforeAction)
                    {
                        if (pVal.ColUID == "Col_5")
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
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(pVal.Row).Specific).Value = val;
                            }
                            catch (Exception)
                            {
                            }

                            try
                            {
                                val = oDataTable.GetValue("ItemName", 0).ToString();
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_6").Cells.Item(pVal.Row).Specific).Value = val;
                            }
                            catch (Exception)
                            {
                            }


                            try
                            {

                                string sql = "select T1.Descr from CUFD as T0 INNER JOIN UFD1 as T1 ON T0.FieldID = T1.FieldID where T0.TableID = 'OITM' and T1.TableID = 'OITM' and T0.AliasID='ItemGroup2' and T1.FldValue = '" + oDataTable.GetValue("U_ItemGroup2", 0).ToString() + "'";

                                ConstVariables.oRecordset.DoQuery(sql);

                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_4").Cells.Item(pVal.Row).Specific).Value = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();
                            }
                            catch (Exception)
                            {

                            }


                            oMatrix.AutoResizeColumns();

                        }

                        if (pVal.ColUID == "Col_7")
                        {
                            try
                            {

                                SAPbouiCOM.DataTable oDataTable = ((SAPbouiCOM.ChooseFromListEvent)pVal).SelectedObjects;
                                if (oDataTable == null)
                                {
                                    break;
                                }

                                string val = "";
                                try
                                {
                                    val = oDataTable.GetValue("BatchNum", 0).ToString();
                                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_7").Cells.Item(pVal.Row).Specific).Value = val;
                                }
                                catch (Exception)
                                {
                                }

                                val = "";
                                try
                                {
                                    val = oDataTable.GetValue("WhsCode", 0).ToString();
                                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_17").Cells.Item(pVal.Row).Specific).Value = val;
                                }
                                catch (Exception)
                                {
                                }


                                try
                                {

                                    ConstVariables.oRecordset.DoQuery("Select \"WhsName\" from \"OWHS\" where \"WhsCode\" = '" + val + "'");


                                    val = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();
                                    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_18").Cells.Item(pVal.Row).Specific).Value = val;
                                }
                                catch (Exception)
                                {
                                }


                                val = "";
                                try
                                {
                                    string sql = "";
                                    sql = "Select ISNULL(\"Indate\", '1900-01-01'),ISNULL(\"ExpDate\",'1900-01-01') from \"OBTN\" where \"DistNumber\" = '" + ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_7").Cells.Item(pVal.Row).Specific).Value + "' and \"ItemCode\" ='" + ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(pVal.Row).Specific).Value + "' ";

                                    //ConstVariables.oRecordset.DoQuery("Select \"Indate\",\"ExpDate\" from \"OBTN\" where \"DistNumber\" = '" + ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_7").Cells.Item(pVal.Row).Specific).Value + "' and \"ItemCode\" ='" + ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(pVal.Row).Specific).Value + "' ");

                                    ConstVariables.oRecordset.DoQuery(sql);
                                    val = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();

                                    //val = oDataTable.GetValue("InDate", 0).ToString();

                                    if (val != "" && Convert.ToDateTime(val).Year.ToString() != "1900")
                                    {
                                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_8").Cells.Item(pVal.Row).Specific).Value = Convert.ToDateTime(val).ToString("yyyyMMdd");
                                    }
                                }
                                catch (Exception)
                                {
                                }

                                val = "";
                                try
                                {
                                    val = ConstVariables.oRecordset.Fields.Item(1).Value.ToString();


                                    //val = oDataTable.GetValue("ExpDate", 0).ToString();

                                    if (val != "" && Convert.ToDateTime(val).Year.ToString() != "1900")
                                    {
                                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_9").Cells.Item(pVal.Row).Specific).Value = Convert.ToDateTime(val).ToString("yyyyMMdd");
                                    }
                                }
                                catch (Exception)
                                {
                                }

                                val = "";
                                try
                                {


                                    val = oDataTable.GetValue("Quantity", 0).ToString();

                                    if (val != "")
                                    {
                                        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_10").Cells.Item(pVal.Row).Specific).Value = Convert.ToDouble(val).ToString();
                                    }
                                }
                                catch (Exception)
                                {
                                }

                                //val = "";
                                //try
                                //{

                                //    string sql = "SELECT T1.\"ExpDate\" as \"SonKullanmaTarihi\" FROM IBT1 T0 LEFT JOIN OBTN T1 ON T0.\"BatchNum\" = T1.\"DistNumber\" AND T0.\"ItemCode\" = T1.\"ItemCode\" LEFT JOIN OWHS T2 ON T0.\"WhsCode\" = T2.\"WhsCode\" WHERE T0.\"BaseType\" = '20' ";
                                //    sql += " AND T0.\"BaseEntry\" = '" + oEditIadeBelgeNo.Value.ToString() + "' ";
                                //    sql += " AND T0.\"ItemCode\" = '" + ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(pVal.Row).Specific).Value + "'";

                                //    ConstVariables.oRecordset.DoQuery(sql);

                                //    val = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();
                                //    ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_8").Cells.Item(pVal.Row).Specific).Value = val;
                                //}
                                //catch (Exception)
                                //{
                                //}


                                oMatrix.AutoResizeColumns();
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                    //else 
                    //if (pVal.ItemUID == "Item_17" && pVal.ColUID == "Col_5" && pVal.BeforeAction)
                    //{
                    //    try
                    //    {
                    //        SAPbouiCOM.IChooseFromListEvent oCFLEvento = default(SAPbouiCOM.IChooseFromListEvent);
                    //        oCFLEvento = (SAPbouiCOM.IChooseFromListEvent)pVal;

                    //        SAPbouiCOM.ChooseFromList oCFL = default(SAPbouiCOM.ChooseFromList);
                    //        oCFL = frmUrunIadeSecim.ChooseFromLists.Item(oCFLEvento.ChooseFromListUID);

                    //        SAPbouiCOM.Conditions oCons = default(SAPbouiCOM.Conditions);
                    //        SAPbouiCOM.Condition oCon = default(SAPbouiCOM.Condition);
                    //        SAPbouiCOM.Conditions oEmptyConts = new SAPbouiCOM.Conditions();

                    //        oCFL.SetConditions(oEmptyConts);
                    //        oCons = oCFL.GetConditions();

                    //        oCon = oCons.Add();
                    //        oCon.Alias = "validFor";
                    //        oCon.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                    //        oCon.CondVal = "Y";

                    //        oCFL.SetConditions(oCons);
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }
                    //}
                    //else if (pVal.ItemUID == "Item_17" && pVal.ColUID == "Col_5" && !pVal.BeforeAction)
                    //{
                    //    SAPbouiCOM.DataTable oDataTable = ((SAPbouiCOM.ChooseFromListEvent)pVal).SelectedObjects;
                    //    if (oDataTable == null)
                    //    {
                    //        break;
                    //    }
                    //    string val = "";
                    //    try
                    //    {
                    //        val = oDataTable.GetValue("ItemCode", 0).ToString();
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }

                    //    try
                    //    {
                    //        //oEditUrunKodu.Value = val;
                    //        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(pVal.Row).Specific).Value = val;
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }

                    //    try
                    //    {
                    //        val = oDataTable.GetValue("Dscription", 0).ToString();
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }

                    //    try
                    //    {
                    //        //oEditUrunAdi.Value = val;
                    //        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_6").Cells.Item(pVal.Row).Specific).Value = val;
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }

                    //    try
                    //    {
                    //        val = oDataTable.GetValue("U_ItemGroup2", 0).ToString();
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }

                    //    try
                    //    {
                    //        //oEditUrunAdi.Value = val;
                    //        ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_4").Cells.Item(pVal.Row).Specific).Value = val;
                    //    }
                    //    catch (Exception)
                    //    {
                    //    }

                    //}
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
                    oMatrix.AddRow();
                }
                catch (Exception)
                {
                }
            }

            try
            {
                if (pVal.MenuUID == "AIFRGHTCLK_DeleteRow" && pVal.BeforeAction)
                {
                    int row = oMatrix.GetNextSelectedRow();
                    if (row != -1)
                    {
                        //if (((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(row).Specific).Value != "")
                        //{
                        //    silinecekler.Add(((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_5").Cells.Item(row).Specific).Value);
                        //}

                        oMatrix.DeleteRow(row);

                        if (frmUrunIadeSecim.Mode == BoFormMode.fm_OK_MODE)
                        {
                            frmUrunIadeSecim.Mode = BoFormMode.fm_UPDATE_MODE;
                        }
                    }
                }
                else if (pVal.MenuUID == "AIFRGHTCLK_AddRow" && pVal.BeforeAction)
                {
                    frmUrunIadeSecim.DataSources.DBDataSources.Item("@AIF_URUNIADE1").Clear();
                    oMatrix.AddRow();

                    try
                    {
                        frmUrunIadeSecim.Freeze(true);

                        if (urunIadeParametres != null)
                        {
                            oEditIadeBelgeNo.Value = urunIadeParametres[0].IadeBelgeNo.ToString();

                            ConstVariables.oRecordset.DoQuery("Select \"DocEntry\" from \"@AIF_URUNIADE\" where \"U_IadeBelgeNo\" = '" + oEditIadeBelgeNo.Value + "'");

                            if (ConstVariables.oRecordset.RecordCount > 0)
                            {
                                oEditDocEntry.Item.Enabled = true;
                                frmUrunIadeSecim.Mode = BoFormMode.fm_FIND_MODE;
                                oEditDocEntry.Value = ConstVariables.oRecordset.Fields.Item(0).Value.ToString();
                                oBtn.Item.Click();
                                oEditTarih.Item.Click();
                                oEditDocEntry.Item.Enabled = false;
                            }
                            else
                            {
                                //((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].IadeTarih.ToString("yyyyMMdd");
                                //((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_1").Cells.Item(oMatrix.RowCount).Specific).String = urunIadeParametres[0].IadeTarih.ToString("yyyyMMdd");
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_0").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].IadeTarih.ToString();
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_1").Cells.Item(oMatrix.RowCount).Specific).String = urunIadeParametres[0].IadeTarih.ToString();
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_16").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].CariKodu.ToString();
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_2").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].CariAdi.ToString();
                                ((SAPbouiCOM.EditText)oMatrix.Columns.Item("Col_3").Cells.Item(oMatrix.RowCount).Specific).Value = urunIadeParametres[0].CariDetay.ToString();
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }
                    finally
                    {
                        frmUrunIadeSecim.Freeze(false);
                    }

                    oMatrix.AutoResizeColumns();

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