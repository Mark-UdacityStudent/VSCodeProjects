using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

// this is a comment.
namespace myconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s;
            (i, s) = (10, "abc");
            
            //long n = 21;
            //Console.WriteLine("{0} is {1}", n, IsPrime2(n).ToString());

            string Pi1000 = "3141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949129833673362440656643086021394946395224737190702179860943702770539217176293176752384674818467669405132000568127145263560827785771342757789609173637178721468440901224953430146549585371050792279689258923542019956112129021960864034418159813629774771309960518707211349999998372978049951059731732816096318595024459455346908302642522308253344685035261931188171010003137838752886587533208381420617177669147303598253490428755468731159562863882353787593751957781857780532171226806613001927876611195909216420198";
            //  string Pi1000 = "3141592653";

            HashSet<string> hs = new HashSet<string>();     
            int cc = 0;      
            i = 0;
            while(i < 994){
                if(Pi1000[i].ToString() == "0") // skip
                {
                    i++;
                }
                else // get the number and get the prime
                {
                    s = Pi1000.Substring(i, 7);
                    if(IsPrime(Int32.Parse(s)))
                    {
                        hs.Add(s);
                        cc++;
                    }
                    i++;
                }
            }
            Console.WriteLine("Unique primes: {0}, primes total: {1}", hs.Count, cc);  
            int sum = 0;
            foreach(var x in hs){
                sum += Int32.Parse(x);
                Console.WriteLine("{0}", x);  
            }   
            Console.WriteLine("sum: {0}", sum);  
            

/*
            // regex:
            string pattern = @"[1-9]\d{6}";
            MatchCollection mc = Regex.Matches(Pi1000, pattern);
            Console.WriteLine("Matches: {0} ", mc.Count);
            int counter = 0;
             foreach (var x in mc){
                if(IsPrime(Int32.Parse(x.ToString())))
                {   
                    Console.WriteLine("Primes: {0} ", x.ToString());
                    counter++;
                }
            }
            Console.WriteLine("Primes count: {0} ", counter); 
            Console.WriteLine("Pi1000[0]: {0} ", Pi1000[1]); 
 */            
 /*           

            // string.Substring:
            string[] a = new string[994];
            for (int j = 0; j <= 993; j++){
                a[j] = Pi1000.Substring(j, 7);
            }            
            int counter = 0;
            foreach (var x in a){
                if(IsPrime(Int32.Parse(x.ToString())))
                {   
                    Console.WriteLine("{0} ", x.ToString());
                    counter++;
                }
            }
            Console.WriteLine("{0} ", counter);            
            

            // HashSet<T>:
            counter = 0;
            int counterTotal = 0;
            string[] a = new string[994];
            for (int j = 0; j <= 993; j++){
                a[j] = Pi1000.Substring(j, 7);
                counterTotal++; 
                if(a[j][0].ToString() == "0"){
                    counter++;
                    Console.WriteLine("{0} - {1}", a[j][0].ToString(), a[j]);            
                }
            }            
            Console.WriteLine("{0} - {1}", counter, counterTotal);            

            HashSet<string> hs = new HashSet<string>();
            int k = 0;
            counter = 0;
            while (k <= 993){
                // check if IsPrime
                string ss = Pi1000.Substring(k, 7);
                if(IsPrime(Int32.Parse(ss))){
                    //write the number to the hashtable and move forward by 7 positions
                    hs.Add(ss);
                    k += 7;
                    counter++;
                }
                else{
                    // move forward by 1 positon
                    k ++;
                }
            }
            /*
            //int counter = 0;
            foreach (var x in a){
                if(IsPrime2(Int32.Parse(x.ToString())))
                {   
                    hs.Add(x);                    
                    //Console.WriteLine("{0} ", x.ToString());
                    //counter++;
                }
            }                                    
            

            Console.WriteLine("{0}, {1} ", hs.Count, counter);            
            */
            

/*          Console.WriteLine("{0} ", a[0]);
            Console.WriteLine("{0} ", a[1]);
            Console.WriteLine("{0} ", a[991]);
            Console.WriteLine("{0} ", a[992]);
            Console.WriteLine("{0} ", a[993]);

            *** new line ***
 */

        }
        static bool IsPrime(long n)
        {   
            for(long i = 2; i*i <= n; i++){
                if(n % i == 0) {
                    //Console.WriteLine(i);
                    return false;
                }
            }
            return true;
        }
        static bool IsPrime2(long n)
        {   
            for(long i = 2; i <= n - 1; i++){
                //Console.WriteLine(i);
                if(n % i == 0) {
                    //Console.WriteLine(i);
                    return false;
                }
            }
            return true;
        }

    }

}
