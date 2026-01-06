//given an array prices  = [7,1,5,3,6,4],
// i represents days
// values represent stock prices each day
// return maximum profit if exists or return 0.

var maxProfit = function(prices) {
//     let max = 0;
//     //check for empty or one element array
//     if (prices.length <= 1){return max} //no transactions can be done
//     //declare a sliding window
//     let left = 0;
//     let right = 1;
//     while(left < prices.length-1){
//         max = Math.max(max, prices[right]-prices[left]);
//         right++;
//         if(right === prices.length){
//             left++;
//             right = left+1;
//         }
//     }
//     return max;

     //optimal solution
     let minPrice = prices[0];
     let max = 0;
     if (prices.length <= 1){return max}

     for (let i=0; i<prices.length; i++){
         max = Math.max(max, prices[i]-minPrice);
         minPrice = Math.min(minPrice,prices[i]);
     }
     return max;
};

