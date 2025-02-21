string[] nomeAlunos = new string[]{"Max", "Alasca", "Lucas"};

int quantidadeProvas = 5;

int[] maxNotas = new int[]{9, 8, 8, 9, 10, 9, 9};
int[] alascaNotas = new int[]{9, 8, 8, 9, 9, 8};
int[] lucasNotas = new int[]{9, 8, 7, 9, 6, 8, 8, 8};

int[] alunosNotas = new int[10];


Console.WriteLine("Alunos\t\tNotas\tNota final\tSituação\tPontos extra\n");

foreach(string nome in nomeAlunos){

    string alunosAtual = nome;

    if(alunosAtual == "Max"){
        alunosNotas = maxNotas;
    }
    else if(alunosAtual == "Alasca"){
        alunosNotas = alascaNotas;
    }
    else if(alunosAtual == "Lucas"){
        alunosNotas = lucasNotas;
    }

    decimal somaNotas = 0;
    decimal notaFinal = 0;
    decimal notaFinalExtra = 0;
    decimal pontosExtra = 0;
    int provaAtual = 0;

    foreach(int nota in alunosNotas){
        provaAtual += 1;

        if(provaAtual <= quantidadeProvas){
        somaNotas += nota;
        notaFinal = somaNotas / quantidadeProvas;
        }
        else{
            somaNotas += (decimal)nota / 10;
        }
    }

    notaFinalExtra = somaNotas / quantidadeProvas;
    pontosExtra = notaFinalExtra - notaFinal;

    string situacaoDoAluno = "";

    if(notaFinal >= 6 && notaFinal <= 10){
        situacaoDoAluno = "Aprovado";
    }
    else{
        situacaoDoAluno = "Reprovado";
    }


    Console.WriteLine($"{alunosAtual}\t\t{notaFinal}\t{notaFinalExtra}\t\t{situacaoDoAluno}\t{notaFinal} ({pontosExtra} pts)");
}



