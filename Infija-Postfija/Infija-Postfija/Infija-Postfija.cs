using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infija_Postfija
{
    class Infija_Postfija
    {


        public String[] expresionPostfija(String[] expresionInfija) {


            int caracteres = contadorCaraceteresAgrupacion(expresionInfija);
            Stack<String> pila = new Stack<String>();
            String caracter = "";
            String[] expresionResultante = new String[expresionInfija.Length - caracteres];
            Boolean validar = false;
            int contadorPosicion = 0;
            
            for (int i = 0; i < expresionInfija.Length; i++)
            {
                validar=false;
                caracter = expresionInfija[i];

                // si es numero lo agrega al array automaticamente
                if (caracter != "+" && caracter != "-" && caracter != "/" && caracter != "*" && caracter != "^" &&
                    caracter != "(" && caracter != ")" && caracter != "[" && caracter != "]" && caracter != "{" &&
                    caracter != "}"){
                
                    expresionResultante[contadorPosicion] = caracter;
                    contadorPosicion++;
                }else {
                  
                    if (caracter=="+") {

                      
                     
                        if (pila.Count==0 && validar==false) {

                            pila.Push(caracter);
                            validar = true;

                        }

                        if (pila.Peek()=="-" && validar==false) {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;
                        }
                        if (pila.Peek() == "+" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "/" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }
                               




                   

                            }


                        }
                        if (pila.Peek() == "*" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }


                        }
                        if (pila.Peek() == "^" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }


                        }
                        if (pila.Peek() == "(" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "[" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "{" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                    }
                    if (caracter == "-"){
                        if (pila.Count == 0 && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "-" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;
                        }
                        if (pila.Peek() == "+" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "/" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }


                        }
                        if (pila.Peek() == "*" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }


                        }
                        if (pila.Peek() == "^" && validar == false)
                        {

                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }



                        }
                        if (pila.Peek() == "(" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "[" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "{" && validar == false)
                        {



                            pila.Push(caracter);


                        }

                    }
                    if (caracter == "/"){
                        if (pila.Count == 0 && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "+" && validar == false)
                        {

                          
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "-" && validar == false)
                        {

                         
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "*" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "/" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "^" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }


                        }
                        if (pila.Peek() == "(" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "[" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "{" && validar == false)
                        {



                            pila.Push(caracter);


                        }



                    }
                    if (caracter == "*"){
                        if (pila.Count == 0 && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "+" && validar == false)
                        {


                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "-" && validar == false)
                        {


                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "*" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "/" && validar == false)
                        {

                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "^" && validar == false)
                        {


                            for (;;)
                            {


                                if (pila.Count == 0)
                                {

                                    pila.Push(caracter);
                                    validar = true;
                                    break;

                                }
                                else
                                {

                                    if (pila.Peek() == "(" || pila.Peek() == "[" || pila.Peek() == "{")
                                    {
                                        pila.Push(caracter);
                                        validar = true;
                                        break;


                                    }
                                    else
                                    {

                                        expresionResultante[contadorPosicion] = pila.Pop();
                                        contadorPosicion++;


                                    }

                                }







                            }


                        }
                        if (pila.Peek() == "(" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "[" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "{" && validar == false)
                        {



                            pila.Push(caracter);


                        }

                    }
                    if (caracter == "^"){
                        if (pila.Count == 0 && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "+" && validar == false) {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "-" && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "/" && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;
                        }
                        if (pila.Peek() == "*" && validar == false)
                        {

                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "^" && validar == false)
                        {


                            expresionResultante[contadorPosicion] = pila.Pop();
                            contadorPosicion++;
                            pila.Push(caracter);
                            validar = true;

                        }
                        if (pila.Peek() == "(" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "[" && validar == false)
                        {



                            pila.Push(caracter);


                        }
                        if (pila.Peek() == "{" && validar == false)
                        {



                            pila.Push(caracter);


                        }

                    }
                    
                    
                    // caracteres de agrupacion
                    if (caracter == "(") {
                       
                        pila.Push(caracter);


                    }
                    if (caracter == ")")
                    {
                    
                        for (;;)
                        {




                            if (pila.Peek() == "(")
                            {
                               
                                pila.Pop();
                                validar = true;
                                break;


                            }
                            else {

                             
                                expresionResultante[contadorPosicion] = pila.Pop();
                                contadorPosicion++;

                            }
                        }


                    }
                    if (caracter == "["){

                        pila.Push(caracter);


                    }
                    if (caracter == "]")
                    {

                        for (;;)
                        {




                            if (pila.Peek() == "[")
                            {

                                pila.Pop();
                                validar = true;
                                break;


                            }
                            else
                            {


                                expresionResultante[contadorPosicion] = pila.Pop();
                                contadorPosicion++;

                            }
                        }

                    }
                    if (caracter == "{")
                    {

                        pila.Push(caracter);


                    }
                    if (caracter == "}")
                    {

                        for (;;)
                        {




                            if (pila.Peek() == "{")
                            {

                                pila.Pop();
                                validar = true;
                                break;


                            }
                            else
                            {


                                expresionResultante[contadorPosicion] = pila.Pop();
                                contadorPosicion++;

                            }
                        }

                    }




                }








            }



            if (pila.Count!=0) {

                expresionResultante[contadorPosicion] = pila.Pop();

            }

            for (int i = 0; i < expresionResultante.Length; i++)
            {
                Console.Write(expresionResultante[i]+" ");

            }
            return expresionResultante ;


        }

        public String[] expresionToArray(String expresionInfija) {

            String[] aExpresion;
            String caracter = "";
            String Expresion = "";
            for (int i = 0; i < expresionInfija.Length; i++) {


                caracter = expresionInfija.Substring(i, 1);

                if (caracter == "+" || caracter == "-" || caracter == "/" ||
                    caracter == "*" || caracter == "^" || caracter == "(" ||
                    caracter == ")" || caracter == "[" || caracter == "]" ||
                    caracter == "{" || caracter == "}")
                {


                    Expresion += " " + caracter + " ";


                }
                else {

                    Expresion += caracter;
                }

            }

            aExpresion = Expresion.Split(' ');

            String []aFinal = new String[aExpresion.Length];
            
            caracter = "";
            
            String cadena = "";
            for (int i = 0; i <  aExpresion.Length; i++)
            {
                caracter = aExpresion[i];
                if (caracter != "")
                {

                    cadena += caracter + " ";
                   

                }
                


            }

         
            String[] aExpresionInfijaFinal = cadena.Split(' ');
            String[] otro = new String[aExpresionInfijaFinal.Length - 1];
            
            for (int i = 0; i < otro.Length; i++)
            {
                otro[i] = aExpresionInfijaFinal[i];
               

            }
         
            Console.WriteLine("size "+otro.Length);
            return otro;
           





        }

        public int contadorCaraceteresAgrupacion(String[] expresion) {
            int caracteres = 0;

            for (int i = 0; i < expresion.Length; i++){

                if (expresion[i]=="(" || expresion[i] == ")" ||
                    expresion[i] == "[" || expresion[i] == "]" ||
                    expresion[i] == "{" || expresion[i] == "}") {

                    caracteres++;

                }

            }


            return caracteres;


        }

        public double calcularResultado(String[] expresion) {

            double resultado = 0;

            Stack<String> pila = new Stack<String>();
            String caracter = "";
            double num2 = 0;
            double num1 = 0;
            double result = 0;
            for (int i = 0; i < expresion.Length; i++)
            {

                caracter = expresion[i];
                if (caracter != "+" && caracter != "-" && caracter != "/" && caracter != "*" && caracter != "^")
                {

                    pila.Push(caracter);


                }
                else {

                    if (caracter=="+") {

                        num1 = Convert.ToDouble(pila.Pop());
                        num2 = Convert.ToDouble(pila.Pop());
                        result = num2 + num1;
                        pila.Push(result + "");




                    }

                    if (caracter == "-")
                    {

                        num1 = Convert.ToDouble(pila.Pop());
                        num2 = Convert.ToDouble(pila.Pop());
                        result = num2 - num1;
                        pila.Push(result + "");




                    }
                    if (caracter == "*")
                    {

                        num1 = Convert.ToDouble(pila.Pop());
                        num2 = Convert.ToDouble(pila.Pop());
                        result = num2 * num1;
                        pila.Push(result + "");




                    }
                    if (caracter == "/")
                    {

                        num1 = Convert.ToDouble(pila.Pop());
                        num2 = Convert.ToDouble(pila.Pop());
                        result = num2 / num1;
                        pila.Push(result + "");




                    }
                    if (caracter == "^")
                    {

                        num1 = Convert.ToDouble(pila.Pop());
                        num2 = Convert.ToDouble(pila.Pop());
                        result = Math.Pow(num2,num1);
                        pila.Push(result + "");




                    }







                }

            }

            resultado =Convert.ToDouble(pila.Pop()) ;
       


            return resultado;
        }
      
    }
}
