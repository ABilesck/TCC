/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Toolkit;
import javax.swing.BorderFactory;
import javax.swing.ImageIcon;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JWindow;

/**
 *
 * @author aluno
 */
public class SplashCode extends JWindow {

    private int duracao;

    public int getDuracao() {
        return duracao;
    }

    public void setDuracao(int duracao) {
        this.duracao = duracao * 1000;
    }

    public SplashCode(int duracao) {
        setDuracao(this.duracao);
    }

    public void ShowSplash() {

        JPanel content = (JPanel) getContentPane();
        content.setBackground(Color.white);

        //configurar bordas
        int width = 500;
        int height = 300;
        Dimension screen = Toolkit.getDefaultToolkit().getScreenSize();

        int x = (screen.width - width) / 2;
        int y = (screen.height - height) / 2;

        //colocar valores na jwindow
        setBounds(x, y, width, height);

        //construir a splashScreen
        JLabel label = new JLabel(new ImageIcon("src/imagens/splash.jpg"));

        JLabel copyrt = new JLabel("Splash", JLabel.CENTER);
        label.setSize(x / 2, y / 2);
        copyrt.setFont(new Font("Sans-Serif", Font.BOLD, 12));
        content.add(label, BorderLayout.CENTER);
        content.add(copyrt, BorderLayout.CENTER);
        Color oraRed = new Color(156, 20, 20, 255);
        content.setBorder(BorderFactory.createLineBorder(oraRed, 5));
        //tornar a splascreen visivel
        setVisible(true);
        //espera
        try {
            Thread.sleep(getDuracao());
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Ocorreu um erro: " + e.getMessage(),
                    "Erro:", JOptionPane.ERROR_MESSAGE);

        }

        setVisible(false);

    }

    public void showSplashAndExit() throws Exception {
        ShowSplash();
        FrmMain frmMain = new FrmMain();
        try {
            frmMain.setVisible(true);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "erro:" + e.getMessage(),
                    "Erro:", JOptionPane.ERROR_MESSAGE);
            throw e;
        }
        this.dispose();
    }

}
