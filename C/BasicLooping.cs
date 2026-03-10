//start of quick practice before moving to small challenege
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

//print length of fraudulentOrderIDs arr
Console.WriteLine($"Length of fraudulentOrderIDs is: {fraudulentOrderIDs.Length}");

//loop through array
string[] names = {"Alex","Chris","Niko"};
foreach(string name in names)
{
    Console.WriteLine(name);
}

//end of quick practice

//start of mini challenge

//declare an arr of IDs
string[] arr =
{
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
};

//report IDs starting with B
foreach(string id in arr)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine($"ID: {id} starts with 'B'");
    }
}