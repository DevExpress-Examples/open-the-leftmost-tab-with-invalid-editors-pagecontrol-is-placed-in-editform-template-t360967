<script type="text/javascript">
    MVCxClientGlobalEvents.AddControlsInitializedEventHandler(function () {
        MVCx.validateInvisibleEditors = true;
    });

    function UpdateGridView(s, e) {
        GridView.UpdateEdit();

        var editors = [ProductName, UnitPrice, UnitsOnOrder];

        for (i = 0; i < editors.length; i++) {
            if (!IsEditorValid(editors[i]))
                break;
        }
    }

    function IsEditorValid(editor) {
        var isValid = editor.GetIsValid();
        if (!isValid)
            PageControl.SetActiveTabIndex(editor.cpTabIndex);
        return isValid;
    }
</script>

@Using (Html.BeginForm())
    @Html.Action("GridViewPartial")
End Using