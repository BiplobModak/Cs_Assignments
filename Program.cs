using System;

namespace blog
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            /*
                frist piramid 
                      *
                     * *
                    * * * 

            */
            for(i = 0; i<10 ; i++){
                for(j =10; j>i; j--){
                    Console.Write(" ");
                
                }
                for(j =0; j<i; j++){
                    Console.Write("* ");
                
                }
                Console.WriteLine("");   

            }

            /*
                2nd piramid 
                  * * *
                   * *
                    * 

            */
             for(i = 0; i<10 ; i++){
                for(j =0; j<i; j++){
                    Console.Write(" ");
                
                }
                for(j =10; j>i; j--){
                    Console.Write("* ");
                
                }                
                Console.WriteLine("");   

            }
             /*
                3nd piramid 
                  *
                  * *
                  * * *
                  * *
                  * 

            */

            for(i = 0; i<10 ; i++){
                for(j =0; j<i; j++){
                    Console.Write("* ");
                
                }
                for(j =10; j>i; j--){
                    Console.Write(" ");
                
                }                
                Console.WriteLine("");   

            }
            for(i = 0; i<10 ; i++){
                
                for(j =10; j>i; j--){
                    Console.Write("* ");
                
                }                
                Console.WriteLine("");   

            }
            /*
                3nd piramid 
                      *
                    * *
                  * * *
                    * *
                      * 

            */
            for(i = 0; i<10 ; i++){
                for(j =10; j>i; j--){
                    Console.Write(" ");
                
                }
                for(j =0; j<=i; j++){
                    Console.Write("*");
                
                }                                
                Console.WriteLine("");   

            }
            for(i = 0; i<10 ; i++){
                for(j =0; j<=i; j++){
                    Console.Write(" ");
                
                }
                for(j =10; j>i; j--){
                    Console.Write("*");
                
                }
                                                
                Console.WriteLine("");   

            }
            

        }
    }
}
