using System;

class MainClass {
  public static void Main (string[] args) {
    //INSTANCIAÇÃO CLASSE ESTABELECIMENTO
    Estabelecimento padariaBomAmigo = new Estabelecimento;
    padariaBomAmigo.nome = "Padaria Bom Amigo";
    padariaBomAmigo.SetCNPJ = "76696105000199"
    padariaBomAmigo.SetIdentificadorE = 105696;
    padariaBomAmigo.quantRecipienteAtual = 5;
    padariaBomAmigo.endereço_cep = 29504233;


  //INSTANCIAÇÃO CLASSE RECIPIENTE 
  Recipiente poteAlcoolGel = new Recipiente;
  poteAlcoolGel.nome = "Pote de Álcool em Gel";
  poteAlcoolGel.identificadorR = 10102065822;
  poteAlcoolGel.identificadorE = 105402;
  }
}