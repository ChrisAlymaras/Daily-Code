//given an array of integers remove all numbers equal to given val and return the length of the updated array

var removeElement = function(nums, val) {
    let k = nums.length;
    for (let i=0; i<k; i++){
        if (val === nums[i]){
            nums.splice(i,1);
            i--;
        }
        k = nums.length;
    }
    //return nums length
    return k;
};

let nums = [0,1,2,2,3,0,4,2];


console.log(removeElement(nums,2));
console.log(nums);