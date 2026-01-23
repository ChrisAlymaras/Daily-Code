var minSubArrayLen = function(target, nums) {
    let left = 0;
    let sum = 0;
    let minLength = Infinity;

    for (let right = 0; right < nums.length; right++) {
        sum += nums[right];
        // shrink window while valid
        while (sum >= target) {
            minLength = Math.min(minLength, right - left + 1);
            sum -= nums[left];
            left++;
        }
    }
    return minLength === Infinity ? 0 : minLength;
};


let nums =[5,1,3,5,10,7,4,9,2,8];
let target =15;
console.log(minSubArrayLen(target,nums));