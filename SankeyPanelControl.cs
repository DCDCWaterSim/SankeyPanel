using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSimDCDC;
using WaterSimDCDC.Generic;
//using WaterSim_West_v_1;
using ConsumerResourceModelFramework;

namespace SankeyPanel
{
    public partial class SankeyPanelControl : UserControl
    {
        WaterSimManager_DB MyWSIM;

        WaterSimCRFModel TheCRFModel = null;
        string ModelUnitName = "AZ_Central";
        public SankeyPanelControl()
        {
            InitializeComponent();
        }

        public WaterSimManager_DB PanelWaterSim
        {
            get { return MyWSIM; }
            set
            {
                if (value != null)
                {
                    MyWSIM = value;
                    UnitData TheData = null;
                    TheData = MyWSIM.WaterSimWestModel.ModelUnitData;
                    ResetSanKeyGraphUnit(ModelUnitName);
                    sankeyGraph1_label.Text = PanelWaterSimName;
                   
                }
            }
        }
        public string PanelWaterSimName
        {
            get { return ModelUnitName; }
            set
            {
                ModelUnitName = value;
                ResetSanKeyGraphUnit(ModelUnitName);
            }
        }
        public CRF_Network PanelNetwork
        {
            get { return sankeyGraph1.Network ; }
            set { sankeyGraph1.Network = value; }
        }
        //
        private void ResetSanKeyGraphUnit(String aUnitName)
        {

            if (MyWSIM != null) TheCRFModel = MyWSIM.WaterSimWestModel.GetUnitModel(aUnitName);
            if (TheCRFModel != null)
            {
                ModelUnitName = aUnitName;
                sankeyGraph1.Network = TheCRFModel.TheCRFNetwork;
                sankeyGraph1_label.Text = TheCRFModel.UnitName;
              
            }
        }
        //
        class ComboItem
        {
            public int ID { get; set; }
            public string Text { get; set; }
        }
        //  
    }
}
