package Zadanie2;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Zadanie2 extends JFrame {
    private JPanel JPanel;
    private JButton kliknijButton;
    private JTextArea textArea1;

    public Zadanie2() {
        super("Program wypisujący tekst");
        this.setContentPane(this.JPanel);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        int width = 400, height = 400;
        this.setSize(width, height);


        kliknijButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                textArea1.setText("Mam na imię Mateusz");
            }
        });
    }

    public static void main(String[] args) {
        Zadanie2 obj = new Zadanie2();
        obj.setVisible(true);
    }
}
