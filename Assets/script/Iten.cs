using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class Iten
{
    private string nome;
    private int id;
    private int preco;
    private int quantidade;

    public void CriaItem(){
        if(id == 0){
            nome = "nada";
            preco = 0;
            quantidade = 0;
        }
        if(id == 1){
            nome = "graveto";
            preco = 2;
            quantidade = 0;
        }else if(id == 2){
            nome = "pedra pequena";
            preco = 3;
            quantidade = 0;
        }
        if(id == 3){
            nome = "tora de madeira";
            preco = 5;
            quantidade = 0;
        }
        if(id == 4){
            nome = "pedra";
            preco = 7;
            quantidade = 0;
        }
    }

    public void setItem(int idItem){
        id = idItem;
        CriaItem();
    }

    public string getNome(){
        return nome;
    }

    public void setNome(string n){
        nome = n;
    }
    public int getId(){
        return id;
    }

    public void setId(int numeroId){
        id = numeroId;
    }
    public int getPreco(){
        return preco;
    }

    public void setPreco(int numeroPreco){
        preco = numeroPreco;
    }

    public int getQuantidade(){
        return quantidade;
    }
    public void setQuantidade(int numeroQuantidade){
        quantidade = numeroQuantidade;
    }
    
}
