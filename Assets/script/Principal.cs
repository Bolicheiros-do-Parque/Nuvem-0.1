
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Principal : MonoBehaviour
{
    private float tempoRelogio;
    private float tempo;
    private int moedaOuro;
    private int moedaPrata;
    private int moedaBronze;
    private int segundo;
    private int minuto;
    private int hora;
    private int moedaTotal;
    private Text textoRelogio;
    private Text textoMoedaBronze;
    private Text textoMoedaPrata;
    private Text textoMoedaOuro;
    private Text textoNumColetor;
    private Text textoNumLenhador;
    private Text textoNumPedrero;
    Mercado mercado = new Mercado();
    Inventario inventarioJogador = new Inventario();
    EventoBotoes eventoBotoes = new EventoBotoes();
    Trabalho trabalho = new Trabalho();
    Iten graveto = new Iten();
    Iten pedraPequena = new Iten();
    Iten toraMadeira = new Iten();
    Iten pedra = new Iten();
    // Start is called before the first frame update
    void Start()
    {
        incializarVar(); 
    }

    // Update is called once per frame
    void Update()
    {
        timer();
        gerarMoeda();
        atualizarTextos();
        converterMoedas();
    }
    private void incializarVar(){
        graveto.setItem(1);
        pedraPequena.setItem(2);
        toraMadeira.setItem(3);
        pedra.setItem(4);
        trabalho.criarTrabalhadores();
        eventoBotoes.setarEventosBT(trabalho);
        
        tempoRelogio = 0;
        tempo = 0;
        segundo = 0;
        minuto = 0;
        hora = 0;
        moedaBronze = 0;
        moedaOuro = 0;
        moedaPrata = 0;
        moedaTotal = 0;
        textoRelogio = GameObject.Find("Relogio").GetComponent<Text>();
        textoMoedaBronze = GameObject.Find("numeroMoedaBronze").GetComponent<Text>();
        textoMoedaPrata = GameObject.Find("numeroMoedaPrata").GetComponent<Text>();
        textoMoedaOuro = GameObject.Find("numeroMoedaOuro").GetComponent<Text>();
        textoNumColetor = GameObject.Find("TextNumeColetorBT").GetComponent<Text>();
        textoNumLenhador = GameObject.Find("TextNumeLenhadorBT").GetComponent<Text>();
        textoNumPedrero = GameObject.Find("TextNumePedreroBT").GetComponent<Text>();
        textoRelogio.text = string.Format("{0:00}", hora) + ":" + string.Format("{0:00}", minuto) + ":" + string.Format("{0:00}", segundo);
        textoMoedaBronze.text = string.Format("{0:00}", moedaBronze);
        textoMoedaPrata.text = string.Format("{0:00}", moedaPrata);
        textoMoedaOuro.text = string.Format("{0:00}", moedaOuro);
        textoNumColetor.text = string.Format("{0:00}", trabalho.getQuantidadeTrabalhador(0));
        textoNumLenhador.text = string.Format("{0:00}",  trabalho.getQuantidadeTrabalhador(1));
        textoNumPedrero.text = string.Format("{0:00}",  trabalho.getQuantidadeTrabalhador(2));

        
    }

    private void timer(){
        tempoRelogio += Time.deltaTime;

        if(tempoRelogio >= 1f){
            segundo += 1;
            tempoRelogio = 0;
            if(segundo >= 60){
                minuto += 1;
                segundo = 0;
                if(minuto >= 60){
                    hora += 1;
                    minuto = 0;
                }
            }

        }
    }

    private void atualizarTextos(){
        textoRelogio.text = string.Format("{0:00}", hora) + ":" + string.Format("{0:00}", minuto) + ":" + string.Format("{0:00}", segundo);
        textoMoedaBronze.text = string.Format("{0:00}", moedaBronze);
        textoMoedaPrata.text = string.Format("{0:00}", moedaPrata);
        textoMoedaOuro.text = string.Format("{0:00}", moedaOuro);
        textoNumColetor.text = string.Format("{0:00}", trabalho.getQuantidadeTrabalhador(0));
        textoNumLenhador.text = string.Format("{0:00}",  trabalho.getQuantidadeTrabalhador(1));
        textoNumPedrero.text = string.Format("{0:00}",  trabalho.getQuantidadeTrabalhador(2));
    }

    public void gerarMoeda(){
        tempo += Time.deltaTime;
        if(tempo >= 1f){
            moedaBronze += 1;
            tempo = 0;
        }
    }
    public void venderItem(){
        
    }
    public int getMoedaTotal(){
        moedaTotal = moedaBronze + moedaPrata * 100 + moedaOuro * 1000;
        return moedaTotal;
    }

    public void setMoeda(int numeroBroze, int numeroPrata, int numeroOuro){
        moedaBronze = numeroBroze;
        moedaPrata = numeroPrata;
        moedaOuro = numeroOuro;
    }
    public void converterMoedas(){
        if(moedaBronze >= 100){
            moedaBronze -= 100;
            moedaPrata += 1;
        }else if(moedaPrata >= 100){
            moedaPrata -= 100;
            moedaOuro += 1;
        }
    }
    public void adicionarMoeda(int numeroBroze, int numeroPrata, int numeroOuro){
        moedaBronze += numeroBroze;
        moedaPrata += numeroPrata;
        moedaOuro += numeroOuro;
    }
    public void retirarMoeda(int numeroBroze, int numeroPrata, int numeroOuro){
        moedaBronze -= numeroBroze;
        moedaPrata -= numeroPrata;
        moedaOuro -= numeroOuro;
    }

    
}
