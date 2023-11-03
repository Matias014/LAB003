import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Kurs extends JFrame {

    private JPanel JPanel1;
    private JPanel JPanel2;
    private JPanel JPanel3;
    private JCheckBox checkBoxJava;
    private JCheckBox checkBoxCS;
    private JCheckBox checkBoxCPP;
    private JCheckBox checkBoxPython;
    private JButton OKButton;
    private JButton wrocButton;

    public static void main(String[] args) {
        Kurs obj = new Kurs();
        obj.setVisible(true);
    }

    public Kurs() {
        super("CheckBox");
        this.setContentPane(this.JPanel1);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.pack();

        OKButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                float cena = 0;
                String msg = "";
                if (checkBoxJava.isSelected()) {
                    cena += 3500;
                    msg += "Java #price 3500,00 PLN\n";
                }
                if (checkBoxPython.isSelected()) {
                    cena += 5000;
                    msg += "Python #price 5000,00 PLN\n";
                }
                if (checkBoxCPP.isSelected()) {
                    cena += 4000;
                    msg += "C++ #price 4000,00 PLN\n";
                }
                if (checkBoxCS.isSelected()) {
                    cena += 3000;
                    msg += "C# #price 3000,00 PLN\n";
                }

                msg += "============================================\n";
                JOptionPane.showMessageDialog(null, msg + "Razem " + cena);
            }
        });

        wrocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose();
                Logo obj = new Logo();
                obj.setVisible(true);
            }
        });
    }
}
