package com.example.myapplication;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    // W build.gradle compileSdk jest do zmiany na 33
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // Pobranie buttona z layoutu
        Button button = findViewById(R.id.buttonZatwierdz);
        // Ustawienie OnClickListenera za pomocą metody lambda
        button.setOnClickListener(view -> {
            // Pobranie textView z layoutu
            TextView textView = findViewById(R.id.textViewKomunikaty);
            // Pobranie editText z layoutu
            EditText editTextEmail = findViewById(R.id.editTextEmail);
            // Pobranie editText z layoutu
            EditText editTextHaslo = findViewById(R.id.editTextHaslo);
            // Pobranie editText z layoutu
            EditText editTextPowtorz = findViewById(R.id.editTextPowtorz);
            // Weryfikacja, czy mail ma @, jeśli nie - zmiana tekstu w komunikacie
            if(!editTextEmail.getText().toString().contains("@"))
                textView.setText("Nieprawidłowy adres e-mail");
            // Weryfikacja, czy hasła są identyczne, jeśli nie - zmiana tekstu w komunikacie
            else if(!editTextHaslo.getText().toString().equals(editTextPowtorz.getText().toString()))
                textView.setText("Hasła się rożnią");
            // Jeśli oba warunki są prawdziwe, wyświetl komunikat z mailem użytkownika
            else
                textView.setText("Witaj " + editTextEmail.getText().toString());
        });
        // Alternatywą jest zrobienie takiej funkcji...
        /*
        public void OnClick(View view){
            TextView textView = findViewById(R.id.textViewKomunikaty);
            EditText editTextEmail = findViewById(R.id.editTextEmail);
            EditText editTextHaslo = findViewById(R.id.editTextHaslo);
            EditText editTextPowtorz = findViewById(R.id.editTextPowtorz);
            if(!editTextEmail.getText().toString().contains("@"))
                textView.setText("Nieprawidłowy adres e-mail");
            else if(!editTextHaslo.getText().toString().equals(editTextPowtorz.getText().toString()))
                textView.setText("Hasła się rożnią");
            else if(editTextEmail.getText().toString().contains("@") && editTextHaslo.getText().toString().equals(editTextPowtorz.getText().toString()))
                textView.setText("Witaj " + editTextEmail.getText().toString());
        }
        */
        // i podbięcie jej do atrybutu onclick w przycisku
    }
}