Imports System.ComponentModel
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Popup

Namespace WindowsApplication1

    Public Class UserLookUpEdit
        Inherits LookUpEdit

        Shared Sub New()
            RepositoryItemUserLookUpEdit.Register()
        End Sub

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property EditorTypeName As String
            Get
                Return "UserLookUpEdit"
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public Overloads ReadOnly Property Properties As RepositoryItemUserLookUpEdit
            Get
                Return TryCast(MyBase.Properties, RepositoryItemUserLookUpEdit)
            End Get
        End Property

        Protected Overrides Function CreatePopupForm() As PopupBaseForm
            Return New UserPopupLookUpEditForm(Me)
        End Function
    End Class

    <UserRepositoryItem("Register")>
    Public Class RepositoryItemUserLookUpEdit
        Inherits RepositoryItemLookUpEdit

        Shared Sub New()
            Call Register()
        End Sub

        Public Sub New()
        End Sub

        Public Shared Sub Register()
            Call EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo("UserLookUpEdit", GetType(UserLookUpEdit), GetType(RepositoryItemUserLookUpEdit), GetType(ViewInfo.LookUpEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True))
        End Sub

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Overrides ReadOnly Property EditorTypeName As String
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
End Namespace
