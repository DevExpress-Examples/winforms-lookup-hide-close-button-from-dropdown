Imports Microsoft.VisualBasic
Imports System

Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.userLookUpEdit1 = New UserLookUpEdit()
        Me.dataSet1 = New DataSet1()
        Me.dataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.userLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' userLookUpEdit1
        ' 
        Me.userLookUpEdit1.Location = New System.Drawing.Point(56, 79)
        Me.userLookUpEdit1.Name = "userLookUpEdit1"
        Me.userLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.userLookUpEdit1.Properties.DataSource = Me.dataTable1BindingSource
        Me.userLookUpEdit1.Properties.DisplayMember = "Name"
        Me.userLookUpEdit1.Properties.ValueMember = "ID"
        Me.userLookUpEdit1.Size = New System.Drawing.Size(147, 20)
        Me.userLookUpEdit1.TabIndex = 0
        ' 
        ' dataSet1
        ' 
        Me.dataSet1.DataSetName = "DataSet1"
        Me.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' dataSet1BindingSource
        ' 
        Me.dataSet1BindingSource.DataSource = Me.dataSet1
        Me.dataSet1BindingSource.Position = 0
        ' 
        ' dataTable1BindingSource
        ' 
        Me.dataTable1BindingSource.DataMember = "DataTable1"
        Me.dataTable1BindingSource.DataSource = Me.dataSet1BindingSource
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.userLookUpEdit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        '			Me.Load += New System.EventHandler(Me.Form1_Load);
        CType(Me.userLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private userLookUpEdit1 As UserLookUpEdit
    Private dataTable1BindingSource As System.Windows.Forms.BindingSource
    Private dataSet1BindingSource As System.Windows.Forms.BindingSource
    Private dataSet1 As DataSet1

End Class
