let nums = [0,76,76,3,27,5,9];
let max = nums[0];
let count = 0;
//max number of array
for (let i = 0; i < nums.length; i++) 
{
if(nums[i] > max)
{
    max = nums[i];
}
else if(nums[i] == max)
{
    count++;
}
}
console.log("Max number of array is: "+max+" and there is "+count+ " of this element in this array.");