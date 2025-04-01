string? lerResultado;
int valorNumerico = 0;
bool validarNumero = false;
bool validarEntrada = false;

Console.WriteLine("Digite um numero entre 5 e 10: ");
do{
    lerResultado = Console.ReadLine();

    validarNumero = int.TryParse(lerResultado, out valorNumerico);

    if(valorNumerico != null){
        if(valorNumerico >= 5 && valorNumerico <= 10){
            validarEntrada = true;
        }
        else if(valorNumerico < 5 || valorNumerico > 10){
            Console.WriteLine($"Sua entrada {validarNumero}, por favor tente um numero entre 5 e 10.");
        }
        else{
            Console.WriteLine("Sua entra é invalida, tente novamente");
        }
    }
}while (validarEntrada == false);

Console.WriteLine($"Seu valor de entrada ({valorNumerico}) foi aceito.");