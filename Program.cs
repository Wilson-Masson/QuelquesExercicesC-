using System;

namespace consolrAppExercise
{
    class Program
   
    {
         public static double calculatrice(double valeur1,char op,double valeur2)
         {
             double result ;
             switch(op)
             {
                 case '+':
                 result=valeur1+valeur2;
                 break;
                 case '-':
                 result=valeur1-valeur2;
                 break;
                 case '*':
                 result=valeur1*valeur2;
                 break;
                 case '/':
                 result=valeur1/valeur2;
                 break;
                 default:
                 result=0;
                 break;

             }
             return result;
         

    }
        static void Main(string[] args)
        { 
            double result=calculatrice(34 ,'-',12);
            Console.WriteLine("Entrez l'age ");
            int age=Convert.ToInt32(Console.ReadLine());
            //Expression ternaire
            string texte =(age >18) ? "Mageur" : "Mineur";
            Console.WriteLine(texte);

            //string
            string name ="Wilson Masson";
            string[] names=name.Split('-');
            foreach(var i in names)
            {
             Console.WriteLine(i);
            }
            
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.IndexOf('n'));
            Console.WriteLine(name.Length);
            Console.WriteLine(name.Substring(name.IndexOf('M')));
            Console.WriteLine(name[0]);

            //les boucles :while, do while , for, foreach
            // int i=12;
            // while (i<10)
            // {
            //     Console.WriteLine(i);
            //              i++;
            // }
            // do while
            //    {

            //    }
            // for(int i =10 ; i >= 0 ; i--)
            // {
            //     Console.WriteLine(i);
            // }
            for(int i = 0 ; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            //foreach 
            // foreach(char n in name){
            //     Console.WriteLine(n);
            // }
            //arrays(tableaux)
            // string [] names ={ "Wilson","Jean","Etienne","Ben","Elisa"};
            int [] ages ={ 20,30,24,22};
            //Autre Maniere de declaration de tableau
            // string[] names =new string[]{ "Wilson","Jean","Etienne","Ben","Elisa"};
            //  int [] ages=new int[]{ 20,30,24,22};
            //pour afficher
            foreach(string nom in names)
            {
                Console.WriteLine(nom);
            }
            foreach(int chiffre in ages)
            {
                Console.WriteLine(chiffre);
            }
            
            //Affichage
            // Console.WriteLine("Tapper votre nom:");
            // string nom= Console.ReadLine();
            // Console.WriteLine($"votre nom est:{nom}");
            //  // les types de donnes
            //  int a=34;
            //  long b=34L;
            //  char m='M';
            //  string nome ="Francois";
            //  bool bo=true;
            //  float f=5,3;
            //  double =54.3;
            //  string="20";
            //   Console.WriteLine("Tapper votre age:");
              
            //  int age=Convert.ToInt32(Console.ReadLine());
            //  //les conditions:if et switch
             
            //  if (age >=30)
            //  {
            //      Console.WriteLine("vous etes adultes");
            //  }
            //  else if(age >=20)
            //  {
            //      Console.WriteLine("Vous etes adolescents");
            //  }
            //  else
            //  Console.WriteLine("Vous etes mineur");

             string []namess={"Ella","Bosco"};
             Console.WriteLine(namess.GetType());
             Console.WriteLine("La taille est de:" + namess.Length);

             namess=new string[]{"Ella","Bosco","Wil"};
             foreach(var namet in namess)
             {
                 Console.WriteLine(namet);
             }
             Array.Sort(namess);
             Array.Sort(namess);
            

             Console.WriteLine("Ordonner un tableau");
             foreach(var namet in namess)
             {
                  Console.WriteLine(namet);
             }
        }
    }
}
