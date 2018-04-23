Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports MvcTreeListDragDrop.Model

Namespace MvcTreeListDragDrop.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function
		Public Function LeftTreePartial() As ActionResult
			Return PartialView("LeftTreePartial")
		End Function
		Public Function RightTreePartial() As ActionResult
			Return PartialView("RightTreePartial")
		End Function
		Public Function UpdateTreeListContainer(ByVal sourceKey As String, ByVal newParentKey As String) As ActionResult
			MyProvider.MoveNode(sourceKey, newParentKey)
			Return PartialView("TreeListContainerPartial")
		End Function
	End Class
End Namespace