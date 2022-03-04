using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trabalhador 
{
    
    private int id;
    private string nome;
    private int valor;
    private int salario;
    private int[] producao;
    private int[] idItem;
    
    public void setId(int idTrabalhador){
        id = idTrabalhador;
        setarTrabalhador();
    }

    private void setarTrabalhador(){
        if(id == 0){
            nome = "nuvem";
            valor = 99999;
            salario = 0;
            producao = new int[]{0};
            idItem = new int[]{0};
        
        }else if(id == 1){
            nome = "coletor";
            valor = 10;
            salario = 2;
            producao = new int[]{3,1};
            idItem = new int[]{1,2};
        }else if(id == 2){
            nome = "lenhador";
            valor = 30;
            salario = 5;
            producao = new int[]{2};
            idItem = new int[]{2};
        }else if(id == 3){
            nome = "pedreiro";
            valor = 50;
            salario = 12;
            producao = new int[]{2};
            idItem = new int[]{3};
        }
    }

    public void setValor(int valorTrabalhador){
        valor = valorTrabalhador;
    }
    public int getValor(){
        return valor;
    }
    public void setSalario(int salarioTrabalhador){
        salario = salarioTrabalhador;
    }
    public int getSalario(){
        return salario;
    }

}
