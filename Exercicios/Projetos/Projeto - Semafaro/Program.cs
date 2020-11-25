using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace speech
{
    class Program
    {
        static void Main(string[] args)
        {
            string desejaRefazer = "sim";

            Console.WriteLine("Seja bem vindo, esse é um programa que mostra oque se deve fazer de acordo com a tonalidade do semafaro.");
            Speech.Speak("Seja bem vindo, esse é um programa que mostra oque se deve fazer de acordo com a tonalidade do semáforo.");
            Thread.Sleep(8000);
            Console.WriteLine("Para podermos começar:");
            Speech.Speak("Para podermos começar:");
            Thread.Sleep(2500);

            while(desejaRefazer == "sim"){

                Console.WriteLine("Digite a cor do semáforo.");
                Speech.Speak("Digite a cor do semáforo.");
                string corDoSemafaro = Console.ReadLine();

                 if(corDoSemafaro == "vermelho"){
                    Console.WriteLine("Pare o carro");
                    Speech.Speak("Pare o carro, a cor vermelha indica que deve parar o veiculo imediatamente");
                    Thread.Sleep(6500);
                }

                if(corDoSemafaro == "amarelo"){
                    Console.WriteLine("Diminua a velocidade do carro");
                    Speech.Speak("Diminua a velocidade do carro, a cor amarela indica que deve reduzir a velocidade do veiculo");
                    Thread.Sleep(7500);
                }

                if(corDoSemafaro == "verde"){
                    Console.WriteLine("Prossiga com velocidade constante");
                    Speech.Speak("Prossiga com velocidade constante, a cor verde indica que pode passar sem nenhum problema");
                    Thread.Sleep(7500);
                }

                if(corDoSemafaro == "bandeirado"){
                    Console.WriteLine("Tem pessoas atravesando a rua?");
                    Speech.Speak("Tem pessoas atravessando a rua?");
                    Thread.Sleep(1000);
                    string pessoaNaRua = Console.ReadLine();
                    if(pessoaNaRua == "sim"){
                        while( pessoaNaRua == "sim"){
                            Console.WriteLine("Parar, a preferencia é do pedestre");
                            Speech.Speak("Parar, a preferencia é do pedestre");
                            Thread.Sleep(4000);
                            Console.WriteLine("Tem pessoas atravesando a rua?");
                            Speech.Speak("E agora, tem pessoas atravessando a rua?");
                            string pessoaNaRua2 = Console.ReadLine();
                            if(pessoaNaRua2 == "não"){
                                Console.WriteLine("Muito bem, pode avançar com uma velocidade constante");
                                Speech.Speak("Muito bem, pode avançar com uma velocidade constante e com cuidado");
                                Thread.Sleep(6000);
                                break;
                            }else{}
                        }
                    }
                    else{
                        Console.WriteLine("Muito bem, pode avançar com uma velocidade constante");
                        Speech.Speak("Muito bem, pode avançar com uma velocidade constante e com cuidado");
                        Thread.Sleep(6000);
                    }
                }

                Console.WriteLine("Deseja refazer a operação?");
                Speech.Speak("Deseja refazer a operação?");
                string desejaRefazer1 = Console.ReadLine();
                if(desejaRefazer1 == "sim"){}
                else{
                    Console.WriteLine("Certo, obrigado pela preferencia :)");
                    Speech.Speak("Certo, obrigado pela preferencia, carinha feliz");
                    break;
                }

            }
        }
    }

    public static class Speech
    {
        public static void Speak(string text, bool wait = false)
        {
            ExecuteCommand(
                $@"Add-Type -AssemblyName System.speech; 
                $speak = New-Object System.Speech.Synthesis.SpeechSynthesizer; 
                $speak.Speak(""{text}"");");

            void ExecuteCommand(string command)
            {
                string path = Path.GetTempPath() + Guid.NewGuid() + ".ps1";

                // make sure to be using System.Text
                using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
                {
                    sw.Write(command);

                    ProcessStartInfo start = new ProcessStartInfo()
                    {
                        FileName = @"C:\Windows\System32\windowspowershell\v1.0\powershell.exe",
                        LoadUserProfile = false,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Arguments = $"-executionpolicy bypass -File {path}",
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process process = Process.Start(start);

                    if (wait)
                        process.WaitForExit();
                }
            }
        }
    }
}