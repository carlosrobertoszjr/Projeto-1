using System;

class Recipiente
{
  public string nomeR; //nome genérico que pode ser dado
  private int identificadorR; //Identificador único de cada recipiente
  private int identificadorE; //Identificador único da empresa (estabelecimento) o qual está aquele recipiente vinculado
  public string status; //status do recipiente
  public int endereco_cep; //CEP o qual o recipiente está
  public int quantRecipienteAtual; // Quantidade
  

  public int LocalizarRecipiente(int cep, int codR){
    if (cep == endereco_cep && codR == identificadorR){
      Console.WriteLine("Situação identificação do endereço do recipiente: identificado > endereço é o "+cep);
      
    }else{
      Console.WriteLine("Situação identificação do endereço do recipiente: não identificado.");
    } 
    return cep;
  }




//GET E SET DO IDENTIFCADOR DO ESTABELECIMENTO
  public void SetIdentificadorE(int IdE){
    identificadorE = IdE;
  }
  public int GetIdentificadorE(){
    return identificadorE;
  }


//GET E SET DO IDENTIFCADOR DO RECIPIENTE
  public void SetIdentificadorR(int IdR){
    identificadorR = IdR;
  }
  public int GetIdentificadorR(){
    return identificadorR;
  }





  public int AdicionarNovoRecipiente(int identificadorEmpresa){
    if (identificadorEmpresa == identificadorE){
      quantRecipienteAtual = quantRecipienteAtual + 1;
      Console.WriteLine("Recipientes adicionados >> Dados atualizados! "+quantRecipienteAtual);
  }
    else{
      Console.WriteLine("Recipientes adicionados >> Identificador de estabalecimento não encontrado!");
    
      Console.Write("Recipiente atuais:"+quantRecipienteAtual);
    }
    //return padariaBomAmigo(quantRecipienteAtual);
    return quantRecipienteAtual;
    
  }
    

public string averiguarRecipiente(string status){
  Console.Write("STATUS DO RECIPIENTE >> ");
  if (status == "OK"){
    Console.WriteLine("Ok. Não vai ser necessário realizar a troca.");
  }
  else if (status == "BOM"){
    Console.WriteLine("Ok. Não vai ser necessário realizar a troca.");
  }
  else if (status == "RUIM"){
    Console.WriteLine("Ok. É necessário realizar a troca.");
    }
  else if (status == "PESSIMO"){
    Console.WriteLine("Ok. Realizar a troca urgente!.");
    }
  else{
    Console.WriteLine("Status não encontrado");
}
  return status;
}
}
