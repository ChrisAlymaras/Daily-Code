var hasCycle = function(head) {
    //this could be solved using fast-slow method
    let slow=head;
    let fast = head;
    //slow moves one .next at a time, while fast moves .next.next each time
    //if they both meat we have a cycle. If fast ends up to null there is not
    while(fast != null && fast.next !=null){
        slow = slow.next;
        fast = fast.next.next;
        //make comparison
        if(fast === slow){
            return true;
        }
    }
    return false;
};