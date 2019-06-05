/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.*;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import model.Venda;

/**
 *
 * @author aluno
 */
public class DaoVenda extends Venda {

    private Connection conexao;
    private PreparedStatement comandoSQL;
    private Date data;

    public void incluir() throws SQLException, ClassNotFoundException {

        String sql = "set dateformat dmy INSERT INTO pc_venda "
                + "(numVenda, codCli, dataVenda, dataEntrega, obs)"
                + "VALUES"
                + "(?,?,?,?,?)";

        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/YYYY");

        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);

        comandoSQL.setInt(1, this.getNumVenda());
        comandoSQL.setInt(2, this.getCodCli());
        comandoSQL.setString(3, sdf.format(this.getDataVenda()));
        comandoSQL.setString(4, sdf.format(this.getDataEntrega()));
        comandoSQL.setString(5, this.getObs());

        comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();

    }

    public void alterar() throws SQLException, ClassNotFoundException {

        String sql = "set dateformat dmy "
                + "UPDATE pc_venda SET "
                + "codcli = ?,"
                + "dataVenda = ?, "
                + "dataEntrega = ?, "
                + "obs = ? "
                + " WHERE numVenda = ?";

        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);
        comandoSQL.setInt(1, this.getCodCli());

        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/YYYY");
        comandoSQL.setString(2, sdf.format(this.getDataVenda()));
        comandoSQL.setString(3, sdf.format(this.getDataEntrega()));
        comandoSQL.setString(4, this.getObs());

        comandoSQL.setInt(5, this.getNumVenda());

        comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();

    }

    public boolean excluir() throws SQLException, ClassNotFoundException {

        String sql = "DELETE FROM pc_venda "
                + "WHERE NUMVENDA = ?";

        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);
        comandoSQL.setInt(1, this.getNumVenda());
        boolean apagou = comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();
        return apagou;

    }
    
    public ArrayList<DaoVenda> Pesquisar (DaoVenda venda) 
            throws SQLException, ClassNotFoundException{
        
        DaoVenda vendaRetorno = null;
        String sql = "";
        
        if(venda.getNumVenda() > 0){
            
            sql = "set dateformat dmy SELECT numVenda, pc_venda.codcli, nome, dataVenda,"
                    + " dataEntrega, obs "
                    + "FROM pc_venda INNER JOIN pc_clientes ON pc_venda.codcli = pc_cliente.codcli"
                    + " WHERE numVenda = ?";
            
        }else{
            
            sql = "set dateformat dmy SELECT numVenda, pc_venda.codcli, nome, dataVenda,"
                    + " dataEntrega, obs "
                    + "FROM pc_venda INNER JOIN pc_clientes ON pc_venda.codcli = pc_cliente.codcli";
        }
        
        ArrayList<DaoVenda> listaVendas = new ArrayList<DaoVenda>();
        
        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);
        
        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/YYYY");
        
        if(venda.getNumVenda() > 0){
            comandoSQL.setInt(1, venda.getNumVenda());
        }
        
        ResultSet rs = comandoSQL.executeQuery();
        
        while(rs.next()){
            vendaRetorno = new DaoVenda();
            vendaRetorno.setNumVenda(rs.getInt("numvenda"));
            vendaRetorno.setCodCli(rs.getInt("codcli"));
            vendaRetorno.setNome(rs.getString("nome"));
            vendaRetorno.setDataVenda(rs.getDate("datavenda"));
            vendaRetorno.setDataEntrega(rs.getDate("dataentrega"));
            vendaRetorno.setObs(rs.getString("obs"));
            
            listaVendas.add(vendaRetorno);
        }
        
        rs.close();
        
        comandoSQL.close();
        this.conexao.close();
        
        return listaVendas;
    }
}
