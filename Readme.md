<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/MvcTreeListDragDrop/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcTreeListDragDrop/Controllers/HomeController.vb))
* **[MyDragHelper.js](./CS/MvcTreeListDragDrop/Scripts/MyDragHelper.js) (VB: [MyDragHelper.js](./VB/MvcTreeListDragDrop/Scripts/MyDragHelper.js))**
* [Index.cshtml](./CS/MvcTreeListDragDrop/Views/Home/Index.cshtml)
* [LeftTreePartial.cshtml](./CS/MvcTreeListDragDrop/Views/Home/LeftTreePartial.cshtml)
* [RightTreePartial.cshtml](./CS/MvcTreeListDragDrop/Views/Home/RightTreePartial.cshtml)
* [TreeListContainerPartial.cshtml](./CS/MvcTreeListDragDrop/Views/Home/TreeListContainerPartial.cshtml)
<!-- default file list end -->
# TreeList - How to drag and drop nodes between two treelists


This example demonstrates how to drag and drop nodes between two treelists. To do so, each extension has its client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxTreeListScriptsASPxClientTreeList_StartDragNodetopic">StartDragNode</a> and <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxTreeListScriptsASPxClientTreeList_EndDragNodetopic">EndDragNode</a> events handled to:<br />
<p>- Add new drop targets for the node being dragged;<br />- Perform a callback to the server to update the state of both treelists.</p>
This logic is implemented inside the MyDragHelper.js file.<br /><br /><strong>See Also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/E251">How to drag and drop nodes between two ASPxTreeList controls</a>

<br/>


