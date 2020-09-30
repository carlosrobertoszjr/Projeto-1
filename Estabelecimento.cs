using System;

class Estabelecimento
{
  public string nomeE;
  private string cnpj;
  private int identificadorE;
  public int quantRecipienteAtual;
  public int endereco_cep;

  


  public int LocalizarEstabelecimento(int idE, int endereco_cep){
    Console.Write("Situação da pesquisa do endereço do estabelecimento >> ");
    if (idE == identificadorE){
      Console.WriteLine("Endereço encontrado");
      return endereco_cep;
    }else{
      Console.WriteLine("Endereço não encontrado");
    }
    Console.WriteLine("Endereço/CEP encontrado foi >> "+endereco_cep);
    return endereco_cep;
  }


  
  //GET E SET DO IDENTIFCADOR DO CNPJ DO ESTABELECIMENTO
  public void SetCNPJ(string codCNPJ){
    cnpj = codCNPJ;
  }
  public string GetCNPJ(){
    return cnpj;
  }
  
  //GET E SET DO IDENTIFICADOR DO ESTABELECIMENTO
  public void SetIdentificadorE(int idE){
    identificadorE = idE;
  }
  public int GetIdentificadorE(){
    return identificadorE;
  }

}


  