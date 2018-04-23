MyDragHelper = {    
    StartDragNode: function(s, e) {
        MyDragHelper.CreateTargets(e.targets);
    },
    EndDragNode: function(s, e) {
        var key = parseInt(e.nodeKey);
        var targetKey;
        if(e.targetElement.id == "__leftRoot") {
            targetKey = 1;
        } else if(e.targetElement.id == "__rightRoot") {
            targetKey = 8;
        } else {
            targetKey = MyDragHelper.GetTargetTree(e.targetElement).GetNodeKeyByRow(e.targetElement);
        }
        $.ajax({
            url: $("#container").data('request-url'),
            data: { sourceKey: key, newParentKey: targetKey },
            success: function(response){
                $("#container").html(response);
            }
        });
        e.cancel = true;
    },

    CreateTargets: function(targets) {
        targets.splice(0, targets.length);
        var list = [LeftTree, RightTree];
        for(var i = 0; i < list.length; i++) {
            var tree = list[i];
            var keys = tree.GetVisibleNodeKeys();
            for(var j = 0; j < keys.length; j++)
                targets.push(tree.GetNodeHtmlElement(keys[j]));
        }
        targets.push(document.getElementById("__leftRoot"));
        targets.push(document.getElementById("__rightRoot"));
    },
    
    GetTargetTree: function(element) {
        var leftElement = LeftTree.GetMainElement();
        var rightElement = RightTree.GetMainElement();
        while(element) {
            if(element == leftElement)
                return LeftTree;
            if(element == rightElement)
                return RightTree;
            element = element.parentNode;
        }
    }
}