/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.*;
import java.util.ArrayList;
import model.ItemVenda;

/**
 *
 * @author aluno
 */
public class DaoItemVenda extends ItemVenda{

    private Connection conexao;
    private PreparedStatement comandoSQL;
    private Date data;
    
    @Override
    public void incluir() throws SQLException, ClassNotFoundException {
        
        String sql = "INSER INTO pc_itemvenda "
                + " (numVenda, codpro, quantidade, precounit)"
                + "VALUES "
                + "(?,?,?,?)";
        
        this.conexao = BancoSQL.getConnection();
        
        comandoSQL = conexao.prepareStatement(sql);
        
        comandoSQL.setInt(1, getNumVenda());
        comandoSQL.setInt(2, getCodPro());
        comandoSQL.setInt(3, getQuantidade());
        comandoSQL.setDouble(4, getPrecoUnit());
        
        comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();
        
    }

    @Override
    public void alterar() throws SQLException, ClassNotFoundException {
        
        String sql = "UPDATE pc_itemvenda SET "
                + "codpro = ?, "
                + "quantidade = ?, "
                + "precounit = ?, "
                + "WHERE numVenda = ?";
        
        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);
        comandoSQL.setInt(1, this.getCodPro());
        comandoSQL.setInt(2, this.getQuantidade());
        comandoSQL.setDouble(3, this.getCodPro());
        comandoSQL.setInt(4, this.getNumVenda());
        
        comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();
        
        
    }

    @Override
    public boolean excluir() throws SQLException, ClassNotFoundException {
        
        String sql = "DELETE FROM pc_itemvenda "
                + "WHERE NUMVENDA = ?";
        
        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);
        comandoSQL.setInt(1, this.getNumVenda());
        boolean apagou = comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();
        
        return apagou;
        
    }
    
    public ArrayList<DaoItemVenda> Pesquisar(DaoItemVenda item) 
            throws SQLException, ClassNotFoundException{
        
        DaoItemVenda itemRetorno = null;
        
       String sql = "";
        
       if(item.getCodPro() > 0){
           sql =  "SELECT numVenda, pc_itemvenda.codpro, pc_produto.descricao, "
                   + "pc_itemvenda.quantidade, pc_itemvenda.precounit, "
                   + "(pc_itemvenda.quantidade * pc_itemvenda.precounit) AS SubTotal "
                   + "FROM pc_itemvenda INNER JOIN pc_produto ON "
                   + "pc_itemvenda.codpro = pc_produto.codpro "
                   + "WHERE pc_itemvenda.numVenda = ? and pc_itemvenda.codpro = ?";
       } else{
           sql = "SELECT numVenda, pc_itemvenda.codpro, pc_produto.descricao, "
                   + "pc_itemvenda.quantidade, pc_itemvenda.precounit, "
                   + "(pc_itemvenda.quantidade * pc_itemvenda.precounit) AS SubTotal "
                   + "FROM pc_itemvenda INNER JOIN pc_produto ON pc_itemvenda.codpro = pc_Produto.codpro "
                   + "WHERE numVenda = ?";
       }
       
       ArrayList<DaoItemVenda> listaItens = new ArrayList<DaoItemVenda>();
       
       this.conexao = BancoSQL.getConnection();
       comandoSQL = conexao.prepareStatement(sql);
       
       if(item.getCodPro() > 0){
           comandoSQL.setInt(1, item.getNumVenda());
           comandoSQL.setInt(2, item.getCodPro());
       } else{
           comandoSQL.setInt(1, item.getNumVenda());
       }
       
       ResultSet rs = comandoSQL.executeQuery();
       
       while (rs.next()){
           itemRetorno = new DaoItemVenda();
           itemRetorno.setNumVenda(rs.getInt("numvenda"));
           itemRetorno.setCodPro(rs.getInt("codpro"));
           itemRetorno.setDescricao(rs.getString("descricao"));
           itemRetorno.setQuantidade(rs.getInt("quantidade"));
           itemRetorno.setPrecoUnit(rs.getDouble("precounit"));
           itemRetorno.setSubtotal(rs.getInt("subtotal"));
           
           listaItens.add(itemRetorno);
       }
       
       rs.close();
       
       comandoSQL.close();
       this.conexao.close();
       
       return listaItens;
    }
    
}
