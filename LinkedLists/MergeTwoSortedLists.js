//list1 and list2 represent the head of each list
var mergeTwoLists = function(list1, list2) {
    //check for empty lists
    if (list1 === null){return list2}
    if (list2 === null){return list1}
    //solve in recursive way
    if(list1.val <= list2.val){
        list1.next = mergeTwoLists(list1.next,list2);
        return list1;
    }else{
        list2.next = mergeTwoLists(list1,list2.next);
        return list2;
    }
    //the head of the sorted list is returned at the end
};