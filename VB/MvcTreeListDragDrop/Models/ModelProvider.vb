Imports Microsoft.VisualBasic
Imports System.Web
Imports System.Web.SessionState
Imports System.Xml
Imports DevExpress.Web.ASPxTreeList

Namespace MvcTreeListDragDrop.Model
	Public NotInheritable Class MyProvider
		Private Const XmlSessionKey As String = "DXUNIQ"

		Private Sub New()
		End Sub
		Private Shared ReadOnly Property Session() As HttpSessionState
			Get
				Return HttpContext.Current.Session
			End Get
		End Property

		Private Shared ReadOnly Property Xml() As XmlDocument
			Get
				If Session(XmlSessionKey) Is Nothing Then
					Session(XmlSessionKey) = CreateXml()
				End If
				Return CType(Session(XmlSessionKey), XmlDocument)
			End Get
		End Property
		Private Shared Function CreateXml() As XmlDocument
			Dim doc As New XmlDocument()
			doc.Load(HttpContext.Current.Request.MapPath("~/Models/XMLfile1.xml"))
			Return doc
		End Function

		Public Shared Sub Bind(ByVal tree As ASPxTreeList, ByVal path As String)
			tree.ClearNodes()
			Dim root As XmlElement = TryCast(Xml.SelectSingleNode(path), XmlElement)
			BindCore(tree, tree.RootNode, root)
		End Sub
		Private Shared Sub BindCore(ByVal tree As ASPxTreeList, ByVal node As TreeListNode, ByVal xmlNode As XmlElement)
			node.SetValue("Value", xmlNode.Attributes("value").Value)
			For Each element As XmlElement In xmlNode.ChildNodes
				Dim child As TreeListNode = tree.AppendNode(element.GetAttribute("key"), node)
				BindCore(tree, child, element)
			Next element
		End Sub

		Public Shared Sub MoveNode(ByVal key As String, ByVal newParentKey As String)
			Dim element As XmlElement = FindNode(key)
			Dim toElement As XmlElement = FindNode(newParentKey)
			If element IsNot Nothing AndAlso toElement IsNot Nothing Then
				toElement.AppendChild(element)
			End If
		End Sub
		Private Shared Function FindNode(ByVal key As String) As XmlElement
			Dim xpath As String = String.Format("//node[@key='{0}']", key)
			Return TryCast(Xml.SelectSingleNode(xpath), XmlElement)
		End Function
	End Class
End Namespace