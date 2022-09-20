/*void Numbers(int m, int n){//задача 1
    Console.WriteLine(m + " ");

if  (n==m) {
    return;
}
else Numbers(m+1,n);

}

Numbers (4,8);*/


/*int NumbersSum(int m, int n) {//задача 2
   if (m==n) {
    return n;
   }
   else 
   return n + NumbersSum(m,n-1);
}
Console.WriteLine(NumbersSum(1,4));*/

/*int AkkermanF(int m, int n) {//задача 3
if (m==0) {
    return n+1;
}
else if (n == 0 && m > 0)
{
return AkkermanF(m - 1, 1);
}
else
{
return AkkermanF(m - 1, AkkermanF(m, n - 1));
}
}
Console.WriteLine(AkkermanF(2,3));*/