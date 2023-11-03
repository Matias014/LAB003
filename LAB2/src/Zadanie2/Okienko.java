package Zadanie2;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Okienko extends JFrame {
    private JPanel JPanel1;
    private JPanel JPanel2;
    private JPanel JPanel3;
    private JPanel JPanel4;
    private JLabel LogoLabel;
    private JButton kliknijButton;
    private JCheckBox cocaColaCheckBox;
    private JCheckBox caffeLatteCheckBox;
    private JCheckBox kawaCzarnaCheckBox;
    private JCheckBox herbataZielonaCheckBox;
    private JCheckBox cappuccinoCheckBox;
    private JCheckBox wodaCheckBox;
    private JTextArea textArea1;

    public Okienko() {
        super("Automat napojow");
        this.setContentPane(this.JPanel1);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(500, 500);


        kliknijButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String msg = "\n";
                if (cocaColaCheckBox.isSelected()) {
                    msg += "Coca-Cola\n";
                }
                if (caffeLatteCheckBox.isSelected()) {
                    msg += "Caffe Latte\n";
                }
                if (kawaCzarnaCheckBox.isSelected()) {
                    msg += "Kawa czarna\n";
                }
                if (herbataZielonaCheckBox.isSelected()) {
                    msg += "Herbata zielona\n";
                }
                if (cappuccinoCheckBox.isSelected()) {
                    msg += "Cappuccino\n";
                }
                if (wodaCheckBox.isSelected()) {
                    msg += "Woda\n";
                }

                JOptionPane.showMessageDialog(null, "Wybrałeś: " + msg);
            }
        });
    }

    public static void main(String[] args) {
        Okienko obj = new Okienko();
        obj.setVisible(true);
    }
}
