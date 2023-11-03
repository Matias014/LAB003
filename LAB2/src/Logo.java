import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;


public class Logo extends JFrame {
    private javax.swing.JPanel JPanel;
    private javax.swing.JPanel JPanel2;
    private JRadioButton linuxRadioButton;
    private JRadioButton windowsRadioButton;
    private JRadioButton macintoshRadioButton;
    private JPanel JPanel3;
    private JLabel JLabelImage;
    private JPanel JPanel4;
    private JButton okButton;
    private JButton wrocButton;
    private ImageIcon iconLinux = new ImageIcon(getClass().getResource("linux.png"));
    private ImageIcon iconWindows = new ImageIcon(getClass().getResource("windows.png"));
    private ImageIcon iconMacintosh = new ImageIcon(getClass().getResource("mac.png"));

    public static void main(String[] args) {
        Logo obj = new Logo();
        obj.setVisible(true);
    }

    private static ImageIcon resize(ImageIcon src, int destWidth, int destHeight) {
        return new ImageIcon(src.getImage().getScaledInstance(destWidth, destHeight, Image.SCALE_SMOOTH));
    }

    public Logo() {
        super("Icons");
        this.setContentPane(this.JPanel);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(250,250);

        okButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String selectOption = "";
                if (linuxRadioButton.isSelected()) selectOption = "Linux";
                if (windowsRadioButton.isSelected()) selectOption = "Windows";
                if (macintoshRadioButton.isSelected()) selectOption = "Macintosh";

                JOptionPane.showMessageDialog(Logo.this, "Wybrano system: " + selectOption);

                dispose();
                Kurs obj = new Kurs();
                obj.setVisible(true);
            }
        });

        linuxRadioButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (linuxRadioButton.isSelected()) {
                    JLabelImage.setIcon(resize(iconLinux, 120, 120));
                }
            }
        });

        windowsRadioButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (windowsRadioButton.isSelected()) {
                    JLabelImage.setIcon(resize(iconWindows, 120, 120));
                }
            }
        });

        macintoshRadioButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (macintoshRadioButton.isSelected()) {
                    JLabelImage.setIcon(resize(iconMacintosh, 120, 120));
                }
            }
        });

        wrocButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                dispose();
                Password obj = new Password();
                obj.setVisible(true);
            }
        });
    }
}
