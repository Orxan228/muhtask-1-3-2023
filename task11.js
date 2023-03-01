let val = 345;
let count = 0;
let arr = [45,9345,"Salam",345, 93.6, 345];
for (let i = 0; i < arr.length; i++) {
    if(val == arr[i])
    {
        count++;
    }
}
if (count == 0) 
{
    console.log("There is no "+val+" value in this array");    
}
else
{
    console.log("There is "+count+" values in this array");
}
