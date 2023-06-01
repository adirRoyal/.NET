string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] newOrderStream = orderStream.Split(',');
Array.Sort(newOrderStream);
foreach (string newOrder in newOrderStream)
{
    char[] a = newOrder.ToCharArray();
    if (a.Length != 4)
        Console.WriteLine(newOrder + "        - Error");
    else Console.WriteLine(newOrder);
}