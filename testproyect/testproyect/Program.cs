using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testproyect
{
    class Program
    {
        private static int i;

        public static int I { get => i; set => i = value; }
        public static int I1 { get => i; set => i = value; }

        static void Main(string[] args)
        {
            //palabra a adivinar & palabra a mostrar
            string palabrasecreta = Console.ReadLine();
            string shownword = "";

            //manejo de arrives
            int[] numbers = new int[4];
            numbers[2] = 7;
            char lettter=palabrasecreta[0];
            
            
            
            //limpieza de pantalla
            Console.Clear();

            //llenaba palabra a mostar con un caracter
            //si fuese while(shownword.length!=
            for (int i = 0; i < palabrasecreta.Length; i++){
                shownword += '*';
            }

            

            //palabra a mostrar en la consola
            Console.WriteLine(shownword);
            //loop
            while (shownword != palabrasecreta){
                //update
                string attempt = Console.ReadLine();
                if (attempt.Length > 1){
                    if(attempt==palabrasecreta){
                        shownword = palabrasecreta;
                    }
                }
                else {
                    if (palabrasecreta.Contains(attempt)){
                        Console.WriteLine("ACERTASTE");
                        string tempword = "";

                        for (int i = 0; i < palabrasecreta.Length; i++) ;
                         if (palabrasecreta[i] == attempt[0]){
                            tempword += palabrasecreta[i];
                        }
                        else{
                            tempword += shownword[i];

                        }

                        shownword = tempword;
                    }

                    


                }

            }
        }
    }
}
