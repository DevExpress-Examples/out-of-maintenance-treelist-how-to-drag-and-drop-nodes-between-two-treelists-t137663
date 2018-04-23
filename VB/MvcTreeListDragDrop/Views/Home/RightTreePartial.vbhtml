@Html.DevExpress().TreeList(Sub(settings)
                                settings.Name = "RightTree"
                                settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "RightTreePartial"}
                                settings.SettingsEditing.NodeDragDropRouteValues = New With {.Controller = "Home", .Action = "RightTreePartial"}
                                settings.Columns.Add("Value")
                                settings.Settings.ShowColumnHeaders = False
                                settings.SettingsBehavior.AutoExpandAllNodes = True
                                settings.ClientSideEvents.StartDragNode = "MyDragHelper.StartDragNode"
                                settings.ClientSideEvents.EndDragNode = "MyDragHelper.EndDragNode"
                                settings.Init = Function(s, e)
                                                    MvcTreeListDragDrop.Model.MyProvider.Bind(DirectCast(s, ASPxTreeList), "/node/node[@key='8']")
                                                End Function
                            End Sub).GetHtml()