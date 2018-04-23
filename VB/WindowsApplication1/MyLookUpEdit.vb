Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Popup

Public Class UserLookUpEdit
    Inherits LookUpEdit

    Shared Sub New()
        RepositoryItemUserLookUpEdit.Register()
    End Sub

    Public Sub New()
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "UserLookUpEdit"
        End Get
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Shadows ReadOnly Property Properties() As RepositoryItemUserLookUpEdit
        Get
            Return TryCast(MyBase.Properties, RepositoryItemUserLookUpEdit)
        End Get
    End Property
    Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
        Return New UserPopupLookUpEditForm(Me)
    End Function
End Class

<UserRepositoryItem("Register")> _
Public Class RepositoryItemUserLookUpEdit
    Inherits RepositoryItemLookUpEdit
    Shared Sub New()
        Register()
    End Sub
    Public Sub New()
    End Sub

    Public Shared Sub Register()
        EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("UserLookUpEdit", GetType(UserLookUpEdit), GetType(RepositoryItemUserLookUpEdit), GetType(DevExpress.XtraEditors.ViewInfo.LookUpEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True))
    End Sub

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return "UserLookUpEdit"
        End Get
    End Property
End Class

Public Class UserPopupLookUpEditForm
    Inherits PopupLookUpEditForm

    Public Sub New(ByVal owner As LookUpEdit)
        MyBase.New(owner)
        fCloseButtonStyle = BlobCloseButtonStyle.None
    End Sub
End Class
