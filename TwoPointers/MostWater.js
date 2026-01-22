//You are given an integer array height of length n. There are n vertical lines drawn such that the
//two endpoints of the ith line are (i, 0) and (i, height[i]).
//Find two lines that together with the x-axis form a container,
//such that the container contains the most water.
//Return the maximum amount of water a container can store.
//Notice that you may not slant the container.


// O(n^2)
// var maxArea = function(height) {
//     let maxWater = 0;
//     for (let i=0; i<height.length-1; i++){
//         for (let j=i+1; j<height.length; j++){
//             let capacity = (height[i] > height[j] ? (j-i)*height[j] : (j-i)*height[i]);
//             maxWater = Math.max(maxWater,capacity);
//         }
//     }
//     return maxWater;
// };
//

var maxArea = function(height) {
    let left = 0;
    let right = height.length - 1;
    let maxWater = 0;

    while (left < right) {
        const width = right - left;
        const minHeight = Math.min(height[left], height[right]);
        const area = width * minHeight;

        maxWater = Math.max(maxWater, area);

        //move the pointer at the smaller height
        if (height[left] < height[right]) {
            left++;
        } else {
            right--;
        }
    }

    return maxWater;
};

let height = [1,8,6,2,5,4,8,3,7];
console.log(maxArea(height));
