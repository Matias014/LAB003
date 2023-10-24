package Zadanie1;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Temperatura extends JFrame {

    private javax.swing.JPanel JPanel;
    private JPanel JPanel2;
    private JPanel JPanel3;
    private JTextField textField1;
    private JTextField textField2;
    private JLabel podajStopnieCelsjuszaLabel;
    private JLabel stopnieFarenheitaLabel;
    private JButton obliczButton;
    double celsjusz, farenheit;

    public Temperatura() {
        super("Konwertowanie stopni Celsjusza na Farenheita");
        this.setContentPane(this.JPanel);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        int width = 400, height = 400;
        this.setSize(width, height);
        this.pack();

        obliczButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                celsjusz = Double.parseDouble(textField1.getText());
                farenheit = naFarenheit(celsjusz);
                textField2.setText(String.valueOf(farenheit));
            }
        });
    }

    public static void main(String[] args) {
        Temperatura object = new Temperatura();
        object.setVisible(true);
    }

    public double naFarenheit(double c) {
        return (c * (9.0 / 5.0)) + 32.0;
    }
}
