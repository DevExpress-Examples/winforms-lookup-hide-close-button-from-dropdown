<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128620497/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E292)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [MyLookUpEdit.cs](./CS/WindowsApplication1/MyLookUpEdit.cs) (VB: [MyLookUpEdit.vb](./VB/WindowsApplication1/MyLookUpEdit.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
<!-- default file list end -->
# How to delete the close button from the LookUpEdit popup window


<p>This task can be easily accomplished by creating a LookUpEdit descendant. Inherit from the PopupLookUpEditForm class, and set the fCloseButtonStyle property to BlobCloseButtonStyle.None. To embed your new class in the LookUpEdit descendant, override the LookUpEdit.CreatePopupForm method and return your own form.</p>

<br/>


