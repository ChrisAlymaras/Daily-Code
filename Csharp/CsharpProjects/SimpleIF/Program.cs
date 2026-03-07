Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7); 

int total = roll1 + roll2 + roll3;
roll1 = 6;
roll2 = 6;
roll3 = 5;
Console.WriteLine($"Dice rolls: {roll1}+{roll2}+{roll3} Total sum is {total}");

if (total < 14)
{
    Console.WriteLine("You Win!");
}
else
{
    Console.WriteLine("Sorry you lose.");
}

//give a bonus to doubles
if (roll1 == roll2 || roll1 ==roll3 || roll2 == roll3)
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles ! +2 bonus total !");
        total +=2;    
    }
}