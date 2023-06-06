package pl.edu.sci.egzamin_inf_04_1;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity
{

    EditText Password1;
    EditText Password2;
    EditText Email;
    TextView Info;
    Button AcceptButton;

    @Override
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Password1 = findViewById(R.id.etPassword);
        Password2 = findViewById(R.id.etPassword2);
        Email = findViewById(R.id.etEmail);
        AcceptButton = findViewById(R.id.button);
        Info = findViewById(R.id.infoLabel);

        AcceptButton.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v)
            {
                //Note there is no need for many else ifs here just prioritize what to check first
                //email is a must so there is no need to check anything beyond that point if it is not
                //given, as well as with empty passwords below, since this is not covered by the requirements
                //we write appropriate string and just bail, as it is logical that the passwords should
                // be entered to register


                //If email field is empty or it does not contain @ in the string then it's an invalid email
                //so set appropriate string and bail
                if(TextUtils.isEmpty(Email.getText().toString()) || !Email.getText().toString().contains("@"))
                {
                    Info.setText("Nieprawidłowy adres e-mail");
                    return;
                }
                //Check first if passwords are empty, since this is not described in the requirements
                //note that fact in the info field and bail
                //Note we need only to check if the passwords are not empty. This is because if one is empty it falls down
                //into password mismatch category
                if(TextUtils.isEmpty(Password1.getText().toString()) && TextUtils.isEmpty(Password2.getText().toString()))
                {
                    Info.setText("Przypadek nie przewidziany w wymaganiach puste hasła");
                    return;
                }
                //Depending on password equality write appropriate string to the screen
                if(TextUtils.equals(Password1.getText().toString(),Password2.getText().toString()))
                {
                    Info.setText("Witaj " + Email.getText().toString());
                }
                else
                {
                    Info.setText("Hasłe się różnią");
                }
            }
        });
    }
}