//There are n gas stations along a circular route, where the amount of gas at the ith station is gas[i].
//You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from the ith station to its next (i + 1)th station.
//You begin the journey with an empty tank at one of the gas stations.



var canCompleteCircuit = function(gas, cost) {
    //we can use the sliding window method
    let right = 0;
    let tank = gas[right];
    while(){
        if(tank-cost[i] > 0){
            tank -= cost[i];
            right++;
            tank += gas[right];
        }
    }
};