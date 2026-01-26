//Given a string s consisting of words and spaces,
//return the length of the last word in the string.

var lengthOfLastWord = function(s) {
    return s.trim().split(/\s+/).pop().length;
};

let s = " Hello World ";

console.log(lengthOfLastWord(s));