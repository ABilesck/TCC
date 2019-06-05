/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.sql.SQLException;

/**
 *
 * @author aluno
 */
public interface IMetodosPadrao {
    
    public void incluir() throws SQLException, ClassNotFoundException;
    
    public void alterar() throws SQLException, ClassNotFoundException;
    
    public boolean excluir() throws SQLException, ClassNotFoundException;
}
