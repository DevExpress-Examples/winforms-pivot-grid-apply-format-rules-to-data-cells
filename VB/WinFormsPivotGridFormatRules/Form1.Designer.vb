Namespace WinFormsPivotGridFormatRules

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.nwindDataSet1 = New WinFormsPivotGridFormatRules.nwindDataSet()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderYear1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonTableAdapter1 = New WinFormsPivotGridFormatRules.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataMember = "SalesPerson"
            Me.pivotGridControl1.DataSource = Me.nwindDataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCountry, Me.fieldOrderYear1, Me.fieldExtendedPrice, Me.fieldSalesPerson})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.LookAndFeel.UseDefaultLookAndFeel = False
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(602, 326)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            dataSourceColumnBinding1.ColumnName = "Country"
            Me.fieldCountry.DataBinding = dataSourceColumnBinding1
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldOrderYear1
            ' 
            Me.fieldOrderYear1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderYear1.AreaIndex = 0
            Me.fieldOrderYear1.Caption = "Year"
            dataSourceColumnBinding2.ColumnName = "OrderDate"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear1.DataBinding = dataSourceColumnBinding2
            Me.fieldOrderYear1.Name = "fieldOrderYear1"
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            dataSourceColumnBinding3.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding3
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson.AreaIndex = 1
            Me.fieldSalesPerson.Caption = "Sales Person"
            dataSourceColumnBinding4.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = dataSourceColumnBinding4
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            ' 
            ' salesPersonTableAdapter1
            ' 
            Me.salesPersonTableAdapter1.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(602, 326)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "WinForms Pivot Grid: Conditional Formatting"
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private nwindDataSet1 As WinFormsPivotGridFormatRules.nwindDataSet

        Private salesPersonTableAdapter1 As WinFormsPivotGridFormatRules.nwindDataSetTableAdapters.SalesPersonTableAdapter

        Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderYear1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
