/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import java.text.ParseException;
import javax.swing.text.MaskFormatter;

/**
 *
 * @author aluno
 */
public class FormatRpt {
 
    public String formatCep(String cep) throws ParseException{
        
        MaskFormatter mfCep = new MaskFormatter("#####-###");
        mfCep.setPlaceholderCharacter('_');
        mfCep.setValueContainsLiteralCharacters(false);
        mfCep.setValueClass(String.class);
        return mfCep.valueToString(cep);
    }
    
    public String formatTelefone(String telefone) throws ParseException{
        
        String retorno;
        
        MaskFormatter mfTel = new MaskFormatter("(##)#####-####");
        mfTel.setPlaceholderCharacter('_');
        mfTel.setValueContainsLiteralCharacters(false);
        mfTel.setValueClass(String.class);
        retorno = mfTel.valueToString(telefone);
        
        return retorno;
    }
    
}
