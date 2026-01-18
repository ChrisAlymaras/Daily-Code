//There are n gas stations along a circular route, where the amount of gas at the ith station is gas[i].
//You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from the ith station to its next (i + 1)th station.
//You begin the journey with an empty tank at one of the gas stations.



var canCompleteCircuit = function(gas, cost) {
    let total = 0;
    let tank = 0;
    let start = 0;

    for (let i = 0; i < gas.length; i++) {
        total += gas[i] - cost[i];
        tank += gas[i] - cost[i];

        if (tank < 0) {
            start = i + 1;
            tank = 0;
        }
    }

    return total >= 0 ? start : -1;
};


gas = [1,2,3,4,5];
cost = [3,4,5,1,2];

console.log(canCompleteCircuit(gas, cost));