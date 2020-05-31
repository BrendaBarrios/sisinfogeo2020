using System;
using Newtonsoft.Json;

namespace _38.FacebookApi
{
    //Ejemplo de acceso a la API de facebook.
    class Program
    {
        public static object JsonConvert { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("---------- Programa 38 Acceso a la API de facebook ----------");

            //token.
            string fbtoken= "EAAS5VGo3KKMBACS3QsYeFkZCFBDahppuMw4TG3aiLmHC4zd0fzhYNP7FIpXOln2BVH4YUMBCKppzaaCbLk78NeCeghvx9gtuG3mhcannDl8Sj7EmFv0ZAxiE4ZBsxZCVddsOEb14hcPtMXMvlufVcXxgryho5BZAzepsxG8O4S0Kt9TsjBcaejyfMgqiXOYOeigTnCoT682X4ZBZA05hQxjpZAHkPDgzbf1V76gRpQ7OPQZDZD";
            string fbfields= "id,first_name,last_name,middle_name,name,name_format,picture,short_name,email";

            FacebookApi fb=new FacebookApi(fbtoken);

            string resultado= fb.ObtenerInfo(fbfields).Result;

            var res = JsonConvert.DeserializeObject(resultado);
        

            Console.WriteLine(res);

        }
    }


}