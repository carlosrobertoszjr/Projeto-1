using System;


class MainClass {
  public static void Main(){
    //INSTANCIAÇÃO CLASSE ESTABELECIMENTO
    Estabelecimento padariaBomAmigo = new Estabelecimento();
    padariaBomAmigo.nomeE = "Padaria Bom Amigo";
    padariaBomAmigo.SetCNPJ("76696105000199");
    padariaBomAmigo.SetIdentificadorE(105696);
    padariaBomAmigo.quantRecipienteAtual=5;
    padariaBomAmigo.endereco_cep= 29504233;


    Console.WriteLine("Informações sobre estabelecimentos >>>>>>>>>>>>>>> ");
    //MÉTODO
    padariaBomAmigo.LocalizarEstabelecimento(10596,29504238);
    


  //INSTANCIAÇÃO CLASSE RECIPIENTE 
  Recipiente poteAlcoolGel = new Recipiente();
  poteAlcoolGel.nomeR="Pote de Álcool em Gel";
  poteAlcoolGel.SetIdentificadorR(10102);
  poteAlcoolGel.SetIdentificadorE(105);
  poteAlcoolGel.endereco_cep=222;
  


  Console.WriteLine("");
  Console.WriteLine("Informações sobre recipientes >>>>>>>>>>>>>>> ");
  //MÉTODOS
  poteAlcoolGel.LocalizarRecipiente(222,10102);
  poteAlcoolGel.AdicionarNovoRecipiente(105);
  poteAlcoolGel.averiguarRecipiente("RUIM");
  
  }
}