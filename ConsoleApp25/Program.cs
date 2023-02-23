using Fractions;

string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
string str3 = Console.ReadLine();
Console.WriteLine();
Frac det = new(), detX = new(), detY = new(), detZ = new(), x = new(), y = new(), z = new();
Frac[,] chMatrix = new Frac[3, 1];
Frac[,] matrix = new Frac[3, 3];



matrix[0, 0] = new Frac(Frac.StrToNum(str1)[0]);
matrix[0, 1] = new Frac(Frac.StrToNum(str1)[1]);
matrix[0, 2] = new Frac(Frac.StrToNum(str1)[2]);

matrix[1, 0] = new Frac(Frac.StrToNum(str2)[0]);
matrix[1, 1] = new Frac(Frac.StrToNum(str2)[1]);
matrix[1, 2] = new Frac(Frac.StrToNum(str2)[2]);

matrix[2, 0] = new Frac(Frac.StrToNum(str3)[0]);
matrix[2, 1] = new Frac(Frac.StrToNum(str3)[1]);
matrix[2, 2] = new Frac(Frac.StrToNum(str3)[2]);



chMatrix[0, 0] = new Frac(Frac.StrToNum(str1)[3]);
chMatrix[1, 0] = new Frac(Frac.StrToNum(str2)[3]);
chMatrix[2, 0] = new Frac(Frac.StrToNum(str3)[3]);

det = Frac.DeterMatrix(matrix);

if(det.Get() == "0")
{
    Console.WriteLine("Определитель равен нулю");
    return;
}



detX = Frac.DeterMatrix(Frac.ChMatrix(Frac.NewMatrix(matrix), chMatrix, 0));
detY = Frac.DeterMatrix(Frac.ChMatrix(Frac.NewMatrix(matrix), chMatrix, 1));
detZ = Frac.DeterMatrix(Frac.ChMatrix(Frac.NewMatrix(matrix), chMatrix, 2));

x = Frac.Div(detX, det);
y = Frac.Div(detY, det);
z = Frac.Div(detZ, det);


Console.WriteLine(x.Get());
Console.WriteLine(y.Get());
Console.WriteLine(z.Get());