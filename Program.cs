using System;

namespace Calculadora_simples
{
    class Program
    {
        static void Main(string[] args)
        {
           // Pedir a operação
            // Pedir o 1 número
            //Pedir o 2 numero

            Console.WriteLine("Digite a operação que deseja fazer \n Soma, Subtração, Multiplicação, Divisão");
            string operacao = Console.ReadLine();

            Console.WriteLine("Digite o 1 número");
            float num1 = float.Parse(Console.ReadLine());

            //ALT + SHIFT + Seta para baixo
            Console.WriteLine ("Digite o 2 número");
            float num2 = float.Parse (Console.ReadLine());

            float resultado = 0;

            // IF / ELSE padrão
            // Control + Ponto e vírgula

            // if(operacao == "Soma"){
            //      resultado = num1 + num2;
            //    }else if (operacao == "Subtracao"){
            //    resultado = num1 + num2;
            //    }else if (operacao == "Multiplicacao"){
            //    resultado = num1 + num2;
            //    }else if (operacao == "Divissao"){
            //    resultado = num1 + num2;
            //    }else{
            //     Console.WriteLine("Operação invalida!");
            //     }

                //Switch / Case
                switch(operacao){
                    case "Soma":
                        resultado = num1 + num2;
                        break;
                    
                        case "Subtração":
                        resultado = num1 - num2;
                        break;
                    
                        case "Multiplição":
                        resultado = num1 * num2;
                        break;

                        case "Divisão":
                        resultado = num1 / num2;    
                        break;
                        
                        default:
                        Console.WriteLine("Operação invalida");
                        break;
                }              

                //Concatenação
                //Console. WriteLine("Calculo : "num1+" e "+num2" = Resultado : "+resultado);

                //Interpolação
                Console.WriteLine($"Calculo: {num1} e {num2} = Resultado : {resultado}");

        }
    }
}
