using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trabalho : Principal
{
    private Trabalhador[] trabalhador;
    private int[] quantidade;
    

    
    public void criarTrabalhadores(){
        trabalhador = new Trabalhador[]{new Trabalhador(), new Trabalhador(),new Trabalhador()};
        trabalhador[0].setId(1);
        trabalhador[1].setId(2);
        trabalhador[2].setId(6);
        quantidade = new int[]{0,0,0};
    }
    public void comprarTrabalhador(int idTrabalhador, int quantidadeTrabalhador){
        if(getMoedaTotal() >= trabalhador[idTrabalhador].getValor()){
            quantidade[idTrabalhador] += quantidadeTrabalhador;
        }
        
        
    }

    public int getQuantidadeTrabalhador(int idTrabalhador){
        return quantidade[idTrabalhador];
    }
   
    
    

}
