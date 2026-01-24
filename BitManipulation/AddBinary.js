//Given two binary strings a and b, return their sum as a binary string.

var addBinary = function(a, b) {
    let i = a.length-1;
    let j = b.length-1;
    let carry = 0;
    let result = "";
    //loop stops when both indexes go to minus and no carry exists
    while (i>=0 || j>=0 || carry>0){
        let sum = carry;
        if(i>=0){sum += Number(a[i--])}
        if(j>=0){sum += Number(b[j--])}
        result = (sum % 2) + result;
        carry = Math.floor(sum/2);
    }
    return result;
};

let a = "11";
let b = "10";
console.log(addBinary(a, b));