Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
string message = "";

if (daysUntilExpiration <= 10 && daysUntilExpiration != 0)
{
    if (daysUntilExpiration <= 5)
    {
        if(daysUntilExpiration == 1)
        {
            message = "Your subscription expires within a day! Renew now and save 20%!";
            discountPercentage =20;
        }
        else
        {
            message = $"Your subscription expires in {daysUntilExpiration} days.Renew now and save 10%!";
            discountPercentage = 10;    
        }
    }
    else
    {
        message = "Your subscription will expire soon. Renew now!";        
    }
}
else if (daysUntilExpiration == 0)
{
    message = "Your subscription has expired.";
}
Console.WriteLine(daysUntilExpiration);
Console.WriteLine(message);