<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/WebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcTreeListDragDrop/Controllers/HomeController.vb))
* **[MyDragHelper.js](./CS/WebApplication1/Scripts/MyDragHelper.js) (VB: [MyDragHelper.js](./VB/MvcTreeListDragDrop/Scripts/MyDragHelper.js))**
* [Index.cshtml](./CS/WebApplication1/Views/Home/Index.cshtml)
* [LeftTreePartial.cshtml](./CS/WebApplication1/Views/Home/LeftTreePartial.cshtml)
* [RightTreePartial.cshtml](./CS/WebApplication1/Views/Home/RightTreePartial.cshtml)
* [TreeListContainerPartial.cshtml](./CS/WebApplication1/Views/Home/TreeListContainerPartial.cshtml)
<!-- default file list end -->
# TreeList - How to drag and drop nodes between two treelists
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t137663/)**
<!-- run online end -->


This example demonstrates how to drag and drop nodes between two treelists. To do so, each extension has its client-side <a href="https://docs.devexpress.com/AspNet/js-ASPxClientTreeList.StartDragNode">StartDragNode</a> and <a href="https://docs.devexpress.com/AspNet/js-ASPxClientTreeList.EndDragNode">EndDragNode</a> events handled to:<br />
<p>- Add new drop targets for the node being dragged;<br />- Perform a callback to the server to update the state of both treelists.</p>
This logic is implemented inside the MyDragHelper.js file.<br /><br /><strong>See Also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/E251">How to drag and drop nodes between two ASPxTreeList controls</a>

<br/>


