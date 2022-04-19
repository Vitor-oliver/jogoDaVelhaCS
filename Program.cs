char jogador1;
char ganhador = 'a';

char[,] tabuleiro = new char[3,3];
tabuleiro[0,0] = '1';
tabuleiro[0,1] = '2';
tabuleiro[0,2] = '3';
tabuleiro[1,0] = '4';
tabuleiro[1,1] = '5';
tabuleiro[1,2] = '6';
tabuleiro[2,0] = '7';
tabuleiro[2,1] = '8';
tabuleiro[2,2] = '9';

void mostrarTabuleiro(){
    Console.WriteLine($"{tabuleiro[0,0]}  |  {tabuleiro[0,1]}  |  {tabuleiro[0,2]}\n{tabuleiro[1,0]}  |  {tabuleiro[1,1]}  |  {tabuleiro[1,2]}\n{tabuleiro[2,0]}  |  {tabuleiro[2,1]}  |  {tabuleiro[2,2]}");
}

bool testarGanhador(){
    bool teste = false;
    //teste na horizontal
    if(tabuleiro[0,0] == 'x' && tabuleiro[0,1] == 'x' && tabuleiro[0,2] == 'x' || tabuleiro[1,0] == 'x' && tabuleiro[1,1] == 'x' && tabuleiro[1,2] == 'x' || tabuleiro[2,0] == 'x' && tabuleiro[2,1] == 'x' && tabuleiro[2,2] == 'x'){
        teste = true;
        ganhador = 'x';
    }
    else if(tabuleiro[0,0] == 'o' && tabuleiro[0,1] == 'o' && tabuleiro[0,2] == 'o' || tabuleiro[1,0] == 'o' && tabuleiro[1,1] == 'o' && tabuleiro[1,2] == 'o' || tabuleiro[2,0] == 'o' && tabuleiro[2,1] == 'o' && tabuleiro[2,2] == 'o'){
        teste = true;
        ganhador = 'o';
    }
    //teste na vertical
    else if(tabuleiro[0,0] == 'x' && tabuleiro[1,0] == 'x' && tabuleiro[2,0] == 'x' || tabuleiro[0,1] == 'x' && tabuleiro[1,1] == 'x' && tabuleiro[2,1] == 'x' || tabuleiro[0,2] == 'x' && tabuleiro[1,2] == 'x' && tabuleiro[2,2] == 'x'){
        teste = true;
        ganhador = 'x';
    }
    else if(tabuleiro[0,0] == 'o' && tabuleiro[1,0] == 'o' && tabuleiro[2,0] == 'o' || tabuleiro[0,1] == 'o' && tabuleiro[1,1] == 'o' && tabuleiro[2,1] == 'o' || tabuleiro[0,2] == 'o' && tabuleiro[1,2] == 'o' && tabuleiro[2,2] == 'o'){
        teste = true;
        ganhador = 'o';
    }
    //teste na diagonal
    else if(tabuleiro[0,0] == 'x' && tabuleiro[1,1] == 'x' && tabuleiro[2,2] == 'x' || tabuleiro[0,2] == 'x' && tabuleiro[1,1] == 'x' && tabuleiro[2,0] == 'x'){
        teste = true;
        ganhador = 'x';
    }
    else if(tabuleiro[0,0] == 'o' && tabuleiro[1,1] == 'o' && tabuleiro[2,2] == 'o' || tabuleiro[0,2] == 'o' && tabuleiro[1,1] == 'o' && tabuleiro[2,0] == 'o'){
        teste = true;
        ganhador = 'o';
    }
    else{
        teste = false;
    }
    return teste;
}

bool testarDeuVelha(){
    bool deuVelha = false;
    return deuVelha;
}

void receberJogadaMaquina(){
    Random random = new Random();
    int jogadaMaquina = random.Next(0, 12);
    bool testeJogadaMaquina = true;


}

bool receberJogadaJogador(){
    int jogadaJogador = Convert.ToInt32(Console.ReadLine());
    bool testeJogadaJogador = true;
    //if(se está dentro do numero de casas)
    /*
    do{
        if(jogadaJogador < 1 && jogadaJogador > 9){
            mostrarTabuleiro();
            Console.WriteLine("Escolha uma casa entre 1 e 9:");
            jogadaJogador = Console.ReadKey().KeyChar;
        }
    }while(jogadaJogador < 1 && jogadaJogador > 9);*/
    
    do{
        
        if(testeJogadaJogador == false){
            Console.WriteLine("Escolha uma casa valida:");
            mostrarTabuleiro();
            jogadaJogador = Convert.ToInt32(Console.ReadLine());
            if(jogadaJogador < 1 && jogadaJogador > 9){
                testeJogadaJogador = false;
            }else{
                testeJogadaJogador = true;
            }
        }
        else if(testeJogadaJogador == true){
            switch(jogadaJogador){
        case 1:
            if(tabuleiro[0,0] != '1'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[0,0] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 2:
            if(tabuleiro[0,1] != '2'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[0,1] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 3:
            if(tabuleiro[0,2] != '3'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[0,2] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 4:
            if(tabuleiro[1,0] != '4'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[1,0] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 5:
            if(tabuleiro[1,1] != '5'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[1,1] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 6:
            if(tabuleiro[1,2] != '6'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[1,2] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 7:
            if(tabuleiro[2,0] != '7'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[2,0] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 8:
            if(tabuleiro[2,1] != '8'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[2,1] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        case 9:
            if(tabuleiro[2,2] != '9'){
                testeJogadaJogador = false;
            }
            else{
                tabuleiro[2,2] = jogador1;
                testeJogadaJogador = true;
            }
        break;
        default:
            testeJogadaJogador = false;
            Console.WriteLine("Escolha uma casa entre 1 e 9:");
        break;
    }
        }
    }while(testeJogadaJogador == false);
    
    return testeJogadaJogador;
}

Console.WriteLine("Vamos jogar o jogo da velha!");

Console.WriteLine("Escolha X ou O");

//implementar que ele esteja em maiuscula
do{
    jogador1 = Console.ReadKey().KeyChar;
    if(jogador1 != 'x' && jogador1 != 'o'){
        Console.WriteLine("\nVocê precisa escolher entre X ou O");
    }
}while(jogador1 != 'x' && jogador1 != 'o');

Console.WriteLine($"\nVocê escolheu: {jogador1}\n\t Vamos começar o jogo!");

do{
    Console.WriteLine("\n\tEscolha uma casa:");
    mostrarTabuleiro();
    receberJogadaJogador();
    //desenvolver jogada da maquina
    //receberJogadaMaquina();

    if(testarGanhador() == true){
        Console.Clear();
        Console.WriteLine("\t\tO GANHDOR É " + ganhador);
    }

//OU dar velha for falsa 
}while(testarGanhador() == false);




