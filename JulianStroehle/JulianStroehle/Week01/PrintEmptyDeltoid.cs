using System;
namespace JulianStroehle.Week1{
    public class DeltoidA{
        public static void Deltoid(int l, int h){
            for (int i = 0; i <=l; i++){
                for (int j = 0;j<=h;j++){
                    if (j==(l/2)&i==0||j==(l/2-i)&i==1||j==(l/2+i)&i==1||j==(l/2-i)&i==2||j==(l/2+i)&i==2||j==(l/2-i)&i==3||j==(l/2+i)&i==3||j==(l/2+i)&i==4||j==(l/2-i)&i==4){
                        Console.Write("x");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}