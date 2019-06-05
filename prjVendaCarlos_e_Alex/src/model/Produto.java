/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author aluno
 */
public abstract class Produto implements IMetodosPadrao{
    
    private int codPro;
    private String descricao;
    private int quantidade;
    private double precoUnit;

    public Produto() {
        this(0,"",0,0.0);
    }

    public Produto(int codPro, String descricao, int quantidade, 
            double precoUnit) {
        this.codPro = codPro;
        this.descricao = descricao;
        this.quantidade = quantidade;
        this.precoUnit = precoUnit;
    }

    public int getCodPro() {
        return codPro;
    }

    public void setCodPro(int codPro) {
        this.codPro = codPro;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public int getQuantidade() {
        return quantidade;
    }

    public void setQuantidade(int quantidade) {
        this.quantidade = quantidade;
    }

    public double getPrecoUnit() {
        return precoUnit;
    }

    public void setPrecoUnit(double precoUnit) {
        this.precoUnit = precoUnit;
    }
}