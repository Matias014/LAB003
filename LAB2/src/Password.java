import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Password extends JFrame {
    private javax.swing.JPanel JPanel;
    private JTextField textField1;
    private JButton loginButton;
    private JPasswordField passwordField1;
    private JLabel usernameLabel;
    private JLabel passwordLabel;
    private JLabel loginToTheApplicationLabel;
    private JLabel result;
    private JPanel JPanel2;
    private JPanel JPanel3;
    private JPanel JPanel4;

    String user = "admin", password = "123";

    public static void main(String[] args) {
        Password password = new Password();
        password.setVisible(true);
    }

    public Password() {
        super("Login panel");
        this.setContentPane(this.JPanel);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setSize(600, 200);

        loginButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String userInput = textField1.getText();
                String userPassword = new String(passwordField1.getPassword());

                if (userInput.equals(user) && userPassword.equals(password)) {
                    result.setText("Logged in");
                    dispose();
                    Logo obj = new Logo();
                    obj.setVisible(true);
                } else {
                    result.setText("Bad data given, try again");
                    textField1.setText("");
                    passwordField1.setText("");
                }
            }
        });
    }
}
