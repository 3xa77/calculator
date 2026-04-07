// See https://aka.ms/new-console-template for more information
int var1 = 10;
int var2 = 6;

static int penjumlahan(int var1, int var2)
{
    return var1 + var2;
}
static int pengurangan(int var1, int var2)
{
    return var1 - var2;
}
static int perkalian(int var1, int var2)
{
    return var1 * var2;
}
static int pembagian(int var1, int var2)
{
    return var1 / var2;
}
Console.WriteLine("penjumlahan: " + var1 + " + " + var2 + " = " +penjumlahan(var1,var2));
Console.WriteLine("pengurangan: " + var1 + " + " + var2 + " = " +pengurangan(var1, var2));
Console.WriteLine("perkalian:   " + var1 + " + " + var2 + " = " + perkalian(var1, var2));
Console.WriteLine("pembagian:   " + var1 + " + " + var2 + " = " +pembagian(var1, var2));
