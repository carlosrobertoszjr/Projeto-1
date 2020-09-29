using System;

class Estabelecimento;
  public string nomeE;
  private string cnpj;
  private int identificadorE;
  public int quantRecipienteAtual;
  public string endereço_cep;

  

  //GET E SET DO IDENTIFCADOR DO CNPJ DO estabelecimento
  public void SetCNPJ(int codCNPJ){
    cnpj = codCNPJ;
  }
  public string GetCNPJr(){
    return cnpj;
  }



  //GET E SET DO IDENTIFCADOR DO ESTABELECIMENTO
  public void SetIdentificadorE(int IdE){
    identificadorE = IdE;
  }
  public int GetIdentificadorE(){
    return identificadorE;
  }



  public void CadNovoEstabelecimento(nomeE,cnpj,identificadorE,quantRecipienteAtual,endereço_cep){
    return "Ok";
  }

  

  