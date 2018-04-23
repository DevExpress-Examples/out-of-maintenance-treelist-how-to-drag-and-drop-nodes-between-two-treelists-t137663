using System.Web;
using System.Web.SessionState;
using System.Xml;
using DevExpress.Web.ASPxTreeList;

namespace MvcTreeListDragDrop.Model {
    public static class MyProvider {
        const string XmlSessionKey = "DXUNIQ";

        static HttpSessionState Session { get { return HttpContext.Current.Session; } }

        static XmlDocument Xml {
            get {
                if(Session[XmlSessionKey] == null)
                    Session[XmlSessionKey] = CreateXml();
                return (XmlDocument)Session[XmlSessionKey];
            }
        }
        static XmlDocument CreateXml() {
            XmlDocument doc = new XmlDocument();
            doc.Load(HttpContext.Current.Request.MapPath("~/Models/XMLfile1.xml"));
            return doc;
        }

	    public static void Bind(ASPxTreeList tree, string path) {
		    tree.ClearNodes();
		    XmlElement root = Xml.SelectSingleNode(path) as XmlElement;
		    BindCore(tree, tree.RootNode, root);		
	    }
	    static void BindCore(ASPxTreeList tree, TreeListNode node, XmlElement xmlNode) {
		    node.SetValue("Value", xmlNode.Attributes["value"].Value);
		    foreach(XmlElement element in xmlNode.ChildNodes) {
			    TreeListNode child = tree.AppendNode(element.GetAttribute("key"), node);
			    BindCore(tree, child, element);
		    }
	    }

        public static void MoveNode(string key, string newParentKey) {
            XmlElement element = FindNode(key);
            XmlElement toElement = FindNode(newParentKey);
            if(element != null && toElement != null)
                toElement.AppendChild(element);
        }
        static XmlElement FindNode(string key) {
            string xpath = string.Format("//node[@key='{0}']", key);
            return Xml.SelectSingleNode(xpath) as XmlElement;
        }
    }
}