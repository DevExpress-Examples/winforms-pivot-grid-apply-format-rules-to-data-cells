Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraEditors

Namespace WinFormsPivotGridFormatRules

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson)
            ' Creates a new FormatRule object.
            Dim newRule As PivotGridFormatRule = New PivotGridFormatRule()
            ' Sets a Measure.
            newRule.Measure = fieldExtendedPrice1
            ' Creates and specifies a new Settings object.
            newRule.Settings = New FormatRuleFieldIntersectionSettings With {.Column = fieldOrderYear1, .Row = fieldSalesPerson1}
            ' Creates a new Rule object and sets its parameters.
            newRule.Rule = New FormatConditionRuleDataBar With {.PredefinedName = "Yellow Gradient"}
            ' Adds the rule to the collection.
            pivotGridControl1.FormatRules.Add(newRule)
        End Sub
    End Class
End Namespace
