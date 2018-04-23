@modeltype Product

@Html.DevExpress().PageControl( _
    Sub(settings)
            settings.Name = "PageControl"

            settings.TabPages.Add("Product Name").SetContent( _
                  Sub()
                          Html.DevExpress().Label( _
                              Sub(s)
                                      s.AssociatedControlName = "ProductName"
                                      s.Text = "Product Name:"
                              End Sub).GetHtml()
                          Html.DevExpress().TextBoxFor(Function(m) m.ProductName, _
                                                       Sub(s)
                                                               s.ShowModelErrors = True
                                                               s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                               s.CustomJSProperties = Sub(sender, ea) ea.Properties("cpTabIndex") = 0
                                                       End Sub).GetHtml()
                  End Sub)

            settings.TabPages.Add("Unit Price").SetContent( _
                    Sub()
                            Html.DevExpress().Label( _
                                                Sub(s)
                                                        s.AssociatedControlName = "UnitPrice"
                                                        s.Text = "Unit Price:"
                                                End Sub).GetHtml()
                            Html.DevExpress().TextBoxFor(Function(m) m.UnitPrice, _
                                                         Sub(s)
                                                                 s.ShowModelErrors = True
                                                                 s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                                 s.CustomJSProperties = Sub(sender, ea) ea.Properties("cpTabIndex") = 1
                                                         End Sub).GetHtml()
                    End Sub)
           
            settings.TabPages.Add("Units On Order").SetContent( _
                    Sub()
                            Html.DevExpress().Label( _
                                Sub(s)
                                        s.AssociatedControlName = "UnitsOnOrder"
                                        s.Text = "Units On Order:"
                                End Sub).GetHtml()
                            Html.DevExpress().TextBoxFor(Function(m) m.UnitsOnOrder, _
                                                        Sub(s)
                                                                s.ShowModelErrors = True
                                                                s.Properties.ValidationSettings.ErrorDisplayMode = ErrorDisplayMode.ImageWithText
                                                                s.CustomJSProperties = Sub(sender, ea) ea.Properties("cpTabIndex") = 2
                                                        End Sub).GetHtml()
                    End Sub)
    End Sub).GetHtml()

@Html.DevExpress().HyperLink(Sub(s)
                                 s.Name = "Update"
                                 s.Properties.Text = "Update"
                                 s.NavigateUrl = "javascript:UpdateGridView();"
                             End Sub).GetHtml()
@Html.DevExpress().HyperLink(Sub(s)
                                 s.Name = "Cancel"
                                 s.Properties.Text = "Cancel"
                                 s.NavigateUrl = "javascript:GridView.CancelEdit();"
                             End Sub).GetHtml()