@Html.DevExpress().TreeList(Sub(settings)
                                settings.Name = "LeftTree"
                                settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "LeftTreePartial"}
                                settings.SettingsEditing.NodeDragDropRouteValues = New With {.Controller = "Home", .Action = "LeftTreePartial"}
                                settings.Columns.Add("Value")
                                settings.Settings.ShowColumnHeaders = False
                                settings.SettingsBehavior.AutoExpandAllNodes = True
                                settings.ClientSideEvents.StartDragNode = "MyDragHelper.StartDragNode"
                                settings.ClientSideEvents.EndDragNode = "MyDragHelper.EndDragNode"
                                settings.Init = Function(s, e)
                                                    MvcTreeListDragDrop.Model.MyProvider.Bind(DirectCast(s, ASPxTreeList), "/node/node[@key='1']")
                                                End Function
                            End Sub).GetHtml()
