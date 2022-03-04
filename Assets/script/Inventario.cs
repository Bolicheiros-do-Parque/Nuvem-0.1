using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Inventario
{
    private int[] idItem;
    private int[] quantidade;

    public void adicionarItem(int idItemAdiciona, int quantidadeItem){
        int nume = idItem.Length;
        bool subistituil = false;
        for(int i = 0; subistituil == false || i >= nume; i++){
            if(idItem[i] == 0){
                idItem[i] = idItemAdiciona;
                quantidade[i] = quantidadeItem;
                subistituil = true;
            }else if(i == nume){
                idItem = new int[]{idItemAdiciona} ;
                quantidade = new int[]{quantidadeItem};
                subistituil = true;
            }
        }
        
    }
    public void removerItem(int idItemRemover, int quantidadeItem){
       
        if(quantidade[idItemRemover] >= quantidadeItem){
           quantidade[idItemRemover] -= quantidadeItem; 
        }else if(quantidade[idItemRemover] == 0){
            idItem[idItemRemover] = 0;
            quantidade[idItemRemover] = 0;
        }
    }

    public void otimizarArray(){
        while(idItem[idItem.Length - 1 ] == 0){
            Array.Resize(ref idItem,idItem.Length - 1);
            Array.Resize(ref quantidade,quantidade.Length - 1);
        }
    }


  
 
}
