/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import model.Clientes;

/**
 *
 * @author aluno
 */
public class DaoCliente extends Clientes {

    private Connection conexao;
    private PreparedStatement comandoSQL;
    private Date data;

    @Override
    public void incluir() throws SQLException, ClassNotFoundException {

        String sql = "set dateformat dmy INSERT INTO pc_cliente("
                + "nome, endereco, cidade, bairro, "
                + "uf, cep, telefone, dataNasc) Values"
                + "(?,?,?,?,?,?,?,?)";

        this.conexao = BancoSQL.getConnection();

        comandoSQL = conexao.prepareStatement(sql);

        comandoSQL.setString(1, this.getNome());
        comandoSQL.setString(2, this.getEndereco());
        comandoSQL.setString(3, this.getCidade());
        comandoSQL.setString(4, this.getBairro());
        comandoSQL.setString(5, this.getUf());
        comandoSQL.setString(6, this.getCep());
        comandoSQL.setString(7, this.getTelefone());

        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
        data = new Date(getDataNasc().getTime());
        comandoSQL.setString(8, sdf.format(data));

        comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();

    }

    @Override
    public void alterar() throws SQLException, ClassNotFoundException {

        String sql = "set dateformat dmy "
                + "UPDATE pc_Cliente SET "
                + "nome=?, "
                + "endereco=?, "
                + "cidade=?, "
                + "bairro=?, "
                + "uf=?, "
                + "cep=?, "
                + "telefone=?, "
                + "dataNasc=? "
                + " WHERE codCli = ?";

        this.conexao = BancoSQL.getConnection();

        comandoSQL = conexao.prepareStatement(sql);

        comandoSQL.setString(1, this.getNome());
        comandoSQL.setString(2, this.getEndereco());
        comandoSQL.setString(3, this.getCidade());
        comandoSQL.setString(4, this.getBairro());
        comandoSQL.setString(5, this.getUf());
        comandoSQL.setString(6, this.getCep());
        comandoSQL.setString(7, this.getTelefone());

        SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
        data = new Date(getDataNasc().getTime());
        comandoSQL.setString(8, sdf.format(data));

        comandoSQL.setInt(9, this.getCodCli());
        comandoSQL.execute();
        comandoSQL.close();
        this.conexao.close();

    }

    @Override
    public boolean excluir() throws SQLException, ClassNotFoundException {

        String sql = "DELETE FROM pc_Cliente "
                + " WHERE codCli = ?";

        try {

            this.conexao = BancoSQL.getConnection();
            comandoSQL = conexao.prepareStatement(sql);

            comandoSQL.setInt(1, this.getCodCli());

            boolean apagou = comandoSQL.execute();

            comandoSQL.close();
            this.conexao.close();

            return apagou;

        } catch (SQLException ex) {
            throw ex;
        } catch (ClassNotFoundException ex) {
            throw ex;
        }

    }
    
    public ArrayList<DaoCliente> pesquisar(DaoCliente cliente) 
            throws SQLException, ClassNotFoundException{
        
        DaoCliente clienteRetorno = null;
        
        String sql = "SELECT * FROM pc_Cliente WHERE NOME LIKE ?";
        
        ArrayList<DaoCliente> listaCLientes = new ArrayList<DaoCliente>();
        
        this.conexao = BancoSQL.getConnection();
        comandoSQL = conexao.prepareStatement(sql);
        
        comandoSQL.setString(1, "%"+cliente.getNome() + "%");
        
        ResultSet rs = comandoSQL.executeQuery();
        
        while(rs.next()){
            
            clienteRetorno = new DaoCliente();
            clienteRetorno.setCodCli(rs.getInt("CODCLI"));
            clienteRetorno.setNome(rs.getString("NOME"));
            clienteRetorno.setEndereco(rs.getString("ENDERECO"));
            clienteRetorno.setCidade(rs.getString("CIDADE"));
            clienteRetorno.setBairro(rs.getString("BAIRRO"));
            clienteRetorno.setUf(rs.getString("UF"));
            clienteRetorno.setCep(rs.getString("CEP"));
            clienteRetorno.setTelefone(rs.getString("TELEFONE"));
            clienteRetorno.setDataNasc(rs.getDate("DATANASC"));
            
            listaCLientes.add(clienteRetorno);
            
        }
        
        rs.close();
        
        comandoSQL.close();
        this.conexao.close();
        
        return listaCLientes;
    }

}
