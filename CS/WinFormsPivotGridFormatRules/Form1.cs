using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraEditors;

namespace WinFormsPivotGridFormatRules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson);

            // Creates a new FormatRule object.
            PivotGridFormatRule newRule = new PivotGridFormatRule();

            // Sets a Measure.
            newRule.Measure = fieldExtendedPrice;

            // Creates and specifies a new Settings object.
            newRule.Settings = new FormatRuleFieldIntersectionSettings{
                Column = fieldOrderYear1, 
                Row = fieldSalesPerson 
            };

            // Creates a new Rule object and sets its parameters.
            newRule.Rule = new FormatConditionRuleDataBar{ 
                PredefinedName = "Yellow Gradient" 
            };

            // Adds the rule to the collection.
            pivotGridControl1.FormatRules.Add(newRule);
        }
    }
}
