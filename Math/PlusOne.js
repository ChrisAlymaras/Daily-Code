//You are given a large integer represented as an integer array digits,
// where each digits[i] is the ith digit of the integer.
// The digits are ordered from most significant to least significant in
// left-to-right order. The large integer does not contain any leading 0's.

var plusOne = function(digits) {
    //[9,9,9] digits[length-1] = 0 all 9 go to 0 and we add 1 to the start
    //[2,3,9] 9 goes to 0 and 3 becomes 4
    let i = digits.length-1;
    let carry = 1;
    while (i>=0 && carry>0){
        if(digits[i] === 9){
            digits[i--] = 0;
            carry=1;
        }else{
            digits[i--] += carry;
            carry =0;
        }
    }
    if(carry){digits.unshift(1)}
    return digits;
};

let digits = [1,9,0,1];
console.log(plusOne(digits));