// See https://aka.ms/new-console-template for more information
Console.WriteLine("How many W2's Do you have");
int NumOfW2s = int.Parse(Console.ReadLine());

int SumofW2s = 0;
for(int itr = 0; itr < NumOfW2s; itr++)
{
    Console.WriteLine("Enter W2 Tax Amount");
        int w2Amount = int.Parse(Console.ReadLine());
    SumofW2s += w2Amount;
}
Console.WriteLine("Enter Gross Income:");
int GrossIncome = int.Parse(Console.ReadLine());
int taxableincome = GrossIncome - SumofW2s;


if(taxableincome > 0 && taxableincome < 11000)
{
    double deductions = 0.10 * GrossIncome;
Console.WriteLine("You owe the IRS:" + deductions + "Amount of dollars" );
}
else if(taxableincome > 11000 && taxableincome <= 44000)
{
    double deductions = 0.10 * 11000 + 0.12* ( GrossIncome - 11000);
    Console.WriteLine("You owe the IRS:" + deductions  + "Amount of dollars");

}
else if(taxableincome >44000 && taxableincome <= 95000)
{
    double deductions = 0.10 * 11000 + 0.12 * (44000 - 11000) + +0.22 * (GrossIncome - 44000);
        Console.WriteLine("You owe the IRS:" + deductions  + "Amount of dollars");

}
else if(taxableincome >95000 && taxableincome <= 182000)
{
    double deductions = 0.10 * 11000 + 0.12 * (44000 - 11000) + +0.22 * (95000 - 44000) + 0.24 * (GrossIncome - 95000);

    Console.WriteLine("You owe the IRS:" + deductions + "Amount of dollars");

}
else if(taxableincome > 182000 && taxableincome <= 231000)
{
    double deductions = 0.10 * 11000 + 0.12 * (44000 - 11000) + +0.22 * (95000 - 44000) + 0.24 * (180000 - 95000) - 0.32*(GrossIncome - 182000);

    Console.WriteLine("You owe the IRS:" + deductions + "Amount of dollars");

}
else if (taxableincome > 231000 && taxableincome <= 50000)
{
    double deductions = 0.10 * 11000 + 0.12 * (44000 - 11000) + +0.22 * (95000 - 44000) + 0.24 * (180000 - 95000) + 0.32 * (231000 - 182000) - 0.35*(GrossIncome - 231000);

    Console.WriteLine("You owe the IRS:" + deductions + "Amount of dollars");

}
else if (taxableincome > 500000)
{
    double deductions = 0.10 * 11000 + 0.12 * (44000 - 11000) + +0.22 * (95000 - 44000) + 0.24 * (180000 - 95000) + 0.32 * (231000 - 182000) + 0.35 * (500000 - 231000) + 0.37*(GrossIncome-500000) ;

    Console.WriteLine("You owe the IRS:" + deductions + "Amount of dollars");

}
