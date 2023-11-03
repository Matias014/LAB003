package Zadanie1;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Haslo extends JFrame {
    private JPanel JPanel1;
    private JPanel JPanel2;
    private JButton okButton;
    private JTextField textField1;
    private JTextField textField2;

    String haslo = "codejava";

    public static void main(String[] args){
        Haslo obj = new Haslo();
        obj.setVisible(true);
    }

    public Haslo() {
        super("Enter password");
        this.setContentPane(this.JPanel1);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.pack();


        okButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String password1 = textField1.getText();
                String password2 = textField2.getText();

                if (!password1.equals(password2)) {
                    JOptionPane.showMessageDialog(null, "Passwords do not match!");
                } else if (!password1.equals(haslo) || !password2.equals(haslo)) {
                    JOptionPane.showMessageDialog(null,"Wrong password!");
                } else {
                    JOptionPane.showMessageDialog(null, "Congratulations! You entered correct password.");
                }
            }
        });
    }
}
