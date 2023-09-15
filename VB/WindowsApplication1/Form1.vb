Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            dataSet1.Tables(CInt(0)).Rows.Add(New Object() {1, "First"})
            dataSet1.Tables(CInt(0)).Rows.Add(New Object() {2, "Second"})
        End Sub
    End Class
End Namespace
