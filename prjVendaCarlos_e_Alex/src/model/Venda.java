/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.util.Date;

/**
 *
 * @author aluno
 */
public class Venda {

    private int numVenda;
    private int codCli;
    private String nome;
    private Date dataVenda;
    private Date dataEntrega;
    private String obs;

    public Venda() {
        this(0, 0, "", new Date(), new Date(), "");
    }

    public Venda(int numVenda, int codCli, String nome, Date dataVenda, 
            Date dataEntrega, String obs) {
        this.numVenda = numVenda;
        this.codCli = codCli;
        this.nome = nome;
        this.dataVenda = dataVenda;
        this.dataEntrega = dataEntrega;
        this.obs = obs;
    }

    public int getNumVenda() {
        return numVenda;
    }

    public void setNumVenda(int numVenda) {
        this.numVenda = numVenda;
    }

    public int getCodCli() {
        return codCli;
    }

    public void setCodCli(int codCli) {
        this.codCli = codCli;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public Date getDataVenda() {
        return dataVenda;
    }

    public void setDataVenda(Date dataVenda) {
        this.dataVenda = dataVenda;
    }

    public Date getDataEntrega() {
        return dataEntrega;
    }

    public void setDataEntrega(Date dataEntrega) {
        this.dataEntrega = dataEntrega;
    }

    public String getObs() {
        return obs;
    }

    public void setObs(String obs) {
        this.obs = obs;
    }

    @Override
    public String toString() {
        return "\nItemVenda:"
                + "\nNº da Venda: " + getNumVenda()
                + "\nCódigo do Cliente: " + getCodCli()
                + "\nNome: " + getNome()
                + "\nData da Venda: " + getDataVenda()
                + "\nData de Entrega: " + getDataEntrega()
                + "\nObservações: " + getObs()
                + "\n";
    }
}