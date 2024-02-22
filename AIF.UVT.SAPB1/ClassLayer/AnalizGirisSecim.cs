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
    public class AnalizGirisSecim
    {
        [ItemAtt(AIFConn.AnalizGirisSecimUID)]
        public SAPbouiCOM.Form frmPartiliUretimRaporuSecim;

        [ItemAtt("Item_0")]
        public SAPbouiCOM.Matrix oMatrix;

        [ItemAtt("Item_1")]
        public SAPbouiCOM.Button oBtnIptal;

        [ItemAtt("Item_2")]
        public SAPbouiCOM.Button oBtnSec;

        private SAPbouiCOM.DataTable oDataTable = null;
        private string kalemKodu = "";
        private string analizAdi = "";
        private List<AnalizPartiler> analizPartilers = new List<AnalizPartiler>();

        public void LoadForms(string _kalemKodu, string _analizAdi, List<AnalizPartiler> _analizPartilers)
        {
            ConstVariables.oFnc.LoadSAPXML(AIFConn.AnalizGirisSecimXML, Assembly.GetExecutingAssembly().GetManifestResourceStream(AIFConn.AnalizGirisSecimXML));
            Functions.CreateUserOrSystemFormComponent<AnalizGirisSecim>(AIFConn.AnlzGrsSec);

            kalemKodu = _kalemKodu;
            analizAdi = _analizAdi;
            analizPartilers = _analizPartilers;

            InitForms();
        }

        public void InitForms()
        {
            try
            {
                ConstVariables.oRecordset = (SAPbobsCOM.Recordset)ConstVariables.oCompanyObject.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

                frmPartiliUretimRaporuSecim.EnableMenu("1283", false);
                frmPartiliUretimRaporuSecim.EnableMenu("1284", false);
                frmPartiliUretimRaporuSecim.EnableMenu("1286", false);

                oDataTable = frmPartiliUretimRaporuSecim.DataSources.DataTables.Add("DATA");

                try
                {
                    frmPartiliUretimRaporuSecim.Freeze(true);

                    if (kalemKodu != "")
                    {
                        string sql = "SELECT T0.\"DistNumber\", T0.\"InDate\", T0.\"ExpDate\" FROM OBTN T0 WHERE T0.\"ItemCode\" = '" + kalemKodu + "' ";

                        oDataTable.Clear();
                        oDataTable.ExecuteQuery(sql);

                        oMatrix.Clear();

                        //oMatrix.Columns.Item("Col_0").DataBind.Bind("DATA", "#");
                        oMatrix.Columns.Item("Col_1").DataBind.Bind("DATA", "DistNumber");
                        oMatrix.Columns.Item("Col_2").DataBind.Bind("DATA", "InDate");
                        oMatrix.Columns.Item("Col_3").DataBind.Bind("DATA", "ExpDate");

                        oMatrix.LoadFromDataSource();
                        oMatrix.AutoResizeColumns();
                    }

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    frmPartiliUretimRaporuSecim.Freeze(false);
                }

                oMatrix.AutoResizeColumns();


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
                    if (pVal.ItemUID == "Item_2" && !pVal.BeforeAction)
                    {
                        try
                        {
                            string xml = oMatrix.SerializeAsXML(BoMatrixXmlSelect.mxs_All);

                            analizPartilers = (from x in XDocument.Parse(xml).Descendants("Row")
                                               where (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_0" select new XElement(y.Element("Value"))).First().Value == "Y"
                                               select new AnalizPartiler()
                                               {
                                                   PartiNumarasi = (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_1" select new XElement(y.Element("Value"))).First().Value,
                                                   KabulTarihi = (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_2" select new XElement(y.Element("Value"))).First().Value,
                                                   GecerlilikSonu = (from y in x.Element("Columns").Elements("Column") where y.Element("ID").Value == "Col_3" select new XElement(y.Element("Value"))).First().Value,
                                                   AnalizAdi = analizAdi
                                               }).ToList();


                            frmPartiliUretimRaporuSecim.Close();
                            AIFConn.AnalizGiris.partileriGetir(analizPartilers);
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else if (pVal.ItemUID == "Item_1" && !pVal.BeforeAction)
                    {
                        try
                        {
                            frmPartiliUretimRaporuSecim.Close();
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
        }

        public void RightClickEvent(ref ContextMenuInfo eventInfo, out bool BubbleEvent)
        {
            BubbleEvent = true;
        }

    }
}