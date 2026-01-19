//A subsequence of a string is a new string that is formed from the original
//string by deleting some (can be none) of the characters without disturbing
// the relative positions of the remaining characters.
//(i.e., "ace" is a subsequence of "abcde" while "aec" is not).

var isSubsequence = function(s, t) {
    let sIndex =0;
    for(let i=0; i<t.length; i++){
        if(s[sIndex] === t[i]){
            sIndex++;
        }
    }
    return (sIndex === s.length);
};

let s = "axc";
let t = "ahbgdc";

console.log(isSubsequence(s, t));