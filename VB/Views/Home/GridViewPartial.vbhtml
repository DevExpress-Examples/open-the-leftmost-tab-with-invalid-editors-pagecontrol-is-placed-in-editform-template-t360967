@modeltype List(of Product)

@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "ProductID"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.SettingsEditing.AddNewRowRouteValues = New With {.Controller = "Home", .Action = "GridViewAddNewPartial"}
            settings.SettingsEditing.UpdateRowRouteValues = New With {.Controller = "Home", .Action = "GridViewUpdatePartial"}
            settings.SettingsEditing.DeleteRowRouteValues = New With {.Controller = "Home", .Action = "GridViewDeletePartial"}

            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowEditButton = True
            settings.CommandColumn.ShowNewButton = True
            settings.CommandColumn.ShowDeleteButton = True

            settings.Columns.Add( _
                Sub(column)
                        column.FieldName = "ProductID"
                        column.ReadOnly = True
                        column.EditFormSettings.Visible = DefaultBoolean.False
                End Sub)

            settings.Columns.Add("ProductName")
            settings.Columns.Add("UnitPrice")
            settings.Columns.Add("UnitsOnOrder")

            settings.SetEditFormTemplateContent( _
                Sub(container)
                        Html.RenderPartial("EditFormPartial", If((Not container.Grid.IsNewRowEditing),
                                           Model.FirstOrDefault(Function(m) m.ProductID = Convert.ToInt32(DataBinder.Eval(container.DataItem, "ProductID"))),
                                           New Product()))
                End Sub)

    End Sub).SetEditErrorText(ViewData("EditError")).Bind(Model).GetHtml()