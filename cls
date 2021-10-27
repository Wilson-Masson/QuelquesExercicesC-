[1mdiff --git a/Program.cs b/Program.cs[m
[1mindex 5959b8e..ad507af 100644[m
[1m--- a/Program.cs[m
[1m+++ b/Program.cs[m
[36m@@ -5,7 +5,7 @@[m [mnamespace consolrAppExercise[m
     class Program[m
    [m
     {[m
[31m-         public static double calculatrice(double valeur1,char op,)[m
[32m+[m[32m         public static double calculatrice(double valeur1,char op,double valeur2)[m
          {[m
              double result ;[m
              switch(op)[m
[36m@@ -22,8 +22,12 @@[m [mnamespace consolrAppExercise[m
                  case '/':[m
                  result=valeur1/valeur2;[m
                  break[m
[32m+[m[32m                 default:[m
[32m+[m[32m                 result=0;[m
[32m+[m[32m                 break;[m
 [m
              }[m
[32m+[m[32m             return result;[m
          }[m
 [m
     }[m
[36m@@ -56,7 +60,7 @@[m [mnamespace consolrAppExercise[m
             //  }[m
             //  else[m
             //  Console.WriteLine("Vous etes mineur");[m
[31m-            [m
[32m+[m
              [m
         }[m
     }[m
