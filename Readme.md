<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620497/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E292)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Lookup - Hide the Close button from the dropdown

This example creates a custom lookup control that does not display the Close button in the dropdown (the `fCloseButtonStyle` field is set to `BlobCloseButtonStyle.None`). The example overrides the `LookUpEdit.CreatePopupForm` method to return a custom edit form:

```csharp
public class UserLookUpEdit : LookUpEdit {
  // ...
  protected override DevExpress.XtraEditors.Popup.PopupBaseForm CreatePopupForm() {
      return new UserPopupLookUpEditForm(this);
  }
}

public class UserPopupLookUpEditForm : PopupLookUpEditForm {

    public UserPopupLookUpEditForm(LookUpEdit owner)
        : base(owner) {
        fCloseButtonStyle = BlobCloseButtonStyle.None;
    }
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [MyLookUpEdit.cs](./CS/WindowsApplication1/MyLookUpEdit.cs) (VB: [MyLookUpEdit.vb](./VB/WindowsApplication1/MyLookUpEdit.vb))


## Documentation

* [Custom Editors](https://docs.devexpress.com/WindowsForms/4716/controls-and-libraries/editors-and-simple-controls/common-editor-features-and-concepts/custom-editors)
