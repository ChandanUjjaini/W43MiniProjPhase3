//Code to enter and print product number
//Project Phase 3

using System;

string[] Prodcode = new string[0];
int index = 0;

while (true)
{
    Console.Write("Enter Product Code:");
    String data = Console.ReadLine(); //Reading product code
    if (data.ToLower().Trim() == "exit") //Checking to exit loop,based on multiple possiblities of "exit" Format
    {
        break;
    }
    else
    {
        String[] code = data.Split('-'); //Spliting string based on "-"
        int i = 0;

        //Console.WriteLine(code[i]); //Debug step to check Split data
        bool ifchar = code[i].All(char.IsLetter); // Checking for number in first part
        //Console.WriteLine(ifchar); //Debug step to check bool output
        if (ifchar)
        {
            bool ifnum = int.TryParse(code[i + 1], out int num); // Checking for character in second part
            // Console.WriteLine(code[i+1]); //Debug step to check Split data
            // Console.WriteLine(num); //Debug step to check output
            //Console.WriteLine(ifnum); //Debug step to check bool output
            if (ifnum && num>200 && num<500) //Checking for number band limit (greater than 200 and less than 500)
            {
                Array.Resize(ref Prodcode, index + 1); //Resizing Array based on number of product code entered
                Prodcode[index] = data; //Updating the productcode array
                //Console.WriteLine(data); //Debug step to check output
                index++;
                continue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{code[i+1]} product code not acceptable"); //Display error message with data
                Console.ResetColor();
                continue;

            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{code[i]} product code not acceptable"); //Display error message with data
            Console.ResetColor();
            continue;
        }



    }




    
}

Console.ResetColor();

Console.WriteLine("----------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("product code list (sorted):-");
Console.ResetColor();

Array.Sort(Prodcode); //sorting the array of product
Console.WriteLine("----------------------------");

foreach (string data in Prodcode) // loop to print all the data in the prodcut code array
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(data);
    Console.ResetColor();
    Console.WriteLine("----------------------------");
}



Console.ReadLine();