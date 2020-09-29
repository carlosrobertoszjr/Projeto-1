using System;

class Recipiente;
  public nome; //nome genérico que pode ser dado
  private identificadorR; //Identificador único de cada recipiente
  private identificadorE; //Identificador único da empresa (estabelecimento) o qual está aquele recipiente vinculado
  public status; //status do recipiente
  

  public void LocalizarRecipiente(cep, codR){
    if (cep == endereço_cep ¨&& codR == identificadorR){
      Console.Write("Endereço identificado >> ");
      return cep;
    }else{
      Console.WriteLine("Endereço não identificado.");
    } 
  }






//GET E SET DO IDENTIFCADOR DO ESTABELECIMENTO
  public void SetIdentificador(int IdR){
    identificadorR = IdR;
  }
  public int GetIdentificador(){
    return identificadorR;
  }

  public int adicionarNovoRecipiente(identificadorEmpresa){
    if (identificadorEmpresa == identificadorE){
      quantRecipienteAtual =+ 1;
      Console.WriteLine("Dados atualizados!")
    }
    else{
      Console.WriteLine("Identificador de estabalecimento não encontrado!")
    }
    Console.Write("Recipiente atuais:");
    return quantRecipienteAtual;
  }
    





public string averiguarRecipiente(status){
  if status == "OK"{

  }
  else if status == "BOM"{

  }
  else if`status == "RUIM"{

  }
  else if status == "PESSIMO"{

  }
  else`{
    
  }
  return status;
  }