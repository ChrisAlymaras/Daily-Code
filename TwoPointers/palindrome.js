var isPalindrome = function(s) {
    s = s.toLowerCase().replace(/[^a-z0-9]/g, "");
    let reversed = s.split("").reverse().join("");
    return reversed === s;
};

let str = "A man, a plan, a canal: Panama";
console.log(isPalindrome(str));