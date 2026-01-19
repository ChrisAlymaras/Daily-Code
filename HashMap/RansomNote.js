//Given two strings ransomNote and magazine, return true if
//ransomNote can be constructed by using the letters from magazine and false otherwise.

var canConstruct = function(ransomNote, magazine) {
    const frequency ={};
    //count letter freq in magazine
    for (let letter of magazine){
        frequency[letter] = (frequency[letter] || 0) + 1;
    }
    //check ransomNote and substract each time we use from magazine
    for (let char of ransomNote){
        if (!frequency[char]){return false}
        frequency[char]--;
    }
    return true;
};

console.log(canConstruct("aa","abb"));