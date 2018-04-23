# How to delete the close button from the LookUpEdit popup window


<p>This task can be easily accomplished by creating a LookUpEdit descendant. Inherit from the PopupLookUpEditForm class, and set the fCloseButtonStyle property to BlobCloseButtonStyle.None. To embed your new class in the LookUpEdit descendant, override the LookUpEdit.CreatePopupForm method and return your own form.</p>

<br/>


